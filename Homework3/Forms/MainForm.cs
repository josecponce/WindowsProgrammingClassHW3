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
            form.MdiParent = this;            
            form.Show();
        }

        private void rectangularChildToolStripMenuItem_Click(object sender, EventArgs e) {
            RectangularForm form = new RectangularForm(
                preferences.RectangleHeight, preferences.RectangeRatio);
            form.MdiParent = this;
            form.Show();
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
    }
}
