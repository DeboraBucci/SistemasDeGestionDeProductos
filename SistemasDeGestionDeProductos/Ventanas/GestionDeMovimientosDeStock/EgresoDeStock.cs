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
            dgvControl1.DefinicionesColumnas = NombreColumnasHelper.nombresColumnasMovimientos;
            ActualizarDataGrid();

            cbControl1.LlenarComboBox(Program.GestorDeProductos.BuscarProductos());
        }

        private void EgresoDeStock_Activated(object sender, EventArgs e)
        {
            ActualizarDataGrid();
        }

        private void btnAgregarEgreso_Click(object sender, EventArgs e)
        {

        }


        private void ActualizarDataGrid()
        {
            var movimientos = Program.GestorDeMovimientos.ListarEgresos();
            dgvControl1.Refrescar(movimientos);
        }
    }
}
