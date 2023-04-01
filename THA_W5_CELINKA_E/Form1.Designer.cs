namespace THA_W5_CELINKA_E
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
            this.lbl_Product = new System.Windows.Forms.Label();
            this.dtProdukSimpan = new System.Windows.Forms.DataGridView();
            this.lbl_Category = new System.Windows.Forms.Label();
            this.dtCategory = new System.Windows.Forms.DataGridView();
            this.lbl_Details = new System.Windows.Forms.Label();
            this.lbl_Nama = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lbl_harga = new System.Windows.Forms.Label();
            this.lbl_Stock = new System.Windows.Forms.Label();
            this.tb_namacategory = new System.Windows.Forms.TextBox();
            this.tb_nama = new System.Windows.Forms.TextBox();
            this.tb_harga = new System.Windows.Forms.TextBox();
            this.tb_stock = new System.Windows.Forms.TextBox();
            this.cb_category = new System.Windows.Forms.ComboBox();
            this.btn_addproduct = new System.Windows.Forms.Button();
            this.btn_editproduct = new System.Windows.Forms.Button();
            this.btn_removeproduct = new System.Windows.Forms.Button();
            this.btn_addcategory = new System.Windows.Forms.Button();
            this.btn_removecategory = new System.Windows.Forms.Button();
            this.btn_all = new System.Windows.Forms.Button();
            this.btn_filter = new System.Windows.Forms.Button();
            this.cb_filter = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtProdukSimpan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Product
            // 
            this.lbl_Product.AutoSize = true;
            this.lbl_Product.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product.Location = new System.Drawing.Point(58, 48);
            this.lbl_Product.Name = "lbl_Product";
            this.lbl_Product.Size = new System.Drawing.Size(239, 65);
            this.lbl_Product.TabIndex = 0;
            this.lbl_Product.Text = "Product";
            // 
            // dtProdukSimpan
            // 
            this.dtProdukSimpan.AllowUserToAddRows = false;
            this.dtProdukSimpan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtProdukSimpan.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtProdukSimpan.BackgroundColor = System.Drawing.Color.RosyBrown;
            this.dtProdukSimpan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtProdukSimpan.GridColor = System.Drawing.Color.RosyBrown;
            this.dtProdukSimpan.Location = new System.Drawing.Point(28, 116);
            this.dtProdukSimpan.Name = "dtProdukSimpan";
            this.dtProdukSimpan.RowHeadersWidth = 82;
            this.dtProdukSimpan.RowTemplate.Height = 33;
            this.dtProdukSimpan.Size = new System.Drawing.Size(979, 540);
            this.dtProdukSimpan.TabIndex = 1;
            this.dtProdukSimpan.AllowUserToAddRowsChanged += new System.EventHandler(this.dtProdukSimpan_AllowUserToAddRowsChanged);
            this.dtProdukSimpan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtProdukSimpan_CellClick);
            this.dtProdukSimpan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtProdukSimpan_CellContentClick);
            this.dtProdukSimpan.Click += new System.EventHandler(this.dtProdukSimpan_Click);
            // 
            // lbl_Category
            // 
            this.lbl_Category.AutoSize = true;
            this.lbl_Category.Font = new System.Drawing.Font("Modern No. 20", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Category.Location = new System.Drawing.Point(1225, 48);
            this.lbl_Category.Name = "lbl_Category";
            this.lbl_Category.Size = new System.Drawing.Size(214, 54);
            this.lbl_Category.TabIndex = 2;
            this.lbl_Category.Text = "Category";
            // 
            // dtCategory
            // 
            this.dtCategory.AllowUserToAddRows = false;
            this.dtCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtCategory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtCategory.BackgroundColor = System.Drawing.Color.RosyBrown;
            this.dtCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtCategory.GridColor = System.Drawing.Color.RosyBrown;
            this.dtCategory.Location = new System.Drawing.Point(1033, 116);
            this.dtCategory.Name = "dtCategory";
            this.dtCategory.RowHeadersWidth = 82;
            this.dtCategory.RowTemplate.Height = 33;
            this.dtCategory.Size = new System.Drawing.Size(406, 410);
            this.dtCategory.TabIndex = 3;
            this.dtCategory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtCategory_CellClick);
            this.dtCategory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtCategory_CellContentClick);
            // 
            // lbl_Details
            // 
            this.lbl_Details.AutoSize = true;
            this.lbl_Details.Font = new System.Drawing.Font("Modern No. 20", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Details.Location = new System.Drawing.Point(60, 659);
            this.lbl_Details.Name = "lbl_Details";
            this.lbl_Details.Size = new System.Drawing.Size(183, 54);
            this.lbl_Details.TabIndex = 4;
            this.lbl_Details.Text = "Details";
            // 
            // lbl_Nama
            // 
            this.lbl_Nama.AutoSize = true;
            this.lbl_Nama.Location = new System.Drawing.Point(1033, 577);
            this.lbl_Nama.Name = "lbl_Nama";
            this.lbl_Nama.Size = new System.Drawing.Size(86, 25);
            this.lbl_Nama.TabIndex = 5;
            this.lbl_Nama.Text = "Nama : ";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(54, 742);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(86, 25);
            this.lbl_Name.TabIndex = 6;
            this.lbl_Name.Text = "Nama : ";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(23, 795);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(111, 25);
            this.lblCategory.TabIndex = 7;
            this.lblCategory.Text = "Category :";
            // 
            // lbl_harga
            // 
            this.lbl_harga.AutoSize = true;
            this.lbl_harga.Location = new System.Drawing.Point(53, 842);
            this.lbl_harga.Name = "lbl_harga";
            this.lbl_harga.Size = new System.Drawing.Size(88, 25);
            this.lbl_harga.TabIndex = 8;
            this.lbl_harga.Text = "Harga : ";
            // 
            // lbl_Stock
            // 
            this.lbl_Stock.AutoSize = true;
            this.lbl_Stock.Location = new System.Drawing.Point(58, 889);
            this.lbl_Stock.Name = "lbl_Stock";
            this.lbl_Stock.Size = new System.Drawing.Size(78, 25);
            this.lbl_Stock.TabIndex = 9;
            this.lbl_Stock.Text = "Stock :";
            // 
            // tb_namacategory
            // 
            this.tb_namacategory.BackColor = System.Drawing.Color.LightSalmon;
            this.tb_namacategory.Location = new System.Drawing.Point(1126, 577);
            this.tb_namacategory.Name = "tb_namacategory";
            this.tb_namacategory.Size = new System.Drawing.Size(267, 31);
            this.tb_namacategory.TabIndex = 10;
            // 
            // tb_nama
            // 
            this.tb_nama.BackColor = System.Drawing.Color.LightSalmon;
            this.tb_nama.Location = new System.Drawing.Point(146, 742);
            this.tb_nama.Name = "tb_nama";
            this.tb_nama.Size = new System.Drawing.Size(450, 31);
            this.tb_nama.TabIndex = 11;
            // 
            // tb_harga
            // 
            this.tb_harga.BackColor = System.Drawing.Color.LightSalmon;
            this.tb_harga.Location = new System.Drawing.Point(146, 836);
            this.tb_harga.Name = "tb_harga";
            this.tb_harga.Size = new System.Drawing.Size(205, 31);
            this.tb_harga.TabIndex = 12;
            this.tb_harga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_harga_KeyPress);
            // 
            // tb_stock
            // 
            this.tb_stock.BackColor = System.Drawing.Color.LightSalmon;
            this.tb_stock.Location = new System.Drawing.Point(146, 889);
            this.tb_stock.Name = "tb_stock";
            this.tb_stock.Size = new System.Drawing.Size(205, 31);
            this.tb_stock.TabIndex = 13;
            this.tb_stock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_stock_KeyPress);
            // 
            // cb_category
            // 
            this.cb_category.BackColor = System.Drawing.Color.LightSalmon;
            this.cb_category.FormattingEnabled = true;
            this.cb_category.Location = new System.Drawing.Point(146, 786);
            this.cb_category.Name = "cb_category";
            this.cb_category.Size = new System.Drawing.Size(205, 33);
            this.cb_category.TabIndex = 14;
            // 
            // btn_addproduct
            // 
            this.btn_addproduct.BackColor = System.Drawing.Color.Maroon;
            this.btn_addproduct.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_addproduct.Location = new System.Drawing.Point(442, 813);
            this.btn_addproduct.Name = "btn_addproduct";
            this.btn_addproduct.Size = new System.Drawing.Size(120, 91);
            this.btn_addproduct.TabIndex = 15;
            this.btn_addproduct.Text = "Add Product";
            this.btn_addproduct.UseVisualStyleBackColor = false;
            this.btn_addproduct.Click += new System.EventHandler(this.btn_addproduct_Click);
            // 
            // btn_editproduct
            // 
            this.btn_editproduct.BackColor = System.Drawing.Color.Maroon;
            this.btn_editproduct.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_editproduct.Location = new System.Drawing.Point(577, 813);
            this.btn_editproduct.Name = "btn_editproduct";
            this.btn_editproduct.Size = new System.Drawing.Size(120, 91);
            this.btn_editproduct.TabIndex = 16;
            this.btn_editproduct.Text = "Edit Product";
            this.btn_editproduct.UseVisualStyleBackColor = false;
            this.btn_editproduct.Click += new System.EventHandler(this.btn_editproduct_Click);
            // 
            // btn_removeproduct
            // 
            this.btn_removeproduct.BackColor = System.Drawing.Color.Maroon;
            this.btn_removeproduct.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_removeproduct.Location = new System.Drawing.Point(719, 813);
            this.btn_removeproduct.Name = "btn_removeproduct";
            this.btn_removeproduct.Size = new System.Drawing.Size(120, 91);
            this.btn_removeproduct.TabIndex = 17;
            this.btn_removeproduct.Text = "Remove Product";
            this.btn_removeproduct.UseVisualStyleBackColor = false;
            this.btn_removeproduct.Click += new System.EventHandler(this.btn_removeproduct_Click);
            // 
            // btn_addcategory
            // 
            this.btn_addcategory.BackColor = System.Drawing.Color.LightCoral;
            this.btn_addcategory.Location = new System.Drawing.Point(1137, 649);
            this.btn_addcategory.Name = "btn_addcategory";
            this.btn_addcategory.Size = new System.Drawing.Size(120, 91);
            this.btn_addcategory.TabIndex = 18;
            this.btn_addcategory.Text = "Add Category";
            this.btn_addcategory.UseVisualStyleBackColor = false;
            this.btn_addcategory.Click += new System.EventHandler(this.btn_addcategory_Click);
            // 
            // btn_removecategory
            // 
            this.btn_removecategory.BackColor = System.Drawing.Color.LightCoral;
            this.btn_removecategory.Location = new System.Drawing.Point(1273, 649);
            this.btn_removecategory.Name = "btn_removecategory";
            this.btn_removecategory.Size = new System.Drawing.Size(120, 91);
            this.btn_removecategory.TabIndex = 19;
            this.btn_removecategory.Text = "Remove Category";
            this.btn_removecategory.UseVisualStyleBackColor = false;
            this.btn_removecategory.Click += new System.EventHandler(this.btn_removecategory_Click);
            // 
            // btn_all
            // 
            this.btn_all.AutoSize = true;
            this.btn_all.BackColor = System.Drawing.Color.Red;
            this.btn_all.Location = new System.Drawing.Point(514, 48);
            this.btn_all.Name = "btn_all";
            this.btn_all.Size = new System.Drawing.Size(120, 35);
            this.btn_all.TabIndex = 20;
            this.btn_all.Text = "All";
            this.btn_all.UseVisualStyleBackColor = false;
            this.btn_all.Click += new System.EventHandler(this.btn_all_Click);
            // 
            // btn_filter
            // 
            this.btn_filter.AutoSize = true;
            this.btn_filter.BackColor = System.Drawing.Color.Red;
            this.btn_filter.Location = new System.Drawing.Point(640, 48);
            this.btn_filter.Name = "btn_filter";
            this.btn_filter.Size = new System.Drawing.Size(120, 35);
            this.btn_filter.TabIndex = 21;
            this.btn_filter.Text = "Filter";
            this.btn_filter.UseVisualStyleBackColor = false;
            this.btn_filter.Click += new System.EventHandler(this.btn_filter_Click);
            // 
            // cb_filter
            // 
            this.cb_filter.BackColor = System.Drawing.Color.LightSalmon;
            this.cb_filter.Enabled = false;
            this.cb_filter.FormattingEnabled = true;
            this.cb_filter.Location = new System.Drawing.Point(777, 48);
            this.cb_filter.Name = "cb_filter";
            this.cb_filter.Size = new System.Drawing.Size(191, 33);
            this.cb_filter.TabIndex = 22;
            this.cb_filter.SelectedIndexChanged += new System.EventHandler(this.cb_filter_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1527, 962);
            this.Controls.Add(this.cb_filter);
            this.Controls.Add(this.btn_filter);
            this.Controls.Add(this.btn_all);
            this.Controls.Add(this.btn_removecategory);
            this.Controls.Add(this.btn_addcategory);
            this.Controls.Add(this.btn_removeproduct);
            this.Controls.Add(this.btn_editproduct);
            this.Controls.Add(this.btn_addproduct);
            this.Controls.Add(this.cb_category);
            this.Controls.Add(this.tb_stock);
            this.Controls.Add(this.tb_harga);
            this.Controls.Add(this.tb_nama);
            this.Controls.Add(this.tb_namacategory);
            this.Controls.Add(this.lbl_Stock);
            this.Controls.Add(this.lbl_harga);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_Nama);
            this.Controls.Add(this.lbl_Details);
            this.Controls.Add(this.dtCategory);
            this.Controls.Add(this.lbl_Category);
            this.Controls.Add(this.dtProdukSimpan);
            this.Controls.Add(this.lbl_Product);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtProdukSimpan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Product;
        private System.Windows.Forms.DataGridView dtProdukSimpan;
        private System.Windows.Forms.Label lbl_Category;
        private System.Windows.Forms.DataGridView dtCategory;
        private System.Windows.Forms.Label lbl_Details;
        private System.Windows.Forms.Label lbl_Nama;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lbl_harga;
        private System.Windows.Forms.Label lbl_Stock;
        private System.Windows.Forms.TextBox tb_namacategory;
        private System.Windows.Forms.TextBox tb_nama;
        private System.Windows.Forms.TextBox tb_harga;
        private System.Windows.Forms.TextBox tb_stock;
        private System.Windows.Forms.ComboBox cb_category;
        private System.Windows.Forms.Button btn_addproduct;
        private System.Windows.Forms.Button btn_editproduct;
        private System.Windows.Forms.Button btn_removeproduct;
        private System.Windows.Forms.Button btn_addcategory;
        private System.Windows.Forms.Button btn_removecategory;
        private System.Windows.Forms.Button btn_all;
        private System.Windows.Forms.Button btn_filter;
        private System.Windows.Forms.ComboBox cb_filter;
    }
}

