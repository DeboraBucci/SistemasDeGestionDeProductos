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
    public partial class EgresoDeStock : Form
    {
        public EgresoDeStock()
        {
            InitializeComponent();
        }

        private void EgresoDeStock_Load(object sender, EventArgs e)
        {
            dgvControl1.DefinicionesColumnas = NombreColumnasHelper.nombresColumnasEgresos;
            ActualizarDataGrid();

            cbControl1.LlenarComboBox(Program.GestorDeProductos.BuscarTodos());
        }

        private void EgresoDeStock_Activated(object sender, EventArgs e)
        {
            ActualizarDataGrid();
        }

        private void btnAgregarEgreso_Click(object sender, EventArgs e)
        {
            try
            {
                var productoNombre = cbControl1.CbTxt ?? string.Empty;

                var productoElegido = Program.GestorDeProductos.BuscarPorNombre(productoNombre);

                if (productoNombre == null)
                    throw new ArgumentException("El producto elegido es invalido.");

                var cantidadStr = txtCantidad.Text.Trim();

                if (!int.TryParse(cantidadStr, out var cantidad) || cantidad <= 0)
                    throw new ArgumentException("Stock invalido.");

                var motivo = txtMotivo.Text.Trim();

                if (motivo == null)
                    throw new ArgumentException("El motivo no puede estar vacio.");


                var prodId = productoElegido?.Id;

                if (prodId != null)
                {
                    Program.GestorDeMovimientos.EgresarStock(prodId.Value, cantidad, motivo);
                    ActualizarDataGrid();
                }
            }

            catch (Exception ex)
            {
                MessageHelper.ShowErrorMessage(ex.Message);
            }
        }


        private void ActualizarDataGrid()
        {
            var movimientos = Program.GestorDeMovimientos.ListarEgresos();
            dgvControl1.Refrescar(MovimientosMapper.ListaMovimientoAMovimientoDTO(movimientos));
        }
    }
}
