using Homework3.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3 {
    public class AppPreferences {
        public int EllipseWidth { get; set; }
        public int RectangleHeight { get; set; }
        public float EllipseRatio { get; set; }
        public float RectangeRatio { get; set; }

        public static AppPreferences CreateFromSettings() {
            return new AppPreferences {
                EllipseWidth = Settings.Default.EllipseWidth,
                EllipseRatio = Settings.Default.EllipseRatio,
                RectangleHeight = Settings.Default.RectangleHeight,
                RectangeRatio = Settings.Default.RectangleRatio
            };
        }

        public void Save() {
            Settings.Default.EllipseWidth = EllipseWidth;
            Settings.Default.EllipseRatio = EllipseRatio;
            Settings.Default.RectangleHeight = RectangleHeight;
            Settings.Default.RectangleRatio = RectangeRatio;
            Settings.Default.Save();
        }
    }
}
