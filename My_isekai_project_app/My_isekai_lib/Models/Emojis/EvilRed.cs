using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_isekai_lib.Models.Emojis
{
    public class EvilRed : Emoji
    {
        public EvilRed(Point origin, int radius) : base(origin, radius)
        {
            color = Color.Crimson;
        }

        public override void Draw(PaintEventArgs g)
        {
            base.Draw(g);

            //    Rectangle bounds = new Rectangle(origin.X - 23, origin.Y - 25, 45, 45);

            Pen myPen = new Pen(Color.Black, 3);
            Point p1 = new Point(origin.X - 10, origin.Y + 15);
            Point p2 = new Point(origin.X - 10, origin.Y + 20);
            Point p3 = new Point(origin.X + 10, origin.Y + 20);
            Point p4 = new Point(origin.X + 10, origin.Y + 15);
            Point[] p = { p1, p2, p3, p4 };
            g.Graphics.DrawClosedCurve(myPen, p);

            myPen = new Pen(Color.Purple, 2);
            p1 = new Point(origin.X + 12, origin.Y - 28);
            p2 = new Point(origin.X + 16, origin.Y - 15);
            p3 = new Point(origin.X + 20, origin.Y - 5);
            p4 = new Point(origin.X + 5, origin.Y + 5);
            g.Graphics.DrawBezier(myPen, p1, p2, p3, p4);

            Brush myBrush = new SolidBrush(Color.Black);
            g.Graphics.FillEllipse(myBrush, new Rectangle(origin.X - 18, origin.Y - 25, 16, 10));

            myPen = new Pen(Color.Black, 2);
            Point lineStart = new Point(origin.X + 20, origin.Y - 18);
            Point lineEnd = new Point(origin.X + 5, origin.Y - 18);
            g.Graphics.DrawLine(myPen, lineStart, lineEnd);

            new Pen(Color.Black, 2);
            lineStart = new Point(origin.X, origin.Y - 30);
            lineEnd = new Point(origin.X, origin.Y - 70);
            g.Graphics.DrawLine(myPen, lineStart, lineEnd);

            lineStart = new Point(origin.X, origin.Y - 30);
            lineEnd = new Point(origin.X + 5, origin.Y - 60);
            g.Graphics.DrawLine(myPen, lineStart, lineEnd);

            lineStart = new Point(origin.X, origin.Y - 30);
            lineEnd = new Point(origin.X - 5, origin.Y - 60);
            g.Graphics.DrawLine(myPen, lineStart, lineEnd);

            lineStart = new Point(origin.X, origin.Y - 30);
            lineEnd = new Point(origin.X + 15, origin.Y - 50);
            g.Graphics.DrawLine(myPen, lineStart, lineEnd);

            lineStart = new Point(origin.X, origin.Y - 30);
            lineEnd = new Point(origin.X - 15, origin.Y - 50);
            g.Graphics.DrawLine(myPen, lineStart, lineEnd);
        }
    }
}
