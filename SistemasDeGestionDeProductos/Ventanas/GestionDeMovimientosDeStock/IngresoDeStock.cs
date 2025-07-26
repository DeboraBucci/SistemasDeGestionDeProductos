using SistemasDeGestionDeProductos.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasDeGestionDeProductos.Ventanas.GestionDeMovimientosDeStock
{
    public partial class IngresoDeStock : Form
    {
        public IngresoDeStock()
        {
            InitializeComponent();
        }

        private void IngresoDeStock_Load(object sender, EventArgs e)
        {
            dgvControl1.DefinicionesColumnas = NombreColumnasHelper.nombresColumnasMovimientos;
            ActualizarDataGrid();

            cbControl1.LlenarComboBox(Program.GestorDeProductos.BuscarProductos());
        }

        private void cbControl1_SelectionChangedExternal(object sender, EventArgs e)
        {
            var nombreProducto = cbControl1.CbTxt ?? string.Empty;

            var productoId = Program.GestorDeProductos.BuscarProductoPorNombre(nombreProducto)?.Id ?? Guid.Empty;

            var proovedores = Program.GestorDeMovimientos.ObtenerProveedoresPorProducto(productoId);

            if (proovedores != null)
                cbControl2.LlenarComboBox(proovedores);
        }

        private void IngresoDeStock_Activated(object sender, EventArgs e)
        {
            ActualizarDataGrid();
        }

        private void ActualizarDataGrid()
        {
            var movimientos = Program.GestorDeMovimientos.ListarIngresos();
            dgvControl1.Refrescar(movimientos);
        }

        private void btnAgregarMovimiento_Click(object sender, EventArgs e)
        {
            try
            {
                var producto = cbControl1?.CbTxt ?? string.Empty;
                var proveedor = cbControl2?.CbTxt ?? string.Empty;

                string stockTxt = txtStock.Text.Trim();

                if (!int.TryParse(stockTxt, out var stock) || stock <= 0)
                    throw new Exception("Stock invalido.");

                var fechaVencimiento = dtpFechaVencimiento.Value;

                var productoId = Program.GestorDeProductos.BuscarProductoPorNombre(producto)?.Id;
                var proveedorId = Program.GestorDeProveedores.BuscarProveedorPorNombre(proveedor)?.Id;

                if (productoId != null && proveedorId != null)
                {
                    Program.GestorDeMovimientos.IngresarStock(productoId.Value, stock, fechaVencimiento, proveedorId.Value);
                    ActualizarDataGrid();
                }

                else
                    throw new Exception("Algo salio mal, verifica los datos.");
            }

            catch (Exception ex)
            {
                ErrorMessage.ShowErrorMessage(ex.Message);
            }
        }
    }
}
