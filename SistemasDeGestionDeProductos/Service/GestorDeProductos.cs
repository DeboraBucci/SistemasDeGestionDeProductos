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

        public void CrearProducto(string nombre, string descripcion, decimal precioUnitarioCompra, int stock, string nombreRubro, string nombreProveedor)
        {
            // VERIFICAR SI EXISTE PRODUCTO
            var productoYaExistente = repositorioProductos.BuscarPorNombre(nombre);

            if (productoYaExistente != null)
                throw new InvalidOperationException("Ya existe un producto con el mismo nombre.");

            // CREAR PRODUCTO
            Producto producto = new()
            {
                Nombre = nombre,
                Descripcion = descripcion,
                PrecioUnitarioCompra = precioUnitarioCompra,
                Stock = stock,
                IdRubro = BuscarIdRubro(nombreRubro),
                IdProveedor = BuscarIdProveedor(nombreProveedor)
            };

            repositorioProductos.Agregar(producto);
        }

        public void ModificarProducto(Guid? productoId, string nombre, string descripcion, decimal precioUnitarioCompra, int stock, string nombreRubro, string nombreProveedor)
        {
            if (productoId != null)
                repositorioProductos.Modificar(productoId.Value, nombre, descripcion, precioUnitarioCompra, stock, BuscarIdRubro(nombreRubro), BuscarIdProveedor(nombreProveedor));
        }

        public IReadOnlyCollection<Producto> BuscarProductos() => repositorioProductos.BuscarTodos();

        public Producto? BuscarProductoPorId(Guid id) => repositorioProductos.BuscarPorId(id);


        private Guid BuscarIdRubro(string nombre)
        {
            var rubro = Program.GestorDeRubros.BuscarRubroPorNombre(nombre);

            if (rubro == null)
                throw new InvalidOperationException("El rubro seleccionado no existe.");

            return rubro.Id;
        }

        private Guid BuscarIdProveedor(string nombre)
        {
            var proveedor = Program.GestorDeProveedores.BuscarProveedorPorNombre(nombre);

            if (proveedor == null)
                throw new InvalidOperationException("El proveedor seleccionado no existe.");

            return proveedor.Id;
        }
    }
}
