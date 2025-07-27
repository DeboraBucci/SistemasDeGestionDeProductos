namespace SistemasDeGestionDeProductos.Formularios.Reportes
{
    partial class StockPorRubro
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
            SuspendLayout();
            // 
            // dgvControl1
            // 
            dgvControl1.AutoSize = true;
            dgvControl1.Location = new Point(12, 64);
            dgvControl1.Name = "dgvControl1";
            dgvControl1.Size = new Size(1076, 519);
            dgvControl1.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(12, 17);
            label2.Name = "label2";
            label2.Size = new Size(170, 30);
            label2.TabIndex = 20;
            label2.Text = "Stock por Rubro";
            // 
            // StockPorRubro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 600);
            Controls.Add(dgvControl1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StockPorRubro";
            Text = "StockPorRubro";
            Activated += StockPorRubro_Activated;
            Load += StockPorRubro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DGVControl dgvControl1;
        private Label label2;
    }
}