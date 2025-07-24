using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasDeGestionDeProductos.Controles
{
    public partial class ProveedorCBControl : UserControl
    {
        public string? CbProveedorTxt { get; set; }

        private List<string> nombreProveedores = new();

        public ProveedorCBControl()
        {
            InitializeComponent();
        }

        // EVENTOS
        private void ProveedorCBControl_Load(object sender, EventArgs e)
        {
            LlenarComboBoxRubros();
        }

        private void cbProveedor_SelectedValueChanged(object sender, EventArgs e)
        {
            CbProveedorTxt = cbProveedor.Text;

        }


        // HANDLERS
        public void LlenarComboBoxRubros()
        {
            nombreProveedores.Clear();

            var proveedores = Program.GestorDeProveedores.BuscarProveedores();

            foreach (var proveedor in proveedores)
                nombreProveedores.Add(proveedor.Nombre + "");

            cbProveedor.DataSource = nombreProveedores;
        }

        public void CambiarSeleccionado(string seleccionado)
        {
            cbProveedor.SelectedItem = seleccionado;
        }
    }
}
