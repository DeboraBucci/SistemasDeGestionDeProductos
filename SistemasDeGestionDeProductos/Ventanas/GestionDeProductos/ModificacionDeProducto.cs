using SistemasDeGestionDeProductos.Controles;
using SistemasDeGestionDeProductos.Entidades;
using SistemasDeGestionDeProductos.Helpers;
using SistemasDeGestionDeProductos.Validadores;
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
        private Guid? ProductoId = null;

        public ModificacionDeProducto()
        {
            InitializeComponent();
        }

        private void dgvControl1_SelectionChangedExternal(object sender, EventArgs e)
        {
            var productoId = dgvControl1.SelectedItemId;
            ProductoId = productoId;
            Producto? producto = null;

            if (productoId != null)
                producto = Program.GestorDeProductos.BuscarProductoPorId(productoId.Value);


            if (producto != null)
            {
                txtNombre.Text = producto.Nombre;
                rtxtDescripcion.Text = producto.Descripcion;
                txtPrecioUnitario.Text = producto.PrecioUnitarioCompra.ToString();
                txtStock.Text = producto.Stock.ToString();

                string rubroSeleccionado = Program.GestorDeRubros.BuscarRubroPorId(producto.IdRubro)?.Nombre + "";
                rubroscbControl1.CambiarSeleccionado(rubroSeleccionado);

                string proveedorSeleccionado = Program.GestorDeProveedores.BuscarProveedorPorId(producto.IdProveedor)?.Nombre + "";
                proveedorcbControl1.CambiarSeleccionado(proveedorSeleccionado);
            }
        }


        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string descripcion = rtxtDescripcion.Text;
            string precioUnitarioStr = txtPrecioUnitario.Text;
            string stockStr = txtStock.Text;
            string rubroNombre = rubroscbControl1.CbRubrosTxt + "";
            string proveedorNombre = proveedorcbControl1.CbProveedorTxt + "";

            var prod = ValidadorInputProducto.ValidarInformacion(nombre, descripcion, precioUnitarioStr, stockStr);

            Program.GestorDeProductos.ModificarProducto(ProductoId, prod.Nombre, prod.Descripcion, prod.PrecioUnitarioCompra, prod.Stock, rubroNombre, proveedorNombre);
            ActualizarDataGrid();
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
