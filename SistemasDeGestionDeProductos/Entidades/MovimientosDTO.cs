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
        public string Producto { get; set; } = string.Empty;
        public string Tipo { get; set; } = string.Empty;
        public int Stock { get; set; }
        public DateTime FechaMovimiento { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public string Proveedor { get; set; } = string.Empty;
        public string Motivo { get; set; } = string.Empty; 

        public MovimientosDTO(
            Guid id, 
            string producto, 
            string tipo, 
            int stock, 
            DateTime fechaMovimiento, 
            DateTime fechaVencimiento, 
            string proveedor, 
            string motivo)
        {
            Id = id;
            Producto = producto;
            Tipo = tipo;
            Stock = stock;
            FechaMovimiento = fechaMovimiento;
            FechaVencimiento = fechaVencimiento;
            Proveedor = proveedor;
            Motivo = motivo;
        }
    }
}
