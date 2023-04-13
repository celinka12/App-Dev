namespace CA_W8
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
            this.dgv_Pemain = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.labelValue = new System.Windows.Forms.Label();
            this.combo_NAtionality = new System.Windows.Forms.ComboBox();
            this.combo_Country = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Pemain)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Pemain
            // 
            this.dgv_Pemain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Pemain.Location = new System.Drawing.Point(45, 68);
            this.dgv_Pemain.Name = "dgv_Pemain";
            this.dgv_Pemain.Size = new System.Drawing.Size(730, 344);
            this.dgv_Pemain.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Value member";
            // 
            // labelValue
            // 
            this.labelValue.AutoSize = true;
            this.labelValue.Location = new System.Drawing.Point(122, 39);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(37, 13);
            this.labelValue.TabIndex = 2;
            this.labelValue.Text = "HEHE";
            // 
            // combo_NAtionality
            // 
            this.combo_NAtionality.FormattingEnabled = true;
            this.combo_NAtionality.Location = new System.Drawing.Point(45, 13);
            this.combo_NAtionality.Name = "combo_NAtionality";
            this.combo_NAtionality.Size = new System.Drawing.Size(121, 21);
            this.combo_NAtionality.TabIndex = 3;
            this.combo_NAtionality.SelectedIndexChanged += new System.EventHandler(this.combo_NAtionality_SelectedIndexChanged);
            // 
            // combo_Country
            // 
            this.combo_Country.FormattingEnabled = true;
            this.combo_Country.Location = new System.Drawing.Point(711, 12);
            this.combo_Country.Name = "combo_Country";
            this.combo_Country.Size = new System.Drawing.Size(121, 21);
            this.combo_Country.TabIndex = 4;
            this.combo_Country.SelectedIndexChanged += new System.EventHandler(this.combo_Country_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 424);
            this.Controls.Add(this.combo_Country);
            this.Controls.Add(this.combo_NAtionality);
            this.Controls.Add(this.labelValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_Pemain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Pemain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Pemain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelValue;
        private System.Windows.Forms.ComboBox combo_NAtionality;
        private System.Windows.Forms.ComboBox combo_Country;
    }
}

