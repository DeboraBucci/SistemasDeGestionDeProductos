using SistemasDeGestionDeProductos.Entidades;
using SistemasDeGestionDeProductos.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasDeGestionDeProductos.Service
{
    public class GestorDeProveedores
    {
        private readonly RepositorioProveedores repositorioProveedores;

        public GestorDeProveedores()
        {
            repositorioProveedores = new();
        }

        public void CrearProveedor(string nombre, string contacto, string telefono, string direccion)
        {
            var proveedorYaExistente = repositorioProveedores.BuscarPorNombre(nombre);

            if (proveedorYaExistente != null)
                throw new Exception("Ya existe un proveedor con el mismo nombre.");

            Proveedor proveedor = new()
            {
                Nombre = nombre,
                Contacto = contacto,
                Telefono = telefono,
                Direccion = direccion
            };

            repositorioProveedores.Agregar(proveedor);
        }

        public IReadOnlyCollection<Proveedor> BuscarProveedores() => repositorioProveedores.BuscarTodos();

        public Proveedor? BuscarProveedorPorId(Guid id) => repositorioProveedores.BuscarPorId(id);

        public Proveedor? BuscarProveedorPorNombre(string nombre) => repositorioProveedores.BuscarPorNombre(nombre);

        public void ModificarProveedor(Guid? proveedorId, string nombre, string contacto, string telefono, string direccion)
        {
            if (proveedorId != null)
                repositorioProveedores.Modificar(proveedorId.Value, nombre, contacto, telefono, direccion);
        }

        public IReadOnlyCollection<Proveedor> BuscarPorFiltro(string txt) => repositorioProveedores.BuscarPorNombreContiene(txt.Trim());
    }
}
