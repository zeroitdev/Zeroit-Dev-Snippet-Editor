using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zeroit.Framework.SnippetEditors
{
    public class ExtensiblePanel : ContainerControl
    {

        private Color border = Color.FromArgb(50,Color.Gray);

        public Color Border
        {
            get { return border; }
            set
            {
                border = value;
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            g.DrawRectangle(new Pen(Border), new Rectangle(0,0,this.Width-1, this.Height-1));
        }
    }
}
