namespace SistemasDeGestionDeProductos.Formularios.Reportes
{
    partial class MovimientosPorProveedor
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
            cbControl1 = new Controles.CBControl();
            label1 = new Label();
            SuspendLayout();
            // 
            // dgvControl1
            // 
            dgvControl1.AutoSize = true;
            dgvControl1.Location = new Point(28, 99);
            dgvControl1.Name = "dgvControl1";
            dgvControl1.Size = new Size(1046, 469);
            dgvControl1.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(28, 58);
            label2.Name = "label2";
            label2.Size = new Size(243, 30);
            label2.TabIndex = 22;
            label2.Text = "Ingresos por Proveedor";
            // 
            // cbControl1
            // 
            cbControl1.AutoSize = true;
            cbControl1.CbTxt = null;
            cbControl1.Location = new Point(806, 67);
            cbControl1.Name = "cbControl1";
            cbControl1.Size = new Size(268, 26);
            cbControl1.TabIndex = 24;
            cbControl1.SelectionChangedExternal += cbControl1_SelectionChangedExternal;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(696, 71);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 25;
            label1.Text = "Elige el proveedor:";
            // 
            // MovimientosPorProveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 600);
            Controls.Add(label1);
            Controls.Add(cbControl1);
            Controls.Add(dgvControl1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MovimientosPorProveedor";
            Text = "MovimientosPorProveedor";
            Activated += MovimientosPorProveedor_Activated;
            Load += MovimientosPorProveedor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DGVControl dgvControl1;
        private Label label2;
        private Controles.CBControl cbControl1;
        private Label label1;
    }
}