namespace My_isekai_project.GUI
{
    partial class TitleScreen
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
            this.buttonStartGame = new System.Windows.Forms.Button();
            this.buttonQuitGame = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonStartGame
            // 
            this.buttonStartGame.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonStartGame.Location = new System.Drawing.Point(272, 162);
            this.buttonStartGame.Name = "buttonStartGame";
            this.buttonStartGame.Size = new System.Drawing.Size(244, 63);
            this.buttonStartGame.TabIndex = 0;
            this.buttonStartGame.Text = "Start Game";
            this.buttonStartGame.UseVisualStyleBackColor = true;
            this.buttonStartGame.Click += new System.EventHandler(this.buttonStartGame_Click);
            // 
            // buttonQuitGame
            // 
            this.buttonQuitGame.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonQuitGame.Location = new System.Drawing.Point(272, 283);
            this.buttonQuitGame.Name = "buttonQuitGame";
            this.buttonQuitGame.Size = new System.Drawing.Size(244, 63);
            this.buttonQuitGame.TabIndex = 1;
            this.buttonQuitGame.Text = "Quit Game";
            this.buttonQuitGame.UseVisualStyleBackColor = true;
            this.buttonQuitGame.Click += new System.EventHandler(this.buttonQuitGame_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Consolas", 48F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(45, 38);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(697, 75);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "My Isekai Adventure";
            // 
            // TitleScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonQuitGame);
            this.Controls.Add(this.buttonStartGame);
            this.Name = "TitleScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TitleScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonStartGame;
        private Button buttonQuitGame;
        private Label labelTitle;
    }
}