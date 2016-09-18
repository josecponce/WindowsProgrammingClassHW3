namespace Homework3.Dialogs.AboutDialog {
    partial class AboutDialog {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.SuspendLayout();
            // 
            // AboutDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Homework3.Properties.Resources.download;
            this.ClientSize = new System.Drawing.Size(407, 414);
            this.MaximumSize = new System.Drawing.Size(425, 461);
            this.MinimumSize = new System.Drawing.Size(425, 461);
            this.Name = "AboutDialog";
            this.Text = "AboutDialog";
            this.ResumeLayout(false);

        }

        #endregion
    }
}