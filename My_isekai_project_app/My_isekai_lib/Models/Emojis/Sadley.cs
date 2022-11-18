using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_isekai_lib.Models.Emojis
{
    public class Sadley : Emoji
    {
        public Sadley(Point origin, int radius) : base(origin, radius)
        {
            color = Color.LightBlue;
        }

        public override void Draw(PaintEventArgs g)
        {
            base.Draw(g);

            Rectangle bounds = new Rectangle(origin.X - 22, origin.Y, 45, 45);
            Pen myPen = new Pen(Color.Black, 3);
            g.Graphics.DrawArc(myPen, bounds, 0, -180);

            Brush myBrush = new SolidBrush(Color.GhostWhite);
            g.Graphics.FillEllipse(myBrush, new Rectangle(origin.X - 18, origin.Y - 25, 16, 10));
            g.Graphics.FillEllipse(myBrush, new Rectangle(origin.X + 5, origin.Y - 25, 16, 10));

            myPen = new Pen(Color.GhostWhite, 3);
            Point lineStart = new Point(origin.X - 10, origin.Y - 20);
            Point lineEnd = new Point(origin.X - 10, origin.Y - 5);
            g.Graphics.DrawLine(myPen, lineStart, lineEnd);
        }
    }
}
