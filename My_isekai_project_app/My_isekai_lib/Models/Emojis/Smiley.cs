using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_isekai_lib.Models.Emojis
{
    public class Smiley : Emoji
    {
        public Smiley(Point origin, int radius) : base(origin, radius)
        {
            color = Color.Yellow;
        }

        public override void Draw(PaintEventArgs g)
        {
            base.Draw(g);

            Rectangle bounds = new Rectangle(origin.X - 23, origin.Y - 25, 45, 45);
            Pen myPen = new Pen(Color.Black, 3);
            g.Graphics.DrawArc(myPen, bounds, 0, 180);

            // fill the eyes
            Brush myBrush = new SolidBrush(Color.Black);
            g.Graphics.FillEllipse(myBrush, new Rectangle(origin.X + 20, origin.Y - 45, 20, 40));
            g.Graphics.FillEllipse(myBrush, new Rectangle(origin.X - 40, origin.Y - 45, 20, 40));

            myBrush = new SolidBrush(Color.LightYellow);
            g.Graphics.FillEllipse(myBrush, new Rectangle(origin.X + 25, origin.Y - 35, 10, 20));
            g.Graphics.FillEllipse(myBrush, new Rectangle(origin.X - 35, origin.Y - 35, 10, 20));
        }
    }
}
