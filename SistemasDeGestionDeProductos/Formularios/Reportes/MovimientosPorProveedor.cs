using SistemasDeGestionDeProductos.Clases.Helpers;
using SistemasDeGestionDeProductos.Clases.Mappers;

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
            
            var proveedorId = Program.GestorDeProveedores.BuscarPorNombre(proveedorNombre)?.Id;

            if (proveedorId != null)
            {
                var ingresosDelProveedor = Program.GestorDeMovimientos.BuscarPorProveedor(proveedorId.Value);
                dgvControl1.Refrescar(MovimientosMapper.ListaMovimientoAMovimientoDTO(ingresosDelProveedor));
            }
        }

        private void ActualizarComboBox()
        {
            cbControl1.LlenarComboBox(Program.GestorDeProveedores.BuscarTodos());
        }
    }
}
