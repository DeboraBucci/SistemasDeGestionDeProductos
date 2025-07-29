using SistemasDeGestionDeProductos.Clases.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SistemasDeGestionDeProductos.Clases.Entidades
{
    public enum TipoMovimiento
    {
        Ingreso,
        Egreso
    }

    public class MovimientoStock : IConId
    {
        public Guid Id { get; }
        public Guid ProductoId { get; set; }
        public TipoMovimiento Tipo { get; set; }
        public int Stock { get; set; }
        public DateTime FechaMovimiento { get; set; } = DateTime.Now;
        public DateTime FechaVencimiento { get; set; }

        public Guid? ProveedorId { get; set; } = null; // SOLO INGRESOS
        public string Motivo { get; set; } = string.Empty; // SOLO EGRESOS

        public MovimientoStock()
        {
            Id = Guid.NewGuid();
        }

        [JsonConstructor]
        public MovimientoStock(
        Guid id,
        Guid productoId,
        TipoMovimiento tipo,
        int stock,
        DateTime fechaMovimiento,
        DateTime fechaVencimiento)
        {
            Id = id;
            ProductoId = productoId;
            Tipo = tipo;
            Stock = stock;
            FechaMovimiento = fechaMovimiento;
            FechaVencimiento = fechaVencimiento;
        }
    }
}
