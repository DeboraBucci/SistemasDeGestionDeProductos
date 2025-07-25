using SistemasDeGestionDeProductos.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SistemasDeGestionDeProductos.Entidades
{
    public enum TipoMovimiento
    {
        Ingreso,
        Egreso
    }

    [JsonConverter(typeof(MovimientoStockConverter))]
    public class MovimientoStock
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public Guid ProductoId { get; set; }
        public TipoMovimiento Tipo {  get; set; }
        public int Stock {  get; set; }
        public DateTime FechaMovimiento {  get; set; } = DateTime.Now;
        public DateTime FechaVencimiento { get; set; }

    }

    public class IngresoStock : MovimientoStock
    {
        public Guid ProveedorId { get; set; }
    }

    public class EgresoStock : MovimientoStock
    {
        public string Motivo { get; set; }   = string.Empty;
    }
}
