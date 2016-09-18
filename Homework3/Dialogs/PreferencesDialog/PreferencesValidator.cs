using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework3.Dialogs.PreferencesDialog {
    public static class PreferencesValidator {

        public static bool ValidateInt(ErrorProvider ep, Control control,
            string message) {
            int integer;
            bool result = true;
            if (!int.TryParse(control.Text, out integer)) {
                result = false;
                ep.SetError(control,message);                
            }
            return result;
        }
        public static bool ValidateFloat(ErrorProvider ep, Control control,
            string message) {
            float number;
            bool result = true;
            if (!float.TryParse(control.Text, out number)) {
                result = false;
                ep.SetError(control, message);
            }
            return result;
        }
        public static bool ValidateIntRange(ErrorProvider ep, Control control,
            string message, int low, int high) {
            int integer = int.Parse(control.Text);
            bool result = true;                        
            if (integer < low || integer > high) {
                result = false;
                ep.SetError(control, message);
            }
            return result;
        }
        public static bool ValidateFloatRange(ErrorProvider ep, Control control,
            string message, float low, float high) {
            float number = float.Parse(control.Text);
            bool result = true;
            if (number < low || number > high) {
                result = false;
                ep.SetError(control, message);
            }
            return result;
        }
    }
}
