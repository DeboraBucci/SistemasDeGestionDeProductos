namespace SistemasDeGestionDeProductos.Controles
{
    partial class ProveedorCBControl
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
            cbProveedor = new ComboBox();
            SuspendLayout();
            // 
            // cbProveedor
            // 
            cbProveedor.FormattingEnabled = true;
            cbProveedor.Location = new Point(0, 0);
            cbProveedor.Name = "cbProveedor";
            cbProveedor.Size = new Size(265, 23);
            cbProveedor.TabIndex = 0;
            cbProveedor.SelectedValueChanged += cbProveedor_SelectedValueChanged;
            // 
            // ProveedorCBControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(cbProveedor);
            Name = "ProveedorCBControl";
            Size = new Size(268, 150);
            Load += ProveedorCBControl_Load;
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cbProveedor;
    }
}
