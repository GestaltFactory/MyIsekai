using My_isekai_lib.Models;
using My_isekai_lib.Models.AttributeSystem;
using My_isekai_lib.Models.Emojis;
using My_isekai_lib.Utilities;
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
using System.Xml.Linq;
using static System.Formats.Asn1.AsnWriter;

namespace My_isekai_project.GUI
{
    public partial class MasterTowerScreen : Form
    {
        bool goLeft, goRight;
        int jumpSpeed;
        int force;
        bool jumping;
        int horizontalSpeed = 5;
        int verticalSpeed = 3;
        int speed = 10;
        Label labelPlayerNameAvatar;
        private readonly int selection;

        public Character Avatar { get; }

        public MasterTowerScreen(int selection, Character avatar)
        {
            InitializeComponent();
            this.selection = selection;
            labelPlayerNameAvatar = new Label();
            Avatar = avatar;

            playSimpleSound();
        }

        private void playSimpleSound()
        {
            SoundPlayer simpleSound = new SoundPlayer();
            simpleSound.Stream = Properties.Resources.Resource.Mystical_3_looped_Interstice_;
            simpleSound.Play();
        }

        private void MasterTowerScreen_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D:
                case Keys.Right:
                    goRight = true;
                    break;
                case Keys.A:
                case Keys.Left:
                    goLeft = true;
                    break;
                default:
                    break;
            }

            // jumping
            if (e.KeyCode == Keys.Space && jumping == false)
            {
                jumping = true;
            }
        }

        private void MasterTowerScreen_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D:
                case Keys.Right:
                    goRight = false;
                    break;
                case Keys.A:
                case Keys.Left:
                    goLeft = false;
                    break;
                default:
                    break;
            }

            if (jumping == true)
            {
                jumping = false;
            }
        }

        private void player_Paint(object sender, PaintEventArgs e)
        {
            Emoji emoji;

            if (selection == 1)
            {
                emoji = new Smiley(new Point(player.Width / 2, player.Height / 2 - 15), 35);
                emoji.Draw(e);
            }
            else if (selection == 2)
            {
                emoji = new Neutrey(new Point(player.Width / 2, player.Height / 2 - 15), 35);
                emoji.Draw(e);
            }
            else if (selection == 3)
            {
                emoji = new Sadley(new Point(player.Width / 2, player.Height / 2 - 15), 35);
                emoji.Draw(e);
            }
        }

        private void MasterTowerScreen_Load(object sender, EventArgs e)
        {
            labelPlayerName.Text = Avatar.Name;
            labelPlayerMaxHP.Text = Avatar.HpTotal.ToString();
            labelPlayerCurrentHP.Text = Avatar.HpCurrent.ToString();
            labelPlayerLvValue.Text = Avatar.Level.ToString();
            labelExpCurrent.Text = Avatar.ExpCurrent.ToString();
            labelPlayerAttackValue.Text = Avatar.Attack.ToString();
            labelPlayerDefenseValue.Text = Avatar.Defense.ToString();
            labelPlayerAccuracyValue.Text = Avatar.Accuracy.ToString();

            // these 3 conditions are to show the icons in the inventory if you have found them. Only one of each so faster this way
            if (Avatar.Weapon)
            {
                pictureBoxWeaponIcon.Image = Properties.Resources.Resource.weapon;
                pictureBoxPickup.Visible = false;
                pictureBoxPickup.Enabled = false;
            }

            if (Avatar.Armor)
            {
                pictureBoxArmorIcon.Image = Properties.Resources.Resource.armor;
            }

            if (Avatar.Relic)
            {
                pictureBoxRelicIcon.Image = Properties.Resources.Resource.ring;
            }
        }

        private void MasterTowerScreen_Paint(object sender, PaintEventArgs e)
        {
            Controls.Add(labelPlayerNameAvatar);
            labelPlayerNameAvatar.Text = Avatar.Name;
            labelPlayerNameAvatar.Font = new Font("Consolas", 12, FontStyle.Bold);
            labelPlayerNameAvatar.TextAlign = ContentAlignment.MiddleCenter;
            labelPlayerNameAvatar.Location = new Point(player.Location.X - 20, player.Location.Y - 30);
            labelPlayerNameAvatar.BringToFront();
        }

        /// <summary>
        /// update
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            // hight of the jump
            player.Top += jumpSpeed;

            if (goLeft && player.Left > 5)
            {
                player.Left -= speed;
            }

            if (goRight && player.Left + player.Width < this.ClientSize.Width)
            {
                player.Left += speed;
            }

            // this means the process of mumping is over and you can jump again
            if (jumping == true && force < 0)
            {
                jumping = false;
            }

            // force you back down after a jump
            if (jumping == true)
            {
                jumpSpeed = -8;
                force -= 1;
            }
            else
            {
                jumpSpeed = 10;
            }

            // from here you can manipulate interaction with intersecting controls (like picture boxes - mainly)
            foreach (Control element in this.Controls)
            {
                if (element is PictureBox)
                {
                    if ((string)element.Tag == "Platform")
                    {
                        if (player.Bounds.IntersectsWith(element.Bounds))
                        {
                            force = 8;
                            player.Top = element.Top - player.Height;

                            if (element.Name == "movingPlatformHorizontal" && goLeft == false || element.Name == "movingPlatformHorizontal" && goRight == false)
                            {
                                player.Left -= horizontalSpeed;
                            }
                        }

                        element.BringToFront();
                    }

                    if ((string)element.Tag == "Pickup")
                    {
                        if (player.Bounds.IntersectsWith(element.Bounds) && element.Visible == true)
                        {
                            element.Visible = false;
                            Weapon weapon = new Weapon("Slicer", "A sword that slice", 20);
                            Manager.hasObtainedWeapon = true;
                            Avatar.Weapon = true;
                            Avatar.Attack += weapon.Power;
                            labelPlayerAttackValue.Text = Avatar.Attack.ToString();
                            pictureBoxWeaponIcon.Image = Properties.Resources.Resource.weapon;
                        }
                    }
                }
            }

            // moving platform H
            movingPlatformHorizontal.Left -= horizontalSpeed;
            if (movingPlatformHorizontal.Left < 490 || movingPlatformHorizontal.Left + movingPlatformHorizontal.Width > 1010)
            {
                horizontalSpeed = -horizontalSpeed;
            }

            // moving platform V
            movingPlatformVertical.Top += verticalSpeed;
            if (movingPlatformVertical.Top < 430 || movingPlatformVertical.Top > 580)
            {
                verticalSpeed = -verticalSpeed;
            }

            if (player.Bounds.IntersectsWith(pictureBoxOpenWorldGate.Bounds))
            {
                Hide();
                gameTimer.Stop();
                var end = new CreditScreen();
                end.Closed += (s, args) => Close();
                end.Show();
            }

            if (player.Bounds.IntersectsWith(pictureBoxReturnToOpenWorld.Bounds))
            {
                Hide();
                gameTimer.Stop();
                var end = new OpenWorldCenterScreen(selection, Avatar);
                end.Closed += (s, args) => Close();
                end.Show();
            }           
        }
    }
}
