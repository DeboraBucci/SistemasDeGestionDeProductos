namespace SistemasDeGestionDeProductos.Ventanas.GestionDeProveedores
{
    partial class AltaDeProveedor
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
            components = new System.ComponentModel.Container();
            btnAgregarProveedor = new Button();
            txtNombre = new TextBox();
            label3 = new Label();
            label1 = new Label();
            txtContacto = new TextBox();
            label2 = new Label();
            txtTelefono = new TextBox();
            label4 = new Label();
            txtDireccion = new TextBox();
            label5 = new Label();
            label6 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            dgvControl1 = new DGVControl();
            SuspendLayout();
            // 
            // btnAgregarProveedor
            // 
            btnAgregarProveedor.BackColor = Color.RoyalBlue;
            btnAgregarProveedor.FlatAppearance.BorderSize = 0;
            btnAgregarProveedor.FlatStyle = FlatStyle.Flat;
            btnAgregarProveedor.ForeColor = SystemColors.ButtonFace;
            btnAgregarProveedor.Location = new Point(42, 413);
            btnAgregarProveedor.Name = "btnAgregarProveedor";
            btnAgregarProveedor.Size = new Size(265, 49);
            btnAgregarProveedor.TabIndex = 17;
            btnAgregarProveedor.Text = "Agregar Proveedor";
            btnAgregarProveedor.UseVisualStyleBackColor = false;
            btnAgregarProveedor.Click += btnAgregarProveedor_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(42, 177);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(265, 23);
            txtNombre.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 159);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 15;
            label3.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(62, 98);
            label1.Name = "label1";
            label1.Size = new Size(200, 30);
            label1.TabIndex = 14;
            label1.Text = "Agregar Proveedor";
            // 
            // txtContacto
            // 
            txtContacto.Location = new Point(42, 235);
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(265, 23);
            txtContacto.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 217);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 18;
            label2.Text = "Contacto (email)";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(42, 295);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(265, 23);
            txtTelefono.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 277);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 20;
            label4.Text = "Teléfono";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(42, 352);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(265, 23);
            txtDireccion.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 334);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 22;
            label5.Text = "Direccion";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16F);
            label6.Location = new Point(374, 22);
            label6.Name = "label6";
            label6.Size = new Size(136, 30);
            label6.TabIndex = 25;
            label6.Text = "Proveedores";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // dgvControl1
            // 
            dgvControl1.AutoSize = true;
            dgvControl1.Location = new Point(374, 63);
            dgvControl1.Name = "dgvControl1";
            dgvControl1.Size = new Size(703, 503);
            dgvControl1.TabIndex = 26;
            // 
            // AltaDeProveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 600);
            Controls.Add(dgvControl1);
            Controls.Add(label6);
            Controls.Add(txtDireccion);
            Controls.Add(label5);
            Controls.Add(txtTelefono);
            Controls.Add(label4);
            Controls.Add(txtContacto);
            Controls.Add(label2);
            Controls.Add(btnAgregarProveedor);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AltaDeProveedor";
            Text = "AltaDeProveedor";
            Activated += AltaDeProveedor_Activated;
            Load += AltaDeProveedor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregarProveedor;
        private TextBox txtNombre;
        private Label label3;
        private Label label1;
        private TextBox txtContacto;
        private Label label2;
        private TextBox txtTelefono;
        private Label label4;
        private TextBox txtDireccion;
        private Label label5;
        private Label label6;
        private ContextMenuStrip contextMenuStrip1;
        private DGVControl dgvControl1;
    }
}