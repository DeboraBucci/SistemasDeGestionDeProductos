namespace SistemasDeGestionDeProductos.Formularios.GestionDeRubros
{
    partial class BajaDeRubro
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
            btnEliminarRubro = new Button();
            SuspendLayout();
            // 
            // dgvControl1
            // 
            dgvControl1.AutoSize = true;
            dgvControl1.Location = new Point(76, 74);
            dgvControl1.Name = "dgvControl1";
            dgvControl1.Size = new Size(948, 427);
            dgvControl1.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(76, 30);
            label2.Name = "label2";
            label2.Size = new Size(356, 30);
            label2.TabIndex = 25;
            label2.Text = "Seleccione un rubro para eliminarlo";
            // 
            // btnEliminarRubro
            // 
            btnEliminarRubro.BackColor = Color.Maroon;
            btnEliminarRubro.FlatAppearance.BorderSize = 0;
            btnEliminarRubro.FlatStyle = FlatStyle.Flat;
            btnEliminarRubro.ForeColor = SystemColors.ButtonFace;
            btnEliminarRubro.Location = new Point(76, 518);
            btnEliminarRubro.Name = "btnEliminarRubro";
            btnEliminarRubro.Size = new Size(265, 49);
            btnEliminarRubro.TabIndex = 27;
            btnEliminarRubro.Text = "Eliminar Rubro";
            btnEliminarRubro.UseVisualStyleBackColor = false;
            btnEliminarRubro.Click += btnEliminarRubro_Click;
            // 
            // BajaDeRubro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 600);
            Controls.Add(btnEliminarRubro);
            Controls.Add(dgvControl1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BajaDeRubro";
            Text = "BajaDeRubro";
            Activated += BajaDeRubro_Activated;
            Load += BajaDeRubro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DGVControl dgvControl1;
        private Label label2;
        private Button btnEliminarRubro;
    }
}