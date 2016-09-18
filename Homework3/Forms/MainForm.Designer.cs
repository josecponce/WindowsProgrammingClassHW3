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
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openPreferencesModallyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openPreferencesModeleslyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ellipticChildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rectangularChildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesContextMenu.SuspendLayout();
            this.mainMenu.SuspendLayout();
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
            this.preferencesContextMenu.Size = new System.Drawing.Size(273, 56);
            // 
            // openPreferencesModallyToolStripMenuItem
            // 
            this.openPreferencesModallyToolStripMenuItem.Name = "openPreferencesModallyToolStripMenuItem";
            this.openPreferencesModallyToolStripMenuItem.Size = new System.Drawing.Size(272, 26);
            this.openPreferencesModallyToolStripMenuItem.Text = "Open Preferences Modally";
            this.openPreferencesModallyToolStripMenuItem.Click += new System.EventHandler(this.openPreferencesModallyToolStripMenuItem_Click);
            // 
            // openPreferencesModeleslyToolStripMenuItem
            // 
            this.openPreferencesModeleslyToolStripMenuItem.Name = "openPreferencesModeleslyToolStripMenuItem";
            this.openPreferencesModeleslyToolStripMenuItem.Size = new System.Drawing.Size(272, 26);
            this.openPreferencesModeleslyToolStripMenuItem.Text = "Open Preferences Modelesly";
            this.openPreferencesModeleslyToolStripMenuItem.Click += new System.EventHandler(this.openPreferencesModeleslyToolStripMenuItem_Click);
            // 
            // mainMenu
            // 
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.preferencesToolStripMenuItem});
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
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // ellipticChildToolStripMenuItem
            // 
            this.ellipticChildToolStripMenuItem.Name = "ellipticChildToolStripMenuItem";
            this.ellipticChildToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.ellipticChildToolStripMenuItem.Text = "Elliptic Child";
            this.ellipticChildToolStripMenuItem.Click += new System.EventHandler(this.ellipticChildToolStripMenuItem_Click);
            // 
            // rectangularChildToolStripMenuItem
            // 
            this.rectangularChildToolStripMenuItem.Name = "rectangularChildToolStripMenuItem";
            this.rectangularChildToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.rectangularChildToolStripMenuItem.Text = "Rectangular Child";
            this.rectangularChildToolStripMenuItem.Click += new System.EventHandler(this.rectangularChildToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 321);
            this.ContextMenuStrip = this.preferencesContextMenu;
            this.Controls.Add(this.mainMenu);
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
    }
}

