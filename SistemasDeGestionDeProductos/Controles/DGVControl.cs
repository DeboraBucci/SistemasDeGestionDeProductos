using SistemasDeGestionDeProductos.Clases.Helpers;

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

            if (dgvGenerica.Columns.Contains("colFechaVencimiento"))
            {
                dgvGenerica.Columns["colFechaVencimiento"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }

            if (dgvGenerica.Columns.Contains("colFechaMovimiento"))
            {
                dgvGenerica.Columns["colFechaMovimiento"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
        }

        public void Refrescar<T>(T items)
        {
            dgvGenerica.DataSource = items;
        }
    }
}
