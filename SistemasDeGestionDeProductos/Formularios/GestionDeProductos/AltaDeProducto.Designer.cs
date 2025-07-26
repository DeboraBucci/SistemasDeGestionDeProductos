namespace SistemasDeGestionDeProductos.Ventanas.GestionDeProductos
{
    partial class AltaDeProducto
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNombre = new TextBox();
            label4 = new Label();
            rtxtDescripcion = new RichTextBox();
            txtPrecioUnitario = new TextBox();
            label5 = new Label();
            txtStock = new TextBox();
            label6 = new Label();
            label7 = new Label();
            btnCrearProducto = new Button();
            cbControl1 = new Controles.CBControl();
            label8 = new Label();
            dgvControl1 = new DGVControl();
            dtpFechaVencimiento = new DateTimePicker();
            label9 = new Label();
            cbControl2 = new Controles.CBControl();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(62, 36);
            label1.Name = "label1";
            label1.Size = new Size(160, 30);
            label1.TabIndex = 0;
            label1.Text = "Crear Producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(374, 22);
            label2.Name = "label2";
            label2.Size = new Size(110, 30);
            label2.TabIndex = 2;
            label2.Text = "Productos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 76);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 3;
            label3.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(43, 94);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(265, 23);
            txtNombre.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 134);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 5;
            label4.Text = "Descripción";
            // 
            // rtxtDescripcion
            // 
            rtxtDescripcion.Location = new Point(43, 152);
            rtxtDescripcion.Name = "rtxtDescripcion";
            rtxtDescripcion.Size = new Size(265, 58);
            rtxtDescripcion.TabIndex = 6;
            rtxtDescripcion.Text = "";
            // 
            // txtPrecioUnitario
            // 
            txtPrecioUnitario.Location = new Point(43, 241);
            txtPrecioUnitario.Name = "txtPrecioUnitario";
            txtPrecioUnitario.Size = new Size(265, 23);
            txtPrecioUnitario.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 223);
            label5.Name = "label5";
            label5.Size = new Size(85, 15);
            label5.TabIndex = 7;
            label5.Text = "Precio Unitario";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(43, 346);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(265, 23);
            txtStock.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(43, 328);
            label6.Name = "label6";
            label6.Size = new Size(70, 15);
            label6.TabIndex = 9;
            label6.Text = "Stock Inicial";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(43, 276);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 11;
            label7.Text = "Rubro";
            // 
            // btnCrearProducto
            // 
            btnCrearProducto.BackColor = Color.RoyalBlue;
            btnCrearProducto.FlatAppearance.BorderSize = 0;
            btnCrearProducto.FlatStyle = FlatStyle.Flat;
            btnCrearProducto.ForeColor = SystemColors.ButtonFace;
            btnCrearProducto.Location = new Point(46, 517);
            btnCrearProducto.Name = "btnCrearProducto";
            btnCrearProducto.Size = new Size(265, 49);
            btnCrearProducto.TabIndex = 13;
            btnCrearProducto.Text = "Crear Producto";
            btnCrearProducto.UseVisualStyleBackColor = false;
            btnCrearProducto.Click += btnCrearProducto_Click;
            // 
            // cbControl1
            // 
            cbControl1.AutoSize = true;
            cbControl1.CbTxt = null;
            cbControl1.Location = new Point(43, 294);
            cbControl1.Name = "cbControl1";
            cbControl1.Size = new Size(268, 26);
            cbControl1.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(43, 379);
            label8.Name = "label8";
            label8.Size = new Size(61, 15);
            label8.TabIndex = 15;
            label8.Text = "Proveedor";
            // 
            // dgvControl1
            // 
            dgvControl1.AutoSize = true;
            dgvControl1.Location = new Point(374, 63);
            dgvControl1.Name = "dgvControl1";
            dgvControl1.Size = new Size(703, 503);
            dgvControl1.TabIndex = 17;
            // 
            // dtpFechaVencimiento
            // 
            dtpFechaVencimiento.Location = new Point(43, 451);
            dtpFechaVencimiento.Name = "dtpFechaVencimiento";
            dtpFechaVencimiento.Size = new Size(265, 23);
            dtpFechaVencimiento.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(43, 433);
            label9.Name = "label9";
            label9.Size = new Size(123, 15);
            label9.TabIndex = 19;
            label9.Text = "Fecha de Vencimiento";
            // 
            // cbControl2
            // 
            cbControl2.AutoSize = true;
            cbControl2.CbTxt = null;
            cbControl2.Location = new Point(43, 397);
            cbControl2.Name = "cbControl2";
            cbControl2.Size = new Size(268, 26);
            cbControl2.TabIndex = 20;
            // 
            // AltaDeProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 600);
            Controls.Add(cbControl2);
            Controls.Add(label9);
            Controls.Add(dtpFechaVencimiento);
            Controls.Add(dgvControl1);
            Controls.Add(label8);
            Controls.Add(cbControl1);
            Controls.Add(btnCrearProducto);
            Controls.Add(label7);
            Controls.Add(txtStock);
            Controls.Add(label6);
            Controls.Add(txtPrecioUnitario);
            Controls.Add(label5);
            Controls.Add(rtxtDescripcion);
            Controls.Add(label4);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AltaDeProducto";
            Text = "AltaDeProducto";
            Activated += AltaDeProducto_Activated;
            Load += AltaDeProducto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNombre;
        private Label label4;
        private RichTextBox rtxtDescripcion;
        private TextBox txtPrecioUnitario;
        private Label label5;
        private TextBox txtStock;
        private Label label6;
        private Label label7;
        private Button btnCrearProducto;
        private Controles.CBControl cbControl1;
        private Label label8;
        private DGVControl dgvControl1;
        private DateTimePicker dtpFechaVencimiento;
        private Label label9;
        private Controles.CBControl cbControl2;
    }
}