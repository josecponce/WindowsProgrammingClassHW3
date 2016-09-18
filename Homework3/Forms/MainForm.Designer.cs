namespace Homework3 {
    partial class MainForm {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openPreferencesModallyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openPreferencesModeleslyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ellipticChildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rectangularChildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.customChildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllChildrenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesContextMenu.SuspendLayout();
            this.mainMenu.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.DropDown = this.preferencesContextMenu;
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            // 
            // preferencesContextMenu
            // 
            this.preferencesContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.preferencesContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openPreferencesModallyToolStripMenuItem,
            this.openPreferencesModeleslyToolStripMenuItem});
            this.preferencesContextMenu.Name = "preferencesContextMenu";
            this.preferencesContextMenu.Size = new System.Drawing.Size(322, 56);
            // 
            // openPreferencesModallyToolStripMenuItem
            // 
            this.openPreferencesModallyToolStripMenuItem.Name = "openPreferencesModallyToolStripMenuItem";
            this.openPreferencesModallyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.openPreferencesModallyToolStripMenuItem.Size = new System.Drawing.Size(321, 26);
            this.openPreferencesModallyToolStripMenuItem.Text = "Open Preferences Modally";
            this.openPreferencesModallyToolStripMenuItem.Click += new System.EventHandler(this.openPreferencesModallyToolStripMenuItem_Click);
            // 
            // openPreferencesModeleslyToolStripMenuItem
            // 
            this.openPreferencesModeleslyToolStripMenuItem.Name = "openPreferencesModeleslyToolStripMenuItem";
            this.openPreferencesModeleslyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.openPreferencesModeleslyToolStripMenuItem.Size = new System.Drawing.Size(321, 26);
            this.openPreferencesModeleslyToolStripMenuItem.Text = "Open Preferences Modelesly";
            this.openPreferencesModeleslyToolStripMenuItem.Click += new System.EventHandler(this.openPreferencesModeleslyToolStripMenuItem_Click);
            // 
            // mainMenu
            // 
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.preferencesToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.mainMenu.Size = new System.Drawing.Size(379, 28);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "mainMenu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ellipticChildToolStripMenuItem,
            this.rectangularChildToolStripMenuItem,
            this.customChildToolStripMenuItem,
            this.closeAllChildrenToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // ellipticChildToolStripMenuItem
            // 
            this.ellipticChildToolStripMenuItem.Name = "ellipticChildToolStripMenuItem";
            this.ellipticChildToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.ellipticChildToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.ellipticChildToolStripMenuItem.Text = "Elliptic Child";
            this.ellipticChildToolStripMenuItem.Click += new System.EventHandler(this.ellipticChildToolStripMenuItem_Click);
            // 
            // rectangularChildToolStripMenuItem
            // 
            this.rectangularChildToolStripMenuItem.Name = "rectangularChildToolStripMenuItem";
            this.rectangularChildToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.rectangularChildToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.rectangularChildToolStripMenuItem.Text = "Rectangular Child";
            this.rectangularChildToolStripMenuItem.Click += new System.EventHandler(this.rectangularChildToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 296);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(379, 25);
            this.statusStrip.TabIndex = 3;
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(88, 20);
            this.toolStripStatusLabel.Text = "No Children";
            this.toolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // customChildToolStripMenuItem
            // 
            this.customChildToolStripMenuItem.Name = "customChildToolStripMenuItem";
            this.customChildToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.customChildToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.customChildToolStripMenuItem.Text = "Custom Child";
            this.customChildToolStripMenuItem.Click += new System.EventHandler(this.customChildToolStripMenuItem_Click);
            // 
            // closeAllChildrenToolStripMenuItem
            // 
            this.closeAllChildrenToolStripMenuItem.Name = "closeAllChildrenToolStripMenuItem";
            this.closeAllChildrenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.closeAllChildrenToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.closeAllChildrenToolStripMenuItem.Text = "Close all children";
            this.closeAllChildrenToolStripMenuItem.Visible = false;
            this.closeAllChildrenToolStripMenuItem.Click += new System.EventHandler(this.closeAllChildrenToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oathToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // oathToolStripMenuItem
            // 
            this.oathToolStripMenuItem.Name = "oathToolStripMenuItem";
            this.oathToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.oathToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.oathToolStripMenuItem.Text = "Oath";
            this.oathToolStripMenuItem.Click += new System.EventHandler(this.oathToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 321);
            this.ContextMenuStrip = this.preferencesContextMenu;
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.mainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mainMenu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(127, 112);
            this.Name = "MainForm";
            this.Text = "ShapeApp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.preferencesContextMenu.ResumeLayout(false);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ellipticChildToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rectangularChildToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip preferencesContextMenu;
        private System.Windows.Forms.ToolStripMenuItem openPreferencesModallyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openPreferencesModeleslyToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem customChildToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllChildrenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oathToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

