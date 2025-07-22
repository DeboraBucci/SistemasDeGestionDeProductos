using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemasDeGestionDeProductos.Controles;
using SistemasDeGestionDeProductos.Entidades;
using SistemasDeGestionDeProductos.Service;

namespace SistemasDeGestionDeProductos.Ventanas.GestionDeRubros
{
    public partial class AltaDeRubro : Form
    {
        internal readonly GestorDeRubros gestorDeRubros;

        public AltaDeRubro()
        {
            InitializeComponent();
            gestorDeRubros = new();

            rubrosdgvControl1.RefrescarRubros(gestorDeRubros.BuscarRubros());
        }

        private void btnCrearRubro_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string descripcion = rtxtDescripcion.Text.Trim();

            gestorDeRubros.CrearRubro(nombre, descripcion);
            rubrosdgvControl1.RefrescarRubros(gestorDeRubros.BuscarRubros());
        }
    }
}
