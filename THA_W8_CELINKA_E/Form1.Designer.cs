namespace THA_W8_CELINKA_E
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.playerDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showMatchDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cb_chooseteam = new System.Windows.Forms.ComboBox();
            this.cb_chooseplayer = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_Yellow = new System.Windows.Forms.Label();
            this.label_Penalty = new System.Windows.Forms.Label();
            this.label_Goal = new System.Windows.Forms.Label();
            this.label_Red = new System.Windows.Forms.Label();
            this.label_PlayingPos = new System.Windows.Forms.Label();
            this.label_nation = new System.Windows.Forms.Label();
            this.label_Position = new System.Windows.Forms.Label();
            this.label_Team = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playerDataToolStripMenuItem,
            this.showMatchDetailToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1040, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // playerDataToolStripMenuItem
            // 
            this.playerDataToolStripMenuItem.Name = "playerDataToolStripMenuItem";
            this.playerDataToolStripMenuItem.Size = new System.Drawing.Size(154, 36);
            this.playerDataToolStripMenuItem.Text = "Player Data";
            this.playerDataToolStripMenuItem.Click += new System.EventHandler(this.playerDataToolStripMenuItem_Click);
            // 
            // showMatchDetailToolStripMenuItem
            // 
            this.showMatchDetailToolStripMenuItem.Name = "showMatchDetailToolStripMenuItem";
            this.showMatchDetailToolStripMenuItem.Size = new System.Drawing.Size(235, 36);
            this.showMatchDetailToolStripMenuItem.Text = "Show Match Detail";
            this.showMatchDetailToolStripMenuItem.Click += new System.EventHandler(this.showMatchDetailToolStripMenuItem_Click);
            // 
            // cb_chooseteam
            // 
            this.cb_chooseteam.FormattingEnabled = true;
            this.cb_chooseteam.Location = new System.Drawing.Point(22, 60);
            this.cb_chooseteam.Name = "cb_chooseteam";
            this.cb_chooseteam.Size = new System.Drawing.Size(230, 33);
            this.cb_chooseteam.TabIndex = 1;
            this.cb_chooseteam.SelectedIndexChanged += new System.EventHandler(this.cb_pilihteam_SelectedIndexChanged);
            // 
            // cb_chooseplayer
            // 
            this.cb_chooseplayer.FormattingEnabled = true;
            this.cb_chooseplayer.Location = new System.Drawing.Point(332, 60);
            this.cb_chooseplayer.Name = "cb_chooseplayer";
            this.cb_chooseplayer.Size = new System.Drawing.Size(231, 33);
            this.cb_chooseplayer.TabIndex = 2;
            this.cb_chooseplayer.SelectedIndexChanged += new System.EventHandler(this.cb_chooseplayer_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Team :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(333, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Player :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_Yellow);
            this.panel1.Controls.Add(this.label_Penalty);
            this.panel1.Controls.Add(this.label_Goal);
            this.panel1.Controls.Add(this.label_Red);
            this.panel1.Controls.Add(this.label_PlayingPos);
            this.panel1.Controls.Add(this.label_nation);
            this.panel1.Controls.Add(this.label_Position);
            this.panel1.Controls.Add(this.label_Team);
            this.panel1.Controls.Add(this.label_Name);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cb_chooseplayer);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cb_chooseteam);
            this.panel1.Location = new System.Drawing.Point(12, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1001, 773);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(15, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1004, 758);
            this.panel2.TabIndex = 7;
            // 
            // label_Yellow
            // 
            this.label_Yellow.AutoSize = true;
            this.label_Yellow.Location = new System.Drawing.Point(242, 473);
            this.label_Yellow.Name = "label_Yellow";
            this.label_Yellow.Size = new System.Drawing.Size(60, 25);
            this.label_Yellow.TabIndex = 22;
            this.label_Yellow.Text = "........";
            this.label_Yellow.Click += new System.EventHandler(this.label20_Click);
            // 
            // label_Penalty
            // 
            this.label_Penalty.AutoSize = true;
            this.label_Penalty.Location = new System.Drawing.Point(242, 559);
            this.label_Penalty.Name = "label_Penalty";
            this.label_Penalty.Size = new System.Drawing.Size(60, 25);
            this.label_Penalty.TabIndex = 21;
            this.label_Penalty.Text = "........";
            // 
            // label_Goal
            // 
            this.label_Goal.AutoSize = true;
            this.label_Goal.Location = new System.Drawing.Point(242, 518);
            this.label_Goal.Name = "label_Goal";
            this.label_Goal.Size = new System.Drawing.Size(60, 25);
            this.label_Goal.TabIndex = 20;
            this.label_Goal.Text = "........";
            // 
            // label_Red
            // 
            this.label_Red.AutoSize = true;
            this.label_Red.Location = new System.Drawing.Point(242, 424);
            this.label_Red.Name = "label_Red";
            this.label_Red.Size = new System.Drawing.Size(60, 25);
            this.label_Red.TabIndex = 19;
            this.label_Red.Text = "........";
            // 
            // label_PlayingPos
            // 
            this.label_PlayingPos.AutoSize = true;
            this.label_PlayingPos.Location = new System.Drawing.Point(242, 375);
            this.label_PlayingPos.Name = "label_PlayingPos";
            this.label_PlayingPos.Size = new System.Drawing.Size(60, 25);
            this.label_PlayingPos.TabIndex = 18;
            this.label_PlayingPos.Text = "........";
            // 
            // label_nation
            // 
            this.label_nation.AutoSize = true;
            this.label_nation.Location = new System.Drawing.Point(242, 328);
            this.label_nation.Name = "label_nation";
            this.label_nation.Size = new System.Drawing.Size(60, 25);
            this.label_nation.TabIndex = 17;
            this.label_nation.Text = "........";
            // 
            // label_Position
            // 
            this.label_Position.AutoSize = true;
            this.label_Position.Location = new System.Drawing.Point(242, 274);
            this.label_Position.Name = "label_Position";
            this.label_Position.Size = new System.Drawing.Size(60, 25);
            this.label_Position.TabIndex = 16;
            this.label_Position.Text = "........";
            // 
            // label_Team
            // 
            this.label_Team.AutoSize = true;
            this.label_Team.Location = new System.Drawing.Point(242, 225);
            this.label_Team.Name = "label_Team";
            this.label_Team.Size = new System.Drawing.Size(60, 25);
            this.label_Team.TabIndex = 15;
            this.label_Team.Text = "........";
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(242, 169);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(60, 25);
            this.label_Name.TabIndex = 14;
            this.label_Name.Text = "........";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(30, 473);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(151, 25);
            this.label11.TabIndex = 13;
            this.label11.Text = "Yellow Cards :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(30, 559);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(177, 25);
            this.label20.TabIndex = 12;
            this.label20.Text = "Penalty Missed : ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(30, 518);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(143, 25);
            this.label12.TabIndex = 11;
            this.label12.Text = "Goal Scored :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 424);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 25);
            this.label10.TabIndex = 10;
            this.label10.Text = "Red Cards :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 375);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 25);
            this.label7.TabIndex = 9;
            this.label7.Text = "Playing Pos :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Nationality :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Position :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Player Team :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Player Name :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 865);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem playerDataToolStripMenuItem;
        private System.Windows.Forms.ComboBox cb_chooseteam;
        private System.Windows.Forms.ComboBox cb_chooseplayer;
        private System.Windows.Forms.ToolStripMenuItem showMatchDetailToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_Yellow;
        private System.Windows.Forms.Label label_Penalty;
        private System.Windows.Forms.Label label_Goal;
        private System.Windows.Forms.Label label_Red;
        private System.Windows.Forms.Label label_PlayingPos;
        private System.Windows.Forms.Label label_nation;
        private System.Windows.Forms.Label label_Position;
        private System.Windows.Forms.Label label_Team;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
    }
}

