using SistemasDeGestionDeProductos.Controles;
using SistemasDeGestionDeProductos.Entidades;
using SistemasDeGestionDeProductos.Helpers;
using SistemasDeGestionDeProductos.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasDeGestionDeProductos.Ventanas.GestionDeRubros
{
    public partial class ModificacionDeRubro : Form
    {
        private Guid? _rubroId = null;


        public ModificacionDeRubro()
        {
            InitializeComponent();
        }

        private void ModificacionDeRubro_Load(object sender, EventArgs e)
        {
            dgvControl1.DefinicionesColumnas = NombreColumnasHelper.nombresColumnasRubro;
            ActualizarDataGrid();
        }

       
        private void dgvControl1_SelectionChangedExternal(object sender, EventArgs e)
        {
            var rubroId = dgvControl1.SelectedItemId;
            _rubroId = rubroId;
            Rubro? rubro = null;

            if (_rubroId != null)
                rubro = Program.GestorDeRubros.BuscarPorId(_rubroId.Value);


            if (rubro != null)
            {
                txtNombre.Text = rubro.Nombre;
                rtxtDescripcion.Text = rubro.Descripcion;
            }
        }

        private void btnModificarRubro_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombre.Text.Trim();
                string descripcion = rtxtDescripcion.Text.Trim();

                if (nombre == "")
                    throw new Exception("El nombre del rubro no puede estar vacio.");

                Program.GestorDeRubros.Modificar(_rubroId, nombre, descripcion);
                ActualizarDataGrid();

            }
            catch (Exception ex)
            {
                MessageHelper.ShowErrorMessage(ex.ToString());
            }
        }

        private void ActualizarDataGrid()
        {
            dgvControl1.Refrescar(Program.GestorDeRubros.BuscarTodos());
        }
    }
}
