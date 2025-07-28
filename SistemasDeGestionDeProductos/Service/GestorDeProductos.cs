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
    public class GestorDeProductos
    {
        private readonly RepositorioProductos repositorioProductos;

        public GestorDeProductos(string path)
        {
            repositorioProductos = new RepositorioProductos(path);
        }

        // MODIFICACIONES
        public Producto CrearProducto(string nombre, string descripcion, decimal precioUnitarioCompra, string nombreRubro)
        {
            // VERIFICAR SI EXISTE PRODUCTO
            var productoYaExistente = repositorioProductos.BuscarPorNombre(nombre);

            if (productoYaExistente != null)
                throw new InvalidOperationException("Ya existe un producto con el mismo nombre.");

            var rubroId = BuscarIdRubro(nombreRubro);

            if (rubroId == null)
                throw new InvalidOperationException("El rubro es invalido.");

            // CREAR PRODUCTO
            Producto producto = new()
            {
                Nombre = nombre,
                Descripcion = descripcion,
                PrecioUnitarioCompra = precioUnitarioCompra,
                IdRubro = rubroId.Value,
            };

            repositorioProductos.Agregar(producto);

            return producto;
        }

        public void ModificarProducto(Guid? productoId, string nombre, string descripcion, decimal precioUnitarioCompra, string nombreRubro)
        {
            var rubroId = BuscarIdRubro(nombreRubro);

            if (productoId != null && rubroId != null)
                repositorioProductos.Modificar(productoId.Value, nombre, descripcion, precioUnitarioCompra, rubroId.Value);
        }


        // BUSQUEDAS
        public IReadOnlyCollection<Producto> BuscarProductos() => repositorioProductos.BuscarTodos();

        public IReadOnlyCollection<Producto> BuscarPorFiltro(string txt)
        {
            var texto = txt.Trim();
            IReadOnlyCollection<Producto> productosFiltrados = new List<Producto>();

            if (Guid.TryParse(texto, out var id))
            {
                var producto = repositorioProductos.BuscarPorId(id);

                if (producto != null)
                    productosFiltrados = Array.AsReadOnly(new[] {producto});
            }

            else
            {
                productosFiltrados = repositorioProductos.BuscarPorNombreContiene(texto);
            }

            return productosFiltrados;
        }

        public Producto? BuscarProductoPorId(Guid id) => repositorioProductos.BuscarPorId(id);

        public Producto? BuscarProductoPorNombre(string nombre) => repositorioProductos.BuscarPorNombre(nombre);

        public IReadOnlyCollection<Producto>? BuscarPorRubro(string nombreRubro)
        {
            var rubroId = BuscarIdRubro(nombreRubro);

            if (rubroId == null)
                return null;

            return repositorioProductos.BuscarPorRubro(rubroId.Value);
        }

        // MOVER A GESTOR RUBROS
        private Guid? BuscarIdRubro(string nombre)
        {
            var rubro = Program.GestorDeRubros.BuscarRubroPorNombre(nombre);

            if (rubro == null)
                return null;

            return rubro.Id;
        }
    }
}
