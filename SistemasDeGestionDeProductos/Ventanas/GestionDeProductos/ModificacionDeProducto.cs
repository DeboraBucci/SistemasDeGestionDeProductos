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
        public ModificacionDeProducto()
        {
            InitializeComponent();
        }

        private void productosdgvControl1_SelectionChangedExternal(object sender, EventArgs e)
        {
            var productId = dgvControl1.SelectedItemId;
            Producto? producto = null;

            if (productId != null)
                producto = Program.GestorDeProductos.BuscarProductoPorId(productId.Value);

        
            if (producto != null)
            {
                txtNombre.Text = producto.Nombre;
                rtxtDescripcion.Text = producto.Descripcion;
                txtPrecioUnitario.Text = producto.PrecioUnitarioCompra.ToString();
                txtStock.Text = producto.Stock.ToString();

                string seleccionado = Program.GestorDeRubros.BuscarRubroPorId(producto.IdRubro)?.Nombre + "";

                rubroscbControl1.CambiarSeleccionado(seleccionado);
            }
        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {

        }

        private void ModificacionDeProducto_Load(object sender, EventArgs e)
        {
            dgvControl1.DefinicionesColumnas = NombreColumnasHelper.nombresColumnasProductos;
            ActualizarDataGrid();
        }

        private void ActualizarDataGrid()
        {
            var productos = Program.GestorDeProductos.BuscarProductos();
            dgvControl1.Refrescar(ProductoMapper.ListaProductoAProductoDTO(productos));
        }
    }
}
