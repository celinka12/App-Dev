namespace CA_W12
{
    partial class MANAGER
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
            this.cb_ManagerTeam = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dgv_manager1 = new System.Windows.Forms.DataGridView();
            this.dgv_manager2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_manager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_manager2)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_ManagerTeam
            // 
            this.cb_ManagerTeam.FormattingEnabled = true;
            this.cb_ManagerTeam.Location = new System.Drawing.Point(28, 58);
            this.cb_ManagerTeam.Name = "cb_ManagerTeam";
            this.cb_ManagerTeam.Size = new System.Drawing.Size(225, 33);
            this.cb_ManagerTeam.TabIndex = 20;
            this.cb_ManagerTeam.SelectedIndexChanged += new System.EventHandler(this.cb_ManagerTeam_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 25);
            this.label9.TabIndex = 21;
            this.label9.Text = "Team Name";
            // 
            // dgv_manager1
            // 
            this.dgv_manager1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_manager1.Location = new System.Drawing.Point(42, 136);
            this.dgv_manager1.Name = "dgv_manager1";
            this.dgv_manager1.RowHeadersWidth = 82;
            this.dgv_manager1.RowTemplate.Height = 33;
            this.dgv_manager1.Size = new System.Drawing.Size(1195, 216);
            this.dgv_manager1.TabIndex = 22;
            // 
            // dgv_manager2
            // 
            this.dgv_manager2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_manager2.Location = new System.Drawing.Point(42, 430);
            this.dgv_manager2.Name = "dgv_manager2";
            this.dgv_manager2.RowHeadersWidth = 82;
            this.dgv_manager2.RowTemplate.Height = 33;
            this.dgv_manager2.Size = new System.Drawing.Size(1195, 216);
            this.dgv_manager2.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 690);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 59);
            this.button1.TabIndex = 24;
            this.button1.Text = "change";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MANAGER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 782);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv_manager2);
            this.Controls.Add(this.dgv_manager1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cb_ManagerTeam);
            this.Name = "MANAGER";
            this.Text = "MANAGER";
            this.Load += new System.EventHandler(this.MANAGER_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_manager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_manager2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_ManagerTeam;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgv_manager1;
        private System.Windows.Forms.DataGridView dgv_manager2;
        private System.Windows.Forms.Button button1;
    }
}