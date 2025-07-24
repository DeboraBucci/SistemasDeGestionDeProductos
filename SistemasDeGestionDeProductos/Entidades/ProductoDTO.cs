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
        public int Stock { get; }
        public string Rubro { get;  }
        public string Proveedor { get; }

        public ProductoDTO(
            Guid id, 
            string nombre, 
            string descripcion, 
            decimal precioUnitarioCompra, 
            decimal precioUnitarioVenta, 
            int stock,
            string rubro,
            string proveedor
            )
        {
            Id = id;
            Nombre = nombre;
            Descripcion = descripcion;
            PrecioUnitarioCompra = precioUnitarioCompra;
            PrecioUnitarioVenta = precioUnitarioVenta;
            Stock = stock;
            Rubro = rubro;
            Proveedor = proveedor;
        } 
    }
}
