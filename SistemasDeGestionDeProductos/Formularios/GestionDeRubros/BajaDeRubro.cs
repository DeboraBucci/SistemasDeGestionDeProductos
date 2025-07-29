using SistemasDeGestionDeProductos.Clases.Helpers;

namespace SistemasDeGestionDeProductos.Formularios.GestionDeRubros
{
    public partial class BajaDeRubro : Form
    {
        public BajaDeRubro()
        {
            InitializeComponent();
        }

        private void BajaDeRubro_Load(object sender, EventArgs e)
        {
            dgvControl1.DefinicionesColumnas = NombreColumnasHelper.nombresColumnasRubro;
            ActualizarDataGrid();
        }

        private void BajaDeRubro_Activated(object sender, EventArgs e)
        {
            ActualizarDataGrid();
        }

        private void btnEliminarRubro_Click(object sender, EventArgs e)
        {
            try
            {
                var rubroSeleccionadoId = dgvControl1.SelectedItemId;

                if (rubroSeleccionadoId != null)
                {
                    var rubroSeleccionado = Program.GestorDeRubros.BuscarPorId(rubroSeleccionadoId.Value);

                    if (rubroSeleccionado == null)
                        throw new ArgumentException("El rubro seleccionado no existe.");

                    var dr = MessageBox.Show(
                        $"Esta seguro de querer eliminar el rubro?\n\n\tNombre: {rubroSeleccionado.Nombre}\n\tId: {rubroSeleccionado.Id}",
                        "Confirmar borrado",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (dr == DialogResult.Yes)
                    {
                        bool success = Program.GestorDeRubros.Eliminar(rubroSeleccionado);

                        if (success)
                        {
                            MessageBox.Show(
                                "El rubro se ha eliminado correctamente!",
                                "Eliminado!",MessageBoxButtons.OK, 
                                MessageBoxIcon.Information );
                            ActualizarDataGrid();
                        } 

                        else
                        {
                            throw new Exception("El rubro no pudo eliminarse, prueba nuevamente mas tarde.");
                        }
                    }
                }
            } 

            catch (Exception ex)
            {
                MessageHelper.ShowErrorMessage(ex.Message);
            }
        }

        private void ActualizarDataGrid()
        {
            dgvControl1.Refrescar(Program.GestorDeRubros.BuscarActivos());
        }
    }
}

