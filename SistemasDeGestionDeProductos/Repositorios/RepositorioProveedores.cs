using SistemasDeGestionDeProductos.Entidades;
using SistemasDeGestionDeProductos.Helpers;
using SistemasDeGestionDeProductos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasDeGestionDeProductos.Repositorios
{
    public class RepositorioProveedores : RepositorioEntidad<Proveedor>
    {
        public RepositorioProveedores(string path) : base(path) { }

        public void Modificar(Guid id, string nombre, string contacto, string telefono, string direccion)
        {
            var proveedor = BuscarPorId(id);

            if (proveedor != null)
            {
                proveedor.Nombre = nombre;
                proveedor.Contacto = contacto;
                proveedor.Telefono = telefono;
                proveedor.Direccion = direccion;
            }

            ActualizarArchivo();
        }
    }
}
