using SistemasDeGestionDeProductos.Controles;
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

namespace SistemasDeGestionDeProductos.Formularios.Reportes
{
    public partial class MovimientosPorProveedor : Form
    {
        public MovimientosPorProveedor()
        {
            InitializeComponent();
        }

        private void MovimientosPorProveedor_Load(object sender, EventArgs e)
        {
            dgvControl1.DefinicionesColumnas = NombreColumnasHelper.nombresColumnasMovimientos;
            ActualizarDataGrid();
            ActualizarComboBox();
        }

        private void MovimientosPorProveedor_Activated(object sender, EventArgs e)
        {
            ActualizarDataGrid();
            ActualizarComboBox();
        }

        private void cbControl1_SelectionChangedExternal(object sender, EventArgs e)
        {
            ActualizarDataGrid();
        }

        private void ActualizarDataGrid()
        {
            var proveedorNombre = cbControl1.CbTxt ?? string.Empty;
            
            var proveedorId = Program.GestorDeProveedores.BuscarProveedorPorNombre(proveedorNombre)?.Id;

            if (proveedorId != null)
            {
                var ingresosDelProveedor = Program.GestorDeMovimientos.BuscarPorProveedor(proveedorId.Value);
                dgvControl1.Refrescar(MovimientosMapper.ListaMovimientoAMovimientoDTO(ingresosDelProveedor));
            }
        }

        private void ActualizarComboBox()
        {
            cbControl1.LlenarComboBox(Program.GestorDeProveedores.BuscarProveedores());
        }
    }
}
