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

namespace SistemasDeGestionDeProductos.Ventanas.GestionDeProductos
{
    public partial class ConsultaDeProductos : Form
    {
        public ConsultaDeProductos()
        {
            InitializeComponent();
        }

        private void ConsultaDeProductos_Load(object sender, EventArgs e)
        {
            dgvControl1.DefinicionesColumnas = NombreColumnasHelper.nombresColumnasProductos;
            ActualizarDataGrid();
            ActualizarComboBox();
           
        }

        private void ConsultaDeProductos_Activated(object sender, EventArgs e)
        {
            ActualizarDataGrid();
            ActualizarComboBox();
        }


        private void ActualizarDataGrid()
        {
            var productos = Program.GestorDeProductos.BuscarProductos();
            dgvControl1.Refrescar(ProductosMapper.ListaProductoAProductoDTO(productos));
        }

        private void ActualizarComboBox()
        {
            cbControl1.LlenarComboBox(Program.GestorDeRubros.BuscarRubros(), true);
        }

        private void cbControl1_SelectionChangedExternal(object sender, EventArgs e)
        {
            var nombreRubro = cbControl1.CbTxt ?? string.Empty;

            var productosDelRubro = Program.GestorDeProductos.BuscarPorRubro(nombreRubro);

            if (productosDelRubro == null) // SI ES NULL, CARGA TODOS LOS PRODUCTOS
                ActualizarDataGrid();

            else
                dgvControl1.Refrescar(ProductosMapper.ListaProductoAProductoDTO(productosDelRubro));
        }

        private void txtIdONombre_TextChanged(object sender, EventArgs e)
        {
            var texto = txtFiltro.Text.Trim();

            if (texto == string.Empty) // SI ES "", CARGA TODOS LOS PRODUCTOS
                ActualizarDataGrid();

            else
            {
                var productosFiltrados = Program.GestorDeProductos.BuscarPorFiltro(texto);
                dgvControl1.Refrescar(ProductosMapper.ListaProductoAProductoDTO(productosFiltrados));
            }
        }
    }
}
