namespace Pathfinding_test
{
    partial class PathNodes
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
            this.pathfinderTimer = new System.Windows.Forms.Timer(this.components);
            this.panelGameView = new System.Windows.Forms.Panel();
            this.pictureBoxEvilRed = new System.Windows.Forms.PictureBox();
            this.labelInfo = new System.Windows.Forms.Label();
            this.labelCoord = new System.Windows.Forms.Label();
            this.controllerTimer = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panelGameView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvilRed)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pathfinderTimer
            // 
            this.pathfinderTimer.Enabled = true;
            this.pathfinderTimer.Interval = 1000;
            this.pathfinderTimer.Tick += new System.EventHandler(this.pathfinderTimer_Tick);
            // 
            // panelGameView
            // 
            this.panelGameView.BackColor = System.Drawing.Color.Silver;
            this.panelGameView.Controls.Add(this.pictureBoxEvilRed);
            this.panelGameView.Location = new System.Drawing.Point(12, 49);
            this.panelGameView.Name = "panelGameView";
            this.panelGameView.Size = new System.Drawing.Size(776, 389);
            this.panelGameView.TabIndex = 0;
            this.panelGameView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelGameView_MouseDown);
            this.panelGameView.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelGameView_MouseMove);
            // 
            // pictureBoxEvilRed
            // 
            this.pictureBoxEvilRed.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxEvilRed.Location = new System.Drawing.Point(377, 165);
            this.pictureBoxEvilRed.Name = "pictureBoxEvilRed";
            this.pictureBoxEvilRed.Size = new System.Drawing.Size(80, 144);
            this.pictureBoxEvilRed.TabIndex = 0;
            this.pictureBoxEvilRed.TabStop = false;
            this.pictureBoxEvilRed.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxEvilRed_Paint);
            // 
            // labelInfo
            // 
            this.labelInfo.Location = new System.Drawing.Point(33, 16);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(268, 23);
            this.labelInfo.TabIndex = 1;
            this.labelInfo.Text = "...";
            // 
            // labelCoord
            // 
            this.labelCoord.Location = new System.Drawing.Point(355, 16);
            this.labelCoord.Name = "labelCoord";
            this.labelCoord.Size = new System.Drawing.Size(433, 23);
            this.labelCoord.TabIndex = 2;
            this.labelCoord.Text = "...";
            // 
            // controllerTimer
            // 
            this.controllerTimer.Enabled = true;
            this.controllerTimer.Interval = 20;
            this.controllerTimer.Tick += new System.EventHandler(this.controllerTimer_Tick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(12, 444);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 46);
            this.panel2.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(558, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "Left click on a white node on the grid to add an obstacle or click on a black nod" +
    "e to remove the obstacle.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Controls: ";
            // 
            // PathNodes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 491);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.labelCoord);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.panelGameView);
            this.Name = "PathNodes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PathNodes";
            this.Load += new System.EventHandler(this.PathNodes_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PathNodes_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PathNodes_KeyUp);
            this.panelGameView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvilRed)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer pathfinderTimer;
        private Panel panelGameView;
        private Label labelInfo;
        private Label labelCoord;
        private PictureBox pictureBoxEvilRed;
        private System.Windows.Forms.Timer controllerTimer;
        private Panel panel2;
        private Label label7;
        private Label label5;
    }
}