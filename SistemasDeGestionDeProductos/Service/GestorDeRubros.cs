using SistemasDeGestionDeProductos.Entidades;
using SistemasDeGestionDeProductos.Repositorios;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasDeGestionDeProductos.Service
{
    internal class GestorDeRubros
    {
        private readonly RepositorioRubros repositorioRubros;

        public GestorDeRubros()
        {
            repositorioRubros = new();
        }


        public void CrearRubro(string nombre, string descripcion)
        {
            Rubro rubro = new() {
                Nombre = nombre,
                Descripcion = descripcion
            };

            repositorioRubros.Agregar(rubro);
        }

        public ReadOnlyCollection<Rubro> BuscarRubros() => repositorioRubros.BuscarTodos();


    }
}
