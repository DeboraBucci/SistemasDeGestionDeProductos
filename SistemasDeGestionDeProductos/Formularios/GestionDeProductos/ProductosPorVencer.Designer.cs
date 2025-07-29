namespace SistemasDeGestionDeProductos.Formularios.GestionDeProductos
{
    partial class ProductosPorVencer
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
            cbPorVencer = new ComboBox();
            label1 = new Label();
            label3 = new Label();
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
            label2.Size = new Size(223, 30);
            label2.TabIndex = 20;
            label2.Text = "Productos por Vencer";
            // 
            // cbPorVencer
            // 
            cbPorVencer.FormattingEnabled = true;
            cbPorVencer.Items.AddRange(new object[] { "7", "15", "30" });
            cbPorVencer.Location = new Point(920, 67);
            cbPorVencer.Name = "cbPorVencer";
            cbPorVencer.Size = new Size(115, 23);
            cbPorVencer.TabIndex = 22;
            cbPorVencer.SelectedIndexChanged += cbPorVencer_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(834, 71);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 23;
            label1.Text = "Dentro de los";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1041, 71);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 24;
            label3.Text = "dias";
            // 
            // ProductosPorVencer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 600);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(cbPorVencer);
            Controls.Add(dgvControl1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProductosPorVencer";
            Text = "ProductosPorVencer";
            Activated += ProductosPorVencer_Activated;
            Load += ProductosPorVencer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DGVControl dgvControl1;
        private Label label2;
        private ComboBox cbPorVencer;
        private Label label1;
        private Label label3;
    }
}