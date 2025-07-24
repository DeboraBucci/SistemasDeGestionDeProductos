using SistemasDeGestionDeProductos.Entidades;
using SistemasDeGestionDeProductos.Helpers;
using SistemasDeGestionDeProductos.Service;
using SistemasDeGestionDeProductos.Validadores;
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
                string nombre = txtNombre.Text;
                string descripcion = rtxtDescripcion.Text;
                string precioUnitarioStr = txtPrecioUnitario.Text;
                string stockStr = txtStock.Text;
                string rubroNombre = rubroscbControl1.CbRubrosTxt + "";
                string proveedorNombre = proveedorcbControl1.CbProveedorTxt + "";

                var prod = ValidadorInputProducto.ValidarInformacion(nombre, descripcion, precioUnitarioStr, stockStr );

                Program.GestorDeProductos.CrearProducto(prod.Nombre, prod.Descripcion, prod.PrecioUnitarioCompra, prod.Stock, rubroNombre, proveedorNombre);

                ActualizarDataGrid();
            }

            catch (Exception ex)
            {
                ErrorMessage.ShowErrorMessage(ex.Message);
            }
        }

        private void AltaDeProducto_Load(object sender, EventArgs e)
        {
            
            dgvControl1.DefinicionesColumnas = NombreColumnasHelper.nombresColumnasProductos;
            ActualizarDataGrid();
        }

        private void ActualizarDataGrid()
        {
            var productos = Program.GestorDeProductos.BuscarProductos();
            dgvControl1.Refrescar(ProductoMapper.ListaProductoAProductoDTO(productos));
        }
    }
}
