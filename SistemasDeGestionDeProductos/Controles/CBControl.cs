using SistemasDeGestionDeProductos.Clases.Interfaces;

namespace SistemasDeGestionDeProductos.Controles
{
    public partial class CBControl : UserControl
    {
        public event EventHandler? SelectionChangedExternal;

        public string? CbTxt { get; set; }

        private List<string> nombres = new();

        public CBControl()
        {
            InitializeComponent();
        }

        // EVENTOS
        private void cbGenerico_SelectedValueChanged(object sender, EventArgs e)
        {
            CbTxt = cbGenerico.Text;
            SelectionChangedExternal?.Invoke(this, e);
        }

        // HANDLERS
        public void LlenarComboBox(IReadOnlyCollection<INombre> items, bool addFirstElement = false)
        {
            cbGenerico.DataSource = null;
            nombres.Clear();

            if (addFirstElement)
                nombres.Add("Seleccione una opcion...");

            foreach (var item in items)
                nombres.Add(item.Nombre + "");

            cbGenerico.DataSource = nombres;

        }

        public void CambiarSeleccionado(string seleccionado)
        {
            cbGenerico.SelectedItem = seleccionado;
        }
    }
}
