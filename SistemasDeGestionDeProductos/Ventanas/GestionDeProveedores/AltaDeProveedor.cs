using SistemasDeGestionDeProductos.Controles;
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

namespace SistemasDeGestionDeProductos.Ventanas.GestionDeProveedores
{
    public partial class AltaDeProveedor : Form
    {
        public AltaDeProveedor()
        {
            InitializeComponent();

            proveedordgvControl1.RefrescarProveedores();
        }

        private void btnAgregarProveedor_Click(object sender, EventArgs e)
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


                Program.GestorDeProvedores.CrearProveedor(nombre, contacto, telefono, direccion);
                proveedordgvControl1.RefrescarProveedores();
            }

            catch (Exception ex)
            {
                ErrorMessage.ShowErrorMessage(ex.Message);
            }
        }
    }
}
