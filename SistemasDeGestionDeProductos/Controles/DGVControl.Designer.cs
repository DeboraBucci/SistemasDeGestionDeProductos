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
            ((System.ComponentModel.ISupportInitialize)dgvGenerica).BeginInit();
            SuspendLayout();
            // 
            // dgvGenerica
            // 
            dgvGenerica.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGenerica.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGenerica.Dock = DockStyle.Fill;
            dgvGenerica.Location = new Point(0, 0);
            dgvGenerica.Name = "dgvGenerica";
            dgvGenerica.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGenerica.Size = new Size(700, 500);
            dgvGenerica.TabIndex = 0;
            dgvGenerica.SelectionChanged += dgvProductos_SelectionChanged;
            // 
            // DGVControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvGenerica);
            Name = "DGVControl";
            Size = new Size(700, 500);
            ((System.ComponentModel.ISupportInitialize)dgvGenerica).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvGenerica;
    }
}
