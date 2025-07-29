namespace SistemasDeGestionDeProductos.Ventanas.GestionDeRubros
{
    partial class ModificacionDeRubro
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
            btnModificarRubro = new Button();
            rtxtDescripcion = new RichTextBox();
            label4 = new Label();
            txtNombre = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // dgvControl1
            // 
            dgvControl1.AutoSize = true;
            dgvControl1.Location = new Point(371, 68);
            dgvControl1.Name = "dgvControl1";
            dgvControl1.Size = new Size(703, 503);
            dgvControl1.TabIndex = 30;
            dgvControl1.SelectionChangedExternal += dgvControl1_SelectionChangedExternal;
            // 
            // btnModificarRubro
            // 
            btnModificarRubro.BackColor = Color.RoyalBlue;
            btnModificarRubro.FlatAppearance.BorderSize = 0;
            btnModificarRubro.FlatStyle = FlatStyle.Flat;
            btnModificarRubro.ForeColor = SystemColors.ButtonFace;
            btnModificarRubro.Location = new Point(52, 362);
            btnModificarRubro.Name = "btnModificarRubro";
            btnModificarRubro.Size = new Size(265, 49);
            btnModificarRubro.TabIndex = 29;
            btnModificarRubro.Text = "Modificar Rubro";
            btnModificarRubro.UseVisualStyleBackColor = false;
            btnModificarRubro.Click += btnModificarRubro_Click;
            // 
            // rtxtDescripcion
            // 
            rtxtDescripcion.Location = new Point(52, 224);
            rtxtDescripcion.Name = "rtxtDescripcion";
            rtxtDescripcion.Size = new Size(265, 72);
            rtxtDescripcion.TabIndex = 28;
            rtxtDescripcion.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 206);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 27;
            label4.Text = "Descripción";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(52, 166);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(265, 23);
            txtNombre.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 148);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 25;
            label3.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(371, 24);
            label2.Name = "label2";
            label2.Size = new Size(81, 30);
            label2.TabIndex = 24;
            label2.Text = "Rubros";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(71, 95);
            label1.Name = "label1";
            label1.Size = new Size(170, 30);
            label1.TabIndex = 23;
            label1.Text = "Modificar Rubro";
            // 
            // ModificacionDeRubro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 600);
            Controls.Add(dgvControl1);
            Controls.Add(btnModificarRubro);
            Controls.Add(rtxtDescripcion);
            Controls.Add(label4);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ModificacionDeRubro";
            Text = "ModificacionDeRubro";
            Load += ModificacionDeRubro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DGVControl dgvControl1;
        private Button btnModificarRubro;
        private RichTextBox rtxtDescripcion;
        private Label label4;
        private TextBox txtNombre;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}