using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TabletopGameManagementSystem.CustomControls
{
    public partial class RoundedPanel : Panel
    {

        public int _borderRadius = 20;
        public int BorderRadius
        {
            get => _borderRadius;
            set
            {
                _borderRadius = value;
                Invalidate();
            }
        }

        public RoundedPanel()
        {
            //constructor
            this.BackColor = Color.SlateGray;
            this.Size = new Size(300, 1000);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            //prevent flickering in the designer

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

  
            using (GraphicsPath path = GetRoundedPath(ClientRectangle, BorderRadius))
            {
               
                    // fill the panel background
                    using (SolidBrush brush = new SolidBrush(this.BackColor))
                        e.Graphics.FillPath(brush, path);

                    // apply rounded region
                    this.Region = new Region(path);
                

                //Region = new Region(path);
            }
        }
        private GraphicsPath GetRoundedPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int d = radius * 2;
            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }
   
    }
}
