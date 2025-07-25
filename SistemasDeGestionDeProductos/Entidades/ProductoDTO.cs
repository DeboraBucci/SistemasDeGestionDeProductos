using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasDeGestionDeProductos.Entidades
{
    public class ProductoDTO
    {
        public Guid Id { get; }
        public string Nombre { get; }
        public string Descripcion { get; }
        public decimal PrecioUnitarioCompra { get; }
        public decimal PrecioUnitarioVenta { get; }
        public string Rubro { get;  }

        public ProductoDTO(
            Guid id, 
            string nombre, 
            string descripcion, 
            decimal precioUnitarioCompra, 
            decimal precioUnitarioVenta, 
            string rubro
            )
        {
            Id = id;
            Nombre = nombre;
            Descripcion = descripcion;
            PrecioUnitarioCompra = precioUnitarioCompra;
            PrecioUnitarioVenta = precioUnitarioVenta;
            Rubro = rubro;
        } 
    }
}
