using SistemasDeGestionDeProductos.Clases.DTOs;
using SistemasDeGestionDeProductos.Clases.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasDeGestionDeProductos.Clases.Mappers
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
                Program.GestorDeRubros.BuscarPorId(p.IdRubro)?.Nombre ?? string.Empty
                )).ToList();

        public static ProductoVencerDTO
                ProductoAProductoVencerDTO(Producto producto, DateTime fechaVencimiento, int stock) =>
            new ProductoVencerDTO(
                    producto.Id,
                    producto.Nombre ?? string.Empty,
                    producto.Descripcion ?? string.Empty,
                    producto.PrecioUnitarioCompra,
                    producto.PrecioUnitarioVenta,
                    Program.GestorDeRubros.BuscarPorId(producto.IdRubro)?.Nombre ?? string.Empty,
                    stock,
                    fechaVencimiento);
    }
}
