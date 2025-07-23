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
        public ProductosDGVControl()
        {
            InitializeComponent();

            dgvProductos.Columns.Clear();
            dgvProductos.AutoGenerateColumns = false;

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
                Name = "colPrecioUnitario",
                HeaderText = "Precio Unitario",
                DataPropertyName = "PrecioUnitario",
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

        }

        public void RefrescarProductos(IReadOnlyCollection<Producto> productos)
        {
            var productosVM = productos.Select(p => new
            {
                p.Id,
                p.Nombre,
                p.Descripcion,
                p.PrecioUnitario,
                p.Stock,    
                Rubro = (Program.GestorDeRubros.BuscarRubroPorId(p.IdRubro))?.Nombre,
            }).ToList();

            dgvProductos.DataSource = productosVM;
            
        }

    }
}
