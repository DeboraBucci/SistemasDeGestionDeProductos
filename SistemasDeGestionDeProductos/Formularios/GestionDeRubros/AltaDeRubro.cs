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
            try
            {
                string nombre = txtNombre.Text.Trim();
                string descripcion = rtxtDescripcion.Text.Trim();


                if (nombre == "")
                    throw new Exception("El nombre del rubro no puede estar vacio.");

                Program.GestorDeRubros.CrearRubro(nombre, descripcion);
                ActualizarDataGrid();
                VaciarTextos();

                MessageHelper.ShowSuccessfulMessage("Se ha creado el rubro de manera exitosa!");
            }
            catch (Exception ex)
            {
                MessageHelper.ShowErrorMessage(ex.Message);
            }
        }

        private void AltaDeRubro_Load(object sender, EventArgs e)
        {
            dgvControl1.DefinicionesColumnas = NombreColumnasHelper.nombresColumnasRubro;
            ActualizarDataGrid();
        }

        private void AltaDeRubro_Activated(object sender, EventArgs e)
        {
            ActualizarDataGrid();
        }

        private void ActualizarDataGrid()
        {
            dgvControl1.Refrescar(Program.GestorDeRubros.BuscarRubros());
        }

        private void VaciarTextos()
        {
            txtNombre.Text = string.Empty;
            rtxtDescripcion.Text = string.Empty;
        }
    }
}

