using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;
using System.ComponentModel;

namespace FKM_2022.selfmadecomp
{
    class RoundBtn : Button
    {
        private int borderSize = 0;
        private int borderRadius = 40;
        private Color borderColor = Color.Black;
        [Category("advancedmadebyme")]
        public int BorderSize
        {
            get { return borderSize; }
            set { borderSize = value; 
                this.Invalidate();
            }
        }
        [Category("advancedmadebyme")]
        public int BorderRadius
        {
            get { return borderRadius; }
            set { borderRadius = value;
                this.Invalidate();
            }
        }
        [Category("advancedmadebyme")]
        private Color BorderColor
        {
            get { return borderColor; }
            set { borderColor = value;
                this.Invalidate();
            }
        }
        [Category ("advancedmadebyme")]
        public Color BackgroudColor
        {
            get {
                return this.BackColor;
            }
            set{
                this.BackColor = value;
            }
        }
        [Category("advancedmadebyme")]
        public  Color TextColor
        {
            get
            {
                return this.ForeColor;
            }
            set
            {
                this.ForeColor = value;
            }
        }
        

         public RoundBtn()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new System.Drawing.Size(150, 40);
            this.BackColor = Color.MediumSlateBlue;
            this.ForeColor = Color.White;
        }
        private GraphicsPath GetFiguirePath (RectangleF rect ,float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, radius,radius, 180, 90);
            path.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius, rect.Height-radius, radius,radius, 0, 90);
            path.AddArc(rect.X ,  rect.Height- radius, radius, radius, 90, 90);
            path.CloseFigure();
            return path;
        }
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            RectangleF recSurface= new RectangleF(0,0,this.Width, this.Height);
            RectangleF recBorder = new RectangleF(1,1, this.Width-0.8F, this.Height-1);
            if(borderRadius > 2)
            {
                using (GraphicsPath pathSurface = GetFiguirePath(recSurface, borderRadius))
                using (GraphicsPath pathBoRDER = GetFiguirePath(recBorder, borderRadius - 1F))
                using (Pen penSurface = new Pen(this.Parent.BackColor, 2))
                using (Pen penBorder = new Pen(borderColor, borderSize))

                {
                    penBorder.Alignment = PenAlignment.Inset;
                    this.Region = new Region(pathSurface);
                    pevent.Graphics.DrawPath(penSurface, pathSurface);
                    if(borderSize >= 1)
                    {
                        pevent.Graphics.DrawPath(penBorder, pathBoRDER);
                    }
                }
            }
            else
            {
                this.Region = new Region(recSurface);
                if(borderSize >= 1)
                {
                    using(Pen penBorder = new Pen(borderColor, borderSize))
                    {
                        penBorder.Alignment= PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder, 0,0,this.Width-1,this.Height-1);
                    }

                }
            }
        }
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Container_backColorChanged);
        }
        private void Container_backColorChanged(object sender , EventArgs e)
        {
            if (this.DesignMode)
            {
                this.Invalidate();
            }
        }
    }
    
}
