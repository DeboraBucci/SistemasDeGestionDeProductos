using SistemasDeGestionDeProductos.Entidades;
using SistemasDeGestionDeProductos.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasDeGestionDeProductos.Service
{
    public class GestorDeProveedores : GestorBase<Proveedor, RepositorioProveedores>
    {
        public GestorDeProveedores(RepositorioProveedores repositorio) : base(repositorio) { }

        public void Crear(string nombre, string contacto, string telefono, string direccion)
        {
            var proveedorYaExistente = _repositorio.BuscarPorNombre(nombre);

            if (proveedorYaExistente != null)
                throw new Exception("Ya existe un proveedor con el mismo nombre.");

            Proveedor proveedor = new()
            {
                Nombre = nombre,
                Contacto = contacto,
                Telefono = telefono,
                Direccion = direccion
            };

            _repositorio.Agregar(proveedor);
        }


        public void Modificar(Guid? proveedorId, string nombre, string contacto, string telefono, string direccion)
        {
            if (proveedorId != null)
                _repositorio.Modificar(proveedorId.Value, nombre, contacto, telefono, direccion);
        }
    }
}
