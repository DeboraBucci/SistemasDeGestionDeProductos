using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasDeGestionDeProductos.Entidades
{
    public class Rubro
    {
        public Guid Id { get; private set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }

        public Rubro()
        {
            Id = new Guid();
        }
    }
}
