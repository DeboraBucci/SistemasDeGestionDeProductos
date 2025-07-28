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
            btnAgregarIngreso = new Button();
            label1 = new Label();
            cbControl1 = new Controles.CBControl();
            label2 = new Label();
            label3 = new Label();
            cbControl2 = new Controles.CBControl();
            label9 = new Label();
            dtpFechaVencimiento = new DateTimePicker();
            txtStock = new TextBox();
            label4 = new Label();
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
            label6.Size = new Size(184, 30);
            label6.TabIndex = 28;
            label6.Text = "Ingresos de Stock";
            // 
            // btnAgregarIngreso
            // 
            btnAgregarIngreso.BackColor = Color.RoyalBlue;
            btnAgregarIngreso.FlatAppearance.BorderSize = 0;
            btnAgregarIngreso.FlatStyle = FlatStyle.Flat;
            btnAgregarIngreso.ForeColor = SystemColors.ButtonFace;
            btnAgregarIngreso.Location = new Point(42, 420);
            btnAgregarIngreso.Name = "btnAgregarIngreso";
            btnAgregarIngreso.Size = new Size(265, 49);
            btnAgregarIngreso.TabIndex = 27;
            btnAgregarIngreso.Text = "Agregar Movimiento";
            btnAgregarIngreso.UseVisualStyleBackColor = false;
            btnAgregarIngreso.Click += btnAgregarMovimiento_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(62, 120);
            label1.Name = "label1";
            label1.Size = new Size(171, 30);
            label1.TabIndex = 26;
            label1.Text = "Agregar Ingreso";
            // 
            // cbControl1
            // 
            cbControl1.AutoSize = true;
            cbControl1.CbTxt = null;
            cbControl1.Location = new Point(42, 201);
            cbControl1.Name = "cbControl1";
            cbControl1.Size = new Size(268, 26);
            cbControl1.TabIndex = 29;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 183);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 30;
            label2.Text = "Elige el producto:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 238);
            label3.Name = "label3";
            label3.Size = new Size(104, 15);
            label3.TabIndex = 32;
            label3.Text = "Elige el proveedor:";
            // 
            // cbControl2
            // 
            cbControl2.AutoSize = true;
            cbControl2.CbTxt = null;
            cbControl2.Location = new Point(42, 256);
            cbControl2.Name = "cbControl2";
            cbControl2.Size = new Size(268, 26);
            cbControl2.TabIndex = 31;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(42, 352);
            label9.Name = "label9";
            label9.Size = new Size(123, 15);
            label9.TabIndex = 36;
            label9.Text = "Fecha de Vencimiento";
            // 
            // dtpFechaVencimiento
            // 
            dtpFechaVencimiento.Location = new Point(42, 370);
            dtpFechaVencimiento.Name = "dtpFechaVencimiento";
            dtpFechaVencimiento.Size = new Size(265, 23);
            dtpFechaVencimiento.TabIndex = 35;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(42, 312);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(265, 23);
            txtStock.TabIndex = 34;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 294);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 33;
            label4.Text = "Stock";
            // 
            // IngresoDeStock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 600);
            Controls.Add(label9);
            Controls.Add(dtpFechaVencimiento);
            Controls.Add(txtStock);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cbControl2);
            Controls.Add(label2);
            Controls.Add(cbControl1);
            Controls.Add(label6);
            Controls.Add(btnAgregarIngreso);
            Controls.Add(label1);
            Controls.Add(dgvControl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "IngresoDeStock";
            Text = "IngresoDeStock";
            Activated += IngresoDeStock_Activated;
            Load += IngresoDeStock_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DGVControl dgvControl1;
        private Label label6;
        private Button btnAgregarIngreso;
        private Label label1;
        private Controles.CBControl cbControl1;
        private Label label2;
        private Label label3;
        private Controles.CBControl cbControl2;
        private Label label9;
        private DateTimePicker dtpFechaVencimiento;
        private TextBox txtStock;
        private Label label4;
    }
}