using SistemasDeGestionDeProductos.Clases.Helpers;
using SistemasDeGestionDeProductos.Controles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasDeGestionDeProductos.Ventanas.GestionDeProveedores
{
    public partial class AltaDeProveedor : Form
    {
        public AltaDeProveedor()
        {
            InitializeComponent();
        }

        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {

            try
            {
                string nombre = txtNombre.Text.Trim();
                string contacto = txtContacto.Text.Trim();
                string telefono = txtTelefono.Text.Trim();
                string direccion = txtDireccion.Text.Trim();

                // VALIDACIONES
                if (nombre == "")
                    throw new Exception("El nombre del proveedor no puede estar vacio.");

                if (contacto == "")
                    throw new Exception("El contacto del proveedor no puede estar vacio.");

                if (telefono == "")
                    throw new Exception("El telefono del proveedor no puede estar vacio.");

                if (direccion == "")
                    throw new Exception("La direccion del proveedor no puede estar vacia.");

                if (!RegexHelper.FormatoEmailValido(contacto))
                    throw new Exception("El formato del email es incorrecto.");

                if (!RegexHelper.FormatoTelefonoValido(telefono))
                    throw new Exception("El formato del telefono es incorrecto.");

                Program.GestorDeProveedores.Crear(nombre, contacto, telefono, direccion);
                ActualizarDataGrid();
            }

            catch (Exception ex)
            {
                MessageHelper.ShowErrorMessage(ex.Message);
            }
        }

        private void AltaDeProveedor_Load(object sender, EventArgs e)
        {
            dgvControl1.DefinicionesColumnas = NombreColumnasHelper.nombresColumnasProveedor;
            ActualizarDataGrid();
        }

        private void AltaDeProveedor_Activated(object sender, EventArgs e)
        {
            ActualizarDataGrid();
        }

        private void ActualizarDataGrid()
        {
            dgvControl1.Refrescar(Program.GestorDeProveedores.BuscarTodos());
        }

        private void VaciarTextos()
        {
            txtNombre.Text = string.Empty;
            txtContacto.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtTelefono.Text = string.Empty;
        }
    }
}
