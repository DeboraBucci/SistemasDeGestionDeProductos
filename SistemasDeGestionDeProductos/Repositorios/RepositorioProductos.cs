using SistemasDeGestionDeProductos.Entidades;
using SistemasDeGestionDeProductos.Helpers;
using SistemasDeGestionDeProductos.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SistemasDeGestionDeProductos.Repositorios
{
    internal class RepositorioProductos : IRepositorio<Producto>
    {
        private static readonly string archivoProductos = "productos.json";
        private readonly List<Producto> productos = JsonHelper.LeerDesdeArchivo<Producto>(archivoProductos);


        // MODIFICADORES
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


        // BUSCADORES
        public IReadOnlyCollection<Producto> BuscarTodos() => productos.AsReadOnly();
       
        public IReadOnlyCollection<Producto> BuscarPorRubro(Guid idRubro) => productos.Where(p => p.IdRubro == idRubro).ToList();
        
        public IReadOnlyCollection<Producto> BuscarPorNombreContiene(string txt) => 
            productos.Where(p => !string.IsNullOrEmpty(p.Nombre) && p.Nombre.Contains(txt, StringComparison.OrdinalIgnoreCase))
                     .ToList()
                     .AsReadOnly();

        public Producto? BuscarPorNombre(string nombre) => productos.FirstOrDefault(p => TextHelper.SonIgualesSinTildes(p.Nombre + "", nombre));
       
        public Producto? BuscarPorId(Guid id) => productos.FirstOrDefault(r => r.Id == id);
    }
}
