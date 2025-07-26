namespace SistemasDeGestionDeProductos.Ventanas.GestionDeMovimientosDeStock
{
    partial class ConsultaDeMovimientos
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
            dgvControl1 = new DGVControl();
            cbControl1 = new Controles.CBControl();
            label1 = new Label();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16F);
            label6.Location = new Point(28, 30);
            label6.Name = "label6";
            label6.Size = new Size(228, 30);
            label6.TabIndex = 40;
            label6.Text = "Movimientos de Stock";
            // 
            // dgvControl1
            // 
            dgvControl1.AutoSize = true;
            dgvControl1.Location = new Point(28, 85);
            dgvControl1.Name = "dgvControl1";
            dgvControl1.Size = new Size(1046, 489);
            dgvControl1.TabIndex = 39;
            // 
            // cbControl1
            // 
            cbControl1.AutoSize = true;
            cbControl1.CbTxt = null;
            cbControl1.Location = new Point(806, 53);
            cbControl1.Name = "cbControl1";
            cbControl1.Size = new Size(268, 26);
            cbControl1.TabIndex = 41;
            cbControl1.SelectionChangedExternal += cbControl1_SelectionChangedExternal;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(806, 30);
            label1.Name = "label1";
            label1.Size = new Size(113, 15);
            label1.TabIndex = 42;
            label1.Text = "Filtrar por producto:";
            // 
            // ConsultaDeMovimientos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 600);
            Controls.Add(label1);
            Controls.Add(cbControl1);
            Controls.Add(label6);
            Controls.Add(dgvControl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ConsultaDeMovimientos";
            Text = "ConsultaDeMovimientos";
            Activated += ConsultaDeMovimientos_Activated;
            Load += ConsultaDeMovimientos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private DGVControl dgvControl1;
        private Controles.CBControl cbControl1;
        private Label label1;
    }
}