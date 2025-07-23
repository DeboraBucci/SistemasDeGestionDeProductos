using SistemasDeGestionDeProductos.Service;
using SistemasDeGestionDeProductos.Ventanas.GestionDeProductos;
using SistemasDeGestionDeProductos.Ventanas.GestionDeRubros;

namespace SistemasDeGestionDeProductos
{
    public partial class Menu : Form
    {
        // GESTION DE PRODUCTOS
        AltaDeProducto altaDeProducto = new();

        // GESTION DE RUBROS
        AltaDeRubro altaDeRubro = new AltaDeRubro();


        public Menu()
        {
            InitializeComponent();

            altaDeProducto.MdiParent = this;
            altaDeProducto.Dock = DockStyle.Fill;

            altaDeRubro.MdiParent = this;
            altaDeRubro.Dock = DockStyle.Fill;

            altaDeProducto.Show();
        }


        // PRODUCTOS
        private void altaDeProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            altaDeProducto.Show();
            altaDeRubro.Hide();
        }

        // RUBROS
        private void altaDeRubroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            altaDeProducto.Hide();
            altaDeRubro.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void modificaciónDeProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
