namespace SistemasDeGestionDeProductos.Formularios.Reportes
{
    partial class ProductosConBajoStock
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
            label1 = new Label();
            txtMinStock = new TextBox();
            SuspendLayout();
            // 
            // dgvControl1
            // 
            dgvControl1.AutoSize = true;
            dgvControl1.Location = new Point(28, 99);
            dgvControl1.Name = "dgvControl1";
            dgvControl1.Size = new Size(1046, 469);
            dgvControl1.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(28, 58);
            label2.Name = "label2";
            label2.Size = new Size(257, 30);
            label2.TabIndex = 20;
            label2.Text = "Productos con Bajo Stock";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(616, 71);
            label1.Name = "label1";
            label1.Size = new Size(135, 15);
            label1.TabIndex = 22;
            label1.Text = "Elija el minimo de stock:";
            // 
            // txtMinStock
            // 
            txtMinStock.Location = new Point(757, 67);
            txtMinStock.Name = "txtMinStock";
            txtMinStock.Size = new Size(317, 23);
            txtMinStock.TabIndex = 23;
            txtMinStock.TextChanged += txtMinStock_TextChanged;
            // 
            // ProductosConBajoStock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 600);
            Controls.Add(txtMinStock);
            Controls.Add(label1);
            Controls.Add(dgvControl1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProductosConBajoStock";
            Text = "ProductosConBajoStock";
            Activated += ProductosConBajoStock_Activated;
            Load += ProductosConBajoStock_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DGVControl dgvControl1;
        private Label label2;
        private Label label1;
        private TextBox txtMinStock;
    }
}