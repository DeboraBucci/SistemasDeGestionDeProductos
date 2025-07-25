using SistemasDeGestionDeProductos.Entidades;
using SistemasDeGestionDeProductos.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasDeGestionDeProductos.Repositorios
{
    internal class RepositorioProductos : IRepositorio<Producto>
    {
        private static readonly string archivoProductos = "productos.json";
        private readonly List<Producto> productos = JsonHelper.LeerDesdeArchivo<Producto>(archivoProductos);

        public void Agregar(Producto producto) {
            productos.Add(producto);
            JsonHelper.GuardarEnArchivo(productos, archivoProductos);
        }

        public void Modificar(Guid id, string nombre, string descripcion, decimal precioUnitarioCompra, Guid idRubro)
        {
            var producto = BuscarPorId(id);

            if (producto != null)
            {
                producto.Nombre = nombre;
                producto.Descripcion = descripcion;
                producto.PrecioUnitarioCompra = precioUnitarioCompra;
                producto.IdRubro = idRubro;
            }

            JsonHelper.GuardarEnArchivo(productos, archivoProductos);
        }

        public Producto? BuscarPorNombre(string nombre) => productos.FirstOrDefault(p => TextHelper.SonIgualesSinTildes(p.Nombre + "", nombre));

        public IReadOnlyCollection<Producto> BuscarTodos() => productos.AsReadOnly();
        public Producto? BuscarPorId(Guid id) => productos.FirstOrDefault(r => r.Id == id);
    }
}
