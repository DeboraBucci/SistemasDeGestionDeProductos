using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasDeGestionDeProductos.Interfaces
{
    public interface IRepositorioEntidad<T>
    {
        T? BuscarPorNombre(string nombre);

    }
}
