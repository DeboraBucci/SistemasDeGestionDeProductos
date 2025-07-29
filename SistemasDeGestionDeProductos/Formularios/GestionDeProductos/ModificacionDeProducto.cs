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

namespace SistemasDeGestionDeProductos.Ventanas.GestionDeProductos
{
    public partial class ModificacionDeProducto : Form
    {
        private Guid? _productoId = null;

        public ModificacionDeProducto()
        {
            InitializeComponent();
        }

        private void dgvControl1_SelectionChangedExternal(object sender, EventArgs e)
        {
            var productoId = dgvControl1.SelectedItemId;
            _productoId = productoId;
            Producto? producto = null;

            if (productoId != null)
                producto = Program.GestorDeProductos.BuscarPorId(productoId.Value);


            if (producto != null)
            {
                txtNombre.Text = producto.Nombre;
                rtxtDescripcion.Text = producto.Descripcion;
                txtPrecioUnitario.Text = producto.PrecioUnitarioCompra.ToString();

                string rubroSeleccionado = Program.GestorDeRubros.BuscarPorId(producto.IdRubro)?.Nombre + "";
                cbControl1.CambiarSeleccionado(rubroSeleccionado);
            }
        }


        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombre.Text.Trim();
                string descripcion = rtxtDescripcion.Text.Trim();
                string precioUnitarioStr = txtPrecioUnitario.Text;
                string rubroNombre = cbControl1.CbTxt + "";

                // VALIDACIONES
                if (nombre == "")
                    throw new Exception("El nombre del producto no puede estar vacio.");

                if (!decimal.TryParse(precioUnitarioStr, out decimal precioUnit) || precioUnit < 0)
                    throw new Exception("El precio unitario debe ser un número mayor o igual que 0.");

                Program.GestorDeProductos.Modificar(_productoId, nombre, descripcion, precioUnit, rubroNombre);
                ActualizarDataGrid();
            }

            catch (Exception ex)
            {
                MessageHelper.ShowErrorMessage(ex.Message);
            }
        }

        private void ModificacionDeProducto_Load(object sender, EventArgs e)
        {
            dgvControl1.DefinicionesColumnas = NombreColumnasHelper.nombresColumnasProductos;
            ActualizarDataGrid();

            cbControl1.LlenarComboBox(Program.GestorDeRubros.BuscarTodos());
        }

        private void ModificacionDeProducto_Activated(object sender, EventArgs e)
        {
            ActualizarDataGrid();
        }

        private void ActualizarDataGrid()
        {
            var productos = Program.GestorDeProductos.BuscarTodos();
            dgvControl1.Refrescar(ProductosMapper.ListaProductoAProductoDTO(productos));
        }
    }
}
