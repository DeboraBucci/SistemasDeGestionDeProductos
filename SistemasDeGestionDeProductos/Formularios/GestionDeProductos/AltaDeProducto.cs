using SistemasDeGestionDeProductos.Clases.Helpers;
using SistemasDeGestionDeProductos.Clases.Mappers;

namespace SistemasDeGestionDeProductos.Ventanas.GestionDeProductos
{
    public partial class AltaDeProducto : Form
    {

        public AltaDeProducto()
        {
            InitializeComponent();
        }

        private void btnCrearProducto_Click(object sender, EventArgs e)
        {
            try
            {
                // INFO PRODUCTO
                string nombre = txtNombre.Text.Trim();
                string descripcion = rtxtDescripcion.Text.Trim();
                string precioUnitarioStr = txtPrecioUnitario.Text;
                string rubroNombre = cbControl1.CbTxt + "";

                // INFO PRIMER MOVIMIENTO
                string stockStr = txtStock.Text;
                string proveedorNombre = cbControl2.CbTxt + "";
                DateTime fechaVencimiento = dtpFechaVencimiento.Value.Date;

                // VALIDACIONES
                if (nombre == "")
                    throw new Exception("El nombre del producto no puede estar vacio.");

                if (!decimal.TryParse(precioUnitarioStr, out decimal precioUnit) || precioUnit < 0)
                    throw new Exception("El precio unitario debe ser un número mayor o igual que 0.");

                if (!int.TryParse(stockStr, out int stock) || stock <= 0)
                    throw new Exception("Numero de stock invalido.");

                var proveedorId = Program.GestorDeProveedores.BuscarPorNombre(proveedorNombre)?.Id;

                if (proveedorId == null)
                    throw new Exception("El proveedor es invalido.");

                var producto = Program.GestorDeProductos.Crear(nombre, descripcion, precioUnit, rubroNombre);

                Program.GestorDeMovimientos.IngresarStock(producto.Id, stock, fechaVencimiento, proveedorId.Value);

                VaciarTxt();
                ActualizarDataGrid();

                MessageHelper.ShowSuccessfulMessage("Se ha agregado el producto correctamente!");
            }

            catch (Exception ex)
            {
                MessageHelper.ShowErrorMessage(ex.Message);
            }
        }

        private void AltaDeProducto_Load(object sender, EventArgs e)
        {

            dgvControl1.DefinicionesColumnas = NombreColumnasHelper.nombresColumnasProductos;
            ActualizarDataGrid();
            ActualizarComboBoxes();
        }

        private void AltaDeProducto_Activated(object sender, EventArgs e)
        {
            ActualizarDataGrid();
            ActualizarComboBoxes();
        }

        private void ActualizarDataGrid()
        {
            var productos = Program.GestorDeProductos.BuscarActivos();
            dgvControl1.Refrescar(ProductosMapper.ListaProductoAProductoDTO(productos));
        }

        private void ActualizarComboBoxes()
        {
            cbControl1.LlenarComboBox(Program.GestorDeRubros.BuscarActivos());
            cbControl2.LlenarComboBox(Program.GestorDeProveedores.BuscarActivos());
        }

        private void VaciarTxt()
        {
            txtNombre.Text = string.Empty;
            rtxtDescripcion.Text = string.Empty;
            txtPrecioUnitario.Text = string.Empty;
            txtStock.Text = string.Empty;

            dtpFechaVencimiento.Value = DateTime.Today;
        }
    }
}
