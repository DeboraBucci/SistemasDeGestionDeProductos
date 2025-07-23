using SistemasDeGestionDeProductos.Entidades;
using SistemasDeGestionDeProductos.Helpers;
using SistemasDeGestionDeProductos.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasDeGestionDeProductos.Ventanas.GestionDeProductos
{
    public partial class AltaDeProducto : Form
    {

        public AltaDeProducto()
        {
            InitializeComponent();
        }

        private void btnCrearProducto_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombre.Text.Trim();
                string descripcion = rtxtDescripcion.Text.Trim();
                string precioUnitarioStr = txtPrecioUnitario.Text.Trim();
                string stockStr = txtStock.Text.Trim();
                string rubroNombre = rubroscbControl1.CbRubrosTxt;

                if (nombre == "")
                    throw new Exception("El nombre del producto no puede estar vacio.");

                if (!decimal.TryParse(precioUnitarioStr, out decimal precioUnit))
                    throw new Exception("El precio unitario es invalido, pruebe nuevamente.");

                if (!int.TryParse(stockStr, out int stock) || stock < 0)
                    throw new Exception("El stock debe ser un numero entero mayor o igual a 0.");

                var rubro = Program.GestorDeRubros.BuscarRubroPorNombre(rubroNombre);

                if (rubro == null)
                    throw new Exception("El rubro seleccionado no existe.");

                Guid idRubro = rubro.Id;


                Program.GestorDeProductos.CrearProducto(nombre, descripcion, precioUnit, stock, idRubro);
                productosdgvControl1.RefrescarProductos();
            }

            catch (Exception ex)
            {
                ErrorMessage.ShowErrorMessage(ex.Message);
            }
        }
    }
}
