using Homework3.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework3.Dialogs.LoginDialog {
    public partial class LoginDialog : Form {
        public bool SkipConfirmation {
            get {
                return Settings.Default.SkipConfirmation;
            }
            set {
                Settings.Default.SkipConfirmation = value;
                Settings.Default.Save();
            }
        }
        public LoginDialog() {
            InitializeComponent();
        }

        private void yesButton_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void noButton_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void dontShowAgainCheckBox_CheckedChanged(object sender, EventArgs e) {
            var box = sender as CheckBox;
            SkipConfirmation = box.Checked;
        }

        private void LoginDialog_Shown(object sender, EventArgs e) {
            if (SkipConfirmation) {
                this.DialogResult = DialogResult.Yes;            
                this.Close();
            }            
        }
    }
}
