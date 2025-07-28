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
    public class RepositorioProductos : RepositorioBase<Producto>
    {
        public RepositorioProductos(string path): base(path) { }


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

            ActualizarArchivo();
        }


        public IReadOnlyCollection<Producto> BuscarPorRubro(Guid idRubro) => _items.Where(p => p.IdRubro == idRubro).ToList();
        
        public IReadOnlyCollection<Producto> BuscarPorNombreContiene(string txt) => 
            _items
            .Where(p => !string.IsNullOrEmpty(p.Nombre) && p.Nombre.Contains(txt, StringComparison.OrdinalIgnoreCase))
            .ToList()
            .AsReadOnly();

        public Producto? BuscarPorNombre(string nombre) => _items.FirstOrDefault(p => TextHelper.SonIgualesSinTildes(p.Nombre + "", nombre));
    }
}
