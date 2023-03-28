namespace THA_W3_CELINKA_E
{
    partial class Main_Window_Form
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
            this.button_OpenNextForm = new System.Windows.Forms.Button();
            this.label_Name = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label_Fav_Artist = new System.Windows.Forms.Label();
            this.textBox_Fav_artist = new System.Windows.Forms.TextBox();
            this.checkBox_TermsCondition = new System.Windows.Forms.CheckBox();
            this.button_Submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_OpenNextForm
            // 
            this.button_OpenNextForm.Location = new System.Drawing.Point(40, 49);
            this.button_OpenNextForm.Name = "button_OpenNextForm";
            this.button_OpenNextForm.Size = new System.Drawing.Size(287, 66);
            this.button_OpenNextForm.TabIndex = 0;
            this.button_OpenNextForm.Text = "Open Next Form";
            this.button_OpenNextForm.UseVisualStyleBackColor = true;
            this.button_OpenNextForm.Click += new System.EventHandler(this.button_OpenNextForm_Click);
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(213, 170);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(86, 25);
            this.label_Name.TabIndex = 1;
            this.label_Name.Text = "Name : ";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(315, 170);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(240, 31);
            this.textBox_Name.TabIndex = 2;
            this.textBox_Name.Click += new System.EventHandler(this.textBox_Name_Click);
            this.textBox_Name.TextChanged += new System.EventHandler(this.textBox_Name_TextChanged);
            // 
            // label_Fav_Artist
            // 
            this.label_Fav_Artist.AutoSize = true;
            this.label_Fav_Artist.Location = new System.Drawing.Point(101, 251);
            this.label_Fav_Artist.Name = "label_Fav_Artist";
            this.label_Fav_Artist.Size = new System.Drawing.Size(198, 25);
            this.label_Fav_Artist.TabIndex = 3;
            this.label_Fav_Artist.Text = "My Favorite Artist : ";
            // 
            // textBox_Fav_artist
            // 
            this.textBox_Fav_artist.Location = new System.Drawing.Point(315, 248);
            this.textBox_Fav_artist.Name = "textBox_Fav_artist";
            this.textBox_Fav_artist.Size = new System.Drawing.Size(240, 31);
            this.textBox_Fav_artist.TabIndex = 4;
            // 
            // checkBox_TermsCondition
            // 
            this.checkBox_TermsCondition.AutoSize = true;
            this.checkBox_TermsCondition.Location = new System.Drawing.Point(315, 323);
            this.checkBox_TermsCondition.Name = "checkBox_TermsCondition";
            this.checkBox_TermsCondition.Size = new System.Drawing.Size(388, 29);
            this.checkBox_TermsCondition.TabIndex = 5;
            this.checkBox_TermsCondition.Text = "All of the content I put above is true!";
            this.checkBox_TermsCondition.UseVisualStyleBackColor = true;
            this.checkBox_TermsCondition.CheckedChanged += new System.EventHandler(this.checkBox_TermsCondition_CheckedChanged);
            // 
            // button_Submit
            // 
            this.button_Submit.Enabled = false;
            this.button_Submit.Location = new System.Drawing.Point(352, 397);
            this.button_Submit.Name = "button_Submit";
            this.button_Submit.Size = new System.Drawing.Size(147, 66);
            this.button_Submit.TabIndex = 6;
            this.button_Submit.Text = "Submit";
            this.button_Submit.UseVisualStyleBackColor = true;
            this.button_Submit.Click += new System.EventHandler(this.button_Submit_Click);
            // 
            // Main_Window_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1518, 779);
            this.Controls.Add(this.button_Submit);
            this.Controls.Add(this.checkBox_TermsCondition);
            this.Controls.Add(this.textBox_Fav_artist);
            this.Controls.Add(this.label_Fav_Artist);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.button_OpenNextForm);
            this.Name = "Main_Window_Form";
            this.Text = "Main Window Form";
            this.Click += new System.EventHandler(this.Main_Window_Form_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_OpenNextForm;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label label_Fav_Artist;
        private System.Windows.Forms.TextBox textBox_Fav_artist;
        private System.Windows.Forms.CheckBox checkBox_TermsCondition;
        private System.Windows.Forms.Button button_Submit;
    }
}

