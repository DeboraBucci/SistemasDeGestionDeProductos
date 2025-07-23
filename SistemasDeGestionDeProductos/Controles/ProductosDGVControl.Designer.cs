namespace SistemasDeGestionDeProductos
{
    partial class ProductosDGVControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvProductos = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            PrecioUnitario = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // dgvProductos
            // 
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { Nombre, Descripcion, PrecioUnitario, Stock });
            dgvProductos.Location = new Point(0, 0);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.Size = new Size(522, 346);
            dgvProductos.TabIndex = 0;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripcion";
            Descripcion.Name = "Descripcion";
            // 
            // PrecioUnitario
            // 
            PrecioUnitario.HeaderText = "Precio Unitario";
            PrecioUnitario.Name = "PrecioUnitario";
            // 
            // Stock
            // 
            Stock.HeaderText = "Stock";
            Stock.Name = "Stock";
            // 
            // ProductosDGVControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(dgvProductos);
            Name = "ProductosDGVControl";
            Size = new Size(525, 349);
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvProductos;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn PrecioUnitario;
        private DataGridViewTextBoxColumn Stock;
    }
}
