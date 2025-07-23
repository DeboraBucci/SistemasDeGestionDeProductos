namespace SistemasDeGestionDeProductos.Controles
{
    partial class RubrosCBControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cbRubros = new ComboBox();
            SuspendLayout();
            // 
            // cbRubros
            // 
            cbRubros.FormattingEnabled = true;
            cbRubros.Location = new Point(0, 0);
            cbRubros.Name = "cbRubros";
            cbRubros.Size = new Size(265, 23);
            cbRubros.TabIndex = 0;
            cbRubros.SelectedValueChanged += cbRubros_SelectedValueChanged;
            // 
            // RubrosCBControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(cbRubros);
            Name = "RubrosCBControl";
            Size = new Size(268, 150);
            Load += RubrosCBControl_Load;
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cbRubros;
    }
}
