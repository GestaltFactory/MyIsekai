using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_isekai_lib.Models.Emojis
{
    public class Neutrey : Emoji
    {
        public Neutrey(Point origin, int radius) : base(origin, radius)
        {
            color = Color.LightGreen;
        }

        public override void Draw(PaintEventArgs g)
        {
            base.Draw(g);

            Pen myPen = new Pen(Color.Black, 3);
            Point lineStart = new Point(origin.X - 20, origin.Y + 20);
            Point lineEnd = new Point(origin.X + 20, origin.Y + 20);
            g.Graphics.DrawLine(myPen, lineStart, lineEnd);

            Brush myBrush = new SolidBrush(Color.Blue);
            g.Graphics.FillEllipse(myBrush, new Rectangle(origin.X - 18, origin.Y - 10, 8, 8));
            g.Graphics.FillEllipse(myBrush, new Rectangle(origin.X + 12, origin.Y - 15, 8, 8));
        }
    }
}
