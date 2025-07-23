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
            productosdgvControl1 = new ProductosDGVControl();
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
            rubroscbControl1 = new Controles.RubrosCBControl();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(53, 50);
            label1.Name = "label1";
            label1.Size = new Size(160, 30);
            label1.TabIndex = 0;
            label1.Text = "Crear Producto";
            // 
            // productosdgvControl1
            // 
            productosdgvControl1.AutoSize = true;
            productosdgvControl1.Location = new Point(334, 88);
            productosdgvControl1.Name = "productosdgvControl1";
            productosdgvControl1.Size = new Size(554, 419);
            productosdgvControl1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(334, 49);
            label2.Name = "label2";
            label2.Size = new Size(110, 30);
            label2.TabIndex = 2;
            label2.Text = "Productos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 103);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 3;
            label3.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(34, 121);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(265, 23);
            txtNombre.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 161);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 5;
            label4.Text = "Descripción";
            // 
            // rtxtDescripcion
            // 
            rtxtDescripcion.Location = new Point(34, 179);
            rtxtDescripcion.Name = "rtxtDescripcion";
            rtxtDescripcion.Size = new Size(265, 72);
            rtxtDescripcion.TabIndex = 6;
            rtxtDescripcion.Text = "";
            // 
            // txtPrecioUnitario
            // 
            txtPrecioUnitario.Location = new Point(34, 285);
            txtPrecioUnitario.Name = "txtPrecioUnitario";
            txtPrecioUnitario.Size = new Size(126, 23);
            txtPrecioUnitario.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 267);
            label5.Name = "label5";
            label5.Size = new Size(85, 15);
            label5.TabIndex = 7;
            label5.Text = "Precio Unitario";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(173, 285);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(126, 23);
            txtStock.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(173, 267);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 9;
            label6.Text = "Stock";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(34, 329);
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
            btnCrearProducto.Location = new Point(34, 389);
            btnCrearProducto.Name = "btnCrearProducto";
            btnCrearProducto.Size = new Size(265, 49);
            btnCrearProducto.TabIndex = 13;
            btnCrearProducto.Text = "Crear Producto";
            btnCrearProducto.UseVisualStyleBackColor = false;
            btnCrearProducto.Click += btnCrearProducto_Click;
            // 
            // rubroscbControl1
            // 
            rubroscbControl1.AutoSize = true;
            rubroscbControl1.CbRubrosTxt = null;
            rubroscbControl1.Location = new Point(34, 347);
            rubroscbControl1.Name = "rubroscbControl1";
            rubroscbControl1.Size = new Size(268, 26);
            rubroscbControl1.TabIndex = 14;
            // 
            // AltaDeProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 550);
            Controls.Add(rubroscbControl1);
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
            Controls.Add(productosdgvControl1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AltaDeProducto";
            Text = "AltaDeProducto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ProductosDGVControl productosdgvControl1;
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
        private Controles.RubrosCBControl rubroscbControl1;
    }
}