using SistemasDeGestionDeProductos.Entidades;
using SistemasDeGestionDeProductos.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasDeGestionDeProductos.Service
{
    public class GestorDeMovimientos
    {
        private readonly RepositorioMovimientos _repositorioMovimientos = new();

        public void IngresarStock(Guid productoId, int cantidad, DateTime vencimiento, Guid proveedorId)
        {
            if (cantidad <= 0)
                throw new ArgumentException("Cantidad debe ser > 0");

            _repositorioMovimientos.Agregar(new MovimientoStock
            {
                ProductoId = productoId,
                Tipo = TipoMovimiento.Ingreso,
                Stock = cantidad,
                FechaMovimiento = DateTime.Now,
                FechaVencimiento = vencimiento,
                ProveedorId = proveedorId,
            });
        }

        public void EgresarStock(Guid productoId, int cantidad, string motivo)
        {
            // VALIDACION

            if (cantidad <= 0)
                throw new ArgumentException("Cantidad debe ser > 0");

            var movimimentos = _repositorioMovimientos.BuscarTodos();

            int stockActual = ObtenerStockActual(productoId);

            if (cantidad > stockActual)
                throw new InvalidOperationException(
                    $"No hay suficiente stock. Disponible: {stockActual}, solicitado: {cantidad}.");


            // Trae todos los ingresos del producto, ordenados por fecha de vencimiento.
            var ingresos = movimimentos
                            .Where(m => m.ProductoId == productoId && m.Tipo == TipoMovimiento.Ingreso)
                            .OrderBy(m => m.FechaVencimiento)
                            .ToList();

            // Busca todos los egresos del producto
            var egresos = movimimentos
                            .Where(m => m.ProductoId == productoId && m.Tipo == TipoMovimiento.Egreso)
                            .ToList();

            // Resta los egresos a los ingresos del producto, por fecha de vencimiento, convirtiendo todo en lotes disponibles
            var lotes = ingresos
                .Select(i => new {
                    Movimiento = i,
                    Restante = i.Stock - 
                            egresos 
                            .Where(e => e.FechaVencimiento == i.FechaVencimiento)
                            .Sum(e => e.Stock) // Suma todos los egresos con misma fecha de vencimiento que ingreso.
                })
                .Where(x => x.Restante > 0) // Solo agrega productos donde la cantidad restante de stock sea mayor que 0.
                .ToList();


            // CREA MOVIMIENTOS
            int aConsumir = cantidad;

            foreach (var lote in lotes)
            {
                if (aConsumir <= 0) break; // Verifica que la cantidad a consumir no sea menor o igual a cero.

                int valorTomado = Math.Min(lote.Restante, aConsumir); // Agarra el menor entre ambos: (2, 5) => 2
                aConsumir -= valorTomado;

                // Genera un nuevo movimiento por cada lote con fecha de vencimiento diferente
                _repositorioMovimientos.Agregar(
                    new MovimientoStock
                    {
                        ProductoId = productoId,
                        Tipo = TipoMovimiento.Egreso,
                        Stock = valorTomado,
                        FechaMovimiento = DateTime.Now,
                        FechaVencimiento = lote.Movimiento.FechaVencimiento,
                        Motivo = motivo
                    });
            }
        }

        public IReadOnlyCollection<MovimientoStock> ListarMovimientos(
            Guid? productoId = null,
            TipoMovimiento? tipo = null,
            DateTime? desde = null,
            DateTime? hasta = null)
        {
            return _repositorioMovimientos
                .BuscarTodos()
                .Where(m => productoId == null || m.ProductoId == productoId) 
                .Where(m => tipo == null || m.Tipo == tipo) 
                .Where(m => desde == null || m.FechaMovimiento >= desde)
                .Where(m => hasta == null || m.FechaMovimiento <= hasta)
                .ToList()
                .AsReadOnly();
        }

        public IEnumerable<(Producto? producto, int stock)> StockActual() => 
                _repositorioMovimientos
                .BuscarTodos()
                .GroupBy(m => m.ProductoId) // agrupa x mismo id
                .Select(g => (
                    prod: Program.GestorDeProductos.BuscarProductoPorId(g.Key),
                    stock: g.Sum(m => m.Tipo == TipoMovimiento.Ingreso ? m.Stock : -m.Stock)
                ));

        public int ObtenerStockActual(Guid prodId) => 
            _repositorioMovimientos
                            .BuscarTodos()
                            .Where(m => m.ProductoId == prodId)
                            .Sum(m => m.Tipo == TipoMovimiento.Ingreso ? m.Stock : -m.Stock);


        public IEnumerable<(Producto? producto, DateTime vencimiento, int stock)>
            ProductosPorVencer(TimeSpan anticipacion = default)
        {
            if (anticipacion == default)
                anticipacion = TimeSpan.FromDays(7);

            var hoy = DateTime.Today;

            // Agrupa movimientos por fecha, que tengan vencimiento dentro de los proximos 7 dias.
            var movimientosPorFecha = 
                _repositorioMovimientos
                    .BuscarTodos()
                    .Where(movimiento => movimiento.Tipo == TipoMovimiento.Ingreso
                            && movimiento.FechaVencimiento > hoy
                            && movimiento.FechaVencimiento <= hoy + anticipacion)
                    .GroupBy(movimiento => movimiento.FechaVencimiento);

            return movimientosPorFecha
                        .SelectMany(grupoFecha => 
                            grupoFecha
                                .Select(movimiento => 
                                    (producto: Program.GestorDeProductos.BuscarProductoPorId(movimiento.ProductoId),
                                    vencimiento: movimiento.FechaVencimiento,
                                    stock: grupoFecha
                                            .Sum(movFecha => 
                                                movFecha.Stock) - 
                                                _repositorioMovimientos
                                                    .BuscarTodos()
                                                    .Where(e => 
                                                        e.Tipo == TipoMovimiento.Egreso
                                                        && e.FechaVencimiento == movimiento.FechaVencimiento
                                                        && e.ProductoId == movimiento.ProductoId)
                                                    .Sum(e => e.Stock)
                                             )
                                )
                        );
        }

        public IReadOnlyCollection<Proveedor?> ObtenerProveedoresPorProducto(Guid productoId)
        {

            var movimientos = 
                _repositorioMovimientos
                .BuscarTodos();

            var mov = movimientos.FirstOrDefault();

            var ingresos = _repositorioMovimientos
                .BuscarTodos()
                .Where(m => m.ProductoId == productoId && m.Tipo == TipoMovimiento.Ingreso);

            var ingreso = ingresos.FirstOrDefault();


            var proveedoresIds = ingresos
                .Select(m => m.ProveedorId)                    
                .Distinct();

            var id = proveedoresIds.FirstOrDefault();

            var proveedores = proveedoresIds
                .Select(id => Program.GestorDeProveedores.BuscarProveedorPorId(id ?? Guid.Empty))
                .Where(p => p != null)!
                .ToList();

            return proveedores.AsReadOnly();
        }
    }
}
