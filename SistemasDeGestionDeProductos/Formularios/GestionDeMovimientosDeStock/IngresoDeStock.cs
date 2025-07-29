using SistemasDeGestionDeProductos.Clases.Helpers;
using SistemasDeGestionDeProductos.Clases.Mappers;
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
            dgvControl1.DefinicionesColumnas = NombreColumnasHelper.nombresColumnasIngresos;
            ActualizarDataGrid();
            ActualizarComboBoxes();
        }

        private void IngresoDeStock_Activated(object sender, EventArgs e)
        {
            ActualizarDataGrid();
            ActualizarComboBoxes();
        }

        private void ActualizarDataGrid()
        {
            var movimientos = Program.GestorDeMovimientos.ListarIngresos();
            dgvControl1.Refrescar(MovimientosMapper.ListaMovimientoAMovimientoDTO(movimientos));
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

                var fechaVencimiento = dtpFechaVencimiento.Value.Date;

                var productoId = Program.GestorDeProductos.BuscarPorNombre(producto)?.Id;
                var proveedorId = Program.GestorDeProveedores.BuscarPorNombre(proveedor)?.Id;

                if (productoId != null && proveedorId != null)
                {
                    Program.GestorDeMovimientos.IngresarStock(productoId.Value, stock, fechaVencimiento, proveedorId.Value);
                    ActualizarDataGrid();
                    VaciarTextos();
                    MessageHelper.ShowSuccessfulMessage("Se ha realizado el ingreso manera exitosa!");
                }

                else
                    throw new Exception("Algo salio mal, verifica los datos.");
            }

            catch (Exception ex)
            {
                MessageHelper.ShowErrorMessage(ex.Message);
            }
        }

        private void ActualizarComboBoxes()
        {
            cbControl1.LlenarComboBox(Program.GestorDeProductos.BuscarActivos());
            cbControl2.LlenarComboBox(Program.GestorDeProveedores.BuscarActivos());
        }

        private void VaciarTextos()
        {
            txtStock.Text = string.Empty;
        }
    }
}
