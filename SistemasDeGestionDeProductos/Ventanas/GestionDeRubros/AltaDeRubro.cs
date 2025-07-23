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
        public AltaDeRubro()
        {
            InitializeComponent();

            rubrosdgvControl1.RefrescarRubros(Program.GestorDeRubros.BuscarRubros());


        }

        private void btnCrearRubro_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string descripcion = rtxtDescripcion.Text.Trim();
            
            Program.GestorDeRubros.CrearRubro(nombre, descripcion);
            rubrosdgvControl1.RefrescarRubros(Program.GestorDeRubros.BuscarRubros());
        }
    }
}
