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

namespace Homework3.Dialogs.OathDialog {
    public partial class OathDialog : DialogBase {
        public OathUserControl OathControl { get; set; }
        public OathDialog() {
            InitializeComponent();
            OathControl = new OathUserControl();
            ContentPanel.Controls.Add(OathControl);
        }

        private void OathDialog_Load(object sender, EventArgs e) {
            OathControl.Location = new Point(
                (ContentPanel.Width - OathControl.Width) / 2,
                (ContentPanel.Height - OathControl.Height) / 2);
        }
    }
}
