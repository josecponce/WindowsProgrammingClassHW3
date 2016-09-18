namespace Homework3.Dialogs.LoginDialog {
    partial class LoginDialog {
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
            this.label1 = new System.Windows.Forms.Label();
            this.yesButton = new System.Windows.Forms.Button();
            this.noButton = new System.Windows.Forms.Button();
            this.dontShowAgainCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(456, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "A \"ReplaceUserException\" has been thrown.\r\nContinue launching the application at " +
    "your own risk?";
            // 
            // yesButton
            // 
            this.yesButton.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.yesButton.Location = new System.Drawing.Point(12, 103);
            this.yesButton.Name = "yesButton";
            this.yesButton.Size = new System.Drawing.Size(80, 27);
            this.yesButton.TabIndex = 1;
            this.yesButton.Text = "yes";
            this.yesButton.UseVisualStyleBackColor = true;
            this.yesButton.Click += new System.EventHandler(this.yesButton_Click);
            // 
            // noButton
            // 
            this.noButton.DialogResult = System.Windows.Forms.DialogResult.No;
            this.noButton.Location = new System.Drawing.Point(364, 103);
            this.noButton.Name = "noButton";
            this.noButton.Size = new System.Drawing.Size(80, 27);
            this.noButton.TabIndex = 2;
            this.noButton.Text = "no";
            this.noButton.UseVisualStyleBackColor = true;
            this.noButton.Click += new System.EventHandler(this.noButton_Click);
            // 
            // dontShowAgainCheckBox
            // 
            this.dontShowAgainCheckBox.AutoSize = true;
            this.dontShowAgainCheckBox.Location = new System.Drawing.Point(12, 64);
            this.dontShowAgainCheckBox.Name = "dontShowAgainCheckBox";
            this.dontShowAgainCheckBox.Size = new System.Drawing.Size(225, 21);
            this.dontShowAgainCheckBox.TabIndex = 3;
            this.dontShowAgainCheckBox.Text = "Don\'t show this message again";
            this.dontShowAgainCheckBox.UseVisualStyleBackColor = true;
            this.dontShowAgainCheckBox.CheckedChanged += new System.EventHandler(this.dontShowAgainCheckBox_CheckedChanged);
            // 
            // LoginDialog
            // 
            this.AcceptButton = this.yesButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.noButton;
            this.ClientSize = new System.Drawing.Size(456, 142);
            this.ControlBox = false;
            this.Controls.Add(this.dontShowAgainCheckBox);
            this.Controls.Add(this.noButton);
            this.Controls.Add(this.yesButton);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(474, 189);
            this.MinimumSize = new System.Drawing.Size(474, 189);
            this.Name = "LoginDialog";
            this.ShowIcon = false;
            this.Text = "LoginDialog";
            this.Shown += new System.EventHandler(this.LoginDialog_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button yesButton;
        private System.Windows.Forms.Button noButton;
        private System.Windows.Forms.CheckBox dontShowAgainCheckBox;
    }
}