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
        }

        private void ActualizarDataGrid()
        {
            var movimientos = Program.GestorDeMovimientos.ListarMovimientos();
            dgvControl1.Refrescar(movimientos);
        }
    }
}
