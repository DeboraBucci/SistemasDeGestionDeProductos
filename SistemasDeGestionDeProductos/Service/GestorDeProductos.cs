using SistemasDeGestionDeProductos.Entidades;
using SistemasDeGestionDeProductos.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasDeGestionDeProductos.Service
{
    public class GestorDeProductos
    {
        private readonly RepositorioProductos repositorioProductos;

        public GestorDeProductos()
        {
            repositorioProductos = new RepositorioProductos();
        }

        public void CrearProducto(string nombre, string descripcion, decimal precioUnitario, int stock, Guid idRubro)
        {
            var productoYaExistente = repositorioProductos.BuscarPorNombre(nombre);

            if (productoYaExistente != null)
                throw new Exception("Ya existe un producto con el mismo nombre.");

            Producto producto = new()
            {
                Nombre = nombre,
                Descripcion = descripcion,
                PrecioUnitario = precioUnitario,
                Stock = stock,
                IdRubro = idRubro
            };

            repositorioProductos.Agregar(producto);
        }

        public IReadOnlyCollection<Producto> BuscarProductos() => repositorioProductos.BuscarTodos();
    }
}
