using SistemasDeGestionDeProductos.Clases.DTOs;
using SistemasDeGestionDeProductos.Clases.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasDeGestionDeProductos.Clases.Mappers
{
    public static class MovimientosMapper
    {
        public static IReadOnlyCollection<MovimientosDTO>
            ListaMovimientoAMovimientoDTO(IReadOnlyCollection<MovimientoStock> movimientos) =>
                movimientos.Select(m =>
                {
                    string nombreProducto = Program.GestorDeProductos.BuscarPorId(m.ProductoId)?.Nombre ?? string.Empty;
                    string nombreProveedor = string.Empty;

                    if (m.ProveedorId != null)
                        nombreProveedor = Program.GestorDeProveedores.BuscarPorId(m.ProveedorId.Value)?.Nombre ?? string.Empty;

                    return new MovimientosDTO(
                    m.Id,
                    nombreProducto,
                    m.Tipo == 0 ? "Ingreso" : "Egreso",
                    m.Stock,
                    m.FechaMovimiento,
                    m.FechaVencimiento,
                    nombreProveedor,
                    m.Motivo);
                }).ToList();
    }
}
