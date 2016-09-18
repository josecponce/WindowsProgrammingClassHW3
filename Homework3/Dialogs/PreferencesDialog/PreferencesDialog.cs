using Homework3ControlLib;
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
    public partial class PreferencesDialog : DialogBase {
        private static PreferencesDialog instance;        

        private PreferencesPanel prefsPanel;
        public event EventHandler Apply;
        public AppPreferences Preferences => prefsPanel.Preferences;

        public static PreferencesDialog GetDialog(AppPreferences preferences) {
            if (instance == null) {
                instance = new PreferencesDialog(preferences);
            }
            return instance;
        }
        private PreferencesDialog(AppPreferences Preferences) : base(){
            InitializeComponent();
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            prefsPanel = new PreferencesPanel(Preferences);                        
            prefsPanel.Apply.Click += Apply_Click;
            prefsPanel.Accept.Click += Accept_Click;
            prefsPanel.Cancel.Click += Cancel_Click;

            this.AcceptButton = prefsPanel.Accept;
            this.CancelButton = prefsPanel.Cancel;

            ContentPanel.MinimumSize = prefsPanel.Size;
            ContentPanel.Controls.Add(prefsPanel);
        }

        private void Cancel_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Accept_Click(object sender, EventArgs e) {
            if (ValidateChildren()) {
                this.DialogResult = DialogResult.OK;
                Apply.Invoke(this, new EventArgs());
                this.Close();
            }            
        }

        private void Apply_Click(object sender, EventArgs e) {
            if (ValidateChildren()) {
                Apply.Invoke(this, new EventArgs());
            }
        }

        private void PreferencesDialog_Resize(object sender, EventArgs e) {
            prefsPanel.Location = new Point(
                (ContentPanel.Width - prefsPanel.Width)/2,
                (ContentPanel.Height - prefsPanel.Height) / 2);
        }

        private void PreferencesDialog_Load(object sender, EventArgs e) {
            prefsPanel.Location = new Point(
                (ContentPanel.Width - prefsPanel.Width) / 2,
                (ContentPanel.Height - prefsPanel.Height) / 2);
            if (Modal) {
                prefsPanel.Apply.Visible = false;
            }
        }

        private void PreferencesDialog_FormClosed(object sender, FormClosedEventArgs e) {
            instance = null;
        }
    }
}
