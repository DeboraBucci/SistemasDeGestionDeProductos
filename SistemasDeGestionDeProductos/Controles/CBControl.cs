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
            SelectionChangedExternal?.Invoke(this, e);

            CbTxt = cbGenerico.Text;
        }

        // HANDLERS
        public void LlenarComboBox(IReadOnlyCollection<INombre> items)
        {
            nombres.Clear();

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
