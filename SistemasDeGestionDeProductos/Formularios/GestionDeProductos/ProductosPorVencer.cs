using SistemasDeGestionDeProductos.Clases.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemasDeGestionDeProductos.Formularios.GestionDeProductos
{
    public partial class ProductosPorVencer : Form
    {
        public ProductosPorVencer()
        {
            InitializeComponent();
           
        }

        private void ProductosPorVencer_Load(object sender, EventArgs e)
        {
            dgvControl1.DefinicionesColumnas = NombreColumnasHelper.nombresColumnasProductosVencer;

            cbPorVencer.SelectedIndex = 0;
            ActualizarDataGrid();
        }

        private void ProductosPorVencer_Activated(object sender, EventArgs e)
        {
            cbPorVencer.SelectedIndex = 0;
            ActualizarDataGrid();
        }


        private void cbPorVencer_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarDataGrid();
        }

        private void ActualizarDataGrid()
        {
            try
            {
                var diasAnticipacionTxt = cbPorVencer.Text;

                if (!int.TryParse(diasAnticipacionTxt, out int diasAnticipacion))
                    throw new ArgumentException("Tiempo seleccionado incorrecto.");

                var anticipacion = TimeSpan.FromDays(diasAnticipacion);

                var productos = Program.GestorDeMovimientos.ProductosPorVencer(anticipacion);

                if (productos != null)
                    dgvControl1.Refrescar(productos);
            }

            catch (Exception ex)
            {
                MessageHelper.ShowErrorMessage(ex.Message);
            }
        }
    }
}
