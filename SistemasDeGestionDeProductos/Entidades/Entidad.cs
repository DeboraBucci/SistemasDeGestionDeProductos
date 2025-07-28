using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasDeGestionDeProductos.Entidades
{
    public abstract class Entidad
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
    }
}
