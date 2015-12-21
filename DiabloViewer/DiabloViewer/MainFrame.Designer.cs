namespace DiabloViewer
{
    partial class MainFrame
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

        #region Vom Windows Form-Designer generierter Code

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
            this.tb_battleTag.Location = new System.Drawing.Point(12, 12);
            this.tb_battleTag.Name = "tb_battleTag";
            this.tb_battleTag.Size = new System.Drawing.Size(100, 20);
            this.tb_battleTag.TabIndex = 0;
            this.tb_battleTag.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tb_battleTag_KeyUp);
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 457);
            this.Controls.Add(this.tb_battleTag);
            this.Name = "MainFrame";
            this.Text = "Diablo Viewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_battleTag;
    }
}

