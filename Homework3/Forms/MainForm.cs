using Homework3.Dialogs.AboutDialog;
using Homework3.Dialogs.OathDialog;
using Homework3.Forms;
using Homework3ControlLib;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework3 {
    public partial class MainForm : Form {
        private IUnityContainer container;
        private IPreferenceProvider preferenceProvider;
        private AppPreferences preferences;
        private List<FormBase> openChildren = new List<FormBase>();
        private AboutDialog aboutDialog;

        public MainForm() {
            InitializeComponent();
            container = UnityConfig.RegisterInstances();            
            preferences = AppPreferences.CreateFromSettings();
            preferenceProvider = container.Resolve<IPreferenceProvider>();
            preferenceProvider.NewPreferences += PreferenceProvider_NewPreferences;
        }

        private void PreferenceProvider_NewPreferences(object sender, EventArgs e) {
            preferences = preferenceProvider.Preferences;
            preferences.Save();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void ellipticChildToolStripMenuItem_Click(object sender, EventArgs e) {
            EllipticForm form = new EllipticForm(preferences.EllipseWidth, 
                preferences.EllipseRatio);
            showChild(form);
        }

        private void rectangularChildToolStripMenuItem_Click(object sender, EventArgs e) {
            RectangularForm form = new RectangularForm(
                preferences.RectangleHeight, preferences.RectangeRatio);
            showChild(form);
        }
        private void customChildToolStripMenuItem_Click(object sender, EventArgs e) {
            CustomChildForm form = new CustomChildForm(
                preferences.RectangleHeight, preferences.RectangeRatio);
            showChild(form);
        }
        private void showChild(FormBase child) {
            child.MdiParent = this;
            child.GotFocus += Form_GotFocus;
            child.BackColorChanged += Form_GotFocus;
            child.FormClosed += Child_FormClosed;
            child.Show();
            openChildren.Add(child);
            closeAllChildrenToolStripMenuItem.Visible = true;
        }

        private void Child_FormClosed(object sender, FormClosedEventArgs e) {
            FormBase child = sender as FormBase;
            openChildren.Remove(child);
            if (openChildren.Count == 0) {
                closeAllChildrenToolStripMenuItem.Visible = false;
            }
        }
        private void closeAllChildrenToolStripMenuItem_Click(object sender, EventArgs e) {
            while(openChildren.Count > 0) {
                openChildren[0].Close();
            }
            closeAllChildrenToolStripMenuItem.Visible = false;
        }

        private void Form_GotFocus(object sender, EventArgs e) {
            var rect = sender as RectangularForm;
            if (rect != null) {
                toolStripStatusLabel.Text = $"Rectangle {rect.BackColor.Name}";
                return;
            }
            var ell = sender as EllipticForm;
            if (ell != null) {
                toolStripStatusLabel.Text = $"Ellipse {ell.BackColor.Name}";
                return;
            }
            var custom = sender as CustomChildForm;
            toolStripStatusLabel.Text = $"Custom {custom.BackColor.Name}";
        }

        private void openPreferencesModallyToolStripMenuItem_Click(object sender, EventArgs e) {
            preferenceProvider.retrievePreferences(this, preferences,
                true);
        }

        private void openPreferencesModeleslyToolStripMenuItem_Click(object sender, EventArgs e) {
            preferenceProvider.retrievePreferences(this, preferences,
                false);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
            DialogResult result = MessageBox.Show("Are you sure you want to quit?", 
                "Exit Now?", MessageBoxButtons.OKCancel);
            if (result == DialogResult.Cancel) {
                e.Cancel = true;
            }
        }

        private void oathToolStripMenuItem_Click(object sender, EventArgs e) {
            using (var dialog = new OathDialog()) {
                dialog.StartPosition = FormStartPosition.Manual;
                dialog.Location = new Point(this.Location.X + this.Width,
                    this.Location.Y);
                dialog.ShowDialog();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
            if (aboutDialog != null) {
                return;
            }
            aboutDialog = new AboutDialog();
            aboutDialog.StartPosition = FormStartPosition.Manual;
            aboutDialog.Location = new Point(this.Location.X,
                this.Location.Y + this.Height);
            aboutDialog.FormClosed += AboutDialog_FormClosed;
            aboutDialog.Show();
        }

        private void AboutDialog_FormClosed(object sender, FormClosedEventArgs e) {
            aboutDialog = null;
        }
    }
}
