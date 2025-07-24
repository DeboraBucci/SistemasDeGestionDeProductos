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

                string seleccionado = Program.GestorDeRubros.BuscarRubroPorId(producto.IdRubro)?.Nombre + "";

                rubroscbControl1.CambiarSeleccionado(seleccionado);
            }
        }


        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string descripcion = rtxtDescripcion.Text.Trim();
            string precioUnitarioStr = txtPrecioUnitario.Text.Trim();
            string stockStr = txtStock.Text.Trim();
            string rubroNombre = rubroscbControl1.CbRubrosTxt + "";
            string proveedorNombre = proveedorcbControl1.CbProveedorTxt + "";

            if (nombre == "")
                throw new Exception("El nombre del producto no puede estar vacio.");

            if (!decimal.TryParse(precioUnitarioStr, out decimal precioUnit))
                throw new Exception("El precio unitario es invalido, pruebe nuevamente.");

            if (!int.TryParse(stockStr, out int stock) || stock < 0)
                throw new Exception("El stock debe ser un numero entero mayor o igual a 0.");

            var rubro = Program.GestorDeRubros.BuscarRubroPorNombre(rubroNombre);

            if (rubro == null)
                throw new Exception("El rubro seleccionado no existe.");

            Guid idRubro = rubro.Id;

            var proveedor = Program.GestorDeProveedores.BuscarProveedorPorNombre(proveedorNombre);

            if (proveedor == null)
                throw new Exception("El proveedor seleccionado no existe.");

            Guid idProveedor = proveedor.Id;

            Program.GestorDeProductos.ModificarProducto(ProductoId, nombre, descripcion, precioUnit, stock, idRubro, idProveedor);
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
