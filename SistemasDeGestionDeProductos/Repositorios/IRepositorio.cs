using SistemasDeGestionDeProductos.Entidades;
using SistemasDeGestionDeProductos.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasDeGestionDeProductos.Repositorios
{
    public interface IRepositorio<T>
    {
        IReadOnlyCollection<T> BuscarTodos();
        T? BuscarPorNombre(string nombre);
        void Agregar(T entidad);
    }
}
