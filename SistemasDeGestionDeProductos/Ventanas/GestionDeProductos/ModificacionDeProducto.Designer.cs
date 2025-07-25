namespace SistemasDeGestionDeProductos.Ventanas.GestionDeProductos
{
    partial class ModificacionDeProducto
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
            btnModificarProducto = new Button();
            label7 = new Label();
            txtPrecioUnitario = new TextBox();
            label5 = new Label();
            rtxtDescripcion = new RichTextBox();
            label4 = new Label();
            txtNombre = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            rubroscbControl1 = new Controles.RubrosCBControl();
            dgvControl1 = new DGVControl();
            SuspendLayout();
            // 
            // btnModificarProducto
            // 
            btnModificarProducto.BackColor = Color.RoyalBlue;
            btnModificarProducto.FlatAppearance.BorderSize = 0;
            btnModificarProducto.FlatStyle = FlatStyle.Flat;
            btnModificarProducto.ForeColor = SystemColors.ButtonFace;
            btnModificarProducto.Location = new Point(43, 474);
            btnModificarProducto.Name = "btnModificarProducto";
            btnModificarProducto.Size = new Size(265, 49);
            btnModificarProducto.TabIndex = 27;
            btnModificarProducto.Text = "Modificar Producto";
            btnModificarProducto.UseVisualStyleBackColor = false;
            btnModificarProducto.Click += btnModificarProducto_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(40, 326);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 25;
            label7.Text = "Rubro";
            // 
            // txtPrecioUnitario
            // 
            txtPrecioUnitario.Location = new Point(40, 282);
            txtPrecioUnitario.Name = "txtPrecioUnitario";
            txtPrecioUnitario.Size = new Size(265, 23);
            txtPrecioUnitario.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 264);
            label5.Name = "label5";
            label5.Size = new Size(85, 15);
            label5.TabIndex = 21;
            label5.Text = "Precio Unitario";
            // 
            // rtxtDescripcion
            // 
            rtxtDescripcion.Location = new Point(40, 176);
            rtxtDescripcion.Name = "rtxtDescripcion";
            rtxtDescripcion.Size = new Size(265, 72);
            rtxtDescripcion.TabIndex = 20;
            rtxtDescripcion.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 158);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 19;
            label4.Text = "Descripción";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(40, 118);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(265, 23);
            txtNombre.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 100);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 17;
            label3.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(363, 22);
            label2.Name = "label2";
            label2.Size = new Size(110, 30);
            label2.TabIndex = 16;
            label2.Text = "Productos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(59, 47);
            label1.Name = "label1";
            label1.Size = new Size(199, 30);
            label1.TabIndex = 14;
            label1.Text = "Modificar Producto";
            // 
            // rubroscbControl1
            // 
            rubroscbControl1.AutoSize = true;
            rubroscbControl1.CbRubrosTxt = null;
            rubroscbControl1.Location = new Point(40, 344);
            rubroscbControl1.Name = "rubroscbControl1";
            rubroscbControl1.Size = new Size(268, 26);
            rubroscbControl1.TabIndex = 28;
            // 
            // dgvControl1
            // 
            dgvControl1.AutoSize = true;
            dgvControl1.Location = new Point(363, 75);
            dgvControl1.Name = "dgvControl1";
            dgvControl1.Size = new Size(703, 503);
            dgvControl1.TabIndex = 29;
            dgvControl1.SelectionChangedExternal += dgvControl1_SelectionChangedExternal;
            // 
            // ModificacionDeProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 600);
            Controls.Add(dgvControl1);
            Controls.Add(rubroscbControl1);
            Controls.Add(btnModificarProducto);
            Controls.Add(label7);
            Controls.Add(txtPrecioUnitario);
            Controls.Add(label5);
            Controls.Add(rtxtDescripcion);
            Controls.Add(label4);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ModificacionDeProducto";
            Text = "ModificacionDeProducto";
            Load += ModificacionDeProducto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnModificarProducto;
        private Label label7;
        private TextBox txtPrecioUnitario;
        private Label label5;
        private RichTextBox rtxtDescripcion;
        private Label label4;
        private TextBox txtNombre;
        private Label label3;
        private Label label2;
        private Label label1;
        private Controles.RubrosCBControl rubroscbControl1;
        private DGVControl dgvControl1;
    }
}