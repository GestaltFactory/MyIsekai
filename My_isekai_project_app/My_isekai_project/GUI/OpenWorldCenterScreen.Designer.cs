namespace My_isekai_project.GUI
{
    partial class OpenWorldCenterScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.player = new System.Windows.Forms.PictureBox();
            this.emojiTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxTowerEntrance = new System.Windows.Forms.PictureBox();
            this.pictureBoxEnemyAgentOne = new System.Windows.Forms.PictureBox();
            this.labelPlayerName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxPotion = new System.Windows.Forms.PictureBox();
            this.labelRelic = new System.Windows.Forms.Label();
            this.labelArmor = new System.Windows.Forms.Label();
            this.labelWeapon = new System.Windows.Forms.Label();
            this.pictureBoxRelicIcon = new System.Windows.Forms.PictureBox();
            this.labelPlayerMaxHP = new System.Windows.Forms.Label();
            this.labelPlayerCurrentHP = new System.Windows.Forms.Label();
            this.pictureBoxArmorIcon = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelAccuracy = new System.Windows.Forms.Label();
            this.labelHP = new System.Windows.Forms.Label();
            this.labelLv = new System.Windows.Forms.Label();
            this.pictureBoxWeaponIcon = new System.Windows.Forms.PictureBox();
            this.labelPlayerAttackValue = new System.Windows.Forms.Label();
            this.labelExpInfo = new System.Windows.Forms.Label();
            this.labelPlayerLvValue = new System.Windows.Forms.Label();
            this.labelExpTotal = new System.Windows.Forms.Label();
            this.labelDef = new System.Windows.Forms.Label();
            this.labelExp = new System.Windows.Forms.Label();
            this.labelPlayerDefenseValue = new System.Windows.Forms.Label();
            this.labelExpCurrent = new System.Windows.Forms.Label();
            this.labelPlayerAccuracyValue = new System.Windows.Forms.Label();
            this.labelAttack = new System.Windows.Forms.Label();
            this.pictureBoxEnemyAgentTwo = new System.Windows.Forms.PictureBox();
            this.labelGate = new System.Windows.Forms.Label();
            this.pictureBoxPickup = new System.Windows.Forms.PictureBox();
            this.labelRegen = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTowerEntrance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnemyAgentOne)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRelicIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArmorIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWeaponIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnemyAgentTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPickup)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 32;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.SystemColors.Control;
            this.player.Location = new System.Drawing.Point(244, 161);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(80, 120);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            this.player.Paint += new System.Windows.Forms.PaintEventHandler(this.player_Paint);
            // 
            // emojiTimer
            // 
            this.emojiTimer.Enabled = true;
            this.emojiTimer.Interval = 2000;
            // 
            // pictureBoxTowerEntrance
            // 
            this.pictureBoxTowerEntrance.BackColor = System.Drawing.Color.IndianRed;
            this.pictureBoxTowerEntrance.Location = new System.Drawing.Point(1409, 205);
            this.pictureBoxTowerEntrance.Name = "pictureBoxTowerEntrance";
            this.pictureBoxTowerEntrance.Size = new System.Drawing.Size(100, 168);
            this.pictureBoxTowerEntrance.TabIndex = 1;
            this.pictureBoxTowerEntrance.TabStop = false;
            // 
            // pictureBoxEnemyAgentOne
            // 
            this.pictureBoxEnemyAgentOne.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxEnemyAgentOne.Location = new System.Drawing.Point(891, 591);
            this.pictureBoxEnemyAgentOne.Name = "pictureBoxEnemyAgentOne";
            this.pictureBoxEnemyAgentOne.Size = new System.Drawing.Size(80, 120);
            this.pictureBoxEnemyAgentOne.TabIndex = 2;
            this.pictureBoxEnemyAgentOne.TabStop = false;
            this.pictureBoxEnemyAgentOne.Tag = "Legion";
            this.pictureBoxEnemyAgentOne.Paint += new System.Windows.Forms.PaintEventHandler(this.EnemyAgent_Paint);
            // 
            // labelPlayerName
            // 
            this.labelPlayerName.AutoSize = true;
            this.labelPlayerName.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPlayerName.Location = new System.Drawing.Point(26, 14);
            this.labelPlayerName.Name = "labelPlayerName";
            this.labelPlayerName.Size = new System.Drawing.Size(58, 24);
            this.labelPlayerName.TabIndex = 3;
            this.labelPlayerName.Text = "Name";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OldLace;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBoxPotion);
            this.panel1.Controls.Add(this.labelRelic);
            this.panel1.Controls.Add(this.labelArmor);
            this.panel1.Controls.Add(this.labelWeapon);
            this.panel1.Controls.Add(this.pictureBoxRelicIcon);
            this.panel1.Controls.Add(this.labelPlayerMaxHP);
            this.panel1.Controls.Add(this.labelPlayerCurrentHP);
            this.panel1.Controls.Add(this.pictureBoxArmorIcon);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.labelAccuracy);
            this.panel1.Controls.Add(this.labelHP);
            this.panel1.Controls.Add(this.labelPlayerName);
            this.panel1.Controls.Add(this.labelLv);
            this.panel1.Controls.Add(this.pictureBoxWeaponIcon);
            this.panel1.Controls.Add(this.labelPlayerAttackValue);
            this.panel1.Controls.Add(this.labelExpInfo);
            this.panel1.Controls.Add(this.labelPlayerLvValue);
            this.panel1.Controls.Add(this.labelExpTotal);
            this.panel1.Controls.Add(this.labelDef);
            this.panel1.Controls.Add(this.labelExp);
            this.panel1.Controls.Add(this.labelPlayerDefenseValue);
            this.panel1.Controls.Add(this.labelExpCurrent);
            this.panel1.Controls.Add(this.labelPlayerAccuracyValue);
            this.panel1.Controls.Add(this.labelAttack);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1541, 128);
            this.panel1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(913, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(273, 15);
            this.label4.TabIndex = 25;
            this.label4.Text = "Press \"H\" to use (only in this scene).";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(889, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(308, 15);
            this.label2.TabIndex = 24;
            this.label2.Text = "<- infitine amount can be used just in case";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(823, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "Potion";
            // 
            // pictureBoxPotion
            // 
            this.pictureBoxPotion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPotion.Location = new System.Drawing.Point(823, 45);
            this.pictureBoxPotion.Name = "pictureBoxPotion";
            this.pictureBoxPotion.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxPotion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPotion.TabIndex = 22;
            this.pictureBoxPotion.TabStop = false;
            // 
            // labelRelic
            // 
            this.labelRelic.AutoSize = true;
            this.labelRelic.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelRelic.Location = new System.Drawing.Point(646, 8);
            this.labelRelic.Name = "labelRelic";
            this.labelRelic.Size = new System.Drawing.Size(42, 15);
            this.labelRelic.TabIndex = 21;
            this.labelRelic.Text = "Relic";
            // 
            // labelArmor
            // 
            this.labelArmor.AutoSize = true;
            this.labelArmor.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelArmor.Location = new System.Drawing.Point(520, 8);
            this.labelArmor.Name = "labelArmor";
            this.labelArmor.Size = new System.Drawing.Size(42, 15);
            this.labelArmor.TabIndex = 20;
            this.labelArmor.Text = "Armor";
            // 
            // labelWeapon
            // 
            this.labelWeapon.AutoSize = true;
            this.labelWeapon.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelWeapon.Location = new System.Drawing.Point(393, 8);
            this.labelWeapon.Name = "labelWeapon";
            this.labelWeapon.Size = new System.Drawing.Size(49, 15);
            this.labelWeapon.TabIndex = 19;
            this.labelWeapon.Text = "Weapon";
            // 
            // pictureBoxRelicIcon
            // 
            this.pictureBoxRelicIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxRelicIcon.Location = new System.Drawing.Point(628, 30);
            this.pictureBoxRelicIcon.Name = "pictureBoxRelicIcon";
            this.pictureBoxRelicIcon.Size = new System.Drawing.Size(80, 80);
            this.pictureBoxRelicIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRelicIcon.TabIndex = 18;
            this.pictureBoxRelicIcon.TabStop = false;
            // 
            // labelPlayerMaxHP
            // 
            this.labelPlayerMaxHP.AutoSize = true;
            this.labelPlayerMaxHP.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPlayerMaxHP.Location = new System.Drawing.Point(113, 81);
            this.labelPlayerMaxHP.Name = "labelPlayerMaxHP";
            this.labelPlayerMaxHP.Size = new System.Drawing.Size(36, 19);
            this.labelPlayerMaxHP.TabIndex = 4;
            this.labelPlayerMaxHP.Text = "200";
            // 
            // labelPlayerCurrentHP
            // 
            this.labelPlayerCurrentHP.AutoSize = true;
            this.labelPlayerCurrentHP.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPlayerCurrentHP.Location = new System.Drawing.Point(71, 81);
            this.labelPlayerCurrentHP.Name = "labelPlayerCurrentHP";
            this.labelPlayerCurrentHP.Size = new System.Drawing.Size(36, 19);
            this.labelPlayerCurrentHP.TabIndex = 2;
            this.labelPlayerCurrentHP.Text = "200";
            // 
            // pictureBoxArmorIcon
            // 
            this.pictureBoxArmorIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxArmorIcon.Location = new System.Drawing.Point(501, 31);
            this.pictureBoxArmorIcon.Name = "pictureBoxArmorIcon";
            this.pictureBoxArmorIcon.Size = new System.Drawing.Size(80, 80);
            this.pictureBoxArmorIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxArmorIcon.TabIndex = 17;
            this.pictureBoxArmorIcon.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(101, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "/";
            // 
            // labelAccuracy
            // 
            this.labelAccuracy.AutoSize = true;
            this.labelAccuracy.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAccuracy.Location = new System.Drawing.Point(210, 101);
            this.labelAccuracy.Name = "labelAccuracy";
            this.labelAccuracy.Size = new System.Drawing.Size(99, 19);
            this.labelAccuracy.TabIndex = 16;
            this.labelAccuracy.Text = "Accuracy: ";
            // 
            // labelHP
            // 
            this.labelHP.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelHP.Location = new System.Drawing.Point(26, 81);
            this.labelHP.Name = "labelHP";
            this.labelHP.Size = new System.Drawing.Size(40, 19);
            this.labelHP.TabIndex = 0;
            this.labelHP.Text = "HP: ";
            // 
            // labelLv
            // 
            this.labelLv.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelLv.Location = new System.Drawing.Point(26, 50);
            this.labelLv.Name = "labelLv";
            this.labelLv.Size = new System.Drawing.Size(66, 19);
            this.labelLv.TabIndex = 12;
            this.labelLv.Text = "Level: ";
            // 
            // pictureBoxWeaponIcon
            // 
            this.pictureBoxWeaponIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxWeaponIcon.Location = new System.Drawing.Point(377, 31);
            this.pictureBoxWeaponIcon.Name = "pictureBoxWeaponIcon";
            this.pictureBoxWeaponIcon.Size = new System.Drawing.Size(80, 80);
            this.pictureBoxWeaponIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxWeaponIcon.TabIndex = 0;
            this.pictureBoxWeaponIcon.TabStop = false;
            // 
            // labelPlayerAttackValue
            // 
            this.labelPlayerAttackValue.AutoSize = true;
            this.labelPlayerAttackValue.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPlayerAttackValue.Location = new System.Drawing.Point(311, 61);
            this.labelPlayerAttackValue.Name = "labelPlayerAttackValue";
            this.labelPlayerAttackValue.Size = new System.Drawing.Size(27, 19);
            this.labelPlayerAttackValue.TabIndex = 8;
            this.labelPlayerAttackValue.Text = "99";
            // 
            // labelExpInfo
            // 
            this.labelExpInfo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelExpInfo.Location = new System.Drawing.Point(17, 101);
            this.labelExpInfo.Name = "labelExpInfo";
            this.labelExpInfo.Size = new System.Drawing.Size(51, 19);
            this.labelExpInfo.TabIndex = 15;
            this.labelExpInfo.Text = "EXP: ";
            // 
            // labelPlayerLvValue
            // 
            this.labelPlayerLvValue.AutoSize = true;
            this.labelPlayerLvValue.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPlayerLvValue.Location = new System.Drawing.Point(91, 50);
            this.labelPlayerLvValue.Name = "labelPlayerLvValue";
            this.labelPlayerLvValue.Size = new System.Drawing.Size(18, 19);
            this.labelPlayerLvValue.TabIndex = 13;
            this.labelPlayerLvValue.Text = "1";
            // 
            // labelExpTotal
            // 
            this.labelExpTotal.AutoSize = true;
            this.labelExpTotal.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelExpTotal.Location = new System.Drawing.Point(113, 101);
            this.labelExpTotal.Name = "labelExpTotal";
            this.labelExpTotal.Size = new System.Drawing.Size(36, 19);
            this.labelExpTotal.TabIndex = 6;
            this.labelExpTotal.Text = "100";
            // 
            // labelDef
            // 
            this.labelDef.AutoSize = true;
            this.labelDef.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDef.Location = new System.Drawing.Point(218, 81);
            this.labelDef.Name = "labelDef";
            this.labelDef.Size = new System.Drawing.Size(90, 19);
            this.labelDef.TabIndex = 15;
            this.labelDef.Text = "Defense: ";
            // 
            // labelExp
            // 
            this.labelExp.AutoSize = true;
            this.labelExp.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelExp.Location = new System.Drawing.Point(98, 101);
            this.labelExp.Name = "labelExp";
            this.labelExp.Size = new System.Drawing.Size(18, 19);
            this.labelExp.TabIndex = 14;
            this.labelExp.Text = "/";
            // 
            // labelPlayerDefenseValue
            // 
            this.labelPlayerDefenseValue.AutoSize = true;
            this.labelPlayerDefenseValue.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPlayerDefenseValue.Location = new System.Drawing.Point(311, 82);
            this.labelPlayerDefenseValue.Name = "labelPlayerDefenseValue";
            this.labelPlayerDefenseValue.Size = new System.Drawing.Size(27, 19);
            this.labelPlayerDefenseValue.TabIndex = 9;
            this.labelPlayerDefenseValue.Text = "99";
            // 
            // labelExpCurrent
            // 
            this.labelExpCurrent.AutoSize = true;
            this.labelExpCurrent.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelExpCurrent.Location = new System.Drawing.Point(71, 101);
            this.labelExpCurrent.Name = "labelExpCurrent";
            this.labelExpCurrent.Size = new System.Drawing.Size(18, 19);
            this.labelExpCurrent.TabIndex = 5;
            this.labelExpCurrent.Text = "0";
            // 
            // labelPlayerAccuracyValue
            // 
            this.labelPlayerAccuracyValue.AutoSize = true;
            this.labelPlayerAccuracyValue.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPlayerAccuracyValue.Location = new System.Drawing.Point(311, 102);
            this.labelPlayerAccuracyValue.Name = "labelPlayerAccuracyValue";
            this.labelPlayerAccuracyValue.Size = new System.Drawing.Size(27, 19);
            this.labelPlayerAccuracyValue.TabIndex = 10;
            this.labelPlayerAccuracyValue.Text = "99";
            // 
            // labelAttack
            // 
            this.labelAttack.AutoSize = true;
            this.labelAttack.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAttack.Location = new System.Drawing.Point(227, 61);
            this.labelAttack.Name = "labelAttack";
            this.labelAttack.Size = new System.Drawing.Size(81, 19);
            this.labelAttack.TabIndex = 14;
            this.labelAttack.Text = "Attack: ";
            // 
            // pictureBoxEnemyAgentTwo
            // 
            this.pictureBoxEnemyAgentTwo.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxEnemyAgentTwo.Location = new System.Drawing.Point(1139, 177);
            this.pictureBoxEnemyAgentTwo.Name = "pictureBoxEnemyAgentTwo";
            this.pictureBoxEnemyAgentTwo.Size = new System.Drawing.Size(80, 120);
            this.pictureBoxEnemyAgentTwo.TabIndex = 5;
            this.pictureBoxEnemyAgentTwo.TabStop = false;
            this.pictureBoxEnemyAgentTwo.Tag = "Legion";
            this.pictureBoxEnemyAgentTwo.Paint += new System.Windows.Forms.PaintEventHandler(this.EnemyAgent_Paint);
            // 
            // labelGate
            // 
            this.labelGate.AutoSize = true;
            this.labelGate.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelGate.Location = new System.Drawing.Point(1419, 177);
            this.labelGate.Name = "labelGate";
            this.labelGate.Size = new System.Drawing.Size(81, 19);
            this.labelGate.TabIndex = 6;
            this.labelGate.Text = "Tower 2D";
            // 
            // pictureBoxPickup
            // 
            this.pictureBoxPickup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBoxPickup.Location = new System.Drawing.Point(229, 570);
            this.pictureBoxPickup.Name = "pictureBoxPickup";
            this.pictureBoxPickup.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxPickup.TabIndex = 7;
            this.pictureBoxPickup.TabStop = false;
            this.pictureBoxPickup.Tag = "Pickup";
            // 
            // labelRegen
            // 
            this.labelRegen.AutoSize = true;
            this.labelRegen.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelRegen.Location = new System.Drawing.Point(32, 696);
            this.labelRegen.Name = "labelRegen";
            this.labelRegen.Size = new System.Drawing.Size(0, 15);
            this.labelRegen.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(1229, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(301, 117);
            this.panel2.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Controls: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Up: \"W\" or up arrow";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "Right: \"D\" or right arrow";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 15);
            this.label8.TabIndex = 3;
            this.label8.Text = "Left: \"A\" or left arrow";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 15);
            this.label9.TabIndex = 4;
            this.label9.Text = "Down: \"S\" or down arrow";
            // 
            // OpenWorldCenterScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1544, 732);
            this.Controls.Add(this.labelRegen);
            this.Controls.Add(this.pictureBoxPickup);
            this.Controls.Add(this.labelGate);
            this.Controls.Add(this.pictureBoxEnemyAgentTwo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBoxEnemyAgentOne);
            this.Controls.Add(this.pictureBoxTowerEntrance);
            this.Controls.Add(this.player);
            this.Name = "OpenWorldCenterScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OpenWorldCenterScreen";
            this.Load += new System.EventHandler(this.OpenWorldCenterScreen_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.OpenWorldCenterScreen_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OpenWorldCenterScreen_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OpenWorldCenterScreen_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTowerEntrance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnemyAgentOne)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRelicIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArmorIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWeaponIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnemyAgentTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPickup)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
        private PictureBox player;
        private System.Windows.Forms.Timer emojiTimer;
        private PictureBox pictureBoxTowerEntrance;
        private PictureBox pictureBoxEnemyAgentOne;
        private Label labelPlayerName;
        private Panel panel1;
        private PictureBox pictureBoxWeaponIcon;
        private Label labelPlayerMaxHP;
        private Label label3;
        private Label labelAccuracy;
        private Label labelLv;
        private Label labelPlayerAttackValue;
        private Label labelExpInfo;
        private Label labelPlayerLvValue;
        private Label labelExpTotal;
        private Label labelDef;
        private Label labelExp;
        private Label labelPlayerDefenseValue;
        private Label labelExpCurrent;
        private Label labelPlayerAccuracyValue;
        private Label labelHP;
        private Label labelPlayerCurrentHP;
        private Label labelAttack;
        private Label labelRelic;
        private Label labelArmor;
        private Label labelWeapon;
        private PictureBox pictureBoxRelicIcon;
        private PictureBox pictureBoxArmorIcon;
        private PictureBox pictureBoxEnemyAgentTwo;
        private Label labelGate;
        private PictureBox pictureBoxPickup;
        private Label label1;
        private PictureBox pictureBoxPotion;
        private Label label4;
        private Label label2;
        private Label labelRegen;
        private Panel panel2;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
    }
}