using SistemasDeGestionDeProductos.Clases.Helpers;
using SistemasDeGestionDeProductos.Clases.Mappers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasDeGestionDeProductos.Formularios.Reportes
{
    public partial class StockActualPorProducto : Form
    {
        public StockActualPorProducto()
        {
            InitializeComponent();
        }

        private void StockActualPorProducto_Load(object sender, EventArgs e)
        {
            dgvControl1.DefinicionesColumnas = NombreColumnasHelper.nombresColumnasProductosStock;
            ActualizarDataGrid();
        }

        private void StockActualPorProducto_Activated(object sender, EventArgs e)
        {
            ActualizarDataGrid();
        }

        private void ActualizarDataGrid() { 
            var productos = ProductosMapper.ListaProductoAProductoDTO(Program.GestorDeProductos.BuscarTodos());

            var productosConStock = productos.Select(p => new
            {
                p.Id,
                p.Nombre,
                Stock = Program.GestorDeMovimientos.ObtenerStockActual(p.Id),
                p.Descripcion,
                p.Rubro,
                p.PrecioUnitarioCompra,
                p.PrecioUnitarioVenta,
            }).ToList();

            dgvControl1.Refrescar(productosConStock);
        }

    }
}
