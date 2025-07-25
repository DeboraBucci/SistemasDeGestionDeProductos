namespace SistemasDeGestionDeProductos.Controles
{
    partial class CBControl
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
            cbGenerico = new ComboBox();
            SuspendLayout();
            // 
            // cbGenerico
            // 
            cbGenerico.FormattingEnabled = true;
            cbGenerico.Location = new Point(0, 0);
            cbGenerico.Name = "cbGenerico";
            cbGenerico.Size = new Size(265, 23);
            cbGenerico.TabIndex = 0;
            cbGenerico.SelectedValueChanged += cbGenerico_SelectedValueChanged;
            // 
            // CBControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(cbGenerico);
            Name = "CBControl";
            Size = new Size(268, 26);
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cbGenerico;
    }
}
