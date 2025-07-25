namespace SistemasDeGestionDeProductos.Ventanas.GestionDeMovimientosDeStock
{
    partial class IngresoDeStock
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            dgvControl1 = new DGVControl();
            SuspendLayout();
            // 
            // dgvControl1
            // 
            dgvControl1.AutoSize = true;
            dgvControl1.Location = new Point(363, 70);
            dgvControl1.Name = "dgvControl1";
            dgvControl1.Size = new Size(703, 503);
            dgvControl1.TabIndex = 18;
            // 
            // IngresoDeStock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 600);
            Controls.Add(dgvControl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "IngresoDeStock";
            Text = "IngresoDeStock";
            Load += IngresoDeStock_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DGVControl dgvControl1;
    }
}