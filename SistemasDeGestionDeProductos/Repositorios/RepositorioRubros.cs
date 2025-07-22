using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemasDeGestionDeProductos.Entidades;
using SistemasDeGestionDeProductos.Helpers;

namespace SistemasDeGestionDeProductos.Repositorios
{
    internal class RepositorioRubros
    {
        private static string archivoRubros = "rubros.json";
        private readonly List<Rubro> rubros = JsonHelper.LeerDesdeArchivo<Rubro>(archivoRubros);

        public void Agregar(Rubro rubro)
        {
            rubros.Add(rubro);
            JsonHelper.GuardarEnArchivo(rubros, archivoRubros);
        }
        
        public ReadOnlyCollection<Rubro> BuscarTodos() => rubros.AsReadOnly();
    }
}
