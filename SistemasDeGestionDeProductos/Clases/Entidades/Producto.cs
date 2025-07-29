using System.Text.Json.Serialization;

namespace SistemasDeGestionDeProductos.Clases.Entidades
{
    public class Producto : Entidad
    {
        private static readonly decimal _porcentajeIncrementoPrecio = 0.5m; // 50%

        public string Descripcion { get; set; } = string.Empty;
        public decimal PrecioUnitarioCompra { get; set; }
        public decimal PrecioUnitarioVenta
        {
            get
            {
                return PrecioUnitarioCompra + PrecioUnitarioCompra * _porcentajeIncrementoPrecio;
            }
        }
        public Guid IdRubro { get; set; }

        public Producto() { }

        [JsonConstructor]
        public Producto(Guid id, string nombre, string descripcion, decimal precioUnitarioCompra, Guid idRubro, bool eliminado)
        {
            Id = id;
            Nombre = nombre;
            Descripcion = descripcion;
            PrecioUnitarioCompra = precioUnitarioCompra;
            IdRubro = idRubro;
            Eliminado = eliminado;
        }
    }
}
