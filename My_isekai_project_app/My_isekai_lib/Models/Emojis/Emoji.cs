using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_isekai_lib.Models.Emojis
{
    public abstract class Emoji
    {
        protected Point origin;
        protected int radius;
        protected Color color;

        public Emoji(Point origin, int radius)
        {
            this.origin = origin;
            this.radius = radius;
        }

        public virtual void Draw(PaintEventArgs g)
        {
            Rectangle bounds = GetBounds();

            // draw the face
            Pen myPen = new Pen(Color.Black, 3);
            g.Graphics.DrawEllipse(myPen, bounds);

            // fill the face
            SolidBrush myBrush = new SolidBrush(color);
            g.Graphics.FillEllipse(myBrush, bounds);

            // draw the body
            DrawBodyLines(g, myPen);
        }

        private Rectangle GetBounds()
        {
            int x = origin.X - radius;
            int y = origin.Y - radius;
            int width = radius * 2;
            int height = width;

            Rectangle rect = new Rectangle(x, y, width, height);
            return rect;
        }

        private void DrawBodyLines(PaintEventArgs g, Pen myPen)
        {
            Point lineStart = new Point(origin.X, origin.Y + 35);
            Point lineEnd = new Point(origin.X, origin.Y + 65);
            g.Graphics.DrawLine(myPen, lineStart, lineEnd);

            lineStart = new Point(origin.X, origin.Y + 50);
            lineEnd = new Point(origin.X + 25, origin.Y + 35);
            g.Graphics.DrawLine(myPen, lineStart, lineEnd);

            lineStart = new Point(origin.X, origin.Y + 50);
            lineEnd = new Point(origin.X - 25, origin.Y + 35);
            g.Graphics.DrawLine(myPen, lineStart, lineEnd);

            lineStart = new Point(origin.X, origin.Y + 65);
            lineEnd = new Point(origin.X - 15, origin.Y + 75);
            g.Graphics.DrawLine(myPen, lineStart, lineEnd);

            lineStart = new Point(origin.X, origin.Y + 65);
            lineEnd = new Point(origin.X + 15, origin.Y + 75);
            g.Graphics.DrawLine(myPen, lineStart, lineEnd);
        }
    }
}
