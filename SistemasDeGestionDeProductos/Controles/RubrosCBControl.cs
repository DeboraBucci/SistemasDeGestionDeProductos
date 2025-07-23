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
    public partial class RubrosCBControl : UserControl
    {
        public string? CbRubrosTxt { get; set; }

        private List<string> nombreRubros = new();

        public RubrosCBControl()
        {
            InitializeComponent();
        }

        // EVENTOS
        private void RubrosCBControl_Load(object sender, EventArgs e)
        {
            LlenarComboBoxRubros();
        }

        private void cbRubros_SelectedValueChanged(object sender, EventArgs e)
        {
            CbRubrosTxt = cbRubros.Text; 
        }

        // HANDLERS
        public void LlenarComboBoxRubros()
        {
            nombreRubros.Clear();

            var rubros = Program.GestorDeRubros.BuscarRubros();

            foreach (var rubro in rubros)
                nombreRubros.Add(rubro.Nombre + "");

            cbRubros.DataSource = nombreRubros;
        }

        public void CambiarSeleccionado(string seleccionado)
        {
            cbRubros.SelectedItem = seleccionado;
        }
    }
}
