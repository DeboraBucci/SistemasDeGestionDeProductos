using SistemasDeGestionDeProductos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasDeGestionDeProductos.Helpers
{
    public static class ProductosMapper
    {
        public static IReadOnlyCollection<ProductoDTO> 
            ListaProductoAProductoDTO(IReadOnlyCollection<Producto> productos) => 
            productos.Select(p => new ProductoDTO(
                p.Id,
                p.Nombre ?? string.Empty,
                p.Descripcion ?? string.Empty,
                p.PrecioUnitarioCompra,
                p.PrecioUnitarioVenta,
                Program.GestorDeRubros.BuscarRubroPorId(p.IdRubro)?.Nombre ?? string.Empty
                )).ToList();
    }
}
