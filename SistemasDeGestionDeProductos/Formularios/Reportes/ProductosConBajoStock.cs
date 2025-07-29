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

namespace SistemasDeGestionDeProductos.Formularios.Reportes
{
    public partial class ProductosConBajoStock : Form
    {
        public ProductosConBajoStock()
        {
            InitializeComponent();
        }


        private void ProductosConBajoStock_Load(object sender, EventArgs e)
        {
            dgvControl1.DefinicionesColumnas = NombreColumnasHelper.nombresColumnasProductosStock;
            ActualizarDataGrid();
        }

        private void ProductosConBajoStock_Activated(object sender, EventArgs e)
        {
            ActualizarDataGrid();
        }

        private void txtMinStock_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var minStockStr = txtMinStock.Text.Trim();

                if (minStockStr == string.Empty)
                    ActualizarDataGrid();

                else
                {
                    if (!int.TryParse(minStockStr, out var minStock))
                        throw new ArgumentException("Stock invalido, ingrese un numero entero para el stock minimo.");

                    if (minStock <= 0)
                        throw new ArgumentException("El stock minimo no puede ser igual a cero o menor.");

                    var productos = ProductosMapper.ListaProductoAProductoDTO(Program.GestorDeProductos.BuscarTodos());

                    var productosConStock = productos.Select(p =>
                    {
                        var stock = Program.GestorDeMovimientos.ObtenerStockActual(p.Id);

                        if (stock >= minStock)
                            return null;

                        else
                            return new
                            {
                                p.Id,
                                p.Nombre,
                                Stock = stock,
                                p.Descripcion,
                                p.Rubro,
                                p.PrecioUnitarioCompra,
                                p.PrecioUnitarioVenta,
                            };
                    }).Where(p => p != null).ToList();

                    dgvControl1.Refrescar(productosConStock);
                }
            }

            catch (Exception ex)
            {
                MessageHelper.ShowErrorMessage(ex.Message);
            }
        }

        private void ActualizarDataGrid()
        {
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
