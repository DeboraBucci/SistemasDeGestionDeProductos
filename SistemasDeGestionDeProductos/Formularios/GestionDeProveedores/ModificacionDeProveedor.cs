using SistemasDeGestionDeProductos.Clases.Entidades;
using SistemasDeGestionDeProductos.Clases.Helpers;
using SistemasDeGestionDeProductos.Controles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasDeGestionDeProductos.Ventanas.GestionDeProveedores
{
    public partial class ModificacionDeProveedor : Form
    {
        private Guid? _proveedorId = null;

        public ModificacionDeProveedor()
        {
            InitializeComponent();
        }


        private void dgvControl1_SelectionChangedExternal(object sender, EventArgs e)
        {
            var proveedorId = dgvControl1.SelectedItemId;
            _proveedorId = proveedorId;
            Proveedor? proveedor = null;

            if (proveedorId != null)
                proveedor = Program.GestorDeProveedores.BuscarPorId(proveedorId.Value);


            if (proveedor != null)
            {
                txtNombre.Text = proveedor.Nombre;
                txtDireccion.Text = proveedor.Direccion;
                txtContacto.Text = proveedor.Contacto;
                txtTelefono.Text = proveedor.Telefono;
            }
        }

        private void btnModificarProveedor_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombre.Text.Trim();
                string contacto = txtContacto.Text.Trim();
                string telefono = txtTelefono.Text.Trim();
                string direccion = txtDireccion.Text.Trim();

                if (nombre == "")
                    throw new Exception("El nombre del proveedor no puede estar vacio.");

                if (contacto == "")
                    throw new Exception("El contacto del proveedor no puede estar vacio.");

                if (telefono == "")
                    throw new Exception("El telefono del proveedor no puede estar vacio.");

                if (direccion == "")
                    throw new Exception("La direccion del proveedor no puede estar vacia.");


                Program.GestorDeProveedores.Modificar(_proveedorId, nombre, contacto, telefono, direccion);
                ActualizarDataGrid();

                MessageHelper.ShowSuccessfulMessage("Se ha modificado el proveedor de manera exitosa!");
            }

            catch (Exception ex)
            {
                MessageHelper.ShowErrorMessage(ex.Message);
            }
        }

        private void ModificacionDeProveedor_Load(object sender, EventArgs e)
        {
            dgvControl1.DefinicionesColumnas = NombreColumnasHelper.nombresColumnasProveedor;
            ActualizarDataGrid();
        }

        private void ModificacionDeProveedor_Activated(object sender, EventArgs e)
        {
            ActualizarDataGrid();
        }

        private void ActualizarDataGrid()
        {
            dgvControl1.Refrescar(Program.GestorDeProveedores.BuscarActivos());
        }
    }
}
