﻿using SistemasDeGestionDeProductos.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasDeGestionDeProductos.Ventanas.GestionDeProveedores
{
    public partial class ConsultaDeProveedores : Form
    {
        public ConsultaDeProveedores()
        {
            InitializeComponent();
        }

        private void ConsultaDeProveedores_Load(object sender, EventArgs e)
        {
            dgvControl1.DefinicionesColumnas = NombreColumnasHelper.nombresColumnasProveedor;
            ActualizarDataGrid();
        }

        private void ConsultaDeProveedores_Activated(object sender, EventArgs e)
        {
            ActualizarDataGrid();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            string txt = txtFiltro.Text.Trim();

            if (txt == string.Empty)
                ActualizarDataGrid();

            else
            {
                var proveedoresFiltrados = Program.GestorDeProveedores.BuscarPorFiltro(txt);
                dgvControl1.Refrescar(proveedoresFiltrados);
            }
        }

        private void ActualizarDataGrid()
        {
            dgvControl1.Refrescar(Program.GestorDeProveedores.BuscarProveedores());
        }
      
    }
}
