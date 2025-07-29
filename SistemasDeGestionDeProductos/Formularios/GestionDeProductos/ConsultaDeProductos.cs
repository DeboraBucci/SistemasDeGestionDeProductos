using SistemasDeGestionDeProductos.Clases.Helpers;
using SistemasDeGestionDeProductos.Clases.Mappers;

namespace SistemasDeGestionDeProductos.Ventanas.GestionDeProductos
{
    public partial class ConsultaDeProductos : Form
    {
        public ConsultaDeProductos()
        {
            InitializeComponent();
        }

        private void ConsultaDeProductos_Load(object sender, EventArgs e)
        {
            dgvControl1.DefinicionesColumnas = NombreColumnasHelper.nombresColumnasProductos;
            ActualizarDataGrid();
            ActualizarComboBox();
           
        }

        private void ConsultaDeProductos_Activated(object sender, EventArgs e)
        {
            ActualizarDataGrid();
            ActualizarComboBox();
        }


        private void cbControl1_SelectionChangedExternal(object sender, EventArgs e)
        {
            ActualizarDataGrid();
        }

        private void txtIdONombre_TextChanged(object sender, EventArgs e)
        {
            ActualizarDataGrid();
        }

        private void ActualizarDataGrid()
        {
            var texto = txtFiltro.Text.Trim();
            string nombreRubro = cbControl1.CbTxt ?? string.Empty;
      
             var idRubro = Program.GestorDeRubros.BuscarPorNombre(nombreRubro)?.Id;

             var productos = Program.GestorDeProductos.BuscarPorFiltro(idRubro, texto);
             dgvControl1.Refrescar(ProductosMapper.ListaProductoAProductoDTO(productos));
        }

        private void ActualizarComboBox()
        {
            cbControl1.LlenarComboBox(Program.GestorDeRubros.BuscarActivos(), true);
        }
    }
}
