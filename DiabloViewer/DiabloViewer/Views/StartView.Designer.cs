namespace DiabloViewer.Views
{
    partial class StartView
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_battleTag = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_battleTag
            // 
            this.tb_battleTag.Location = new System.Drawing.Point(3, 3);
            this.tb_battleTag.Name = "tb_battleTag";
            this.tb_battleTag.Size = new System.Drawing.Size(100, 20);
            this.tb_battleTag.TabIndex = 1;
            this.tb_battleTag.Text = "Svenson#2281";
            this.tb_battleTag.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tb_battleTag_KeyUp);
            // 
            // StartView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tb_battleTag);
            this.Name = "StartView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_battleTag;
    }
}
