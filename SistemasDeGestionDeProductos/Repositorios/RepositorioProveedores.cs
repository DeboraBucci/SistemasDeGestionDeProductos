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
    internal class RepositorioProveedores : IRepositorio<Proveedor>
    {
        private static readonly string archivoProveedores = "proveedores.json";
        private readonly List<Proveedor> proveedores = JsonHelper.LeerDesdeArchivo<Proveedor>(archivoProveedores);

        public void Agregar(Proveedor proveedor)
        {
            proveedores.Add(proveedor);
            JsonHelper.GuardarEnArchivo(proveedores, archivoProveedores);
        }

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

            JsonHelper.GuardarEnArchivo(proveedores, archivoProveedores);
        }

        public IReadOnlyCollection<Proveedor> BuscarTodos() => proveedores.AsReadOnly();

        public IReadOnlyCollection<Proveedor> BuscarPorNombreContiene(string txt) =>
            proveedores.Where(p => !string.IsNullOrEmpty(p.Nombre) && p.Nombre.Contains(txt, StringComparison.OrdinalIgnoreCase))
                     .ToList()
                     .AsReadOnly();

        public Proveedor? BuscarPorNombre(string nombre) => proveedores.FirstOrDefault(r => TextHelper.SonIgualesSinTildes(r.Nombre + "", nombre));
        
        public Proveedor? BuscarPorId(Guid id) => proveedores.FirstOrDefault(p => p.Id == id);
    }
}
