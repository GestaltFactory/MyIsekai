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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace My_isekai_project.GUI
{
    public partial class CombatScreen : Form
    {
        private readonly int selection;

        bool isEvilRed = false;
        bool isDefending = false;

        public Character Avatar { get; }
        public Enemy Enemy;

        public CombatScreen(int selection, Character avatar)
        {
            InitializeComponent();
            this.selection = selection;
            Avatar = avatar;
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

        private void enemy_Paint(object sender, PaintEventArgs e)
        {
            Emoji emoji;
            if (!isEvilRed)
            {
                
                emoji = new DarkLegion(new Point(enemy.Width / 2, enemy.Height / 2 - 15), 35);
                emoji.Draw(e);
            }
            else
            {
                emoji = new EvilRed(new Point(enemy.Width / 2, enemy.Height / 2 - 15), 35);
                emoji.Draw(e);
            }
        }

        /// <summary>
        /// This is where the enemy are being created. You can change their values here to test or to better balance the experience
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CombatScreen_Load(object sender, EventArgs e)
        {            
            InitPlayerDisplay();
            panelDropChance.Visible = false;
            isEvilRed = false;

            int roll;

            if (!Manager.hasObtainedRelic)
            {
                roll = Randomizer.Dice(1, 4);
            }
            else
            {
                roll = Randomizer.Dice(1, 3);
            }          

            if (roll == 1)
            {
                Enemy = new Enemy("Lesser Legion", 100, 36, 12, 14, 20);
            }
            else if (roll == 2)
            {
                Enemy =  new Enemy("Legion", 150, 45, 18, 15, 30);
            }
            else if (roll == 3)
            {               
                Enemy = new Enemy("Evil Red", 250, 62, 28, 18, 40, new Relic("Binocular", "It Increases accuracy.", 3));
                isEvilRed = true;
                panelDropChance.Visible = true;
                labelDropInv.Text = "Binocular";
                pictureBoxDropItem.Image = Properties.Resources.Resource.ring;               
            }

            InitEnemyDisplay();
        }

        private void InitPlayerDisplay()
        {
            labelPlayerName.Text = Avatar.Name;
            labelPlayerMaxHP.Text = Avatar.HpTotal.ToString();
            labelPlayerCurrentHP.Text = Avatar.HpCurrent.ToString();
            labelPlayerLvValue.Text = Avatar.Level.ToString();
            labelExpCurrent.Text = Avatar.ExpCurrent.ToString();
            labelPlayerAttackValue.Text = Avatar.Attack.ToString();
            labelPlayerDefenseValue.Text = Avatar.Defense.ToString();
            labelPlayerAccuracyValue.Text = Avatar.Accuracy.ToString();

            progressBarPlayerHp.Maximum = Convert.ToInt32(Avatar.HpTotal);
            progressBarPlayerHp.Value = Convert.ToInt32(Avatar.HpCurrent);

            if (Avatar.Weapon)
            {
                pictureBoxPlayerWeapon.Image = Properties.Resources.Resource.weapon;
            }

            if (Avatar.Armor)
            {
                pictureBoxPlayerArmor.Image = Properties.Resources.Resource.armor;
            }

            if (Avatar.Relic)
            {
                pictureBoxPlayerRelic.Image = Properties.Resources.Resource.ring;
            }
        }

        private void InitEnemyDisplay()
        {
            labelEnemyName.Text = Enemy.Name;
            labelEnemyHpMax.Text = Enemy.HpTotal.ToString();
            labelEnemyHpCurrent.Text = Enemy.HpCurrent.ToString();
            labelEnemyAttackValue.Text = Enemy.Attack.ToString();
            labelEnemyDefenseValue.Text = Enemy.Defense.ToString();
            labelEnemyAccuracyValue.Text = Enemy.Accuracy.ToString();

            progressBarEnemy.Maximum = Convert.ToInt32(Enemy.HpTotal);
            progressBarEnemy.Value = Convert.ToInt32(Enemy.HpCurrent);
        }

        /// <summary>
        /// Enemy turn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gameTimerCombat_Tick(object sender, EventArgs e)
        {
            gameTimerCombat.Enabled = false;
            int roll = Randomizer.Dice(1, 3);

            labelInfo.Text = "";

            if (roll == 1)
            {
                if (isDefending == true)
                {
                    labelInfo.Text += "  - player defended.";
                }
                else
                {
                    labelInfo.Text += Avatar.TakeDamage(Enemy.Attack, Avatar.Defense, Enemy.Accuracy);
                }
            }
            else if (roll == 2)
            {
                if (isDefending == true)
                {
                    labelInfo.Text += "  - player defended.";
                }
                else
                {
                    labelInfo.Text += Avatar.TakeDamage(Enemy.Attack, Avatar.Defense, Enemy.Accuracy);
                }
            }

            if (Avatar.HpCurrent > 0)
            {
                progressBarPlayerHp.Value = Convert.ToInt32(Avatar.HpCurrent);
                labelPlayerCurrentHP.Text = Avatar.HpCurrent.ToString();
            }
            else
            {
                progressBarPlayerHp.Value = 0;
                MessageBox.Show(Avatar.Name + " has died pathetically! - Going back to title!");
                GameOver();
            }

            buttonAttack.Enabled = true;
            buttonDefend.Enabled = true;
        }

        private void buttonAttack_Click(object sender, EventArgs e)
        {
            labelInfo.Text += Enemy.TakeDamage(Avatar.Attack, Enemy.Defense, Avatar.Accuracy);

            if (Enemy.HpCurrent > 0)
            {
                progressBarEnemy.Value = Convert.ToInt32(Enemy.HpCurrent);
                labelEnemyHpCurrent.Text = Enemy.HpCurrent.ToString();
                ButtonControls();
            }
            else
            {
                gameTimerCombat.Enabled = false;
                progressBarEnemy.Value = 0;
                Avatar.ExpCurrent += Enemy.ExpGain;

                if (Avatar.ExpCurrent >= 100)
                {
                    Avatar.ExpCurrent %= 100;
                    Avatar.LevelUp();
                    MessageBox.Show("The enemy" + Enemy.Name + " has been vanquished! - you have gained " + Enemy.ExpGain + " EXP" + " You gained a new level!");
                }
                else
                {
                    MessageBox.Show("The enemy" + Enemy.Name + " has been vanquished! - you have gained " + Enemy.ExpGain + " EXP");
                }

                if (Enemy.Relic != null)
                {
                    Avatar.Accuracy += Enemy.Relic.Attribute;
                    labelPlayerAccuracyValue.Text = Avatar.Accuracy.ToString();
                    pictureBoxPlayerRelic.Image = Properties.Resources.Resource.ring;
                    Manager.hasObtainedRelic = true;
                    Avatar.Relic = true;
                }
                
                Exit();
            }           
        }

        private void buttonDefend_Click(object sender, EventArgs e)
        {
            isDefending = true;
            labelInfo.Text = "";
            labelInfo.Text = Avatar.Name + " is preparing to defend.";
            ButtonControls();
        }

        private void ButtonControls()
        {
            gameTimerCombat.Enabled = true;
            buttonAttack.Enabled = false;
            buttonDefend.Enabled = false;
        }

        private void buttonEscape_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void Exit()
        {
            Hide();
            gameTimerCombat.Stop();
            var escape = new OpenWorldCenterScreen(selection, Avatar);
            escape.Closed += (s, args) => Close();
            escape.Show();
        }

        private void GameOver()
        {
            Hide();
            gameTimerCombat.Stop();
            var title = new TitleScreen();
            title.Closed += (s, args) => Close();
            title.Show();
        }
    }
}
