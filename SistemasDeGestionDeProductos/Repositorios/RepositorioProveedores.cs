using SistemasDeGestionDeProductos.Entidades;
using SistemasDeGestionDeProductos.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasDeGestionDeProductos.Repositorios
{
    internal class RepositorioProveedores : IRepositorio<Proveedor>
    {
        private static readonly string archivoProveedores = "proveedores.json";
        private readonly List<Proveedor> proveedores = JsonHelper.LeerDesdeArchivo<Proveedor>(archivoProveedores);

        public void Agregar(Proveedor proveedor)
        {
            proveedores.Add(proveedor);
            JsonHelper.GuardarEnArchivo(proveedores, archivoProveedores);
        }

        public IReadOnlyCollection<Proveedor> BuscarTodos() => proveedores.AsReadOnly();

        public Proveedor? BuscarPorNombre(string nombre) => proveedores.FirstOrDefault(r => TextHelper.SonIgualesSinTildes(r.Nombre + "", nombre));
        
        public Proveedor? BuscarPorId(Guid id) => proveedores.FirstOrDefault(p => p.Id == id);

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
        }
    }
}
