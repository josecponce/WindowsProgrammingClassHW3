using Homework3ControlLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework3 {
    public partial class RectangularForm : FormBase {
        private int height;
        private float ratio;
        public RectangularForm(int height, float ratio) {
            InitializeComponent();
            this.height = height;
            this.ratio = ratio;
        }

        private void RectangularForm_Resize(object sender, EventArgs e) {
            setRectangleRegion();
        }

        private void RectangularForm_Load(object sender, EventArgs e) {
            this.ClientSize = new Size(
                (int)Math.Round(height * ratio),height);
            setRectangleRegion();
        }

        private void setRectangleRegion() {
            using (GraphicsPath path = new GraphicsPath()) {
                path.AddRectangle(this.ClientRectangle);
                this.Region = new Region(path);
            }
        }
    }
}
