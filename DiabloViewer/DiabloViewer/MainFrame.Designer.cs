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
            this.diabloProfileView = new DiabloViewer.DiabloProfileView();
            this.SuspendLayout();
            // 
            // startPanel
            // 
            this.diabloProfileView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diabloProfileView.Location = new System.Drawing.Point(0, 0);
            this.diabloProfileView.Name = "startPanel";
            this.diabloProfileView.Size = new System.Drawing.Size(513, 457);
            this.diabloProfileView.TabIndex = 0;
            this.diabloProfileView.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.startPanel_ControlRemoved);
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 457);
            this.Controls.Add(this.diabloProfileView);
            this.Name = "MainFrame";
            this.Text = "Diablo Viewer";
            this.ResumeLayout(false);

        }

        #endregion

        private DiabloProfileView diabloProfileView;

    }
}

