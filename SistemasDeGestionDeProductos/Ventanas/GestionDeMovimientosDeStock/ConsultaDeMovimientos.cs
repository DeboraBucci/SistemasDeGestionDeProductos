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

            cbControl1.LlenarComboBox(Program.GestorDeProductos.BuscarProductos());
        }

        private void ConsultaDeMovimientos_Activated(object sender, EventArgs e)
        {
            ActualizarDataGrid();
        }

        private void ActualizarDataGrid()
        {
            var movimientos = Program.GestorDeMovimientos.ListarMovimientos();
            dgvControl1.Refrescar(movimientos);
        }

    }
}
