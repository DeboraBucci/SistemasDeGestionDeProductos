using SistemasDeGestionDeProductos.Entidades;
using SistemasDeGestionDeProductos.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasDeGestionDeProductos.Interfaces
{
    public interface IRepositorioBase<T>
    {
        IReadOnlyCollection<T> BuscarTodos();
        T? BuscarPorId(Guid id);
        void Agregar(T entidad);
    }
}
