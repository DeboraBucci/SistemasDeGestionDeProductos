using SistemasDeGestionDeProductos.Entidades;
using SistemasDeGestionDeProductos.Helpers;
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
        private readonly RepositorioMovimientos _repositorioMovimientos;

        public GestorDeMovimientos(string path)
        {
            _repositorioMovimientos = new(path);
        }


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

            // Junta ingresos con igual fecha de vencimiento
            var ingresosPorFecha =
                ingresos
                .GroupBy(i => i.FechaVencimiento)
                .Select(g => new
                {
                    FechaVencimiento = g.Key,
                    StockTotal = g.Sum(i => i.Stock),
                });

            // Resta los egresos a los ingresos del producto, por fecha de vencimiento, convirtiendo todo en lotes disponibles
            var lotes = ingresosPorFecha
                .Select(i => new {
                    Movimiento = i,
                    Restante = i.StockTotal - 
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
            VerificarYRegistrarVencimientos();

            return _repositorioMovimientos
                .BuscarTodos()
                .Where(m => productoId == null || m.ProductoId == productoId) 
                .Where(m => tipo == null || m.Tipo == tipo) 
                .Where(m => desde == null || m.FechaMovimiento >= desde)
                .Where(m => hasta == null || m.FechaMovimiento <= hasta)
                .ToList()
                .AsReadOnly();
        }

        public IReadOnlyCollection<MovimientoStock> ListarIngresos() => _repositorioMovimientos.BuscarPorTipo(TipoMovimiento.Ingreso);

        public IReadOnlyCollection<MovimientoStock> ListarEgresos() => _repositorioMovimientos.BuscarPorTipo(TipoMovimiento.Egreso);

        public IReadOnlyCollection<MovimientoStock> BuscarPorProveedor(Guid proveedorId) => _repositorioMovimientos.BuscarPorProveedor(proveedorId);

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

        public int ObtenerStockActualPorRubro(Guid rubroId) =>
            _repositorioMovimientos
                            .BuscarTodos()
                            .Where(m => {
                                var producto = Program.GestorDeProductos.BuscarProductoPorId(m.ProductoId);
                                return producto?.IdRubro == rubroId;
                            })
                            .Sum(m => m.Tipo == TipoMovimiento.Ingreso ? m.Stock : -m.Stock);


        public IReadOnlyCollection<ProductoVencerDTO>
        ProductosPorVencer(TimeSpan anticipacion = default)
        {
            if (anticipacion == default)
                anticipacion = TimeSpan.FromDays(7);

            var hoy = DateTime.Today;
            var movimientos = _repositorioMovimientos.BuscarTodos();

            var ingresos = movimientos
                .Where(m => m.Tipo == TipoMovimiento.Ingreso
                            && m.FechaVencimiento > hoy
                            && m.FechaVencimiento <= hoy + anticipacion);

            var grupos = ingresos
                .GroupBy(m => new { m.ProductoId, m.FechaVencimiento });

            var tuplasInfo = new List<(Producto? producto, DateTime vencimiento, int stock)>();

            foreach (var grupo in grupos)
            {
                int stockIngresado = grupo.Sum(m => m.Stock);

                int stockEgresado = movimientos
                    .Where(e => e.Tipo == TipoMovimiento.Egreso
                                && e.ProductoId == grupo.Key.ProductoId
                                && e.FechaVencimiento == grupo.Key.FechaVencimiento)
                    .Sum(e => e.Stock);

                int stockDisponible = stockIngresado - stockEgresado;

                if (stockDisponible > 0)
                {
                    var producto = Program.GestorDeProductos.BuscarProductoPorId(grupo.Key.ProductoId);
                    tuplasInfo.Add((producto, grupo.Key.FechaVencimiento, stockDisponible));
                }
            }

            return tuplasInfo
                    .Where(t => t.producto != null)
                    .Select(t => ProductosMapper.ProductoAProductoVencerDTO(t.producto!, t.vencimiento, t.stock))
                    .ToList()
                    .AsReadOnly();
        }

        public IReadOnlyCollection<Proveedor> ObtenerProveedoresPorProducto(Guid productoId)
        {

            var ingresos = _repositorioMovimientos
                .BuscarTodos()
                .Where(m => m.ProductoId == productoId && m.Tipo == TipoMovimiento.Ingreso);

            var proveedoresIds = ingresos
                .Select(m => m.ProveedorId)                    
                .Distinct();

            var proveedores = proveedoresIds
                .Select(id => Program.GestorDeProveedores.BuscarProveedorPorId(id ?? Guid.Empty))
                .Where(p => p != null)!
                .Select(p => p!)
                .ToList();

            return proveedores.AsReadOnly();
        }

        private void VerificarYRegistrarVencimientos()
        {
            var hoy = DateTime.Today;
            var movimientos = _repositorioMovimientos.BuscarTodos();

            var ingresosVencidos = movimientos
                .Where(m => m.Tipo == TipoMovimiento.Ingreso && m.FechaVencimiento < hoy)
                .ToList();

            foreach (var ingreso in ingresosVencidos)
            {
                var totalEgresado = movimientos
                    .Where(e => e.Tipo == TipoMovimiento.Egreso &&
                                e.FechaVencimiento == ingreso.FechaVencimiento &&
                                e.ProductoId == ingreso.ProductoId)
                    .Sum(e => e.Stock);

                int restante = ingreso.Stock - totalEgresado;

                bool yaEgresadoPorVencimiento = movimientos.Any(e =>
                    e.Tipo == TipoMovimiento.Egreso &&
                    e.Motivo == "Vencimiento" &&
                    e.FechaVencimiento == ingreso.FechaVencimiento &&
                    e.ProductoId == ingreso.ProductoId);

                if (restante > 0 && !yaEgresadoPorVencimiento)
                {
                    _repositorioMovimientos.Agregar(new MovimientoStock
                    {
                        ProductoId = ingreso.ProductoId,
                        Tipo = TipoMovimiento.Egreso,
                        Stock = restante,
                        FechaMovimiento = DateTime.Now,
                        FechaVencimiento = ingreso.FechaVencimiento,
                        Motivo = "Vencimiento"
                    });
                }
            }
        }
    }
}
