using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SistemasDeGestionDeProductos.Entidades
{
    public class Producto
    {
        private static decimal porcentajeIncrementoPrecio = 0.5m; // 50%

        public Guid Id { get; private set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public decimal PrecioUnitarioCompra { get; set; }
        public decimal PrecioUnitarioVenta { get
            {
                return PrecioUnitarioCompra + (PrecioUnitarioCompra * porcentajeIncrementoPrecio); 
            } 
        }
        public int Stock { get; set; }
        public Guid IdRubro { get; set; }

        public Producto()
        {
            Id = Guid.NewGuid();
        }

        [JsonConstructor]
        public Producto(Guid id, string? nombre, string? descripcion, decimal precioUnitarioCompra,  int stock, Guid idRubro)
        {
            Id = id;
            Nombre = nombre;
            Descripcion = descripcion;
            PrecioUnitarioCompra = precioUnitarioCompra;
            Stock = stock;
            IdRubro = idRubro;
        }
    }
}
