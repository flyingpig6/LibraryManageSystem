namespace LibraryMS
{
    partial class Service_M1
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lv_Book = new System.Windows.Forms.ListView();
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
            this.btn_Borrow = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.lbl_Note = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lv_Reader = new System.Windows.Forms.ListView();
            this.RID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RPWD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RTID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RSex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RegDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ValDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BorBookNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TolBorBookNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IfLost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ViolationNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Remark = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lv_Book);
            this.groupBox2.Location = new System.Drawing.Point(41, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(724, 211);
            this.groupBox2.TabIndex = 8;
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
            // lv_Book
            // 
            this.lv_Book.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
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
            this.lv_Book.FullRowSelect = true;
            this.lv_Book.GridLines = true;
            this.lv_Book.HideSelection = false;
            this.lv_Book.Location = new System.Drawing.Point(6, 38);
            this.lv_Book.MultiSelect = false;
            this.lv_Book.Name = "lv_Book";
            this.lv_Book.Size = new System.Drawing.Size(721, 194);
            this.lv_Book.TabIndex = 1;
            this.lv_Book.UseCompatibleStateImageBehavior = false;
            this.lv_Book.View = System.Windows.Forms.View.Details;
            this.lv_Book.SelectedIndexChanged += new System.EventHandler(this.lv_Book_SelectedIndexChanged);
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
            // btn_Borrow
            // 
            this.btn_Borrow.Location = new System.Drawing.Point(263, 502);
            this.btn_Borrow.Name = "btn_Borrow";
            this.btn_Borrow.Size = new System.Drawing.Size(85, 41);
            this.btn_Borrow.TabIndex = 11;
            this.btn_Borrow.Text = "借阅";
            this.btn_Borrow.UseVisualStyleBackColor = true;
            this.btn_Borrow.Click += new System.EventHandler(this.btn_Borrow_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(435, 502);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(88, 41);
            this.btn_Cancel.TabIndex = 12;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // lbl_Note
            // 
            this.lbl_Note.AutoSize = true;
            this.lbl_Note.Location = new System.Drawing.Point(307, 145);
            this.lbl_Note.Name = "lbl_Note";
            this.lbl_Note.Size = new System.Drawing.Size(0, 15);
            this.lbl_Note.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lv_Reader);
            this.groupBox1.Location = new System.Drawing.Point(44, 255);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(724, 221);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "读者信息列表";
            // 
            // lv_Reader
            // 
            this.lv_Reader.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.RID,
            this.RPWD,
            this.RTID,
            this.RName,
            this.RSex,
            this.RPhone,
            this.RegDate,
            this.ValDate,
            this.BorBookNum,
            this.TolBorBookNum,
            this.IfLost,
            this.ViolationNum,
            this.Remark});
            this.lv_Reader.FullRowSelect = true;
            this.lv_Reader.GridLines = true;
            this.lv_Reader.HideSelection = false;
            this.lv_Reader.Location = new System.Drawing.Point(6, 37);
            this.lv_Reader.MultiSelect = false;
            this.lv_Reader.Name = "lv_Reader";
            this.lv_Reader.Size = new System.Drawing.Size(721, 185);
            this.lv_Reader.TabIndex = 1;
            this.lv_Reader.UseCompatibleStateImageBehavior = false;
            this.lv_Reader.View = System.Windows.Forms.View.Details;
            this.lv_Reader.SelectedIndexChanged += new System.EventHandler(this.lv_Reader_SelectedIndexChanged);
            // 
            // RID
            // 
            this.RID.Text = "读者编号";
            this.RID.Width = 72;
            // 
            // RPWD
            // 
            this.RPWD.Text = "密码";
            this.RPWD.Width = 56;
            // 
            // RTID
            // 
            this.RTID.Text = "读者类型";
            this.RTID.Width = 78;
            // 
            // RName
            // 
            this.RName.Text = "读者姓名";
            this.RName.Width = 75;
            // 
            // RSex
            // 
            this.RSex.Text = "性别";
            this.RSex.Width = 70;
            // 
            // RPhone
            // 
            this.RPhone.Text = "电话号码";
            this.RPhone.Width = 74;
            // 
            // RegDate
            // 
            this.RegDate.Text = "注册日期";
            this.RegDate.Width = 80;
            // 
            // ValDate
            // 
            this.ValDate.Text = "有效期至";
            // 
            // BorBookNum
            // 
            this.BorBookNum.Text = "现借图书数";
            this.BorBookNum.Width = 88;
            // 
            // TolBorBookNum
            // 
            this.TolBorBookNum.Text = "累计借书数";
            this.TolBorBookNum.Width = 90;
            // 
            // IfLost
            // 
            this.IfLost.Text = "是否丢失";
            // 
            // ViolationNum
            // 
            this.ViolationNum.Text = "违规次数";
            // 
            // Remark
            // 
            this.Remark.Text = "备注";
            // 
            // Service_M1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 555);
            this.Controls.Add(this.lbl_Note);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Borrow);
            this.Controls.Add(this.groupBox2);
            this.Name = "Service_M1";
            this.Text = "图书借阅服务管理";
            this.Load += new System.EventHandler(this.Service_M1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView lv_Book;
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
        private System.Windows.Forms.ColumnHeader TotalStock;
        private System.Windows.Forms.Button btn_Borrow;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label lbl_Note;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lv_Reader;
        private System.Windows.Forms.ColumnHeader RID;
        private System.Windows.Forms.ColumnHeader RPWD;
        private System.Windows.Forms.ColumnHeader RTID;
        private System.Windows.Forms.ColumnHeader RName;
        private System.Windows.Forms.ColumnHeader RSex;
        private System.Windows.Forms.ColumnHeader RPhone;
        private System.Windows.Forms.ColumnHeader RegDate;
        private System.Windows.Forms.ColumnHeader ValDate;
        private System.Windows.Forms.ColumnHeader BorBookNum;
        private System.Windows.Forms.ColumnHeader TolBorBookNum;
        private System.Windows.Forms.ColumnHeader IfLost;
        private System.Windows.Forms.ColumnHeader ViolationNum;
        private System.Windows.Forms.ColumnHeader Remark;
    }
}