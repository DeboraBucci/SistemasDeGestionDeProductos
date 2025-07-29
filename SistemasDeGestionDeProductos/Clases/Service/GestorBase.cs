using SistemasDeGestionDeProductos.Clases.Entidades;
using SistemasDeGestionDeProductos.Clases.Repositorios;

namespace SistemasDeGestionDeProductos.Clases.Service
{
    public abstract class GestorBase<TEntidad, TRepositorio>
        where TEntidad : Entidad
        where TRepositorio : RepositorioEntidad<TEntidad>
    {

        protected readonly TRepositorio _repositorio;

        public GestorBase(TRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public virtual bool Eliminar(TEntidad entidad)
        {
            if (entidad.Nombre != null)
            {
                _repositorio.Eliminar(entidad);
                return true;
            }

            return false;
        }


        public IReadOnlyCollection<TEntidad> BuscarTodos() => _repositorio.BuscarTodos();

        public IReadOnlyCollection<TEntidad> BuscarActivos() => _repositorio.BuscarActivos();

        public TEntidad? BuscarPorId(Guid id) => _repositorio.BuscarPorId(id);

        public TEntidad? BuscarPorNombre(string nombre) => _repositorio.BuscarPorNombre(nombre);

        public IReadOnlyCollection<Entidad> BuscarPorFiltro(string txt) => _repositorio.BuscarPorNombreContiene(txt.Trim());
    }
}
