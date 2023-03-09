namespace HW_W2_Celin
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
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_Age = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_PhoneNumb = new System.Windows.Forms.Label();
            this.txt_nama = new System.Windows.Forms.TextBox();
            this.txt_age = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(238, 168);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(80, 25);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Name :";
            // 
            // lbl_Age
            // 
            this.lbl_Age.AutoSize = true;
            this.lbl_Age.Location = new System.Drawing.Point(241, 248);
            this.lbl_Age.Name = "lbl_Age";
            this.lbl_Age.Size = new System.Drawing.Size(62, 25);
            this.lbl_Age.TabIndex = 1;
            this.lbl_Age.Text = "Age :";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(241, 329);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(77, 25);
            this.lbl_email.TabIndex = 2;
            this.lbl_email.Text = "Email :";
            // 
            // lbl_PhoneNumb
            // 
            this.lbl_PhoneNumb.AutoSize = true;
            this.lbl_PhoneNumb.Location = new System.Drawing.Point(241, 427);
            this.lbl_PhoneNumb.Name = "lbl_PhoneNumb";
            this.lbl_PhoneNumb.Size = new System.Drawing.Size(86, 25);
            this.lbl_PhoneNumb.TabIndex = 3;
            this.lbl_PhoneNumb.Text = "Phone :";
            // 
            // txt_nama
            // 
            this.txt_nama.Location = new System.Drawing.Point(398, 168);
            this.txt_nama.Name = "txt_nama";
            this.txt_nama.Size = new System.Drawing.Size(382, 31);
            this.txt_nama.TabIndex = 4;
            this.txt_nama.Click += new System.EventHandler(this.textBox1_nama);
            // 
            // txt_age
            // 
            this.txt_age.Location = new System.Drawing.Point(398, 242);
            this.txt_age.Name = "txt_age";
            this.txt_age.Size = new System.Drawing.Size(382, 31);
            this.txt_age.TabIndex = 5;
            this.txt_age.Click += new System.EventHandler(this.txt_age_Click);
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(398, 323);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(382, 31);
            this.txt_email.TabIndex = 6;
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(398, 421);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(382, 31);
            this.txt_phone.TabIndex = 7;
            // 
            // btn_submit
            // 
            this.btn_submit.BackColor = System.Drawing.Color.Lime;
            this.btn_submit.Location = new System.Drawing.Point(976, 567);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(129, 39);
            this.btn_submit.TabIndex = 8;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = false;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.Red;
            this.btn_Clear.Location = new System.Drawing.Point(189, 567);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(129, 39);
            this.btn_Clear.TabIndex = 9;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1455, 786);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_age);
            this.Controls.Add(this.txt_nama);
            this.Controls.Add(this.lbl_PhoneNumb);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_Age);
            this.Controls.Add(this.lbl_name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_Age;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_PhoneNumb;
        private System.Windows.Forms.TextBox txt_nama;
        private System.Windows.Forms.TextBox txt_age;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Button btn_Clear;
    }
}

