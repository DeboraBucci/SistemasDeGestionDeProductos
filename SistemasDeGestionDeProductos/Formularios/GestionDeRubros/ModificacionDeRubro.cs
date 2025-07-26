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

namespace SistemasDeGestionDeProductos.Ventanas.GestionDeRubros
{
    public partial class ModificacionDeRubro : Form
    {
        private Guid? RubroId = null;


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
            RubroId = rubroId;
            Rubro? rubro = null;

            if (RubroId != null)
                rubro = Program.GestorDeRubros.BuscarRubroPorId(RubroId.Value);


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
                string nombre = txtNombre.Text;
                string descripcion = rtxtDescripcion.Text;

                var rubro = ValidadorInputRubro.ValidarInformacion(nombre, descripcion);

                Program.GestorDeRubros.ModificarRubro(RubroId, rubro.Nombre, rubro.Descripcion);
                ActualizarDataGrid();

            }
            catch (Exception ex)
            {
                ErrorMessage.ShowErrorMessage(ex.ToString());
            }
        }

        private void ActualizarDataGrid()
        {
            dgvControl1.Refrescar(Program.GestorDeRubros.BuscarRubros());
        }
    }
}
