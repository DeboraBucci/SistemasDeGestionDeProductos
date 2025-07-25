using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasDeGestionDeProductos.Validadores
{
    public class ProductoInput
    {
        public string Nombre { get; }
        public string Descripcion { get; }
        public decimal PrecioUnitarioCompra { get; }
 

        public ProductoInput(
            string nombre,
            string descripcion,
            decimal precioUnitarioCompra)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            PrecioUnitarioCompra = precioUnitarioCompra;
        }
    }

    public static class ValidadorInputProducto
    {
        public static ProductoInput ValidarInformacion(
               string nombreTxt,
               string descripcionTxt,
               string precioTxt)
        {

            string nombre = nombreTxt.Trim();
            string descripcion = descripcionTxt.Trim();

            if (nombre == "")
                throw new Exception("El nombre del producto no puede estar vacio.");

            if (!decimal.TryParse(precioTxt, out decimal precioUnit) || precioUnit < 0)
                throw new Exception("El precio unitario debe ser un número mayor o igual que 0.");

            return new ProductoInput(
                nombre,
                descripcion,
                precioUnit
            );
        }
    }
}
