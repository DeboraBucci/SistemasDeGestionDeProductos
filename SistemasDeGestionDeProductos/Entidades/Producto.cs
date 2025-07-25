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
        private static readonly decimal _porcentajeIncrementoPrecio = 0.5m; // 50%

        public Guid Id { get; private set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public decimal PrecioUnitarioCompra { get; set; }
        public decimal PrecioUnitarioVenta { get
            {
                return PrecioUnitarioCompra + (PrecioUnitarioCompra * _porcentajeIncrementoPrecio); 
            } 
        }
        public Guid IdRubro { get; set; }

        public Producto()
        {
            Id = Guid.NewGuid();
        }

        [JsonConstructor]
        public Producto(Guid id, string? nombre, string? descripcion, decimal precioUnitarioCompra, Guid idRubro)
        {
            Id = id;
            Nombre = nombre;
            Descripcion = descripcion;
            PrecioUnitarioCompra = precioUnitarioCompra;
            IdRubro = idRubro;
        }
    }
}
