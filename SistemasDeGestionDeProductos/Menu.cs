using SistemasDeGestionDeProductos.Service;
using SistemasDeGestionDeProductos.Ventanas.GestionDeProductos;
using SistemasDeGestionDeProductos.Ventanas.GestionDeProveedores;
using SistemasDeGestionDeProductos.Ventanas.GestionDeRubros;

namespace SistemasDeGestionDeProductos
{
    public partial class Menu : Form
    {
        // GESTION DE PRODUCTOS
        AltaDeProducto altaDeProducto = new();
        ModificacionDeProducto modificacionDeProducto = new();

        // GESTION DE RUBROS
        AltaDeRubro altaDeRubro = new();

        // GESTION DE PROVEEDORES
        AltaDeProveedor altaDeProveedor = new();
        ModificacionDeProveedor modificacionDeProveedor = new();

        private Form? currOpenedForm = null;

        public Menu()
        {
            InitializeComponent();

            altaDeProducto.MdiParent = this;
            altaDeProducto.Dock = DockStyle.Fill;

            altaDeRubro.MdiParent = this;
            altaDeRubro.Dock = DockStyle.Fill;

            modificacionDeProducto.MdiParent = this;
            modificacionDeProducto.Dock = DockStyle.Fill;

            altaDeProveedor.MdiParent = this;
            altaDeProveedor.Dock = DockStyle.Fill;

            modificacionDeProveedor.MdiParent = this;
            modificacionDeProveedor.Dock = DockStyle.Fill;

            AbrirForm(altaDeProducto);
        }


        // PRODUCTOS
        private void altaDeProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirForm(altaDeProducto);
        }

        private void modificaciónDeProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirForm(modificacionDeProducto);

        }

        // RUBROS
        private void altaDeRubroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirForm(altaDeRubro);
        }

        // PROVEEDORES
        private void altaDeProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirForm(altaDeProveedor);
        }

        private void modificaciónDeProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirForm(modificacionDeProveedor);
        }

        // OTROS
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        // HELPER METHODS

        private void AbrirForm(Form form)
        {
            if (currOpenedForm != null)
                currOpenedForm.Hide();

            currOpenedForm = form;
            currOpenedForm.Show();
        }

      
    }
}
