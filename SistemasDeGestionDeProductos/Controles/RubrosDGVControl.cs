using SistemasDeGestionDeProductos.Entidades;
using SistemasDeGestionDeProductos.Service;
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
    public partial class RubrosDGVControl : UserControl
    {
        public RubrosDGVControl()
        {
            InitializeComponent();

            dgvRubros.Columns.Clear();

            dgvRubros.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colNombre",
                HeaderText = "Nombre",
                DataPropertyName = "Nombre",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvRubros.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colDescripcion",
                HeaderText = "Descripción",
                DataPropertyName = "Descripcion",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

        }

        public void RefrescarRubros(IReadOnlyCollection<Rubro> rubros) {
            dgvRubros.DataSource = rubros;
            dgvRubros.Columns["Id"].Visible = false;

        }
    }
}
