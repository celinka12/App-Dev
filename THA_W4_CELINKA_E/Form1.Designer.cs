namespace THA_W4_CELINKA_E
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_Country = new System.Windows.Forms.ComboBox();
            this.comboBox_Team = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox_Position = new System.Windows.Forms.ComboBox();
            this.textBox_TName = new System.Windows.Forms.TextBox();
            this.textBox_TCountry = new System.Windows.Forms.TextBox();
            this.textBox_TCity = new System.Windows.Forms.TextBox();
            this.textBox_PName = new System.Windows.Forms.TextBox();
            this.textBox_PNumber = new System.Windows.Forms.TextBox();
            this.btn_Add_Team = new System.Windows.Forms.Button();
            this.btn_Add_Player = new System.Windows.Forms.Button();
            this.listBox_isi = new System.Windows.Forms.ListBox();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Score Team List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Choose Country : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Choose Team : ";
            // 
            // comboBox_Country
            // 
            this.comboBox_Country.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Country.FormattingEnabled = true;
            this.comboBox_Country.Location = new System.Drawing.Point(269, 166);
            this.comboBox_Country.Name = "comboBox_Country";
            this.comboBox_Country.Size = new System.Drawing.Size(195, 33);
            this.comboBox_Country.TabIndex = 3;
            this.comboBox_Country.SelectedIndexChanged += new System.EventHandler(this.comboBox_Country_SelectedIndexChanged);
            // 
            // comboBox_Team
            // 
            this.comboBox_Team.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Team.FormattingEnabled = true;
            this.comboBox_Team.Location = new System.Drawing.Point(269, 257);
            this.comboBox_Team.Name = "comboBox_Team";
            this.comboBox_Team.Size = new System.Drawing.Size(195, 33);
            this.comboBox_Team.TabIndex = 4;
            this.comboBox_Team.SelectedIndexChanged += new System.EventHandler(this.comboBox_Team_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(625, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Adding Team";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(596, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Team Name :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(596, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Team Country :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(596, 340);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "Team City :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1035, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 25);
            this.label8.TabIndex = 9;
            this.label8.Text = "Adding Player";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1042, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(153, 25);
            this.label9.TabIndex = 10;
            this.label9.Text = "Player Name : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1042, 249);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(166, 25);
            this.label10.TabIndex = 11;
            this.label10.Text = "Player Number :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1042, 331);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(174, 25);
            this.label11.TabIndex = 12;
            this.label11.Text = "Player Position : ";
            // 
            // comboBox_Position
            // 
            this.comboBox_Position.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Position.FormattingEnabled = true;
            this.comboBox_Position.Items.AddRange(new object[] {
            "GK",
            "DF",
            "MF",
            "FW"});
            this.comboBox_Position.Location = new System.Drawing.Point(1222, 331);
            this.comboBox_Position.Name = "comboBox_Position";
            this.comboBox_Position.Size = new System.Drawing.Size(195, 33);
            this.comboBox_Position.TabIndex = 13;
            // 
            // textBox_TName
            // 
            this.textBox_TName.Location = new System.Drawing.Point(756, 157);
            this.textBox_TName.Name = "textBox_TName";
            this.textBox_TName.Size = new System.Drawing.Size(204, 31);
            this.textBox_TName.TabIndex = 14;
            // 
            // textBox_TCountry
            // 
            this.textBox_TCountry.Location = new System.Drawing.Point(756, 249);
            this.textBox_TCountry.Name = "textBox_TCountry";
            this.textBox_TCountry.Size = new System.Drawing.Size(204, 31);
            this.textBox_TCountry.TabIndex = 15;
            // 
            // textBox_TCity
            // 
            this.textBox_TCity.Location = new System.Drawing.Point(756, 331);
            this.textBox_TCity.Name = "textBox_TCity";
            this.textBox_TCity.Size = new System.Drawing.Size(204, 31);
            this.textBox_TCity.TabIndex = 16;
            // 
            // textBox_PName
            // 
            this.textBox_PName.Location = new System.Drawing.Point(1222, 154);
            this.textBox_PName.Name = "textBox_PName";
            this.textBox_PName.Size = new System.Drawing.Size(204, 31);
            this.textBox_PName.TabIndex = 17;
            // 
            // textBox_PNumber
            // 
            this.textBox_PNumber.Location = new System.Drawing.Point(1222, 246);
            this.textBox_PNumber.Name = "textBox_PNumber";
            this.textBox_PNumber.Size = new System.Drawing.Size(204, 31);
            this.textBox_PNumber.TabIndex = 18;
            // 
            // btn_Add_Team
            // 
            this.btn_Add_Team.Location = new System.Drawing.Point(803, 420);
            this.btn_Add_Team.Name = "btn_Add_Team";
            this.btn_Add_Team.Size = new System.Drawing.Size(113, 52);
            this.btn_Add_Team.TabIndex = 19;
            this.btn_Add_Team.Text = "Add";
            this.btn_Add_Team.UseVisualStyleBackColor = true;
            this.btn_Add_Team.Click += new System.EventHandler(this.btn_Add_Team_Click);
            // 
            // btn_Add_Player
            // 
            this.btn_Add_Player.Location = new System.Drawing.Point(1265, 416);
            this.btn_Add_Player.Name = "btn_Add_Player";
            this.btn_Add_Player.Size = new System.Drawing.Size(113, 52);
            this.btn_Add_Player.TabIndex = 20;
            this.btn_Add_Player.Text = "Add";
            this.btn_Add_Player.UseVisualStyleBackColor = true;
            this.btn_Add_Player.Click += new System.EventHandler(this.btn_Add_Player_Click);
            // 
            // listBox_isi
            // 
            this.listBox_isi.FormattingEnabled = true;
            this.listBox_isi.ItemHeight = 25;
            this.listBox_isi.Location = new System.Drawing.Point(72, 390);
            this.listBox_isi.Name = "listBox_isi";
            this.listBox_isi.Size = new System.Drawing.Size(373, 304);
            this.listBox_isi.TabIndex = 21;
            // 
            // btn_Remove
            // 
            this.btn_Remove.Location = new System.Drawing.Point(94, 712);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(113, 52);
            this.btn_Remove.TabIndex = 22;
            this.btn_Remove.Text = "Remove";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1631, 812);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.listBox_isi);
            this.Controls.Add(this.btn_Add_Player);
            this.Controls.Add(this.btn_Add_Team);
            this.Controls.Add(this.textBox_PNumber);
            this.Controls.Add(this.textBox_PName);
            this.Controls.Add(this.textBox_TCity);
            this.Controls.Add(this.textBox_TCountry);
            this.Controls.Add(this.textBox_TName);
            this.Controls.Add(this.comboBox_Position);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_Team);
            this.Controls.Add(this.comboBox_Country);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_Country;
        private System.Windows.Forms.ComboBox comboBox_Team;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox_Position;
        private System.Windows.Forms.TextBox textBox_TName;
        private System.Windows.Forms.TextBox textBox_TCountry;
        private System.Windows.Forms.TextBox textBox_TCity;
        private System.Windows.Forms.TextBox textBox_PName;
        private System.Windows.Forms.TextBox textBox_PNumber;
        private System.Windows.Forms.Button btn_Add_Team;
        private System.Windows.Forms.Button btn_Add_Player;
        private System.Windows.Forms.ListBox listBox_isi;
        private System.Windows.Forms.Button btn_Remove;
    }
}

