﻿namespace DiabloViewer
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
            this.startView1 = new DiabloViewer.Views.StartView();
            this.SuspendLayout();
            // 
            // startView1
            // 
            this.startView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startView1.Location = new System.Drawing.Point(0, 0);
            this.startView1.Name = "startView1";
            this.startView1.UpdateProfile += this.UpdateDiabloProfile;
            this.startView1.Size = new System.Drawing.Size(513, 457);
            this.startView1.TabIndex = 0;
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 457);
            this.Controls.Add(this.startView1);
            this.Name = "MainFrame";
            this.Text = "Diablo Viewer";
            this.ResumeLayout(false);
            
        }

        #endregion

        private Views.StartView startView1;
       


    }
}

