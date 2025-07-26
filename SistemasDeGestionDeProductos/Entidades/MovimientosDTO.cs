using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasDeGestionDeProductos.Entidades
{
    public class MovimientosDTO
    {
        public Guid Id { get; private set; }
        public Guid ProductoId { get; set; }
        public TipoMovimiento Tipo { get; set; }
        public int Stock { get; set; }
        public DateTime FechaMovimiento { get; set; }
        public DateTime FechaVencimiento { get; set; }

        public Guid? ProveedorId { get; set; } = null; // SOLO INGRESOS
        public string Motivo { get; set; } = string.Empty; // SOLO EGRESOS
    }
}
