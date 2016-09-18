using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            rectangleHeightTextBox.Text = Preferences.RectangleHeight.ToString();
            rectangleRatioTextBox.Text = Preferences.RectangeRatio.ToString();
            ellipseWidthTextBox.Text = Preferences.EllipseWidth.ToString();
            ellipseRatioTextBox.Text = Preferences.EllipseRatio.ToString();

            rectangleHeightTextBox.Validating += RectangleHeightTextBox_Validating;
            rectangleRatioTextBox.Validating += RectangleRatioTextBox_Validating;
            ellipseWidthTextBox.Validating += EllipseWidthTextBox_Validating;
            ellipseRatioTextBox.Validating += EllipseRatioTextBox_Validating;
        }

        private void EllipseRatioTextBox_Validating(object sender, CancelEventArgs e) {
            float ratio;            
            if (!float.TryParse(ellipseRatioTextBox.Text, out ratio)) {
                e.Cancel = true;
                PreferencesErrorProvider.SetError(ellipseRatioTextBox,
                    "The ratio is a floating type number.");
                return;
            }
            if (ratio < 0.5 || ratio > 5) {
                e.Cancel = true;
                PreferencesErrorProvider.SetError(ellipseRatioTextBox,
                    "The ratio is supposed to be between 0.5 and 5.");
            }
        }

        private void EllipseWidthTextBox_Validating(object sender, CancelEventArgs e) {
            int width;
            if (!int.TryParse(ellipseWidthTextBox.Text, out width)) {
                e.Cancel = true;
                PreferencesErrorProvider.SetError(ellipseWidthTextBox,
                    "The width is supposed to be an integer.");
                return;
            }
            if (width < 50 || width > 1000) {
                e.Cancel = true;
                PreferencesErrorProvider.SetError(ellipseWidthTextBox,
                    "The width is supposed to be a value between 50 and 1000.");
            }
        }

        private void RectangleRatioTextBox_Validating(object sender, CancelEventArgs e) {
            float ratio;
            if (!float.TryParse(rectangleRatioTextBox.Text, out ratio)) {
                e.Cancel = true;
                PreferencesErrorProvider.SetError(rectangleRatioTextBox,
                    "The ratio is a floating type number.");
                return;
            }
            if (ratio < 0.5 || ratio > 5) {
                e.Cancel = true;
                PreferencesErrorProvider.SetError(rectangleRatioTextBox,
                    "The ratio is supposed to be between 0.5 and 5.");
            }
        }

        private void RectangleHeightTextBox_Validating(object sender, CancelEventArgs e) {
            int height;
            if (!int.TryParse(rectangleHeightTextBox.Text, out height)) {
                e.Cancel = true;
                PreferencesErrorProvider.SetError(rectangleHeightTextBox,
                    "The height is supposed to be an integer.");
                return;
            }
            if (height < 50 || height > 1000) {
                e.Cancel = true;
                PreferencesErrorProvider.SetError(rectangleHeightTextBox,
                    "The height is supposed to be a value between 50 and 1000.");
            }
        }
    }
}
