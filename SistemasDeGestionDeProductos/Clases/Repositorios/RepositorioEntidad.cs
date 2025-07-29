using SistemasDeGestionDeProductos.Clases.Entidades;
using SistemasDeGestionDeProductos.Clases.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasDeGestionDeProductos.Clases.Repositorios
{
    public abstract class RepositorioEntidad<T> : RepositorioBase<T> where T : Entidad
    {
        public RepositorioEntidad(string path) : base(path) { }

        public T? BuscarPorNombre(string nombre) => _items.FirstOrDefault(p => TextHelper.SonIgualesSinTildes(p.Nombre + "", nombre));


        public IReadOnlyCollection<T> BuscarPorNombreContiene(string txt) =>
            BuscarActivos()
            .Where(i => !string.IsNullOrEmpty(i.Nombre) && i.Nombre.Contains(txt, StringComparison.OrdinalIgnoreCase))
            .ToList()
            .AsReadOnly();

        public IReadOnlyCollection<T> BuscarActivos() => _items.Where(i => !i.Eliminado).ToList();

        public void Eliminar(T item)
        {
            item.Eliminar();
            ActualizarArchivo();
        }
    }
}
