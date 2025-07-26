using SistemasDeGestionDeProductos.Service;
using SistemasDeGestionDeProductos.Ventanas.GestionDeMovimientosDeStock;
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
        ConsultaDeProductos consultaDeProductos = new();

        // GESTION DE RUBROS
        AltaDeRubro altaDeRubro = new();
        ModificacionDeRubro modificacionDeRubro = new();
        ConsultaDeRubros consultaDeRubros = new();

        // GESTION DE PROVEEDORES
        AltaDeProveedor altaDeProveedor = new();
        ModificacionDeProveedor modificacionDeProveedor = new();
        ConsultaDeProveedores consultaDeProveedores = new();

        // GESTION DE MOVIMIENTOS DE STOCK
        IngresoDeStock ingresoDeStock = new();


        private Form? currOpenedForm = null;

        public Menu()
        {
            InitializeComponent();

            // PRODUCTOS
            altaDeProducto.MdiParent = this;
            altaDeProducto.Dock = DockStyle.Fill;

            modificacionDeProducto.MdiParent = this;
            modificacionDeProducto.Dock = DockStyle.Fill;

            consultaDeProductos.MdiParent = this;
            consultaDeProductos.Dock = DockStyle.Fill;

            // RUBROS
            altaDeRubro.MdiParent = this;
            altaDeRubro.Dock = DockStyle.Fill;

            modificacionDeRubro.MdiParent = this;
            modificacionDeRubro.Dock = DockStyle.Fill;

            consultaDeRubros.MdiParent = this;
            consultaDeRubros.Dock = DockStyle.Fill;

            // PROVEEDORES
            altaDeProveedor.MdiParent = this;
            altaDeProveedor.Dock = DockStyle.Fill;

            modificacionDeProveedor.MdiParent = this;
            modificacionDeProveedor.Dock = DockStyle.Fill;

            consultaDeProveedores.MdiParent = this;
            consultaDeProveedores.Dock = DockStyle.Fill;

            // MOVIMIENTOS STOCK
            ingresoDeStock.MdiParent = this;
            ingresoDeStock.Dock = DockStyle.Fill;

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

        private void consultaDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirForm(consultaDeProductos);
        }

        // RUBROS
        private void altaDeRubroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirForm(altaDeRubro);
        }

        private void modificaciónDeRubroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirForm(modificacionDeRubro);
        }

        private void consultaDeRubrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirForm(consultaDeRubros);
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

        private void consultaDeProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirForm(consultaDeProveedores);
        }

        // MOVIMIENTOS DE STOCK
        private void ingresoDeStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirForm(ingresoDeStock);
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
