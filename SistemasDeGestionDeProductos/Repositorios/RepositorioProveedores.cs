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
    internal class RepositorioProveedores : RepositorioBase<Proveedor>
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


        public IReadOnlyCollection<Proveedor> BuscarPorNombreContiene(string txt) =>
            _items
            .Where(p => !string.IsNullOrEmpty(p.Nombre) && p.Nombre.Contains(txt, StringComparison.OrdinalIgnoreCase))
            .ToList()
            .AsReadOnly();

        public Proveedor? BuscarPorNombre(string nombre) => _items.FirstOrDefault(r => TextHelper.SonIgualesSinTildes(r.Nombre + "", nombre));


        public void Eliminar(Proveedor proveedor)
        {
            proveedor.Eliminar();
            ActualizarArchivo();
        }
    }
}
