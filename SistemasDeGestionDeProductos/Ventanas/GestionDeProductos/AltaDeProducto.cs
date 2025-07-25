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
                // INFO PRODUCTO
                string nombre = txtNombre.Text;
                string descripcion = rtxtDescripcion.Text;
                string precioUnitarioStr = txtPrecioUnitario.Text;
                string rubroNombre = cbControl1.CbTxt + "";

                // INFO PRIMER MOVIMIENTO
                string stockStr = txtStock.Text;
                string proveedorNombre = proveedorcbControl1.CbProveedorTxt + "";
                DateTime fechaVencimiento = dtpFechaVencimiento.Value.Date;


                if (!int.TryParse(stockStr, out int stock))
                    throw new Exception("Numero de stock invalido.");
                
                var infoProd = ValidadorInputProducto.ValidarInformacion(nombre, descripcion, precioUnitarioStr);

                var proveedorId = Program.GestorDeProveedores.BuscarProveedorPorNombre(proveedorNombre)?.Id ?? Guid.Empty;
                var producto = Program.GestorDeProductos.CrearProducto(infoProd.Nombre, infoProd.Descripcion, infoProd.PrecioUnitarioCompra, rubroNombre);
                
                Program.GestorDeMovimientos.IngresarStock(producto.Id, stock, fechaVencimiento, proveedorId);

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

            cbControl1.LlenarComboBox(Program.GestorDeRubros.BuscarRubros());
        }

        private void ActualizarDataGrid()
        {
            var productos = Program.GestorDeProductos.BuscarProductos();
            dgvControl1.Refrescar(ProductoMapper.ListaProductoAProductoDTO(productos));
        }
    }
}
