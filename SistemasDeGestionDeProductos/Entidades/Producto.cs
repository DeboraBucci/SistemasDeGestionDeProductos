using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasDeGestionDeProductos.Entidades
{
    public class Producto
    {
        public Guid Id { get; private set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public double PrecioUnitario { get; set; }
        public int Stock { get; set; }
        public Guid IdRubro { get; set; }

        public Producto()
        {
            Id = Guid.NewGuid();
        }
    }
}
