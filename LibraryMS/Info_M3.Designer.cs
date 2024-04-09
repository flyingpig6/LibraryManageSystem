namespace LibraryMS
{
    partial class Info_M3
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
            this.lbl_Note = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lv_Customer = new System.Windows.Forms.ListView();
            this.ISBN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BookName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Author = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Edition = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PubDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Summary = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CurrentStock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TotalStock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_Del = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_BTolStock = new System.Windows.Forms.TextBox();
            this.txt_BCurStock = new System.Windows.Forms.TextBox();
            this.txt_BPrice = new System.Windows.Forms.TextBox();
            this.txt_BPubDate = new System.Windows.Forms.TextBox();
            this.txt_BEdition = new System.Windows.Forms.TextBox();
            this.txt_BAuthor = new System.Windows.Forms.TextBox();
            this.txt_BType = new System.Windows.Forms.TextBox();
            this.txt_BName = new System.Windows.Forms.TextBox();
            this.txt_PID = new System.Windows.Forms.TextBox();
            this.txt_ISBN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Note
            // 
            this.lbl_Note.AutoSize = true;
            this.lbl_Note.Location = new System.Drawing.Point(312, 223);
            this.lbl_Note.Name = "lbl_Note";
            this.lbl_Note.Size = new System.Drawing.Size(0, 15);
            this.lbl_Note.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lv_Customer);
            this.groupBox2.Controls.Add(this.btn_Del);
            this.groupBox2.Location = new System.Drawing.Point(34, 305);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(733, 218);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "图书基本信息列表";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(404, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 15);
            this.label7.TabIndex = 2;
            // 
            // lv_Customer
            // 
            this.lv_Customer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ISBN,
            this.PID,
            this.BookName,
            this.Type,
            this.Author,
            this.Edition,
            this.PubDate,
            this.Price,
            this.Summary,
            this.CurrentStock,
            this.TotalStock});
            this.lv_Customer.FullRowSelect = true;
            this.lv_Customer.GridLines = true;
            this.lv_Customer.HideSelection = false;
            this.lv_Customer.Location = new System.Drawing.Point(6, 38);
            this.lv_Customer.MultiSelect = false;
            this.lv_Customer.Name = "lv_Customer";
            this.lv_Customer.Size = new System.Drawing.Size(721, 194);
            this.lv_Customer.TabIndex = 1;
            this.lv_Customer.UseCompatibleStateImageBehavior = false;
            this.lv_Customer.View = System.Windows.Forms.View.Details;
            this.lv_Customer.SelectedIndexChanged += new System.EventHandler(this.lv_Customer_SelectedIndexChanged);
            // 
            // ISBN
            // 
            this.ISBN.Text = "ISBN";
            this.ISBN.Width = 95;
            // 
            // PID
            // 
            this.PID.Text = "出版社编号";
            this.PID.Width = 93;
            // 
            // BookName
            // 
            this.BookName.Text = "书名";
            this.BookName.Width = 78;
            // 
            // Type
            // 
            this.Type.Text = "类型";
            this.Type.Width = 75;
            // 
            // Author
            // 
            this.Author.Text = "作者";
            this.Author.Width = 79;
            // 
            // Edition
            // 
            this.Edition.Text = "版次";
            this.Edition.Width = 74;
            // 
            // PubDate
            // 
            this.PubDate.Text = "出版日期";
            this.PubDate.Width = 80;
            // 
            // Price
            // 
            this.Price.Text = "价格";
            this.Price.Width = 81;
            // 
            // Summary
            // 
            this.Summary.Text = "摘要";
            this.Summary.Width = 88;
            // 
            // CurrentStock
            // 
            this.CurrentStock.Text = "当前库存";
            this.CurrentStock.Width = 90;
            // 
            // TotalStock
            // 
            this.TotalStock.Text = "总库存";
            // 
            // btn_Del
            // 
            this.btn_Del.Location = new System.Drawing.Point(130, -1);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(83, 33);
            this.btn_Del.TabIndex = 0;
            this.btn_Del.Text = "删除";
            this.btn_Del.UseVisualStyleBackColor = true;
            this.btn_Del.Click += new System.EventHandler(this.btn_Del_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_BTolStock);
            this.groupBox1.Controls.Add(this.txt_BCurStock);
            this.groupBox1.Controls.Add(this.txt_BPrice);
            this.groupBox1.Controls.Add(this.txt_BPubDate);
            this.groupBox1.Controls.Add(this.txt_BEdition);
            this.groupBox1.Controls.Add(this.txt_BAuthor);
            this.groupBox1.Controls.Add(this.txt_BType);
            this.groupBox1.Controls.Add(this.txt_BName);
            this.groupBox1.Controls.Add(this.txt_PID);
            this.groupBox1.Controls.Add(this.txt_ISBN);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.lbl_Status);
            this.groupBox1.Controls.Add(this.btn_Cancel);
            this.groupBox1.Controls.Add(this.btn_Save);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Location = new System.Drawing.Point(34, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(733, 265);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "编辑图书基本信息   状态：";
            // 
            // txt_BTolStock
            // 
            this.txt_BTolStock.Location = new System.Drawing.Point(467, 168);
            this.txt_BTolStock.Name = "txt_BTolStock";
            this.txt_BTolStock.Size = new System.Drawing.Size(145, 25);
            this.txt_BTolStock.TabIndex = 37;
            // 
            // txt_BCurStock
            // 
            this.txt_BCurStock.Location = new System.Drawing.Point(467, 137);
            this.txt_BCurStock.Name = "txt_BCurStock";
            this.txt_BCurStock.Size = new System.Drawing.Size(145, 25);
            this.txt_BCurStock.TabIndex = 36;
            // 
            // txt_BPrice
            // 
            this.txt_BPrice.Location = new System.Drawing.Point(467, 105);
            this.txt_BPrice.Name = "txt_BPrice";
            this.txt_BPrice.Size = new System.Drawing.Size(145, 25);
            this.txt_BPrice.TabIndex = 35;
            // 
            // txt_BPubDate
            // 
            this.txt_BPubDate.Location = new System.Drawing.Point(467, 74);
            this.txt_BPubDate.Name = "txt_BPubDate";
            this.txt_BPubDate.Size = new System.Drawing.Size(145, 25);
            this.txt_BPubDate.TabIndex = 34;
            // 
            // txt_BEdition
            // 
            this.txt_BEdition.Location = new System.Drawing.Point(467, 43);
            this.txt_BEdition.Name = "txt_BEdition";
            this.txt_BEdition.Size = new System.Drawing.Size(145, 25);
            this.txt_BEdition.TabIndex = 33;
            // 
            // txt_BAuthor
            // 
            this.txt_BAuthor.Location = new System.Drawing.Point(174, 168);
            this.txt_BAuthor.Name = "txt_BAuthor";
            this.txt_BAuthor.Size = new System.Drawing.Size(145, 25);
            this.txt_BAuthor.TabIndex = 32;
            // 
            // txt_BType
            // 
            this.txt_BType.Location = new System.Drawing.Point(174, 137);
            this.txt_BType.Name = "txt_BType";
            this.txt_BType.Size = new System.Drawing.Size(145, 25);
            this.txt_BType.TabIndex = 31;
            // 
            // txt_BName
            // 
            this.txt_BName.Location = new System.Drawing.Point(174, 105);
            this.txt_BName.Name = "txt_BName";
            this.txt_BName.Size = new System.Drawing.Size(145, 25);
            this.txt_BName.TabIndex = 30;
            // 
            // txt_PID
            // 
            this.txt_PID.Location = new System.Drawing.Point(174, 74);
            this.txt_PID.Name = "txt_PID";
            this.txt_PID.Size = new System.Drawing.Size(145, 25);
            this.txt_PID.TabIndex = 29;
            // 
            // txt_ISBN
            // 
            this.txt_ISBN.Location = new System.Drawing.Point(174, 43);
            this.txt_ISBN.Name = "txt_ISBN";
            this.txt_ISBN.Size = new System.Drawing.Size(145, 25);
            this.txt_ISBN.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(378, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "总库存";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(379, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 21;
            this.label6.Text = "当前库存";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(379, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 15);
            this.label8.TabIndex = 20;
            this.label8.Text = "价格";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(379, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 15);
            this.label9.TabIndex = 19;
            this.label9.Text = "出版日期";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(378, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 15);
            this.label10.TabIndex = 18;
            this.label10.Text = "版次";
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Location = new System.Drawing.Point(185, 0);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(0, 15);
            this.lbl_Status.TabIndex = 16;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(372, 218);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(89, 34);
            this.btn_Cancel.TabIndex = 15;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(249, 218);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(85, 34);
            this.btn_Save.TabIndex = 14;
            this.btn_Save.Text = "保存";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "作者";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "类型";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "书名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "出版社编号";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(85, 53);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 15);
            this.label11.TabIndex = 0;
            this.label11.Text = "ISBN";
            // 
            // Info_M3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 547);
            this.Controls.Add(this.lbl_Note);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Info_M3";
            this.Text = "图书基本信息管理";
            this.Load += new System.EventHandler(this.Info_M3_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Note;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView lv_Customer;
        private System.Windows.Forms.ColumnHeader ISBN;
        private System.Windows.Forms.ColumnHeader PID;
        private System.Windows.Forms.ColumnHeader BookName;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader Author;
        private System.Windows.Forms.ColumnHeader Edition;
        private System.Windows.Forms.ColumnHeader PubDate;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader Summary;
        private System.Windows.Forms.ColumnHeader CurrentStock;
        private System.Windows.Forms.Button btn_Del;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_ISBN;
        private System.Windows.Forms.TextBox txt_BTolStock;
        private System.Windows.Forms.TextBox txt_BCurStock;
        private System.Windows.Forms.TextBox txt_BPrice;
        private System.Windows.Forms.TextBox txt_BPubDate;
        private System.Windows.Forms.TextBox txt_BEdition;
        private System.Windows.Forms.TextBox txt_BAuthor;
        private System.Windows.Forms.TextBox txt_BType;
        private System.Windows.Forms.TextBox txt_BName;
        private System.Windows.Forms.TextBox txt_PID;
        private System.Windows.Forms.ColumnHeader TotalStock;
    }
}