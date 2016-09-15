namespace Homework3 {
    partial class PreferencesPanel {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.preferencePanel = new System.Windows.Forms.Panel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.applyButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.ellipseRatioTextBox = new System.Windows.Forms.TextBox();
            this.ellipseRatioLabel = new System.Windows.Forms.Label();
            this.ellipseWidthTextBox = new System.Windows.Forms.TextBox();
            this.ellipseWidthLabel = new System.Windows.Forms.Label();
            this.rectangleRatioTextBox = new System.Windows.Forms.TextBox();
            this.rectangleRatioLabel = new System.Windows.Forms.Label();
            this.rectangleHeightTextBox = new System.Windows.Forms.TextBox();
            this.RectangleHeighLabel = new System.Windows.Forms.Label();
            this.PreferencesErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.preferencePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PreferencesErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // preferencePanel
            // 
            this.preferencePanel.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.preferencePanel.Controls.Add(this.cancelButton);
            this.preferencePanel.Controls.Add(this.applyButton);
            this.preferencePanel.Controls.Add(this.okButton);
            this.preferencePanel.Controls.Add(this.ellipseRatioTextBox);
            this.preferencePanel.Controls.Add(this.ellipseRatioLabel);
            this.preferencePanel.Controls.Add(this.ellipseWidthTextBox);
            this.preferencePanel.Controls.Add(this.ellipseWidthLabel);
            this.preferencePanel.Controls.Add(this.rectangleRatioTextBox);
            this.preferencePanel.Controls.Add(this.rectangleRatioLabel);
            this.preferencePanel.Controls.Add(this.rectangleHeightTextBox);
            this.preferencePanel.Controls.Add(this.RectangleHeighLabel);
            this.preferencePanel.Location = new System.Drawing.Point(0, 0);
            this.preferencePanel.MaximumSize = new System.Drawing.Size(259, 250);
            this.preferencePanel.MinimumSize = new System.Drawing.Size(259, 250);
            this.preferencePanel.Name = "preferencePanel";
            this.preferencePanel.Size = new System.Drawing.Size(259, 250);
            this.preferencePanel.TabIndex = 0;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(178, 205);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(52, 23);
            this.cancelButton.TabIndex = 14;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // applyButton
            // 
            this.applyButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.applyButton.Location = new System.Drawing.Point(101, 205);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(52, 23);
            this.applyButton.TabIndex = 13;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.okButton.Location = new System.Drawing.Point(25, 205);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(52, 23);
            this.okButton.TabIndex = 12;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // ellipseRatioTextBox
            // 
            this.ellipseRatioTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ellipseRatioTextBox.Location = new System.Drawing.Point(130, 159);
            this.ellipseRatioTextBox.Name = "ellipseRatioTextBox";
            this.ellipseRatioTextBox.Size = new System.Drawing.Size(100, 20);
            this.ellipseRatioTextBox.TabIndex = 10;
            // 
            // ellipseRatioLabel
            // 
            this.ellipseRatioLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ellipseRatioLabel.AutoSize = true;
            this.ellipseRatioLabel.Location = new System.Drawing.Point(22, 162);
            this.ellipseRatioLabel.Name = "ellipseRatioLabel";
            this.ellipseRatioLabel.Size = new System.Drawing.Size(65, 13);
            this.ellipseRatioLabel.TabIndex = 9;
            this.ellipseRatioLabel.Text = "Ellipse Ratio";
            // 
            // ellipseWidthTextBox
            // 
            this.ellipseWidthTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ellipseWidthTextBox.Location = new System.Drawing.Point(130, 113);
            this.ellipseWidthTextBox.Name = "ellipseWidthTextBox";
            this.ellipseWidthTextBox.Size = new System.Drawing.Size(100, 20);
            this.ellipseWidthTextBox.TabIndex = 8;
            // 
            // ellipseWidthLabel
            // 
            this.ellipseWidthLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ellipseWidthLabel.AutoSize = true;
            this.ellipseWidthLabel.Location = new System.Drawing.Point(22, 116);
            this.ellipseWidthLabel.Name = "ellipseWidthLabel";
            this.ellipseWidthLabel.Size = new System.Drawing.Size(68, 13);
            this.ellipseWidthLabel.TabIndex = 7;
            this.ellipseWidthLabel.Text = "Ellipse Width";
            // 
            // rectangleRatioTextBox
            // 
            this.rectangleRatioTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rectangleRatioTextBox.Location = new System.Drawing.Point(130, 70);
            this.rectangleRatioTextBox.Name = "rectangleRatioTextBox";
            this.rectangleRatioTextBox.Size = new System.Drawing.Size(100, 20);
            this.rectangleRatioTextBox.TabIndex = 6;
            // 
            // rectangleRatioLabel
            // 
            this.rectangleRatioLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rectangleRatioLabel.AutoSize = true;
            this.rectangleRatioLabel.Location = new System.Drawing.Point(22, 73);
            this.rectangleRatioLabel.Name = "rectangleRatioLabel";
            this.rectangleRatioLabel.Size = new System.Drawing.Size(84, 13);
            this.rectangleRatioLabel.TabIndex = 5;
            this.rectangleRatioLabel.Text = "Rectangle Ratio";
            // 
            // rectangleHeightTextBox
            // 
            this.rectangleHeightTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rectangleHeightTextBox.Location = new System.Drawing.Point(130, 26);
            this.rectangleHeightTextBox.Name = "rectangleHeightTextBox";
            this.rectangleHeightTextBox.Size = new System.Drawing.Size(100, 20);
            this.rectangleHeightTextBox.TabIndex = 4;
            // 
            // RectangleHeighLabel
            // 
            this.RectangleHeighLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.RectangleHeighLabel.AutoSize = true;
            this.RectangleHeighLabel.Location = new System.Drawing.Point(22, 29);
            this.RectangleHeighLabel.Name = "RectangleHeighLabel";
            this.RectangleHeighLabel.Size = new System.Drawing.Size(90, 13);
            this.RectangleHeighLabel.TabIndex = 0;
            this.RectangleHeighLabel.Text = "Rectangle Height";
            // 
            // PreferencesErrorProvider
            // 
            this.PreferencesErrorProvider.ContainerControl = this;
            // 
            // PreferencesPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.preferencePanel);
            this.MaximumSize = new System.Drawing.Size(259, 250);
            this.MinimumSize = new System.Drawing.Size(259, 250);
            this.Name = "PreferencesPanel";
            this.Size = new System.Drawing.Size(259, 250);
            this.preferencePanel.ResumeLayout(false);
            this.preferencePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PreferencesErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel preferencePanel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.TextBox ellipseRatioTextBox;
        private System.Windows.Forms.Label ellipseRatioLabel;
        private System.Windows.Forms.TextBox ellipseWidthTextBox;
        private System.Windows.Forms.Label ellipseWidthLabel;
        private System.Windows.Forms.TextBox rectangleRatioTextBox;
        private System.Windows.Forms.Label rectangleRatioLabel;
        private System.Windows.Forms.TextBox rectangleHeightTextBox;
        private System.Windows.Forms.Label RectangleHeighLabel;
        private System.Windows.Forms.ErrorProvider PreferencesErrorProvider;
    }
}
