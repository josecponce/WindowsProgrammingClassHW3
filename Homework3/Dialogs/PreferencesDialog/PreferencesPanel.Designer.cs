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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreferencesPanel));
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
            this.preferencesPanelToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.preferencesPanelHelpProvider = new System.Windows.Forms.HelpProvider();
            this.preferencesInfoErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.preferencePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PreferencesErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preferencesInfoErrorProvider)).BeginInit();
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
            this.preferencePanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.preferencePanel.MaximumSize = new System.Drawing.Size(345, 308);
            this.preferencePanel.MinimumSize = new System.Drawing.Size(345, 308);
            this.preferencePanel.Name = "preferencePanel";
            this.preferencePanel.Size = new System.Drawing.Size(345, 308);
            this.preferencePanel.TabIndex = 0;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(237, 252);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(69, 28);
            this.cancelButton.TabIndex = 14;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // applyButton
            // 
            this.applyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.applyButton.Location = new System.Drawing.Point(135, 252);
            this.applyButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(69, 28);
            this.applyButton.TabIndex = 13;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.Location = new System.Drawing.Point(33, 252);
            this.okButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(69, 28);
            this.okButton.TabIndex = 12;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // ellipseRatioTextBox
            // 
            this.ellipseRatioTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.preferencesPanelHelpProvider.SetHelpString(this.ellipseRatioTextBox, "Please enter a decimal value between 0.5 and 5.Please enter a decimal value betwe" +
        "en 0.5 and 5.");
            this.ellipseRatioTextBox.Location = new System.Drawing.Point(173, 196);
            this.ellipseRatioTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ellipseRatioTextBox.Name = "ellipseRatioTextBox";
            this.preferencesPanelHelpProvider.SetShowHelp(this.ellipseRatioTextBox, true);
            this.ellipseRatioTextBox.Size = new System.Drawing.Size(132, 22);
            this.ellipseRatioTextBox.TabIndex = 10;
            this.preferencesPanelToolTip.SetToolTip(this.ellipseRatioTextBox, "Please enter a decimal value between 0.5 and 5.");
            this.ellipseRatioTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.EllipseRatioTextBox_Validating);
            // 
            // ellipseRatioLabel
            // 
            this.ellipseRatioLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ellipseRatioLabel.AutoSize = true;
            this.ellipseRatioLabel.Location = new System.Drawing.Point(29, 199);
            this.ellipseRatioLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ellipseRatioLabel.Name = "ellipseRatioLabel";
            this.ellipseRatioLabel.Size = new System.Drawing.Size(86, 17);
            this.ellipseRatioLabel.TabIndex = 9;
            this.ellipseRatioLabel.Text = "Ellipse Ratio";
            // 
            // ellipseWidthTextBox
            // 
            this.ellipseWidthTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.preferencesPanelHelpProvider.SetHelpString(this.ellipseWidthTextBox, "Please enter an integer between 50 and 1000.");
            this.ellipseWidthTextBox.Location = new System.Drawing.Point(173, 139);
            this.ellipseWidthTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ellipseWidthTextBox.Name = "ellipseWidthTextBox";
            this.preferencesPanelHelpProvider.SetShowHelp(this.ellipseWidthTextBox, true);
            this.ellipseWidthTextBox.Size = new System.Drawing.Size(132, 22);
            this.ellipseWidthTextBox.TabIndex = 8;
            this.preferencesPanelToolTip.SetToolTip(this.ellipseWidthTextBox, "Please enter an integer between 50 and 1000.");
            this.ellipseWidthTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.EllipseWidthTextBox_Validating);
            // 
            // ellipseWidthLabel
            // 
            this.ellipseWidthLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ellipseWidthLabel.AutoSize = true;
            this.ellipseWidthLabel.Location = new System.Drawing.Point(29, 143);
            this.ellipseWidthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ellipseWidthLabel.Name = "ellipseWidthLabel";
            this.ellipseWidthLabel.Size = new System.Drawing.Size(89, 17);
            this.ellipseWidthLabel.TabIndex = 7;
            this.ellipseWidthLabel.Text = "Ellipse Width";
            // 
            // rectangleRatioTextBox
            // 
            this.rectangleRatioTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.preferencesPanelHelpProvider.SetHelpString(this.rectangleRatioTextBox, "Please enter a decimal value between 0.5 and 5.");
            this.rectangleRatioTextBox.Location = new System.Drawing.Point(173, 86);
            this.rectangleRatioTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rectangleRatioTextBox.Name = "rectangleRatioTextBox";
            this.preferencesPanelHelpProvider.SetShowHelp(this.rectangleRatioTextBox, true);
            this.rectangleRatioTextBox.Size = new System.Drawing.Size(132, 22);
            this.rectangleRatioTextBox.TabIndex = 6;
            this.preferencesPanelToolTip.SetToolTip(this.rectangleRatioTextBox, "Please enter a decimal value between 0.5 and 5.");
            this.rectangleRatioTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.RectangleRatioTextBox_Validating);
            // 
            // rectangleRatioLabel
            // 
            this.rectangleRatioLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rectangleRatioLabel.AutoSize = true;
            this.rectangleRatioLabel.Location = new System.Drawing.Point(29, 90);
            this.rectangleRatioLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rectangleRatioLabel.Name = "rectangleRatioLabel";
            this.rectangleRatioLabel.Size = new System.Drawing.Size(109, 17);
            this.rectangleRatioLabel.TabIndex = 5;
            this.rectangleRatioLabel.Text = "Rectangle Ratio";
            // 
            // rectangleHeightTextBox
            // 
            this.rectangleHeightTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.preferencesPanelHelpProvider.SetHelpString(this.rectangleHeightTextBox, "Please enter an integer between 50 and 1000.");
            this.rectangleHeightTextBox.Location = new System.Drawing.Point(173, 32);
            this.rectangleHeightTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rectangleHeightTextBox.Name = "rectangleHeightTextBox";
            this.preferencesPanelHelpProvider.SetShowHelp(this.rectangleHeightTextBox, true);
            this.rectangleHeightTextBox.Size = new System.Drawing.Size(132, 22);
            this.rectangleHeightTextBox.TabIndex = 4;
            this.preferencesPanelToolTip.SetToolTip(this.rectangleHeightTextBox, "Please enter an integer between 50 and 1000.");
            this.rectangleHeightTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.RectangleHeightTextBox_Validating);
            // 
            // RectangleHeighLabel
            // 
            this.RectangleHeighLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.RectangleHeighLabel.AutoSize = true;
            this.RectangleHeighLabel.Location = new System.Drawing.Point(29, 36);
            this.RectangleHeighLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RectangleHeighLabel.Name = "RectangleHeighLabel";
            this.RectangleHeighLabel.Size = new System.Drawing.Size(117, 17);
            this.RectangleHeighLabel.TabIndex = 0;
            this.RectangleHeighLabel.Text = "Rectangle Height";
            // 
            // PreferencesErrorProvider
            // 
            this.PreferencesErrorProvider.ContainerControl = this;
            // 
            // preferencesInfoErrorProvider
            // 
            this.preferencesInfoErrorProvider.ContainerControl = this;
            this.preferencesInfoErrorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("preferencesInfoErrorProvider.Icon")));
            // 
            // PreferencesPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.preferencePanel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(345, 308);
            this.MinimumSize = new System.Drawing.Size(345, 308);
            this.Name = "PreferencesPanel";
            this.Size = new System.Drawing.Size(345, 308);
            this.preferencePanel.ResumeLayout(false);
            this.preferencePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PreferencesErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preferencesInfoErrorProvider)).EndInit();
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
        private System.Windows.Forms.ToolTip preferencesPanelToolTip;
        private System.Windows.Forms.HelpProvider preferencesPanelHelpProvider;
        private System.Windows.Forms.ErrorProvider preferencesInfoErrorProvider;
    }
}
