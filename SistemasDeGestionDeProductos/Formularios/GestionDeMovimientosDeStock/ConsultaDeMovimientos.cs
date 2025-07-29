using SistemasDeGestionDeProductos.Entidades;
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
    public partial class ConsultaDeMovimientos : Form
    {
        public ConsultaDeMovimientos()
        {
            InitializeComponent();
        }

        private void ConsultaDeMovimientos_Load(object sender, EventArgs e)
        {
            dgvControl1.DefinicionesColumnas = NombreColumnasHelper.nombresColumnasMovimientos;
            ActualizarDataGrid();
            ActualizarComboBox();
        }

        private void ConsultaDeMovimientos_Activated(object sender, EventArgs e)
        {
            ActualizarDataGrid();
            ActualizarComboBox();
        }

        private void cbControl1_SelectionChangedExternal(object sender, EventArgs e)
        {
            ActualizarFiltros();
        }

        private void cbFiltrarTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarFiltros();
        }

        private void dtpDesde_ValueChanged(object sender, EventArgs e)
        {
            ActualizarFiltros();
        }

        private void dtpHasta_ValueChanged(object sender, EventArgs e)
        {
            ActualizarFiltros();
        }

        private void ActualizarDataGrid()
        {
            var movimientos = Program.GestorDeMovimientos.ListarMovimientos();
            dgvControl1.Refrescar(MovimientosMapper.ListaMovimientoAMovimientoDTO(movimientos));
        }

        private void ActualizarComboBox()
        {
            cbControl1.LlenarComboBox(Program.GestorDeProductos.BuscarTodos(), true);
        }

        private void ActualizarFiltros()
        {
            var nombreProducto = cbControl1.CbTxt ?? string.Empty;
            var tipoStr = cbFiltrarTipo.Text;

            var productoId = Program.GestorDeProductos.BuscarPorNombre(nombreProducto)?.Id;

            DateTime? fechaDesde = null;
            DateTime? fechaHasta = null;

            if (cboxFiltrarFechas.Checked)
            {
                fechaDesde = dtpDesde.Value.Date;
                fechaHasta = dtpHasta.Value.Date;
            }

            TipoMovimiento? tipo = null;

            if (Enum.TryParse(tipoStr, out TipoMovimiento tipOut))
                tipo = tipOut;


            var movimientosFiltrados = Program.GestorDeMovimientos.ListarMovimientos(productoId, tipo, fechaDesde, fechaHasta);
            dgvControl1.Refrescar(MovimientosMapper.ListaMovimientoAMovimientoDTO(movimientosFiltrados));

        }

        private void cboxFiltrarFechas_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxFiltrarFechas.Checked)
                ControlarActivacionFechas(true);

            else
                ControlarActivacionFechas(false);
        }

        private void ControlarActivacionFechas(bool activas)
        {
            lblDesde.Enabled = activas;
            dtpHasta.Enabled = activas;

            lblHasta.Enabled = activas;
            dtpDesde.Enabled = activas;
        }
    }
}
