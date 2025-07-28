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
            cbFiltrarTipo = new ComboBox();
            label2 = new Label();
            dtpDesde = new DateTimePicker();
            dtpHasta = new DateTimePicker();
            lblDesde = new Label();
            lblHasta = new Label();
            cboxFiltrarFechas = new CheckBox();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16F);
            label6.Location = new Point(28, 27);
            label6.Name = "label6";
            label6.Size = new Size(228, 30);
            label6.TabIndex = 40;
            label6.Text = "Movimientos de Stock";
            // 
            // dgvControl1
            // 
            dgvControl1.AutoSize = true;
            dgvControl1.Location = new Point(28, 99);
            dgvControl1.Name = "dgvControl1";
            dgvControl1.Size = new Size(1046, 489);
            dgvControl1.TabIndex = 39;
            // 
            // cbControl1
            // 
            cbControl1.AutoSize = true;
            cbControl1.CbTxt = null;
            cbControl1.Location = new Point(806, 67);
            cbControl1.Name = "cbControl1";
            cbControl1.Size = new Size(268, 26);
            cbControl1.TabIndex = 41;
            cbControl1.SelectionChangedExternal += cbControl1_SelectionChangedExternal;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(806, 44);
            label1.Name = "label1";
            label1.Size = new Size(113, 15);
            label1.TabIndex = 42;
            label1.Text = "Filtrar por producto:";
            // 
            // cbFiltrarTipo
            // 
            cbFiltrarTipo.FormattingEnabled = true;
            cbFiltrarTipo.Items.AddRange(new object[] { "Ambos", "Ingreso", "Egreso" });
            cbFiltrarTipo.Location = new Point(629, 67);
            cbFiltrarTipo.Name = "cbFiltrarTipo";
            cbFiltrarTipo.Size = new Size(158, 23);
            cbFiltrarTipo.TabIndex = 43;
            cbFiltrarTipo.SelectedIndexChanged += cbFiltrarTipo_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(629, 44);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 44;
            label2.Text = "Filtrar por tipo:";
            // 
            // dtpDesde
            // 
            dtpDesde.Enabled = false;
            dtpDesde.Location = new Point(308, 67);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(153, 23);
            dtpDesde.TabIndex = 45;
            dtpDesde.ValueChanged += dtpHasta_ValueChanged;
            // 
            // dtpHasta
            // 
            dtpHasta.Enabled = false;
            dtpHasta.Location = new Point(470, 67);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(153, 23);
            dtpHasta.TabIndex = 46;
            dtpHasta.ValueChanged += dtpDesde_ValueChanged;
            // 
            // lblDesde
            // 
            lblDesde.AutoSize = true;
            lblDesde.Enabled = false;
            lblDesde.Location = new Point(308, 49);
            lblDesde.Name = "lblDesde";
            lblDesde.Size = new Size(39, 15);
            lblDesde.TabIndex = 47;
            lblDesde.Text = "Desde";
            // 
            // lblHasta
            // 
            lblHasta.AutoSize = true;
            lblHasta.Enabled = false;
            lblHasta.Location = new Point(470, 49);
            lblHasta.Name = "lblHasta";
            lblHasta.Size = new Size(37, 15);
            lblHasta.TabIndex = 48;
            lblHasta.Text = "Hasta";
            // 
            // cboxFiltrarFechas
            // 
            cboxFiltrarFechas.AutoSize = true;
            cboxFiltrarFechas.Location = new Point(308, 27);
            cboxFiltrarFechas.Name = "cboxFiltrarFechas";
            cboxFiltrarFechas.Size = new Size(198, 19);
            cboxFiltrarFechas.TabIndex = 49;
            cboxFiltrarFechas.Text = "Filtrar por fechas de movimiento";
            cboxFiltrarFechas.UseVisualStyleBackColor = true;
            cboxFiltrarFechas.CheckedChanged += cboxFiltrarFechas_CheckedChanged;
            // 
            // ConsultaDeMovimientos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 600);
            Controls.Add(cboxFiltrarFechas);
            Controls.Add(lblHasta);
            Controls.Add(lblDesde);
            Controls.Add(dtpHasta);
            Controls.Add(dtpDesde);
            Controls.Add(label2);
            Controls.Add(cbFiltrarTipo);
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
        private ComboBox cbFiltrarTipo;
        private Label label2;
        private DateTimePicker dtpDesde;
        private DateTimePicker dtpHasta;
        private Label lblDesde;
        private Label lblHasta;
        private CheckBox cboxFiltrarFechas;
    }
}