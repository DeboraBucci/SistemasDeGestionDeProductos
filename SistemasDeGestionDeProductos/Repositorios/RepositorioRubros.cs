using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemasDeGestionDeProductos.Entidades;
using SistemasDeGestionDeProductos.Helpers;

namespace SistemasDeGestionDeProductos.Repositorios
{
    internal class RepositorioRubros : IRepositorio<Rubro>
    {
        private static readonly string archivoRubros = "rubros.json";
        private readonly List<Rubro> rubros = JsonHelper.LeerDesdeArchivo<Rubro>(archivoRubros);

        public void Agregar(Rubro rubro)
        {
            rubros.Add(rubro);
            JsonHelper.GuardarEnArchivo(rubros, archivoRubros);
        }
        
        public IReadOnlyCollection<Rubro> BuscarTodos() => rubros.AsReadOnly();

        public Rubro? BuscarPorNombre(string nombre) => rubros.FirstOrDefault(r => TextHelper.SonIgualesSinTildes(r.Nombre + "", nombre));
        public Rubro? BuscarPorId(Guid id) => rubros.FirstOrDefault(r => r.Id == id);


    }
}
