using My_isekai_lib.Models.Emojis;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_isekai_project.GUI
{
    public partial class CreditScreen : Form
    {
        public CreditScreen()
        {
            InitializeComponent();
        }

        private void pb1_Paint(object sender, PaintEventArgs e)
        {
            Emoji emoji;
            emoji = new Smiley(new Point(pb1.Width / 2, pb1.Height / 2 - 15), 35);
            emoji.Draw(e);
        }

        private void pb2_Paint(object sender, PaintEventArgs e)
        {
            Emoji emoji;
            emoji = new Neutrey(new Point(pb2.Width / 2, pb2.Height / 2 - 15), 35);
            emoji.Draw(e);
        }

        private void pb3_Paint(object sender, PaintEventArgs e)
        {
            Emoji emoji;
            emoji = new Sadley(new Point(pb3.Width / 2, pb3.Height / 2 - 15), 35);
            emoji.Draw(e);
        }

        private void pb4_Paint(object sender, PaintEventArgs e)
        {
            Emoji emoji;
            emoji = new DarkLegion(new Point(pb4.Width / 2, pb4.Height / 2 - 15), 35);
            emoji.Draw(e);
        }

        private void pb5_Paint(object sender, PaintEventArgs e)
        {
            Emoji emoji;
            emoji = new EvilRed(new Point(pb5.Width / 2, pb5.Height / 2 - 15), 35);
            emoji.Draw(e);
        }
    }
}
