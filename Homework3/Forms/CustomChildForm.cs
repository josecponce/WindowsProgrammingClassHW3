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

namespace Homework3.Forms {
    public partial class CustomChildForm : FormBase {
        private int width;
        private float ratio;

        public CustomChildForm(int width, float ratio) {
            InitializeComponent();
            this.width = width;
            this.ratio = ratio;
        }

        private void CustomChildForm_Load(object sender, EventArgs e) {
            Rectangle rect = new Rectangle(this.Location, new Size(
                width, (int)Math.Round(ratio * width)));
            using (GraphicsPath path = new GraphicsPath()) {
                path.AddEllipse(new Rectangle(rect.X,rect.Y + rect.Height/4,
                    rect.Width, rect.Height/2));
                path.AddRectangle(new Rectangle(rect.X + rect.Width/4, rect.Y,
                    rect.Width/2, rect.Height));
                this.Region = new Region(path);
            }
        }        
    }
}
