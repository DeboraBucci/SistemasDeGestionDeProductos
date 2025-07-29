using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasDeGestionDeProductos.Entidades
{
    public class ProductoVencerDTO
    {
        public Guid Id { get; }
        public string Nombre { get; }
        public string Descripcion { get; }
        public decimal PrecioUnitarioCompra { get; }
        public decimal PrecioUnitarioVenta { get; }
        public string Rubro { get; }
        public int Stock { get; }
        public DateTime FechaVencimiento { get; }

        public ProductoVencerDTO(
            Guid id,
            string nombre,
            string descripcion,
            decimal precioUnitarioCompra,
            decimal precioUnitarioVenta,
            string rubro,
            int stock,
            DateTime fechaVencimiento
            )
        {
            Id = id;
            Nombre = nombre;
            Descripcion = descripcion;
            PrecioUnitarioCompra = precioUnitarioCompra;
            PrecioUnitarioVenta = precioUnitarioVenta;
            Rubro = rubro;
            Stock = stock;
            FechaVencimiento = fechaVencimiento;
        }
    }
}
