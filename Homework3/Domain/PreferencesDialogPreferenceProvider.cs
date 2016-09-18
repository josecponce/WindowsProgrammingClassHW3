using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework3 {
    public class PreferencesDialogPreferenceProvider : IPreferenceProvider {
        public event EventHandler NewPreferences;
        public AppPreferences Preferences { get; set; }
        private PreferencesDialog dialog;

        public void retrievePreferences(Form owner, AppPreferences current,
            bool blocking) {
            var newDialog = PreferencesDialog.GetDialog(current);
            if (newDialog == dialog) {
                return;//do not open another dialog
            }
            dialog = newDialog;
            dialog.Apply += Dialog_Apply;
            if (blocking) {
                DialogResult result = dialog.ShowDialog(owner);
                dialog.Dispose();
            } else {         
                dialog.Show(owner);
            }
        }

        private void Dialog_Apply(object sender, EventArgs e) {
            Preferences = (sender as PreferencesDialog).Preferences;
            NewPreferences.Invoke(this, new EventArgs());
        }
    }
}
