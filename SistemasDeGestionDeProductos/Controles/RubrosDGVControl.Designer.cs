namespace SistemasDeGestionDeProductos.Controles
{
    partial class RubrosDGVControl
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
            dgvRubros = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvRubros).BeginInit();
            SuspendLayout();
            // 
            // dgvRubros
            // 
            dgvRubros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRubros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRubros.Columns.AddRange(new DataGridViewColumn[] { Nombre, Descripcion });
            dgvRubros.Location = new Point(0, 0);
            dgvRubros.Name = "dgvRubros";
            dgvRubros.Size = new Size(451, 346);
            dgvRubros.TabIndex = 0;
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
            // RubrosDGVControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(dgvRubros);
            Name = "RubrosDGVControl";
            Size = new Size(454, 349);
            ((System.ComponentModel.ISupportInitialize)dgvRubros).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvRubros;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Descripcion;
    }
}
