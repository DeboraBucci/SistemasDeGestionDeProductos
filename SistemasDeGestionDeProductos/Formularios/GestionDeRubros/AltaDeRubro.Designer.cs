namespace SistemasDeGestionDeProductos.Ventanas.GestionDeRubros
{
    partial class AltaDeRubro
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
            btnCrearRubro = new Button();
            rtxtDescripcion = new RichTextBox();
            label4 = new Label();
            txtNombre = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvControl1 = new DGVControl();
            SuspendLayout();
            // 
            // btnCrearRubro
            // 
            btnCrearRubro.BackColor = Color.RoyalBlue;
            btnCrearRubro.FlatAppearance.BorderSize = 0;
            btnCrearRubro.FlatStyle = FlatStyle.Flat;
            btnCrearRubro.ForeColor = SystemColors.ButtonFace;
            btnCrearRubro.Location = new Point(120, 439);
            btnCrearRubro.Name = "btnCrearRubro";
            btnCrearRubro.Size = new Size(265, 49);
            btnCrearRubro.TabIndex = 21;
            btnCrearRubro.Text = "Crear Rubro";
            btnCrearRubro.UseVisualStyleBackColor = false;
            btnCrearRubro.Click += btnCrearRubro_Click;
            // 
            // rtxtDescripcion
            // 
            rtxtDescripcion.Location = new Point(120, 229);
            rtxtDescripcion.Name = "rtxtDescripcion";
            rtxtDescripcion.Size = new Size(265, 72);
            rtxtDescripcion.TabIndex = 20;
            rtxtDescripcion.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(120, 211);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 19;
            label4.Text = "Descripción";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(120, 171);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(265, 23);
            txtNombre.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(120, 153);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 17;
            label3.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(487, 71);
            label2.Name = "label2";
            label2.Size = new Size(81, 30);
            label2.TabIndex = 16;
            label2.Text = "Rubros";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(139, 100);
            label1.Name = "label1";
            label1.Size = new Size(131, 30);
            label1.TabIndex = 14;
            label1.Text = "Crear Rubro";
            // 
            // dgvControl1
            // 
            dgvControl1.AutoSize = true;
            dgvControl1.Location = new Point(487, 114);
            dgvControl1.Name = "dgvControl1";
            dgvControl1.Size = new Size(554, 417);
            dgvControl1.TabIndex = 22;
            // 
            // AltaDeRubro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 600);
            Controls.Add(dgvControl1);
            Controls.Add(btnCrearRubro);
            Controls.Add(rtxtDescripcion);
            Controls.Add(label4);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AltaDeRubro";
            Text = "AltaDeRubro";
            Activated += AltaDeRubro_Activated;
            Load += AltaDeRubro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCrearRubro;
        private RichTextBox rtxtDescripcion;
        private Label label4;
        private TextBox txtNombre;
        private Label label3;
        private Label label2;
        private Label label1;
        private DGVControl dgvControl1;
    }
}