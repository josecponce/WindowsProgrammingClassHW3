using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework3 {
    public interface IPreferenceProvider {
        event EventHandler NewPreferences;
        AppPreferences Preferences { get; set; }
        void retrievePreferences(Form owner, AppPreferences current,
            bool blocking);
    }
}
