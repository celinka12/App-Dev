namespace THA_W6_CELINKA_E
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
            this.lbl_input = new System.Windows.Forms.Label();
            this.tb_inputangka = new System.Windows.Forms.TextBox();
            this.btn_next = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_input
            // 
            this.lbl_input.AutoSize = true;
            this.lbl_input.Location = new System.Drawing.Point(114, 199);
            this.lbl_input.Name = "lbl_input";
            this.lbl_input.Size = new System.Drawing.Size(315, 25);
            this.lbl_input.TabIndex = 0;
            this.lbl_input.Text = "Set How Much You Can Guess!";
            // 
            // tb_inputangka
            // 
            this.tb_inputangka.Location = new System.Drawing.Point(106, 244);
            this.tb_inputangka.Name = "tb_inputangka";
            this.tb_inputangka.Size = new System.Drawing.Size(352, 31);
            this.tb_inputangka.TabIndex = 1;
            this.tb_inputangka.TextChanged += new System.EventHandler(this.tb_inputangka_TextChanged);
            this.tb_inputangka.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_inputangka_KeyPress);
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(218, 290);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(120, 53);
            this.btn_next.TabIndex = 2;
            this.btn_next.Text = "Next";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Papyrus", 28.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(480, 118);
            this.label1.TabIndex = 3;
            this.label1.Text = "WORDLE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 484);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.tb_inputangka);
            this.Controls.Add(this.lbl_input);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_input;
        private System.Windows.Forms.TextBox tb_inputangka;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Label label1;
    }
}

