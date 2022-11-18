namespace My_isekai_project.GUI
{
    partial class CombatScreen
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
            this.player = new System.Windows.Forms.PictureBox();
            this.panelPlayerStats = new System.Windows.Forms.Panel();
            this.labelExpInfo = new System.Windows.Forms.Label();
            this.labelExp = new System.Windows.Forms.Label();
            this.labelAccuracy = new System.Windows.Forms.Label();
            this.labelExpTotal = new System.Windows.Forms.Label();
            this.labelDef = new System.Windows.Forms.Label();
            this.labelExpCurrent = new System.Windows.Forms.Label();
            this.labelAttack = new System.Windows.Forms.Label();
            this.labelPlayerLvValue = new System.Windows.Forms.Label();
            this.labelLv = new System.Windows.Forms.Label();
            this.labelPlayerAccuracyValue = new System.Windows.Forms.Label();
            this.labelPlayerName = new System.Windows.Forms.Label();
            this.labelPlayerDefenseValue = new System.Windows.Forms.Label();
            this.labelPlayerAttackValue = new System.Windows.Forms.Label();
            this.pictureBoxPlayerRelic = new System.Windows.Forms.PictureBox();
            this.pictureBoxPlayerArmor = new System.Windows.Forms.PictureBox();
            this.pictureBoxPlayerWeapon = new System.Windows.Forms.PictureBox();
            this.labelPlayerMaxHP = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelPlayerCurrentHP = new System.Windows.Forms.Label();
            this.progressBarPlayerHp = new System.Windows.Forms.ProgressBar();
            this.labelHP = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelDropChance = new System.Windows.Forms.Panel();
            this.labelDropInv = new System.Windows.Forms.Label();
            this.labelDrop = new System.Windows.Forms.Label();
            this.pictureBoxDropItem = new System.Windows.Forms.PictureBox();
            this.labelAccuracyEnemy = new System.Windows.Forms.Label();
            this.labelDefenseEnemy = new System.Windows.Forms.Label();
            this.labelAttackEnemy = new System.Windows.Forms.Label();
            this.labelEnemyAccuracyValue = new System.Windows.Forms.Label();
            this.labelEnemyName = new System.Windows.Forms.Label();
            this.labelEnemyDefenseValue = new System.Windows.Forms.Label();
            this.labelEnemyAttackValue = new System.Windows.Forms.Label();
            this.labelEnemyHpMax = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.labelEnemyHpCurrent = new System.Windows.Forms.Label();
            this.progressBarEnemy = new System.Windows.Forms.ProgressBar();
            this.labelHpEnemy = new System.Windows.Forms.Label();
            this.enemy = new System.Windows.Forms.PictureBox();
            this.gameTimerCombat = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonEscape = new System.Windows.Forms.Button();
            this.buttonDefend = new System.Windows.Forms.Button();
            this.buttonAttack = new System.Windows.Forms.Button();
            this.panelInfoPanel = new System.Windows.Forms.Panel();
            this.labelInfo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTitleInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.panelPlayerStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayerRelic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayerArmor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayerWeapon)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelDropChance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDropItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy)).BeginInit();
            this.panel3.SuspendLayout();
            this.panelInfoPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.SystemColors.Control;
            this.player.Location = new System.Drawing.Point(266, 235);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(80, 120);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 1;
            this.player.TabStop = false;
            this.player.Paint += new System.Windows.Forms.PaintEventHandler(this.player_Paint);
            // 
            // panelPlayerStats
            // 
            this.panelPlayerStats.BackColor = System.Drawing.Color.OldLace;
            this.panelPlayerStats.Controls.Add(this.labelExpInfo);
            this.panelPlayerStats.Controls.Add(this.labelExp);
            this.panelPlayerStats.Controls.Add(this.labelAccuracy);
            this.panelPlayerStats.Controls.Add(this.labelExpTotal);
            this.panelPlayerStats.Controls.Add(this.labelDef);
            this.panelPlayerStats.Controls.Add(this.labelExpCurrent);
            this.panelPlayerStats.Controls.Add(this.labelAttack);
            this.panelPlayerStats.Controls.Add(this.labelPlayerLvValue);
            this.panelPlayerStats.Controls.Add(this.labelLv);
            this.panelPlayerStats.Controls.Add(this.labelPlayerAccuracyValue);
            this.panelPlayerStats.Controls.Add(this.labelPlayerName);
            this.panelPlayerStats.Controls.Add(this.labelPlayerDefenseValue);
            this.panelPlayerStats.Controls.Add(this.labelPlayerAttackValue);
            this.panelPlayerStats.Controls.Add(this.pictureBoxPlayerRelic);
            this.panelPlayerStats.Controls.Add(this.pictureBoxPlayerArmor);
            this.panelPlayerStats.Controls.Add(this.pictureBoxPlayerWeapon);
            this.panelPlayerStats.Controls.Add(this.labelPlayerMaxHP);
            this.panelPlayerStats.Controls.Add(this.label3);
            this.panelPlayerStats.Controls.Add(this.labelPlayerCurrentHP);
            this.panelPlayerStats.Controls.Add(this.progressBarPlayerHp);
            this.panelPlayerStats.Controls.Add(this.labelHP);
            this.panelPlayerStats.Location = new System.Drawing.Point(34, 42);
            this.panelPlayerStats.Name = "panelPlayerStats";
            this.panelPlayerStats.Size = new System.Drawing.Size(361, 137);
            this.panelPlayerStats.TabIndex = 2;
            // 
            // labelExpInfo
            // 
            this.labelExpInfo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelExpInfo.Location = new System.Drawing.Point(206, 103);
            this.labelExpInfo.Name = "labelExpInfo";
            this.labelExpInfo.Size = new System.Drawing.Size(51, 19);
            this.labelExpInfo.TabIndex = 15;
            this.labelExpInfo.Text = "EXP: ";
            // 
            // labelExp
            // 
            this.labelExp.AutoSize = true;
            this.labelExp.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelExp.Location = new System.Drawing.Point(287, 103);
            this.labelExp.Name = "labelExp";
            this.labelExp.Size = new System.Drawing.Size(18, 19);
            this.labelExp.TabIndex = 14;
            this.labelExp.Text = "/";
            // 
            // labelAccuracy
            // 
            this.labelAccuracy.AutoSize = true;
            this.labelAccuracy.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAccuracy.Location = new System.Drawing.Point(35, 103);
            this.labelAccuracy.Name = "labelAccuracy";
            this.labelAccuracy.Size = new System.Drawing.Size(99, 19);
            this.labelAccuracy.TabIndex = 16;
            this.labelAccuracy.Text = "Accuracy: ";
            // 
            // labelExpTotal
            // 
            this.labelExpTotal.AutoSize = true;
            this.labelExpTotal.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelExpTotal.Location = new System.Drawing.Point(302, 103);
            this.labelExpTotal.Name = "labelExpTotal";
            this.labelExpTotal.Size = new System.Drawing.Size(36, 19);
            this.labelExpTotal.TabIndex = 6;
            this.labelExpTotal.Text = "100";
            // 
            // labelDef
            // 
            this.labelDef.AutoSize = true;
            this.labelDef.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDef.Location = new System.Drawing.Point(43, 83);
            this.labelDef.Name = "labelDef";
            this.labelDef.Size = new System.Drawing.Size(90, 19);
            this.labelDef.TabIndex = 15;
            this.labelDef.Text = "Defense: ";
            // 
            // labelExpCurrent
            // 
            this.labelExpCurrent.AutoSize = true;
            this.labelExpCurrent.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelExpCurrent.Location = new System.Drawing.Point(253, 103);
            this.labelExpCurrent.Name = "labelExpCurrent";
            this.labelExpCurrent.Size = new System.Drawing.Size(18, 19);
            this.labelExpCurrent.TabIndex = 5;
            this.labelExpCurrent.Text = "0";
            // 
            // labelAttack
            // 
            this.labelAttack.AutoSize = true;
            this.labelAttack.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAttack.Location = new System.Drawing.Point(52, 65);
            this.labelAttack.Name = "labelAttack";
            this.labelAttack.Size = new System.Drawing.Size(81, 19);
            this.labelAttack.TabIndex = 14;
            this.labelAttack.Text = "Attack: ";
            // 
            // labelPlayerLvValue
            // 
            this.labelPlayerLvValue.AutoSize = true;
            this.labelPlayerLvValue.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPlayerLvValue.Location = new System.Drawing.Point(240, 8);
            this.labelPlayerLvValue.Name = "labelPlayerLvValue";
            this.labelPlayerLvValue.Size = new System.Drawing.Size(18, 19);
            this.labelPlayerLvValue.TabIndex = 13;
            this.labelPlayerLvValue.Text = "1";
            // 
            // labelLv
            // 
            this.labelLv.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelLv.Location = new System.Drawing.Point(175, 8);
            this.labelLv.Name = "labelLv";
            this.labelLv.Size = new System.Drawing.Size(66, 19);
            this.labelLv.TabIndex = 12;
            this.labelLv.Text = "Level: ";
            // 
            // labelPlayerAccuracyValue
            // 
            this.labelPlayerAccuracyValue.AutoSize = true;
            this.labelPlayerAccuracyValue.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPlayerAccuracyValue.Location = new System.Drawing.Point(129, 104);
            this.labelPlayerAccuracyValue.Name = "labelPlayerAccuracyValue";
            this.labelPlayerAccuracyValue.Size = new System.Drawing.Size(27, 19);
            this.labelPlayerAccuracyValue.TabIndex = 10;
            this.labelPlayerAccuracyValue.Text = "99";
            // 
            // labelPlayerName
            // 
            this.labelPlayerName.AutoSize = true;
            this.labelPlayerName.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPlayerName.Location = new System.Drawing.Point(34, 8);
            this.labelPlayerName.Name = "labelPlayerName";
            this.labelPlayerName.Size = new System.Drawing.Size(45, 19);
            this.labelPlayerName.TabIndex = 11;
            this.labelPlayerName.Text = "Name";
            // 
            // labelPlayerDefenseValue
            // 
            this.labelPlayerDefenseValue.AutoSize = true;
            this.labelPlayerDefenseValue.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPlayerDefenseValue.Location = new System.Drawing.Point(129, 84);
            this.labelPlayerDefenseValue.Name = "labelPlayerDefenseValue";
            this.labelPlayerDefenseValue.Size = new System.Drawing.Size(27, 19);
            this.labelPlayerDefenseValue.TabIndex = 9;
            this.labelPlayerDefenseValue.Text = "99";
            // 
            // labelPlayerAttackValue
            // 
            this.labelPlayerAttackValue.AutoSize = true;
            this.labelPlayerAttackValue.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPlayerAttackValue.Location = new System.Drawing.Point(129, 65);
            this.labelPlayerAttackValue.Name = "labelPlayerAttackValue";
            this.labelPlayerAttackValue.Size = new System.Drawing.Size(27, 19);
            this.labelPlayerAttackValue.TabIndex = 8;
            this.labelPlayerAttackValue.Text = "99";
            // 
            // pictureBoxPlayerRelic
            // 
            this.pictureBoxPlayerRelic.BackColor = System.Drawing.Color.Tan;
            this.pictureBoxPlayerRelic.Location = new System.Drawing.Point(305, 66);
            this.pictureBoxPlayerRelic.Name = "pictureBoxPlayerRelic";
            this.pictureBoxPlayerRelic.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxPlayerRelic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPlayerRelic.TabIndex = 7;
            this.pictureBoxPlayerRelic.TabStop = false;
            // 
            // pictureBoxPlayerArmor
            // 
            this.pictureBoxPlayerArmor.BackColor = System.Drawing.Color.Tan;
            this.pictureBoxPlayerArmor.Location = new System.Drawing.Point(259, 66);
            this.pictureBoxPlayerArmor.Name = "pictureBoxPlayerArmor";
            this.pictureBoxPlayerArmor.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxPlayerArmor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPlayerArmor.TabIndex = 6;
            this.pictureBoxPlayerArmor.TabStop = false;
            // 
            // pictureBoxPlayerWeapon
            // 
            this.pictureBoxPlayerWeapon.BackColor = System.Drawing.Color.Tan;
            this.pictureBoxPlayerWeapon.Location = new System.Drawing.Point(211, 66);
            this.pictureBoxPlayerWeapon.Name = "pictureBoxPlayerWeapon";
            this.pictureBoxPlayerWeapon.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxPlayerWeapon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPlayerWeapon.TabIndex = 5;
            this.pictureBoxPlayerWeapon.TabStop = false;
            // 
            // labelPlayerMaxHP
            // 
            this.labelPlayerMaxHP.AutoSize = true;
            this.labelPlayerMaxHP.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPlayerMaxHP.Location = new System.Drawing.Point(306, 35);
            this.labelPlayerMaxHP.Name = "labelPlayerMaxHP";
            this.labelPlayerMaxHP.Size = new System.Drawing.Size(36, 19);
            this.labelPlayerMaxHP.TabIndex = 4;
            this.labelPlayerMaxHP.Text = "200";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(294, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "/";
            // 
            // labelPlayerCurrentHP
            // 
            this.labelPlayerCurrentHP.AutoSize = true;
            this.labelPlayerCurrentHP.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPlayerCurrentHP.Location = new System.Drawing.Point(264, 35);
            this.labelPlayerCurrentHP.Name = "labelPlayerCurrentHP";
            this.labelPlayerCurrentHP.Size = new System.Drawing.Size(36, 19);
            this.labelPlayerCurrentHP.TabIndex = 2;
            this.labelPlayerCurrentHP.Text = "200";
            // 
            // progressBarPlayerHp
            // 
            this.progressBarPlayerHp.Location = new System.Drawing.Point(34, 33);
            this.progressBarPlayerHp.Maximum = 300;
            this.progressBarPlayerHp.Name = "progressBarPlayerHp";
            this.progressBarPlayerHp.Size = new System.Drawing.Size(227, 23);
            this.progressBarPlayerHp.TabIndex = 1;
            this.progressBarPlayerHp.Value = 100;
            // 
            // labelHP
            // 
            this.labelHP.AutoSize = true;
            this.labelHP.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelHP.Location = new System.Drawing.Point(5, 35);
            this.labelHP.Name = "labelHP";
            this.labelHP.Size = new System.Drawing.Size(27, 19);
            this.labelHP.TabIndex = 0;
            this.labelHP.Text = "HP";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OldLace;
            this.panel1.Controls.Add(this.panelDropChance);
            this.panel1.Controls.Add(this.labelAccuracyEnemy);
            this.panel1.Controls.Add(this.labelDefenseEnemy);
            this.panel1.Controls.Add(this.labelAttackEnemy);
            this.panel1.Controls.Add(this.labelEnemyAccuracyValue);
            this.panel1.Controls.Add(this.labelEnemyName);
            this.panel1.Controls.Add(this.labelEnemyDefenseValue);
            this.panel1.Controls.Add(this.labelEnemyAttackValue);
            this.panel1.Controls.Add(this.labelEnemyHpMax);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.labelEnemyHpCurrent);
            this.panel1.Controls.Add(this.progressBarEnemy);
            this.panel1.Controls.Add(this.labelHpEnemy);
            this.panel1.Location = new System.Drawing.Point(660, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(361, 137);
            this.panel1.TabIndex = 17;
            // 
            // panelDropChance
            // 
            this.panelDropChance.BackColor = System.Drawing.Color.Transparent;
            this.panelDropChance.Controls.Add(this.labelDropInv);
            this.panelDropChance.Controls.Add(this.labelDrop);
            this.panelDropChance.Controls.Add(this.pictureBoxDropItem);
            this.panelDropChance.Location = new System.Drawing.Point(189, 65);
            this.panelDropChance.Name = "panelDropChance";
            this.panelDropChance.Size = new System.Drawing.Size(153, 57);
            this.panelDropChance.TabIndex = 18;
            this.panelDropChance.Visible = false;
            // 
            // labelDropInv
            // 
            this.labelDropInv.AutoSize = true;
            this.labelDropInv.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.labelDropInv.Location = new System.Drawing.Point(15, 32);
            this.labelDropInv.Name = "labelDropInv";
            this.labelDropInv.Size = new System.Drawing.Size(91, 15);
            this.labelDropInv.TabIndex = 18;
            this.labelDropInv.Text = "Drop Name...";
            // 
            // labelDrop
            // 
            this.labelDrop.AutoSize = true;
            this.labelDrop.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDrop.Location = new System.Drawing.Point(13, 10);
            this.labelDrop.Name = "labelDrop";
            this.labelDrop.Size = new System.Drawing.Size(99, 19);
            this.labelDrop.TabIndex = 17;
            this.labelDrop.Text = "May Drop: ";
            // 
            // pictureBoxDropItem
            // 
            this.pictureBoxDropItem.BackColor = System.Drawing.Color.Tan;
            this.pictureBoxDropItem.Location = new System.Drawing.Point(113, 14);
            this.pictureBoxDropItem.Name = "pictureBoxDropItem";
            this.pictureBoxDropItem.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxDropItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDropItem.TabIndex = 7;
            this.pictureBoxDropItem.TabStop = false;
            // 
            // labelAccuracyEnemy
            // 
            this.labelAccuracyEnemy.AutoSize = true;
            this.labelAccuracyEnemy.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAccuracyEnemy.Location = new System.Drawing.Point(35, 103);
            this.labelAccuracyEnemy.Name = "labelAccuracyEnemy";
            this.labelAccuracyEnemy.Size = new System.Drawing.Size(99, 19);
            this.labelAccuracyEnemy.TabIndex = 16;
            this.labelAccuracyEnemy.Text = "Accuracy: ";
            // 
            // labelDefenseEnemy
            // 
            this.labelDefenseEnemy.AutoSize = true;
            this.labelDefenseEnemy.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDefenseEnemy.Location = new System.Drawing.Point(43, 83);
            this.labelDefenseEnemy.Name = "labelDefenseEnemy";
            this.labelDefenseEnemy.Size = new System.Drawing.Size(90, 19);
            this.labelDefenseEnemy.TabIndex = 15;
            this.labelDefenseEnemy.Text = "Defense: ";
            // 
            // labelAttackEnemy
            // 
            this.labelAttackEnemy.AutoSize = true;
            this.labelAttackEnemy.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAttackEnemy.Location = new System.Drawing.Point(52, 65);
            this.labelAttackEnemy.Name = "labelAttackEnemy";
            this.labelAttackEnemy.Size = new System.Drawing.Size(81, 19);
            this.labelAttackEnemy.TabIndex = 14;
            this.labelAttackEnemy.Text = "Attack: ";
            // 
            // labelEnemyAccuracyValue
            // 
            this.labelEnemyAccuracyValue.AutoSize = true;
            this.labelEnemyAccuracyValue.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEnemyAccuracyValue.Location = new System.Drawing.Point(129, 104);
            this.labelEnemyAccuracyValue.Name = "labelEnemyAccuracyValue";
            this.labelEnemyAccuracyValue.Size = new System.Drawing.Size(27, 19);
            this.labelEnemyAccuracyValue.TabIndex = 10;
            this.labelEnemyAccuracyValue.Text = "99";
            // 
            // labelEnemyName
            // 
            this.labelEnemyName.AutoSize = true;
            this.labelEnemyName.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEnemyName.Location = new System.Drawing.Point(34, 8);
            this.labelEnemyName.Name = "labelEnemyName";
            this.labelEnemyName.Size = new System.Drawing.Size(45, 19);
            this.labelEnemyName.TabIndex = 11;
            this.labelEnemyName.Text = "Name";
            // 
            // labelEnemyDefenseValue
            // 
            this.labelEnemyDefenseValue.AutoSize = true;
            this.labelEnemyDefenseValue.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEnemyDefenseValue.Location = new System.Drawing.Point(129, 84);
            this.labelEnemyDefenseValue.Name = "labelEnemyDefenseValue";
            this.labelEnemyDefenseValue.Size = new System.Drawing.Size(27, 19);
            this.labelEnemyDefenseValue.TabIndex = 9;
            this.labelEnemyDefenseValue.Text = "99";
            // 
            // labelEnemyAttackValue
            // 
            this.labelEnemyAttackValue.AutoSize = true;
            this.labelEnemyAttackValue.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEnemyAttackValue.Location = new System.Drawing.Point(129, 65);
            this.labelEnemyAttackValue.Name = "labelEnemyAttackValue";
            this.labelEnemyAttackValue.Size = new System.Drawing.Size(27, 19);
            this.labelEnemyAttackValue.TabIndex = 8;
            this.labelEnemyAttackValue.Text = "99";
            // 
            // labelEnemyHpMax
            // 
            this.labelEnemyHpMax.AutoSize = true;
            this.labelEnemyHpMax.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEnemyHpMax.Location = new System.Drawing.Point(306, 35);
            this.labelEnemyHpMax.Name = "labelEnemyHpMax";
            this.labelEnemyHpMax.Size = new System.Drawing.Size(36, 19);
            this.labelEnemyHpMax.TabIndex = 4;
            this.labelEnemyHpMax.Text = "200";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(294, 35);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(18, 19);
            this.label16.TabIndex = 3;
            this.label16.Text = "/";
            // 
            // labelEnemyHpCurrent
            // 
            this.labelEnemyHpCurrent.AutoSize = true;
            this.labelEnemyHpCurrent.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEnemyHpCurrent.Location = new System.Drawing.Point(264, 35);
            this.labelEnemyHpCurrent.Name = "labelEnemyHpCurrent";
            this.labelEnemyHpCurrent.Size = new System.Drawing.Size(36, 19);
            this.labelEnemyHpCurrent.TabIndex = 2;
            this.labelEnemyHpCurrent.Text = "200";
            // 
            // progressBarEnemy
            // 
            this.progressBarEnemy.Location = new System.Drawing.Point(34, 33);
            this.progressBarEnemy.Maximum = 300;
            this.progressBarEnemy.Name = "progressBarEnemy";
            this.progressBarEnemy.Size = new System.Drawing.Size(227, 23);
            this.progressBarEnemy.TabIndex = 1;
            this.progressBarEnemy.Value = 100;
            // 
            // labelHpEnemy
            // 
            this.labelHpEnemy.AutoSize = true;
            this.labelHpEnemy.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelHpEnemy.Location = new System.Drawing.Point(5, 35);
            this.labelHpEnemy.Name = "labelHpEnemy";
            this.labelHpEnemy.Size = new System.Drawing.Size(27, 19);
            this.labelHpEnemy.TabIndex = 0;
            this.labelHpEnemy.Text = "HP";
            // 
            // enemy
            // 
            this.enemy.BackColor = System.Drawing.SystemColors.Control;
            this.enemy.Location = new System.Drawing.Point(703, 203);
            this.enemy.Name = "enemy";
            this.enemy.Size = new System.Drawing.Size(80, 152);
            this.enemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy.TabIndex = 18;
            this.enemy.TabStop = false;
            this.enemy.Paint += new System.Windows.Forms.PaintEventHandler(this.enemy_Paint);
            // 
            // gameTimerCombat
            // 
            this.gameTimerCombat.Interval = 2000;
            this.gameTimerCombat.Tick += new System.EventHandler(this.gameTimerCombat_Tick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.OldLace;
            this.panel3.Controls.Add(this.buttonEscape);
            this.panel3.Controls.Add(this.buttonDefend);
            this.panel3.Controls.Add(this.buttonAttack);
            this.panel3.Location = new System.Drawing.Point(271, 536);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(506, 94);
            this.panel3.TabIndex = 19;
            // 
            // buttonEscape
            // 
            this.buttonEscape.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonEscape.Location = new System.Drawing.Point(350, 20);
            this.buttonEscape.Name = "buttonEscape";
            this.buttonEscape.Size = new System.Drawing.Size(134, 57);
            this.buttonEscape.TabIndex = 3;
            this.buttonEscape.Text = "Escape";
            this.buttonEscape.UseVisualStyleBackColor = true;
            this.buttonEscape.Click += new System.EventHandler(this.buttonEscape_Click);
            // 
            // buttonDefend
            // 
            this.buttonDefend.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonDefend.Location = new System.Drawing.Point(182, 20);
            this.buttonDefend.Name = "buttonDefend";
            this.buttonDefend.Size = new System.Drawing.Size(134, 57);
            this.buttonDefend.TabIndex = 2;
            this.buttonDefend.Text = "Defend";
            this.buttonDefend.UseVisualStyleBackColor = true;
            this.buttonDefend.Click += new System.EventHandler(this.buttonDefend_Click);
            // 
            // buttonAttack
            // 
            this.buttonAttack.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAttack.Location = new System.Drawing.Point(17, 20);
            this.buttonAttack.Name = "buttonAttack";
            this.buttonAttack.Size = new System.Drawing.Size(134, 57);
            this.buttonAttack.TabIndex = 0;
            this.buttonAttack.Text = "Attack";
            this.buttonAttack.UseVisualStyleBackColor = true;
            this.buttonAttack.Click += new System.EventHandler(this.buttonAttack_Click);
            // 
            // panelInfoPanel
            // 
            this.panelInfoPanel.BackColor = System.Drawing.Color.OldLace;
            this.panelInfoPanel.Controls.Add(this.labelTitleInfo);
            this.panelInfoPanel.Controls.Add(this.labelInfo);
            this.panelInfoPanel.Location = new System.Drawing.Point(358, 370);
            this.panelInfoPanel.Name = "panelInfoPanel";
            this.panelInfoPanel.Size = new System.Drawing.Size(334, 143);
            this.panelInfoPanel.TabIndex = 20;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.labelInfo.Location = new System.Drawing.Point(37, 40);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(0, 19);
            this.labelInfo.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(856, 556);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(202, 57);
            this.panel2.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "Press a button to act";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(787, 569);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "<---";
            // 
            // labelTitleInfo
            // 
            this.labelTitleInfo.AutoSize = true;
            this.labelTitleInfo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.labelTitleInfo.Location = new System.Drawing.Point(5, 9);
            this.labelTitleInfo.Name = "labelTitleInfo";
            this.labelTitleInfo.Size = new System.Drawing.Size(72, 19);
            this.labelTitleInfo.TabIndex = 1;
            this.labelTitleInfo.Text = "Info...";
            // 
            // CombatScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 642);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelInfoPanel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.enemy);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelPlayerStats);
            this.Controls.Add(this.player);
            this.Name = "CombatScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CombatScreen";
            this.Load += new System.EventHandler(this.CombatScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.panelPlayerStats.ResumeLayout(false);
            this.panelPlayerStats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayerRelic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayerArmor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayerWeapon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelDropChance.ResumeLayout(false);
            this.panelDropChance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDropItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panelInfoPanel.ResumeLayout(false);
            this.panelInfoPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox player;
        private Panel panelPlayerStats;
        private PictureBox pictureBoxPlayerRelic;
        private PictureBox pictureBoxPlayerArmor;
        private PictureBox pictureBoxPlayerWeapon;
        private Label labelPlayerMaxHP;
        private Label label3;
        private Label labelPlayerCurrentHP;
        private ProgressBar progressBarPlayerHp;
        private Label labelHP;
        private Label labelPlayerAttackValue;
        private Label labelPlayerName;
        private Label labelPlayerAccuracyValue;
        private Label labelPlayerDefenseValue;
        private Label labelExpInfo;
        private Label labelExp;
        private Label labelAccuracy;
        private Label labelExpTotal;
        private Label labelDef;
        private Label labelExpCurrent;
        private Label labelAttack;
        private Label labelPlayerLvValue;
        private Label labelLv;
        private Panel panel1;
        private Panel panelDropChance;
        private Label labelDrop;
        private PictureBox pictureBoxDropItem;
        private Label labelAccuracyEnemy;
        private Label labelDefenseEnemy;
        private Label labelAttackEnemy;
        private Label labelEnemyAccuracyValue;
        private Label labelEnemyName;
        private Label labelEnemyDefenseValue;
        private Label labelEnemyAttackValue;
        private Label labelEnemyHpMax;
        private Label label16;
        private Label labelEnemyHpCurrent;
        private ProgressBar progressBarEnemy;
        private Label labelHpEnemy;
        private PictureBox enemy;
        private System.Windows.Forms.Timer gameTimerCombat;
        private Panel panel3;
        private Button buttonEscape;
        private Button buttonDefend;
        private Button buttonAttack;
        private Panel panelInfoPanel;
        private Label labelInfo;
        private Label labelDropInv;
        private Panel panel2;
        private Label label7;
        private Label label5;
        private Label label1;
        private Label labelTitleInfo;
    }
}