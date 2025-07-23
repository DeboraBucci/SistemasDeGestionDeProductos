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
    public partial class ProveedorDGVControl : UserControl
    {
        public event EventHandler? SelectionChangedExternal;

        public ProveedorDGVControl()
        {
            InitializeComponent();

            dgvProveedores.Columns.Clear();

            dgvProveedores.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colNombre",
                HeaderText = "Nombre",
                DataPropertyName = "Nombre",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvProveedores.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colContacto",
                HeaderText = "Contacto",
                DataPropertyName = "Contacto",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvProveedores.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colTelefono",
                HeaderText = "Teléfono",
                DataPropertyName = "Telefono",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvProveedores.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colDireccion",
                HeaderText = "Dirección",
                DataPropertyName = "Direccion",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvProveedores.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colId",
                HeaderText = "Id",
                DataPropertyName = "Id",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvProveedores.Columns["colId"].Visible = false;

            dgvProveedores.SelectionChanged += dgvProductos_SelectionChanged;
        }

        public void RefrescarProveedores()

        {
            dgvProveedores.DataSource = Program.GestorDeProvedores.BuscarProveedores();
        }

        private void dgvProductos_SelectionChanged(object? sender, EventArgs e)
        {
            SelectionChangedExternal?.Invoke(this, e);
        }

        private void ProveedorDGVControl_Load(object sender, EventArgs e)
        {
            RefrescarProveedores();
        }

        /// <summary>
        /// Devuelve el Guid del producto actualmente seleccionado,
        /// o null si no hay selección.
        /// </summary>
        public Guid? SelectedProveedortId
        {
            get
            {
                if (dgvProveedores.SelectedRows.Count == 0)
                    return null;

                // "colId" es la columna oculta que contiene el Guid
                return dgvProveedores.SelectedRows[0]
                                  .Cells["colId"]
                                  .Value as Guid?;
            }
        }
    }
}
