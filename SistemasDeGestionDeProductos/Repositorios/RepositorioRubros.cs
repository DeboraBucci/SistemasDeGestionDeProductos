using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemasDeGestionDeProductos.Entidades;
using SistemasDeGestionDeProductos.Helpers;
using SistemasDeGestionDeProductos.Interfaces;

namespace SistemasDeGestionDeProductos.Repositorios
{
    public class RepositorioRubros : RepositorioBase<Rubro>
    {
        public RepositorioRubros(string path) : base(path) { }

        public void Modificar(Guid id, string nombre, string descripcion)
        {
            var rubro = BuscarPorId(id);

            if (rubro != null)
            {
                rubro.Nombre = nombre;
                rubro.Descripcion = descripcion;
            }

            ActualizarArchivo();
        }

        public Rubro? BuscarPorNombre(string nombre) => _items.FirstOrDefault(r => TextHelper.SonIgualesSinTildes(r.Nombre + "", nombre));

        public bool Eliminar(Rubro rubro)
        {
            var eliminado =  _items.Remove(rubro);
            ActualizarArchivo();

            return eliminado;
        }
    }
}
