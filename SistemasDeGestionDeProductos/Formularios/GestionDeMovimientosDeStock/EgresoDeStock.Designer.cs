namespace SistemasDeGestionDeProductos.Ventanas.GestionDeMovimientosDeStock
{
    partial class EgresoDeStock
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
            txtCantidad = new TextBox();
            label4 = new Label();
            label2 = new Label();
            cbControl1 = new Controles.CBControl();
            label6 = new Label();
            btnAgregarEgreso = new Button();
            label1 = new Label();
            dgvControl1 = new DGVControl();
            txtMotivo = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(42, 258);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(265, 23);
            txtCantidad.TabIndex = 42;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 240);
            label4.Name = "label4";
            label4.Size = new Size(146, 15);
            label4.TabIndex = 41;
            label4.Text = "Elige la cantidad solicitada";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 183);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 40;
            label2.Text = "Elige el producto:";
            // 
            // cbControl1
            // 
            cbControl1.AutoSize = true;
            cbControl1.CbTxt = null;
            cbControl1.Location = new Point(42, 201);
            cbControl1.Name = "cbControl1";
            cbControl1.Size = new Size(268, 26);
            cbControl1.TabIndex = 39;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16F);
            label6.Location = new Point(374, 22);
            label6.Name = "label6";
            label6.Size = new Size(177, 30);
            label6.TabIndex = 38;
            label6.Text = "Egresos de Stock";
            // 
            // btnAgregarEgreso
            // 
            btnAgregarEgreso.BackColor = Color.RoyalBlue;
            btnAgregarEgreso.FlatAppearance.BorderSize = 0;
            btnAgregarEgreso.FlatStyle = FlatStyle.Flat;
            btnAgregarEgreso.ForeColor = SystemColors.ButtonFace;
            btnAgregarEgreso.Location = new Point(42, 420);
            btnAgregarEgreso.Name = "btnAgregarEgreso";
            btnAgregarEgreso.Size = new Size(265, 49);
            btnAgregarEgreso.TabIndex = 37;
            btnAgregarEgreso.Text = "Agregar Egreso";
            btnAgregarEgreso.UseVisualStyleBackColor = false;
            btnAgregarEgreso.Click += btnAgregarEgreso_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(62, 120);
            label1.Name = "label1";
            label1.Size = new Size(164, 30);
            label1.TabIndex = 36;
            label1.Text = "Agregar Egreso";
            // 
            // dgvControl1
            // 
            dgvControl1.AutoSize = true;
            dgvControl1.Location = new Point(374, 63);
            dgvControl1.Name = "dgvControl1";
            dgvControl1.Size = new Size(703, 503);
            dgvControl1.TabIndex = 35;
            // 
            // txtMotivo
            // 
            txtMotivo.Location = new Point(42, 319);
            txtMotivo.Name = "txtMotivo";
            txtMotivo.Size = new Size(265, 23);
            txtMotivo.TabIndex = 44;
            txtMotivo.Text = "Varios";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 301);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 43;
            label3.Text = "Motivo";
            // 
            // EgresoDeStock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 600);
            Controls.Add(txtMotivo);
            Controls.Add(label3);
            Controls.Add(txtCantidad);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(cbControl1);
            Controls.Add(label6);
            Controls.Add(btnAgregarEgreso);
            Controls.Add(label1);
            Controls.Add(dgvControl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EgresoDeStock";
            Text = "EgresoDeStock";
            Activated += EgresoDeStock_Activated;
            Load += EgresoDeStock_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCantidad;
        private Label label4;
        private Label label2;
        private Controles.CBControl cbControl1;
        private Label label6;
        private Button btnAgregarEgreso;
        private Label label1;
        private DGVControl dgvControl1;
        private TextBox txtMotivo;
        private Label label3;
    }
}