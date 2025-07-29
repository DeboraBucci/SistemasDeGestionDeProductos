using SistemasDeGestionDeProductos.Clases.Helpers;

namespace SistemasDeGestionDeProductos.Ventanas.GestionDeRubros
{
    public partial class ConsultaDeRubros : Form
    {
        public ConsultaDeRubros()
        {
            InitializeComponent();
        }

        private void ConsultaDeRubros_Load(object sender, EventArgs e)
        {
            dgvControl1.DefinicionesColumnas = NombreColumnasHelper.nombresColumnasRubro;
            ActualizarDataGrid();
        }

        private void ConsultaDeRubros_Activated(object sender, EventArgs e)
        {
            ActualizarDataGrid();
        }

        private void ActualizarDataGrid()
        {
            dgvControl1.Refrescar(Program.GestorDeRubros.BuscarActivos());
        }
    }
}
