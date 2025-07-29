namespace SistemasDeGestionDeProductos.Formularios.GestionDeProductos
{
    partial class BajaDeProducto
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
            label2 = new Label();
            btnEliminarProducto = new Button();
            SuspendLayout();
            // 
            // dgvControl1
            // 
            dgvControl1.AutoSize = true;
            dgvControl1.Location = new Point(76, 74);
            dgvControl1.Name = "dgvControl1";
            dgvControl1.Size = new Size(948, 427);
            dgvControl1.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(76, 30);
            label2.Name = "label2";
            label2.Size = new Size(110, 30);
            label2.TabIndex = 18;
            label2.Text = "Productos";
            // 
            // btnEliminarProducto
            // 
            btnEliminarProducto.BackColor = Color.Maroon;
            btnEliminarProducto.FlatAppearance.BorderSize = 0;
            btnEliminarProducto.FlatStyle = FlatStyle.Flat;
            btnEliminarProducto.ForeColor = SystemColors.ButtonFace;
            btnEliminarProducto.Location = new Point(76, 518);
            btnEliminarProducto.Name = "btnEliminarProducto";
            btnEliminarProducto.Size = new Size(265, 49);
            btnEliminarProducto.TabIndex = 28;
            btnEliminarProducto.Text = "Eliminar Producto";
            btnEliminarProducto.UseVisualStyleBackColor = false;
            btnEliminarProducto.Click += btnEliminarProducto_Click;
            // 
            // BajaDeProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 600);
            Controls.Add(btnEliminarProducto);
            Controls.Add(dgvControl1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BajaDeProducto";
            Text = "BajaDeProducto";
            Activated += BajaDeProducto_Activated;
            Load += BajaDeProducto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DGVControl dgvControl1;
        private Label label2;
        private Button btnEliminarProducto;
    }
}