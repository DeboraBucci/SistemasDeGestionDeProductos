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
    public class RepositorioRubros : RepositorioEntidad<Rubro>
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
    }
}
