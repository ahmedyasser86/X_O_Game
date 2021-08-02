using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace X_O_Game
{
    class RoundedButton : Button
    {
        private int bSize = 0;
        private int bRedius = 50;
        private Color bColor = Color.DarkRed;
        private Color OnHoverColor = Color.LightGray;
        private Color BaseColor = Color.White;

        [Category("Bika Setting")]
        public int BSize { get => bSize; set { bSize = value; this.Invalidate(); }  }
        [Category("Bika Setting")]
        public int BRedius { get => bRedius; set { bRedius = value; this.Invalidate(); } }
        [Category("Bika Setting")]
        public Color BColor { get => bColor; set { bColor = value; this.Invalidate(); } }
        [Category("Bika Setting")]
        public Color BackgroundColor
        {
            get { return this.BackColor; }
            set { this.BackColor = value; }
        }
        [Category("Bika Setting")]
        public Color OnHoverColor1 { get => OnHoverColor; set { OnHoverColor = value; this.Invalidate(); } }
        [Category("Bika Setting")]
        public Color ReturnHoverColor { get => BaseColor; set { BaseColor = value; this.Invalidate(); } }
        [Category("Bika Setting")]
        public Color TextColor
        {
            get { return this.ForeColor; }
            set { this.ForeColor = value; }
        }

        public RoundedButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(150, 40);
            this.BackColor = Color.White;
            this.ForeColor = Color.Black;
        }

        private GraphicsPath GetFigurePath(RectangleF rec, float reduis)
        {

            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rec.X, rec.Y, reduis, reduis, 180, 90);
            path.AddArc(rec.Width - reduis, rec.Y, reduis, reduis, 270, 90);
            path.AddArc(rec.Width - reduis, rec.Height - reduis, reduis, reduis, 0, 90);
            path.AddArc(rec.X, rec.Height - reduis, reduis, reduis, 90, 90);
            path.CloseFigure();

            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            RectangleF recsource = new RectangleF(0, 0, this.Width, this.Height);
            RectangleF recborder = new RectangleF(0, 0, this.Width - 0.8f, this.Height - 1);

            if(bRedius > 2) // rounded
            {
                using (GraphicsPath pathsource = GetFigurePath(recsource, bRedius))
                using (GraphicsPath pathborder = GetFigurePath(recborder,bRedius-1f))
                using (Pen pensource = new Pen(this.Parent.BackColor,2))
                using (Pen penborder = new Pen(bColor, bSize))
                {
                    penborder.Alignment = PenAlignment.Inset;
                    this.Region = new Region(pathsource);

                    // Draw Serfus
                    pevent.Graphics.DrawPath(pensource, pathsource);

                    // Draw Border
                    if (bSize >= 1) pevent.Graphics.DrawPath(penborder, pathborder);
                }
            }

            else // normal
            {
                this.Region = new Region(recsource);

                if(bSize >= 1)
                {
                    using (Pen penborder = new Pen(bColor, bSize))
                    {
                        penborder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penborder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }
        }

        protected override void OnMouseHover(EventArgs e)
        {
            this.BackColor = OnHoverColor;
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            this.BackColor = BaseColor;
        }
    }
}
