namespace My_isekai_project.GUI
{
    partial class HeroSelectionScreen
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
            this.buttonBeginAdventure = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.pictureBoxCharacterOne = new System.Windows.Forms.PictureBox();
            this.pictureBoxCharacterTwo = new System.Windows.Forms.PictureBox();
            this.pictureBoxCharacterThree = new System.Windows.Forms.PictureBox();
            this.labelCharacterOne = new System.Windows.Forms.Label();
            this.labelCharacterTwo = new System.Windows.Forms.Label();
            this.labelCharacterThree = new System.Windows.Forms.Label();
            this.EmojiTimer = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCharacterOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCharacterTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCharacterThree)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonBeginAdventure
            // 
            this.buttonBeginAdventure.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonBeginAdventure.Location = new System.Drawing.Point(213, 375);
            this.buttonBeginAdventure.Name = "buttonBeginAdventure";
            this.buttonBeginAdventure.Size = new System.Drawing.Size(360, 63);
            this.buttonBeginAdventure.TabIndex = 1;
            this.buttonBeginAdventure.Text = "Begin Isekai Adventure";
            this.buttonBeginAdventure.UseVisualStyleBackColor = true;
            this.buttonBeginAdventure.Click += new System.EventHandler(this.buttonBeginAdventure_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Consolas", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(75, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(662, 75);
            this.labelTitle.TabIndex = 3;
            this.labelTitle.Text = "Choose your avatar";
            // 
            // pictureBoxCharacterOne
            // 
            this.pictureBoxCharacterOne.BackColor = System.Drawing.Color.LightCyan;
            this.pictureBoxCharacterOne.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxCharacterOne.Location = new System.Drawing.Point(30, 155);
            this.pictureBoxCharacterOne.Name = "pictureBoxCharacterOne";
            this.pictureBoxCharacterOne.Size = new System.Drawing.Size(200, 200);
            this.pictureBoxCharacterOne.TabIndex = 4;
            this.pictureBoxCharacterOne.TabStop = false;
            this.pictureBoxCharacterOne.Click += new System.EventHandler(this.pictureBoxCharacterOne_Click);
            this.pictureBoxCharacterOne.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxCharacterOne_Paint);
            // 
            // pictureBoxCharacterTwo
            // 
            this.pictureBoxCharacterTwo.BackColor = System.Drawing.Color.White;
            this.pictureBoxCharacterTwo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxCharacterTwo.Location = new System.Drawing.Point(290, 155);
            this.pictureBoxCharacterTwo.Name = "pictureBoxCharacterTwo";
            this.pictureBoxCharacterTwo.Size = new System.Drawing.Size(200, 200);
            this.pictureBoxCharacterTwo.TabIndex = 5;
            this.pictureBoxCharacterTwo.TabStop = false;
            this.pictureBoxCharacterTwo.Click += new System.EventHandler(this.pictureBoxCharacterTwo_Click);
            this.pictureBoxCharacterTwo.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxCharacterTwo_Paint);
            // 
            // pictureBoxCharacterThree
            // 
            this.pictureBoxCharacterThree.BackColor = System.Drawing.Color.White;
            this.pictureBoxCharacterThree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxCharacterThree.Location = new System.Drawing.Point(559, 155);
            this.pictureBoxCharacterThree.Name = "pictureBoxCharacterThree";
            this.pictureBoxCharacterThree.Size = new System.Drawing.Size(200, 200);
            this.pictureBoxCharacterThree.TabIndex = 6;
            this.pictureBoxCharacterThree.TabStop = false;
            this.pictureBoxCharacterThree.Click += new System.EventHandler(this.pictureBoxCharacterThree_Click);
            this.pictureBoxCharacterThree.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxCharacterThree_Paint);
            // 
            // labelCharacterOne
            // 
            this.labelCharacterOne.AutoSize = true;
            this.labelCharacterOne.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCharacterOne.Location = new System.Drawing.Point(75, 103);
            this.labelCharacterOne.Name = "labelCharacterOne";
            this.labelCharacterOne.Size = new System.Drawing.Size(125, 37);
            this.labelCharacterOne.TabIndex = 7;
            this.labelCharacterOne.Text = "Smiley";
            // 
            // labelCharacterTwo
            // 
            this.labelCharacterTwo.AutoSize = true;
            this.labelCharacterTwo.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCharacterTwo.Location = new System.Drawing.Point(321, 103);
            this.labelCharacterTwo.Name = "labelCharacterTwo";
            this.labelCharacterTwo.Size = new System.Drawing.Size(143, 37);
            this.labelCharacterTwo.TabIndex = 8;
            this.labelCharacterTwo.Text = "Neutrey";
            // 
            // labelCharacterThree
            // 
            this.labelCharacterThree.AutoSize = true;
            this.labelCharacterThree.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCharacterThree.Location = new System.Drawing.Point(597, 103);
            this.labelCharacterThree.Name = "labelCharacterThree";
            this.labelCharacterThree.Size = new System.Drawing.Size(125, 37);
            this.labelCharacterThree.TabIndex = 9;
            this.labelCharacterThree.Text = "Sadley";
            // 
            // EmojiTimer
            // 
            this.EmojiTimer.Enabled = true;
            this.EmojiTimer.Interval = 50;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(597, 389);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(191, 49);
            this.panel2.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "Left click on picture";
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
            // HeroSelectionScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBoxCharacterOne);
            this.Controls.Add(this.labelCharacterThree);
            this.Controls.Add(this.labelCharacterTwo);
            this.Controls.Add(this.labelCharacterOne);
            this.Controls.Add(this.pictureBoxCharacterThree);
            this.Controls.Add(this.pictureBoxCharacterTwo);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonBeginAdventure);
            this.Name = "HeroSelectionScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HeroSelectionScreen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCharacterOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCharacterTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCharacterThree)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonBeginAdventure;
        private Label labelTitle;
        private PictureBox pictureBoxCharacterOne;
        private PictureBox pictureBoxCharacterTwo;
        private PictureBox pictureBoxCharacterThree;
        private Label labelCharacterOne;
        private Label labelCharacterTwo;
        private Label labelCharacterThree;
        private System.Windows.Forms.Timer EmojiTimer;
        private Panel panel2;
        private Label label7;
        private Label label5;
    }
}