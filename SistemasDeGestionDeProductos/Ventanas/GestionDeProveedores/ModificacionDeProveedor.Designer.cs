namespace SistemasDeGestionDeProductos.Ventanas.GestionDeProveedores
{
    partial class ModificacionDeProveedor
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
            label6 = new Label();
            txtDireccion = new TextBox();
            label5 = new Label();
            txtTelefono = new TextBox();
            label4 = new Label();
            txtContacto = new TextBox();
            label2 = new Label();
            btnModificarProveedor = new Button();
            txtNombre = new TextBox();
            label3 = new Label();
            label1 = new Label();
            dgvControl1 = new DGVControl();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16F);
            label6.Location = new Point(315, 48);
            label6.Name = "label6";
            label6.Size = new Size(136, 30);
            label6.TabIndex = 37;
            label6.Text = "Proveedores";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(28, 322);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(265, 23);
            txtDireccion.TabIndex = 36;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 304);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 35;
            label5.Text = "Direccion";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(28, 265);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(265, 23);
            txtTelefono.TabIndex = 34;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 247);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 33;
            label4.Text = "Teléfono";
            // 
            // txtContacto
            // 
            txtContacto.Location = new Point(28, 205);
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(265, 23);
            txtContacto.TabIndex = 32;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 187);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 31;
            label2.Text = "Contacto (email)";
            // 
            // btnModificarProveedor
            // 
            btnModificarProveedor.BackColor = Color.RoyalBlue;
            btnModificarProveedor.FlatAppearance.BorderSize = 0;
            btnModificarProveedor.FlatStyle = FlatStyle.Flat;
            btnModificarProveedor.ForeColor = SystemColors.ButtonFace;
            btnModificarProveedor.Location = new Point(28, 383);
            btnModificarProveedor.Name = "btnModificarProveedor";
            btnModificarProveedor.Size = new Size(265, 49);
            btnModificarProveedor.TabIndex = 30;
            btnModificarProveedor.Text = "Modificar Proveedor";
            btnModificarProveedor.UseVisualStyleBackColor = false;
            btnModificarProveedor.Click += btnModificarProveedor_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(28, 147);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(265, 23);
            txtNombre.TabIndex = 29;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 129);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 28;
            label3.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(47, 68);
            label1.Name = "label1";
            label1.Size = new Size(213, 30);
            label1.TabIndex = 27;
            label1.Text = "Modificar Proveedor";
            // 
            // dgvControl1
            // 
            dgvControl1.AutoSize = true;
            dgvControl1.Location = new Point(315, 92);
            dgvControl1.Name = "dgvControl1";
            dgvControl1.Size = new Size(554, 417);
            dgvControl1.TabIndex = 38;
            dgvControl1.SelectionChangedExternal += dgvControl1_SelectionChangedExternal;
            // 
            // ModificacionDeProveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 550);
            Controls.Add(dgvControl1);
            Controls.Add(label6);
            Controls.Add(txtDireccion);
            Controls.Add(label5);
            Controls.Add(txtTelefono);
            Controls.Add(label4);
            Controls.Add(txtContacto);
            Controls.Add(label2);
            Controls.Add(btnModificarProveedor);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ModificacionDeProveedor";
            Text = "ModificionDeProveedor";
            Load += ModificacionDeProveedor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private TextBox txtDireccion;
        private Label label5;
        private TextBox txtTelefono;
        private Label label4;
        private TextBox txtContacto;
        private Label label2;
        private Button btnModificarProveedor;
        private TextBox txtNombre;
        private Label label3;
        private Label label1;
        private DGVControl dgvControl1;
    }
}