using SistemasDeGestionDeProductos.Clases.Helpers;
using SistemasDeGestionDeProductos.Clases.Mappers;

namespace SistemasDeGestionDeProductos.Formularios.GestionDeProductos
{
    public partial class BajaDeProducto : Form
    {
        public BajaDeProducto()
        {
            InitializeComponent();
        }

        private void BajaDeProducto_Load(object sender, EventArgs e)
        {
            dgvControl1.DefinicionesColumnas = NombreColumnasHelper.nombresColumnasProductos;
            ActualizarDataGrid();
        }

        private void BajaDeProducto_Activated(object sender, EventArgs e)
        {
            ActualizarDataGrid();
        }

        private void ActualizarDataGrid()
        {
            var productos = Program.GestorDeProductos.BuscarActivos();
            dgvControl1.Refrescar(ProductosMapper.ListaProductoAProductoDTO(productos));
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                var productoSeleccionadoId = dgvControl1.SelectedItemId;

                if (productoSeleccionadoId != null)
                {
                    var productoSeleccionado = Program.GestorDeProductos.BuscarPorId(productoSeleccionadoId.Value);

                    if (productoSeleccionado == null)
                        throw new ArgumentException("El producto seleccionado no existe.");

                    var dr = MessageBox.Show(
                        $"Esta seguro de querer eliminar el producto?\n\n\tNombre: {productoSeleccionado.Nombre}\n\tId: {productoSeleccionado.Id}",
                        "Confirmar borrado",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (dr == DialogResult.Yes)
                    {
                        bool success = Program.GestorDeProductos.Eliminar(productoSeleccionado);

                        if (success)
                        {
                            MessageBox.Show(
                                "El producto se ha eliminado correctamente!",
                                "Eliminado!", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            ActualizarDataGrid();
                        }

                        else
                        {
                            throw new Exception("El producto no pudo eliminarse, prueba nuevamente mas tarde.");
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                MessageHelper.ShowErrorMessage(ex.Message);
            }
        }
    }
}
