using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemasDeGestionDeProductos;
using SistemasDeGestionDeProductos.Controles;
using SistemasDeGestionDeProductos.Entidades;
using SistemasDeGestionDeProductos.Helpers;
using SistemasDeGestionDeProductos.Service;

namespace SistemasDeGestionDeProductos.Ventanas.GestionDeRubros
{
    public partial class AltaDeRubro : Form
    {
        public AltaDeRubro()
        {
            InitializeComponent();
            ActualizarDataGrid();
        }

        private void btnCrearRubro_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string descripcion = rtxtDescripcion.Text.Trim();

            Program.GestorDeRubros.CrearRubro(nombre, descripcion);
            ActualizarDataGrid();
        }

        private void AltaDeRubro_Load(object sender, EventArgs e)
        {
            dgvControl1.DefinicionesColumnas = NombreColumnasHelper.nombresColumnasRubro;
            ActualizarDataGrid();
        }

        private void ActualizarDataGrid()
        {
            dgvControl1.Refrescar(Program.GestorDeRubros.BuscarRubros());
        }
    }
}

