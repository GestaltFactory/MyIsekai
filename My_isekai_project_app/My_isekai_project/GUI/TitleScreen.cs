using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.PropertyGridInternal;

namespace My_isekai_project.GUI
{
    public partial class TitleScreen : Form
    {
        public TitleScreen()
        {
            InitializeComponent();

            playSimpleSound();
        }

        private void playSimpleSound()
        {
            SoundPlayer simpleSound = new SoundPlayer();
            simpleSound.Stream = Properties.Resources.Resource.Mystical_3_looped_Interstice_;
            simpleSound.Play();
        }

        private void buttonStartGame_Click(object sender, EventArgs e)
        {
            Hide();
            var select = new HeroSelectionScreen();
            select.Closed += (s, args) => Close();
            select.Show();
        }

        private void buttonQuitGame_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
