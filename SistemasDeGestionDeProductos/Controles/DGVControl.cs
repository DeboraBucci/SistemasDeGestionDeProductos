using SistemasDeGestionDeProductos.Entidades;
using SistemasDeGestionDeProductos.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasDeGestionDeProductos
{
    public partial class DGVControl : UserControl
    {
        public event EventHandler? SelectionChangedExternal;


        private NombreColumna[] _defColumnas = Array.Empty<NombreColumna>();

        public IEnumerable<NombreColumna> DefinicionesColumnas
        {
            get => _defColumnas;

            set
            {
                _defColumnas = value?.ToArray() ?? Array.Empty<NombreColumna>();
                ConstruirColumnas();
            }
        }

        /// <summary>
        /// Devuelve el Guid del producto actualmente seleccionado,
        /// o null si no hay selección.
        /// </summary>
        public Guid? SelectedItemId
        {
            get
            {
                if (dgvGenerica.SelectedRows.Count == 0)
                    return null;

                // "colId" es la columna oculta que contiene el Guid
                return dgvGenerica.SelectedRows[0]
                                  .Cells["colId"]
                                  .Value as Guid?;
            }
        }


        // CONSTRUCTOR
        public DGVControl()
        {
            InitializeComponent();

            dgvGenerica.AutoGenerateColumns = false;
            ConstruirColumnas();
        }


        // EVENTS
        private void dgvProductos_SelectionChanged(object? sender, EventArgs e)
        {
            SelectionChangedExternal?.Invoke(this, e);
        }


        // HANDLERS
        private void ConstruirColumnas()
        {
            dgvGenerica.Columns.Clear();

            foreach (var columna in _defColumnas)
            {
                dgvGenerica.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = $"col{columna.Nombre}",
                    HeaderText = columna.HeaderTxt,
                    DataPropertyName = columna.Nombre,
                });
            }

            dgvGenerica.SelectionChanged += dgvProductos_SelectionChanged;
        }

        public void Refrescar<T>(T items)
        {
            dgvGenerica.DataSource = items;
        }
    }
}
