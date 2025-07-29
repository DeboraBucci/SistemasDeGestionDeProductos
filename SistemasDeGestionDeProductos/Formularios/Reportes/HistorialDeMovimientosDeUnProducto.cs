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

namespace SistemasDeGestionDeProductos.Formularios.Reportes
{
    public partial class HistorialDeMovimientosDeUnProducto : Form
    {
        public HistorialDeMovimientosDeUnProducto()
        {
            InitializeComponent();
        }

        private void HistorialDeMovimientosDeUnProducto_Load(object sender, EventArgs e)
        {
            dgvControl1.DefinicionesColumnas = NombreColumnasHelper.nombresColumnasMovimientos;
            ActualizarDataGrid();

            cbControl1.LlenarComboBox(Program.GestorDeProductos.BuscarTodos());
        }

        private void HistorialDeMovimientosDeUnProducto_Activated(object sender, EventArgs e)
        {
            ActualizarDataGrid();
        }

        private void cbControl1_SelectionChangedExternal(object sender, EventArgs e)
        {
            ActualizarDataGrid();
        }

        private void ActualizarDataGrid()
        {
            var productoNombre = cbControl1.CbTxt ?? string.Empty;

            var productoId = Program.GestorDeProductos.BuscarPorNombre(productoNombre)?.Id;

            if (productoId != null)
            {
                var ingresosDelProducto = Program.GestorDeMovimientos.ListarMovimientos(productoId);
                dgvControl1.Refrescar(MovimientosMapper.ListaMovimientoAMovimientoDTO(ingresosDelProducto));
            }
        }
    }
}
