namespace SistemasDeGestionDeProductos.Formularios.GestionDeProveedores
{
    partial class BajaDeProveedor
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
            btnEliminarProveedor = new Button();
            SuspendLayout();
            // 
            // dgvControl1
            // 
            dgvControl1.AutoSize = true;
            dgvControl1.Location = new Point(76, 74);
            dgvControl1.Name = "dgvControl1";
            dgvControl1.Size = new Size(948, 427);
            dgvControl1.TabIndex = 28;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16F);
            label6.Location = new Point(76, 30);
            label6.Name = "label6";
            label6.Size = new Size(136, 30);
            label6.TabIndex = 27;
            label6.Text = "Proveedores";
            // 
            // btnEliminarProveedor
            // 
            btnEliminarProveedor.BackColor = Color.Maroon;
            btnEliminarProveedor.FlatAppearance.BorderSize = 0;
            btnEliminarProveedor.FlatStyle = FlatStyle.Flat;
            btnEliminarProveedor.ForeColor = SystemColors.ButtonFace;
            btnEliminarProveedor.Location = new Point(76, 518);
            btnEliminarProveedor.Name = "btnEliminarProveedor";
            btnEliminarProveedor.Size = new Size(265, 49);
            btnEliminarProveedor.TabIndex = 29;
            btnEliminarProveedor.Text = "Eliminar Proveedor";
            btnEliminarProveedor.UseVisualStyleBackColor = false;
            btnEliminarProveedor.Click += btnEliminarProveedor_Click;
            // 
            // BajaDeProveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 600);
            Controls.Add(btnEliminarProveedor);
            Controls.Add(dgvControl1);
            Controls.Add(label6);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BajaDeProveedor";
            Text = "BajaDeProveedor";
            Activated += BajaDeProveedor_Activated;
            Load += BajaDeProveedor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DGVControl dgvControl1;
        private Label label6;
        private Button btnEliminarProveedor;
    }
}