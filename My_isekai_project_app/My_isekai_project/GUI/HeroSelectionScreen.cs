using My_isekai_lib.Models;
using My_isekai_lib.Models.AttributeSystem;
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
    public partial class HeroSelectionScreen : Form
    {
        private int selection = 1;
        Character avatar;

        public HeroSelectionScreen()
        {
            InitializeComponent();
        }

        private void pictureBoxCharacterOne_Click(object sender, EventArgs e)
        {
            selection = 1;
            CharacterChanged();
        }

        private void pictureBoxCharacterTwo_Click(object sender, EventArgs e)
        {
            selection = 2;
            CharacterChanged();
        }

        private void pictureBoxCharacterThree_Click(object sender, EventArgs e)
        {
            selection = 3;
            CharacterChanged();
        }

        private void pictureBoxCharacterOne_Paint(object sender, PaintEventArgs e)
        {
            Emoji emoji;
            emoji = new Smiley(new Point(pictureBoxCharacterOne.Width / 2, pictureBoxCharacterOne.Height / 2 - 15), 35);
            emoji.Draw(e);
        }

        private void pictureBoxCharacterTwo_Paint(object sender, PaintEventArgs e)
        {
            Emoji emoji;
            emoji = new Neutrey(new Point(pictureBoxCharacterTwo.Width / 2, pictureBoxCharacterTwo.Height / 2 - 15), 35);
            emoji.Draw(e);
        }

        private void pictureBoxCharacterThree_Paint(object sender, PaintEventArgs e)
        {
            Emoji emoji;
            emoji = new Sadley(new Point(pictureBoxCharacterThree.Width / 2, pictureBoxCharacterThree.Height / 2 - 15), 35);
            emoji.Draw(e);
        }

        /// <summary>
        /// Used when you switch selection
        /// </summary>
        private void CharacterChanged()
        {
            if (selection == 1)
            {
                pictureBoxCharacterOne.BackColor = Color.LightCyan;
                pictureBoxCharacterTwo.BackColor = Color.White;
                pictureBoxCharacterThree.BackColor = Color.White;

                pictureBoxCharacterOne.BorderStyle = BorderStyle.Fixed3D;
                pictureBoxCharacterTwo.BorderStyle = BorderStyle.FixedSingle;
                pictureBoxCharacterThree.BorderStyle = BorderStyle.FixedSingle;
            }
            else if (selection == 2)
            {
                pictureBoxCharacterOne.BackColor = Color.White;
                pictureBoxCharacterTwo.BackColor = Color.LightCyan;
                pictureBoxCharacterThree.BackColor = Color.White;

                pictureBoxCharacterOne.BorderStyle = BorderStyle.FixedSingle;
                pictureBoxCharacterTwo.BorderStyle = BorderStyle.Fixed3D;
                pictureBoxCharacterThree.BorderStyle = BorderStyle.FixedSingle;
            }
            else if (selection == 3)
            {
                pictureBoxCharacterOne.BackColor = Color.White;
                pictureBoxCharacterTwo.BackColor = Color.White;
                pictureBoxCharacterThree.BackColor = Color.LightCyan;

                pictureBoxCharacterOne.BorderStyle = BorderStyle.FixedSingle;
                pictureBoxCharacterTwo.BorderStyle = BorderStyle.FixedSingle;
                pictureBoxCharacterThree.BorderStyle = BorderStyle.Fixed3D;
            }
        }

        private void buttonBeginAdventure_Click(object sender, EventArgs e)
        {           
            if (selection == 1)
            {
                avatar = new Character("Smiley", 200, 70, 12, 17);
            }
            else if (selection == 2)
            {
                avatar = new Character("Neutrey", 180, 82, 10, 16);
            }
            else if (selection == 3)
            {
                avatar = new Character("Sadley", 220, 68, 15, 15);
            }

            Hide();
            var openWorld = new OpenWorldCenterScreen(selection, avatar);
            openWorld.Closed += (s, args) => Close();
            openWorld.Show();
        }
    }
}
