using SistemasDeGestionDeProductos.Clases.Helpers;
using SistemasDeGestionDeProductos.Clases.Interfaces;

namespace SistemasDeGestionDeProductos.Clases.Repositorios
{
    public abstract class RepositorioBase<T> : IRepositorioBase<T>
        where T : IConId
    {
        private readonly string _path;
        public readonly List<T> _items;

        public RepositorioBase(string path)
        {
            _path = path;
            _items = JsonHelper.LeerDesdeArchivo<T>(path);
        }

        public IReadOnlyCollection<T> BuscarTodos() => _items.AsReadOnly();


        public void Agregar(T item)
        {
            _items.Add(item);
            ActualizarArchivo();
        }

        public T? BuscarPorId(Guid id) => _items.FirstOrDefault(p => p.Id == id);

        public void ActualizarArchivo() => JsonHelper.GuardarEnArchivo(_items, _path);
    }
}
