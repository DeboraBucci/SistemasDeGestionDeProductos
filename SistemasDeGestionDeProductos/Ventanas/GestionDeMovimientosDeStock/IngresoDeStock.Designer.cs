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
            label6 = new Label();
            btnAgregarMovimiento = new Button();
            label1 = new Label();
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16F);
            label6.Location = new Point(363, 28);
            label6.Name = "label6";
            label6.Size = new Size(228, 30);
            label6.TabIndex = 28;
            label6.Text = "Movimientos de Stock";
            // 
            // btnAgregarMovimiento
            // 
            btnAgregarMovimiento.BackColor = Color.RoyalBlue;
            btnAgregarMovimiento.FlatAppearance.BorderSize = 0;
            btnAgregarMovimiento.FlatStyle = FlatStyle.Flat;
            btnAgregarMovimiento.ForeColor = SystemColors.ButtonFace;
            btnAgregarMovimiento.Location = new Point(41, 421);
            btnAgregarMovimiento.Name = "btnAgregarMovimiento";
            btnAgregarMovimiento.Size = new Size(265, 49);
            btnAgregarMovimiento.TabIndex = 27;
            btnAgregarMovimiento.Text = "Agregar Movimiento";
            btnAgregarMovimiento.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(60, 106);
            label1.Name = "label1";
            label1.Size = new Size(215, 30);
            label1.TabIndex = 26;
            label1.Text = "Agregar Movimiento";
            // 
            // IngresoDeStock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 600);
            Controls.Add(label6);
            Controls.Add(btnAgregarMovimiento);
            Controls.Add(label1);
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
        private Label label6;
        private Button btnAgregarMovimiento;
        private Label label1;
    }
}