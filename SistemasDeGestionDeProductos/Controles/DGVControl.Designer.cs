namespace SistemasDeGestionDeProductos
{
    partial class DGVControl
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
            dgvGenerica = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            PrecioUnitario = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvGenerica).BeginInit();
            SuspendLayout();
            // 
            // dgvGenerica
            // 
            dgvGenerica.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGenerica.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGenerica.Columns.AddRange(new DataGridViewColumn[] { Nombre, Descripcion, PrecioUnitario, Stock });
            dgvGenerica.Location = new Point(0, 0);
            dgvGenerica.Name = "dgvGenerica";
            dgvGenerica.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGenerica.Size = new Size(551, 414);
            dgvGenerica.TabIndex = 0;
            dgvGenerica.SelectionChanged += dgvProductos_SelectionChanged;
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
            Controls.Add(dgvGenerica);
            Name = "ProductosDGVControl";
            Size = new Size(554, 419);
            ((System.ComponentModel.ISupportInitialize)dgvGenerica).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvGenerica;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn PrecioUnitario;
        private DataGridViewTextBoxColumn Stock;
    }
}
