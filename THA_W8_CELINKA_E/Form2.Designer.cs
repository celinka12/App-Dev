namespace THA_W8_CELINKA_E
{
    partial class Form2
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
            this.dgv_team = new System.Windows.Forms.DataGridView();
            this.dgv_match = new System.Windows.Forms.DataGridView();
            this.panel_form2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_match = new System.Windows.Forms.ComboBox();
            this.cb_team = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_team)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_match)).BeginInit();
            this.panel_form2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_team
            // 
            this.dgv_team.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_team.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_team.Location = new System.Drawing.Point(3, 94);
            this.dgv_team.Name = "dgv_team";
            this.dgv_team.RowHeadersWidth = 82;
            this.dgv_team.RowTemplate.Height = 33;
            this.dgv_team.Size = new System.Drawing.Size(487, 249);
            this.dgv_team.TabIndex = 0;
            // 
            // dgv_match
            // 
            this.dgv_match.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_match.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_match.Location = new System.Drawing.Point(17, 349);
            this.dgv_match.Name = "dgv_match";
            this.dgv_match.RowHeadersWidth = 82;
            this.dgv_match.RowTemplate.Height = 33;
            this.dgv_match.Size = new System.Drawing.Size(959, 235);
            this.dgv_match.TabIndex = 1;
            // 
            // panel_form2
            // 
            this.panel_form2.Controls.Add(this.dataGridView1);
            this.panel_form2.Controls.Add(this.label2);
            this.panel_form2.Controls.Add(this.label1);
            this.panel_form2.Controls.Add(this.cb_match);
            this.panel_form2.Controls.Add(this.cb_team);
            this.panel_form2.Controls.Add(this.dgv_match);
            this.panel_form2.Controls.Add(this.dgv_team);
            this.panel_form2.Location = new System.Drawing.Point(12, 32);
            this.panel_form2.Name = "panel_form2";
            this.panel_form2.Size = new System.Drawing.Size(1004, 611);
            this.panel_form2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(893, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Match :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Team :";
            // 
            // cb_match
            // 
            this.cb_match.FormattingEnabled = true;
            this.cb_match.Location = new System.Drawing.Point(599, 38);
            this.cb_match.Name = "cb_match";
            this.cb_match.Size = new System.Drawing.Size(377, 33);
            this.cb_match.TabIndex = 3;
            this.cb_match.SelectedIndexChanged += new System.EventHandler(this.cb_match_SelectedIndexChanged);
            // 
            // cb_team
            // 
            this.cb_team.FormattingEnabled = true;
            this.cb_team.Location = new System.Drawing.Point(17, 38);
            this.cb_team.Name = "cb_team";
            this.cb_team.Size = new System.Drawing.Size(274, 33);
            this.cb_team.TabIndex = 2;
            this.cb_team.SelectedIndexChanged += new System.EventHandler(this.cb_team_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(496, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(490, 249);
            this.dataGridView1.TabIndex = 6;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 661);
            this.Controls.Add(this.panel_form2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_team)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_match)).EndInit();
            this.panel_form2.ResumeLayout(false);
            this.panel_form2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_team;
        private System.Windows.Forms.DataGridView dgv_match;
        private System.Windows.Forms.Panel panel_form2;
        private System.Windows.Forms.ComboBox cb_team;
        private System.Windows.Forms.ComboBox cb_match;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}