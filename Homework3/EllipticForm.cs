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
    public partial class EllipticForm : FormBase {
        private int width;
        private float ratio;
        public EllipticForm(int width, float ratio) {
            InitializeComponent();
            this.width = width;
            this.ratio = ratio;
        }        

        private void EllipticForm_Load(object sender, EventArgs e) {
            this.ClientSize = new Size(
                width, (int)Math.Round(ratio * width));
            setEllipseRegion();
        }

        private void EllipticForm_Resize(object sender, EventArgs e) {
            setEllipseRegion();
        }

        private void setEllipseRegion() {
            using (GraphicsPath path = new GraphicsPath()) {
                path.AddEllipse(this.ClientRectangle);
                this.Region = new Region(path);
            }
        }
    }
}
