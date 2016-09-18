using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Homework3.Dialogs.PreferencesDialog;

namespace Homework3 {
    public partial class PreferencesPanel : UserControl {
        public Button Accept { get { return okButton; } }
        public Button Apply { get { return applyButton; } }
        public Button Cancel { get { return cancelButton; } }
        public AppPreferences Preferences {
            get {
                return new AppPreferences {
                    RectangleHeight = int.Parse(rectangleHeightTextBox.Text),
                    RectangeRatio = float.Parse(rectangleRatioTextBox.Text),
                    EllipseWidth = int.Parse(ellipseWidthTextBox.Text),
                    EllipseRatio = float.Parse(ellipseRatioTextBox.Text)
                };
            }
        }
        public PreferencesPanel(AppPreferences Preferences) {
            InitializeComponent();

            setErrorProviderHelp();
            rectangleHeightTextBox.Text = Preferences.RectangleHeight.ToString();
            rectangleRatioTextBox.Text = Preferences.RectangeRatio.ToString();
            ellipseWidthTextBox.Text = Preferences.EllipseWidth.ToString();
            ellipseRatioTextBox.Text = Preferences.EllipseRatio.ToString();
        }

        private void setErrorProviderHelp() {
            foreach (Control control in this.Controls) {
                TextBox box = control as TextBox;
                if (box != null) {
                    preferencesInfoErrorProvider.SetError(control,
                        preferencesPanelToolTip.GetToolTip(control));
                }
            }
        }

        private void EllipseRatioTextBox_Validating(object sender, CancelEventArgs e) {
            if(PreferencesValidator.ValidateFloat(PreferencesErrorProvider,
                ellipseRatioTextBox, "The ratio is a floating type number.")
                || PreferencesValidator.ValidateFloatRange(PreferencesErrorProvider,
                ellipseRatioTextBox, "The ratio is supposed to be between 0.5 and 5.",
                0.5f, 5)) {
                e.Cancel = true;
                preferencesInfoErrorProvider.SetError(ellipseRatioTextBox, null);
            }else {
                preferencesInfoErrorProvider.SetError(ellipseRatioTextBox,
                    preferencesPanelToolTip.GetToolTip(ellipseRatioTextBox));
            }
        }

        private void EllipseWidthTextBox_Validating(object sender, CancelEventArgs e) {
            if (PreferencesValidator.ValidateInt(PreferencesErrorProvider,
                ellipseWidthTextBox, "The width is supposed to be an integer.")
                || PreferencesValidator.ValidateIntRange(PreferencesErrorProvider,
                ellipseWidthTextBox, "The width is supposed to be a value between 50 and 1000.",
                50, 1000)) {
                e.Cancel = true;
                preferencesInfoErrorProvider.SetError(ellipseWidthTextBox, null);
            } else {
                preferencesInfoErrorProvider.SetError(ellipseWidthTextBox,
                    preferencesPanelToolTip.GetToolTip(ellipseWidthTextBox));
            }
        }

        private void RectangleRatioTextBox_Validating(object sender, CancelEventArgs e) {
            if (PreferencesValidator.ValidateFloat(PreferencesErrorProvider,
                rectangleRatioTextBox, "The ratio is a floating type number.")
                || PreferencesValidator.ValidateFloatRange(PreferencesErrorProvider,
                rectangleRatioTextBox, "The ratio is supposed to be between 0.5 and 5.",
                0.5f, 5)) {
                e.Cancel = true;
                preferencesInfoErrorProvider.SetError(rectangleRatioTextBox, null);
            } else {
                preferencesInfoErrorProvider.SetError(rectangleRatioTextBox,
                    preferencesPanelToolTip.GetToolTip(rectangleRatioTextBox));
            }
        }

        private void RectangleHeightTextBox_Validating(object sender, CancelEventArgs e) {
            if (PreferencesValidator.ValidateInt(PreferencesErrorProvider,
                rectangleHeightTextBox, "The height is supposed to be an integer.")
                || PreferencesValidator.ValidateIntRange(PreferencesErrorProvider,
                rectangleHeightTextBox, "The height is supposed to be a value between 50 and 1000.",
                50, 1000)) {
                e.Cancel = true;
                preferencesInfoErrorProvider.SetError(rectangleHeightTextBox, null);
            } else {
                preferencesInfoErrorProvider.SetError(rectangleHeightTextBox,
                    preferencesPanelToolTip.GetToolTip(rectangleHeightTextBox));
            }
        }
    }
}
