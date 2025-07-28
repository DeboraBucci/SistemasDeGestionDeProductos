using SistemasDeGestionDeProductos.Entidades;
using SistemasDeGestionDeProductos.Helpers;
using SistemasDeGestionDeProductos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasDeGestionDeProductos.Repositorios
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


        public void Agregar(T item)  {
            _items.Add(item);
            ActualizarArchivo();
        }

        public void ActualizarArchivo() => JsonHelper.GuardarEnArchivo(_items, _path);

        public T? BuscarPorId(Guid id) => _items.FirstOrDefault(p => p.Id == id);
    }
}
