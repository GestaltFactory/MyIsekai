using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_isekai_lib.Models.Emojis
{
    public class DarkLegion : Emoji
    {
        public DarkLegion(Point origin, int radius) : base(origin, radius)
        {
            color = Color.Black;
        }

        public override void Draw(PaintEventArgs g)
        {
            base.Draw(g);

            Brush myBrush = new SolidBrush(Color.GhostWhite);
            g.Graphics.FillEllipse(myBrush, new Rectangle(origin.X - 20, origin.Y + 15, 40, 10));

            myBrush = new SolidBrush(Color.Purple);
            g.Graphics.FillEllipse(myBrush, new Rectangle(origin.X - 16, origin.Y - 18, 8, 8));
            g.Graphics.FillEllipse(myBrush, new Rectangle(origin.X + 12, origin.Y - 18, 8, 8));
        }
    }
}
