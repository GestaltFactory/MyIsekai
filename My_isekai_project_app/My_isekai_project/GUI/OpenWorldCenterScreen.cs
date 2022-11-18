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
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace My_isekai_project.GUI
{
    public partial class OpenWorldCenterScreen : Form
    {
        bool goLeft, goRight, goUp, goDown;
        int speed = 10;

        private readonly int selection;
        private readonly int legionSpeed = 3;

        public Character Avatar { get; }
        Label labelPlayerNameAvatar, labelEnemyNameLegionOne, labelEnemyNameLegionTwo;

        public OpenWorldCenterScreen(int selection, Character avatar)
        {
            InitializeComponent();

            labelPlayerNameAvatar = new Label();
            labelEnemyNameLegionOne = new Label();
            labelEnemyNameLegionTwo = new Label();
            this.selection = selection;
            Avatar = avatar;

            playSimpleSound();
        }

        private void playSimpleSound()
        {
            SoundPlayer simpleSound = new SoundPlayer();
            simpleSound.Stream = Properties.Resources.Resource.Prepare_for_Battle;
            simpleSound.Play();
        }

        /// <summary>
        /// update
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            if (goLeft == true && player.Left > 5)
            {
                player.Left -= speed;
            }

            if (goRight == true && player.Left + player.Width < this.ClientSize.Width)
            {
                player.Left += speed;
            }

            if (goUp == true && player.Top > 140)
            {
                player.Top -= speed;
            }

            if (goDown == true && player.Top + player.Height < this.ClientSize.Height - 20)
            {
                player.Top += speed;
            }

            foreach (Control element in this.Controls)
            {
                if (element is PictureBox && (string)element.Tag == "Legion")
                {
                    if (player.Bounds.IntersectsWith(element.Bounds))
                    {
                        Hide();
                        gameTimer.Stop();
                        var combat = new CombatScreen(selection, Avatar);
                        combat.Closed += (s, args) => Close();
                        combat.Show();
                    }

                    // move the 2 enemies and make them run after the player
                    if (element.Left > player.Left)
                    {
                        element.Left -= legionSpeed;
                    }

                    if (element.Left < player.Left)
                    {
                        element.Left += legionSpeed;
                    }

                    if (element.Top > player.Top)
                    {
                        element.Top -= legionSpeed;
                    }

                    if (element.Top < player.Top)
                    {
                        element.Top += legionSpeed;
                    }
                }
            }

            foreach (Control element in this.Controls)
            {               
                if ((string)element.Tag == "Pickup")
                {
                    if (player.Bounds.IntersectsWith(element.Bounds) && element.Visible == true)
                    {
                        element.Visible = false;
                        Armor armor = new Armor("Slicer", "A sword that slice", 10);
                        Avatar.Defense += armor.Resistance;
                        Avatar.Armor = true;
                        labelPlayerDefenseValue.Text = Avatar.Defense.ToString();
                        pictureBoxArmorIcon.Image = Properties.Resources.Resource.armor;
                    }
                }
            }

            if (player.Bounds.IntersectsWith(pictureBoxTowerEntrance.Bounds))
            {
                Hide();
                gameTimer.Stop();
                var tower = new MasterTowerScreen(selection, Avatar);
                tower.Closed += (s, args) => Close();
                tower.Show();
            }           
        }

        private void OpenWorldCenterScreen_Load(object sender, EventArgs e)
        {
            labelPlayerName.Text = Avatar.Name;
            labelPlayerMaxHP.Text = Avatar.HpTotal.ToString();
            labelPlayerCurrentHP.Text = Avatar.HpCurrent.ToString();
            labelPlayerLvValue.Text = Avatar.Level.ToString();
            labelExpCurrent.Text = Avatar.ExpCurrent.ToString();
            labelPlayerAttackValue.Text = Avatar.Attack.ToString();
            labelPlayerDefenseValue.Text = Avatar.Defense.ToString();
            labelPlayerAccuracyValue.Text = Avatar.Accuracy.ToString();
            pictureBoxPotion.Image = Properties.Resources.Resource.potion;

            // these 3 conditions are to show the icons in the inventory if you have found them.Only one of each so faster this way
            if (Avatar.Weapon)
            {
                pictureBoxWeaponIcon.Image = Properties.Resources.Resource.weapon;
            }

            if (Avatar.Armor)
            {
                pictureBoxArmorIcon.Image = Properties.Resources.Resource.armor;
                pictureBoxPickup.Visible = false;
                pictureBoxPickup.Enabled = false;
            }

            if (Avatar.Relic)
            {
                pictureBoxRelicIcon.Image = Properties.Resources.Resource.ring;
            }
        }

        private void EnemyAgent_Paint(object sender, PaintEventArgs e)
        {
            Emoji emoji;
            emoji = new DarkLegion(new Point(pictureBoxEnemyAgentTwo.Width / 2, pictureBoxEnemyAgentTwo.Height / 2 - 15), 35);
            emoji.Draw(e);
            emoji = new DarkLegion(new Point(pictureBoxEnemyAgentOne.Width / 2, pictureBoxEnemyAgentOne.Height / 2 - 15), 35);
            emoji.Draw(e);
        }

        /// <summary>
        /// To create a label over the head of the characters that will follow them
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenWorldCenterScreen_Paint(object sender, PaintEventArgs e)
        {
            Controls.Add(labelPlayerNameAvatar);
            labelPlayerNameAvatar.Text = Avatar.Name;
            labelPlayerNameAvatar.Font = new Font("Consolas", 12, FontStyle.Bold);
            labelPlayerNameAvatar.TextAlign = ContentAlignment.MiddleCenter;
            labelPlayerNameAvatar.Location = new Point(player.Location.X - 20, player.Location.Y - 30);
            labelPlayerNameAvatar.BringToFront();

            Controls.Add(labelEnemyNameLegionOne);
            labelEnemyNameLegionOne.Text = "Legion";
            labelEnemyNameLegionOne.Font = new Font("Consolas", 12, FontStyle.Bold);
            labelEnemyNameLegionOne.TextAlign = ContentAlignment.MiddleCenter;
            labelEnemyNameLegionOne.Location = new Point(pictureBoxEnemyAgentOne.Location.X - 20, pictureBoxEnemyAgentOne.Location.Y - 30);
            labelEnemyNameLegionOne.BringToFront();

            Controls.Add(labelEnemyNameLegionTwo);
            labelEnemyNameLegionTwo.Text = "Legion";
            labelEnemyNameLegionTwo.Font = new Font("Consolas", 12, FontStyle.Bold);
            labelEnemyNameLegionTwo.TextAlign = ContentAlignment.MiddleCenter;
            labelEnemyNameLegionTwo.Location = new Point(pictureBoxEnemyAgentTwo.Location.X - 20, pictureBoxEnemyAgentTwo.Location.Y - 30);
            labelEnemyNameLegionTwo.BringToFront();
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

        private void OpenWorldCenterScreen_KeyDown(object sender, KeyEventArgs e)
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
                case Keys.W:
                case Keys.Up:
                    goUp = true;
                    break;
                case Keys.S:
                case Keys.Down:
                    goDown = true;
                    break;
                case Keys.H:
                    labelRegen.Text = Avatar.Regenerate();
                    labelPlayerCurrentHP.Text = Avatar.HpCurrent.ToString();
                    break;
                default:
                    break;
            }
        }

        private void OpenWorldCenterScreen_KeyUp(object sender, KeyEventArgs e)
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
                case Keys.W:
                case Keys.Up:
                    goUp = false;
                    break;
                case Keys.S:
                case Keys.Down:
                    goDown = false;
                    break;
                default:
                    break;
            }
        }
    }
}
