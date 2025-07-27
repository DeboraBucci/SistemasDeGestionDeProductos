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

namespace SistemasDeGestionDeProductos.Formularios.Reportes
{
    public partial class StockPorRubro : Form
    {
        public StockPorRubro()
        {
            InitializeComponent();
        }

        private void StockPorRubro_Load(object sender, EventArgs e)
        {
            dgvControl1.DefinicionesColumnas = NombreColumnasHelper.nombresColumnasRubroStock;
            ActualizarDataGrid();
        }

        private void StockPorRubro_Activated(object sender, EventArgs e)
        {
            ActualizarDataGrid();
        }

        private void ActualizarDataGrid()
        {
            var rubros = Program.GestorDeRubros.BuscarRubros();

            var productosConStock = rubros.Select(r => new
            {
                r.Id,
                r.Nombre,
                Stock = Program.GestorDeMovimientos.ObtenerStockActualPorRubro(r.Id),
                r.Descripcion,
            }).ToList();

            dgvControl1.Refrescar(productosConStock);
        }
    }
}
