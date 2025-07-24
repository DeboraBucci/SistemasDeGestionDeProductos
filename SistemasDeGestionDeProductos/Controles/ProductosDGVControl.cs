using SistemasDeGestionDeProductos.Entidades;
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
    public partial class ProductosDGVControl : UserControl
    {
        public event EventHandler? SelectionChangedExternal;

        public ProductosDGVControl()
        {
            InitializeComponent();

            dgvProductos.Columns.Clear();

            dgvProductos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colNombre",
                HeaderText = "Nombre",
                DataPropertyName = "Nombre",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvProductos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colDescripcion",
                HeaderText = "Descripción",
                DataPropertyName = "Descripcion",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvProductos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colPrecioUnitarioCompra",
                HeaderText = "Compra c/u",
                DataPropertyName = "PrecioUnitarioCompra",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvProductos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colPrecioUnitarioVenta",
                HeaderText = "Venta c/u",
                DataPropertyName = "PrecioUnitarioVenta",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvProductos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colStock",
                HeaderText = "Stock",
                DataPropertyName = "Stock",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvProductos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colRubro",
                HeaderText = "Rubro",
                DataPropertyName = "Rubro",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvProductos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colId",
                HeaderText = "Id",
                DataPropertyName = "Id",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvProductos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colProveedor",
                HeaderText = "Proveedor",
                DataPropertyName = "Proveedor",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });


            dgvProductos.Columns["colId"].Visible = false;

            dgvProductos.SelectionChanged += dgvProductos_SelectionChanged;
        }

        public void RefrescarProductos()

        {
            var productos = Program.GestorDeProductos.BuscarProductos();

            var productosVM = productos.Select(p => new
            {
                p.Id,
                p.Nombre,
                p.Descripcion,
                p.PrecioUnitarioCompra,
                p.PrecioUnitarioVenta,
                p.Stock,
                Rubro = (Program.GestorDeRubros.BuscarRubroPorId(p.IdRubro))?.Nombre,
            }).ToList();

            dgvProductos.DataSource = productosVM;
        }

        private void dgvProductos_SelectionChanged(object? sender, EventArgs e)
        {
            SelectionChangedExternal?.Invoke(this, e);
        }

        private void ProductosDGVControl_Load(object sender, EventArgs e)
        {
            RefrescarProductos();
        }

        /// <summary>
        /// Devuelve el Guid del producto actualmente seleccionado,
        /// o null si no hay selección.
        /// </summary>
        public Guid? SelectedProductId
        {
            get
            {
                if (dgvProductos.SelectedRows.Count == 0)
                    return null;

                // "colId" es la columna oculta que contiene el Guid
                return dgvProductos.SelectedRows[0]
                                  .Cells["colId"]
                                  .Value as Guid?;
            }
        }
    }
}
