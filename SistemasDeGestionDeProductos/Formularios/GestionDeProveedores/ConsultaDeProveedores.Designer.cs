namespace SistemasDeGestionDeProductos.Ventanas.GestionDeProveedores
{
    partial class ConsultaDeProveedores
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvControl1 = new DGVControl();
            label6 = new Label();
            label3 = new Label();
            txtFiltro = new TextBox();
            SuspendLayout();
            // 
            // dgvControl1
            // 
            dgvControl1.AutoSize = true;
            dgvControl1.Location = new Point(29, 70);
            dgvControl1.Name = "dgvControl1";
            dgvControl1.Size = new Size(1034, 503);
            dgvControl1.TabIndex = 40;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16F);
            label6.Location = new Point(29, 16);
            label6.Name = "label6";
            label6.Size = new Size(136, 30);
            label6.TabIndex = 39;
            label6.Text = "Proveedores";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(701, 16);
            label3.Name = "label3";
            label3.Size = new Size(111, 15);
            label3.TabIndex = 42;
            label3.Text = "Buscar por nombre:";
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(701, 41);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(362, 23);
            txtFiltro.TabIndex = 41;
            txtFiltro.TextChanged += txtFiltro_TextChanged;
            // 
            // ConsultaDeProveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 600);
            Controls.Add(label3);
            Controls.Add(txtFiltro);
            Controls.Add(dgvControl1);
            Controls.Add(label6);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ConsultaDeProveedores";
            Text = "ConsultaDeProveedores";
            Activated += ConsultaDeProveedores_Activated;
            Load += ConsultaDeProveedores_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DGVControl dgvControl1;
        private Label label6;
        private Label label3;
        private TextBox txtFiltro;
    }
}