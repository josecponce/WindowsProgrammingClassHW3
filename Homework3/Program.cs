using Homework3.Dialogs.LoginDialog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework3 {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DialogResult result = DialogResult.None;
            using (var loginDialog = new LoginDialog()) {
                result = loginDialog.ShowDialog();
            }            
            if (result == DialogResult.Yes) {
                Application.Run(new MainForm());
            }            
        }
    }
}
