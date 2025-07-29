using SistemasDeGestionDeProductos.Clases.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasDeGestionDeProductos.Formularios.GestionDeProveedores
{
    public partial class BajaDeProveedor : Form
    {
        public BajaDeProveedor()
        {
            InitializeComponent();
        }

        private void BajaDeProveedor_Load(object sender, EventArgs e)
        {
            dgvControl1.DefinicionesColumnas = NombreColumnasHelper.nombresColumnasProveedor;
            ActualizarDataGrid();
        }

        private void BajaDeProveedor_Activated(object sender, EventArgs e)
        {
            ActualizarDataGrid();
        }

        private void btnEliminarProveedor_Click(object sender, EventArgs e)
        {
            try
            {
                var proveedorSeleccionadoId = dgvControl1.SelectedItemId;

                if (proveedorSeleccionadoId != null)
                {
                    var proveedorSeleccionado = Program.GestorDeProveedores.BuscarPorId(proveedorSeleccionadoId.Value);

                    if (proveedorSeleccionado == null)
                        throw new ArgumentException("El proveedor seleccionado no existe.");

                    var dr = MessageBox.Show(
                        $"Esta seguro de querer eliminar el proveedor?\n\n\tNombre: {proveedorSeleccionado.Nombre}\n\tId: {proveedorSeleccionado.Id}",
                        "Confirmar borrado",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (dr == DialogResult.Yes)
                    {
                        bool success = Program.GestorDeProveedores.Eliminar(proveedorSeleccionado);

                        if (success)
                        {
                            MessageBox.Show(
                                "El proveedor se ha eliminado correctamente!",
                                "Eliminado!", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);


                            ActualizarDataGrid();
                        }

                        else
                        {
                            throw new Exception("El producto no pudo eliminarse, prueba nuevamente mas tarde.");
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                MessageHelper.ShowErrorMessage(ex.Message);
            }
        }

        private void ActualizarDataGrid()
        {
            dgvControl1.Refrescar(Program.GestorDeProveedores.BuscarTodos());
        }

    }
}
