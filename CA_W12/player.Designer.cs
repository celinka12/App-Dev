namespace CA_W12
{
    partial class player
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
            this.dgv_tampil = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_Team = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tampil)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_tampil
            // 
            this.dgv_tampil.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_tampil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tampil.Location = new System.Drawing.Point(39, 118);
            this.dgv_tampil.Name = "dgv_tampil";
            this.dgv_tampil.RowHeadersWidth = 82;
            this.dgv_tampil.RowTemplate.Height = 33;
            this.dgv_tampil.Size = new System.Drawing.Size(1052, 612);
            this.dgv_tampil.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 25);
            this.label9.TabIndex = 29;
            this.label9.Text = "Team Name";
            // 
            // cb_Team
            // 
            this.cb_Team.FormattingEnabled = true;
            this.cb_Team.Location = new System.Drawing.Point(26, 53);
            this.cb_Team.Name = "cb_Team";
            this.cb_Team.Size = new System.Drawing.Size(225, 33);
            this.cb_Team.TabIndex = 28;
            this.cb_Team.SelectedIndexChanged += new System.EventHandler(this.cb_Team_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(448, 750);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 59);
            this.button1.TabIndex = 30;
            this.button1.Text = "Remove";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 829);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cb_Team);
            this.Controls.Add(this.dgv_tampil);
            this.Name = "player";
            this.Text = "player";
            this.Load += new System.EventHandler(this.player_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tampil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_tampil;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cb_Team;
        private System.Windows.Forms.Button button1;
    }
}