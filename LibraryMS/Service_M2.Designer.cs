namespace LibraryMS
{
    partial class Service_M2
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lv_BorInfo = new System.Windows.Forms.ListView();
            this.BorID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BorDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RetDue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txt_findRID = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_ViolationNum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_RType = new System.Windows.Forms.TextBox();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.txt_RTolBorBookNum = new System.Windows.Forms.TextBox();
            this.txt_RCurBorBookNum = new System.Windows.Forms.TextBox();
            this.txt_RName = new System.Windows.Forms.TextBox();
            this.txt_RID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_findReader = new System.Windows.Forms.Button();
            this.rbtn_lose2 = new System.Windows.Forms.RadioButton();
            this.rbtn_lose1 = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("华文楷体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(37, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "请输入读者编号";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lv_BorInfo);
            this.groupBox2.Location = new System.Drawing.Point(38, 269);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(733, 198);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "图书借阅信息列表";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(404, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 15);
            this.label7.TabIndex = 2;
            // 
            // lv_BorInfo
            // 
            this.lv_BorInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.BorID,
            this.RID,
            this.MID,
            this.BName,
            this.BorDate,
            this.RetDue});
            this.lv_BorInfo.FullRowSelect = true;
            this.lv_BorInfo.GridLines = true;
            this.lv_BorInfo.HideSelection = false;
            this.lv_BorInfo.Location = new System.Drawing.Point(6, 24);
            this.lv_BorInfo.MultiSelect = false;
            this.lv_BorInfo.Name = "lv_BorInfo";
            this.lv_BorInfo.Size = new System.Drawing.Size(721, 168);
            this.lv_BorInfo.TabIndex = 1;
            this.lv_BorInfo.UseCompatibleStateImageBehavior = false;
            this.lv_BorInfo.View = System.Windows.Forms.View.Details;
            this.lv_BorInfo.SelectedIndexChanged += new System.EventHandler(this.lv_BorInfo_SelectedIndexChanged);
            // 
            // BorID
            // 
            this.BorID.Text = "借阅编号";
            this.BorID.Width = 92;
            // 
            // RID
            // 
            this.RID.Text = "读者编号";
            this.RID.Width = 93;
            // 
            // MID
            // 
            this.MID.Text = "管理员编号";
            this.MID.Width = 122;
            // 
            // BName
            // 
            this.BName.Text = "图书名称";
            this.BName.Width = 127;
            // 
            // BorDate
            // 
            this.BorDate.Text = "借阅日期";
            this.BorDate.Width = 143;
            // 
            // RetDue
            // 
            this.RetDue.Text = "应还日期";
            this.RetDue.Width = 145;
            // 
            // txt_findRID
            // 
            this.txt_findRID.Location = new System.Drawing.Point(224, 36);
            this.txt_findRID.Name = "txt_findRID";
            this.txt_findRID.Size = new System.Drawing.Size(131, 25);
            this.txt_findRID.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_ViolationNum);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_RType);
            this.groupBox1.Controls.Add(this.lbl_Status);
            this.groupBox1.Controls.Add(this.txt_RTolBorBookNum);
            this.groupBox1.Controls.Add(this.txt_RCurBorBookNum);
            this.groupBox1.Controls.Add(this.txt_RName);
            this.groupBox1.Controls.Add(this.txt_RID);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(36, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(733, 119);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "读者信息栏：";
            // 
            // txt_ViolationNum
            // 
            this.txt_ViolationNum.Location = new System.Drawing.Point(479, 83);
            this.txt_ViolationNum.Name = "txt_ViolationNum";
            this.txt_ViolationNum.Size = new System.Drawing.Size(150, 25);
            this.txt_ViolationNum.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(376, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "违规次数";
            // 
            // txt_RType
            // 
            this.txt_RType.Location = new System.Drawing.Point(176, 83);
            this.txt_RType.Name = "txt_RType";
            this.txt_RType.Size = new System.Drawing.Size(145, 25);
            this.txt_RType.TabIndex = 17;
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Location = new System.Drawing.Point(185, 0);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(0, 15);
            this.lbl_Status.TabIndex = 16;
            // 
            // txt_RTolBorBookNum
            // 
            this.txt_RTolBorBookNum.Location = new System.Drawing.Point(479, 52);
            this.txt_RTolBorBookNum.Name = "txt_RTolBorBookNum";
            this.txt_RTolBorBookNum.Size = new System.Drawing.Size(150, 25);
            this.txt_RTolBorBookNum.TabIndex = 11;
            // 
            // txt_RCurBorBookNum
            // 
            this.txt_RCurBorBookNum.Location = new System.Drawing.Point(479, 21);
            this.txt_RCurBorBookNum.Name = "txt_RCurBorBookNum";
            this.txt_RCurBorBookNum.Size = new System.Drawing.Size(150, 25);
            this.txt_RCurBorBookNum.TabIndex = 10;
            // 
            // txt_RName
            // 
            this.txt_RName.Location = new System.Drawing.Point(176, 52);
            this.txt_RName.Name = "txt_RName";
            this.txt_RName.Size = new System.Drawing.Size(145, 25);
            this.txt_RName.TabIndex = 8;
            // 
            // txt_RID
            // 
            this.txt_RID.Location = new System.Drawing.Point(176, 17);
            this.txt_RID.Name = "txt_RID";
            this.txt_RID.Size = new System.Drawing.Size(145, 25);
            this.txt_RID.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(376, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "累计借书数量";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(376, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "当前借阅数量";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "读者类别";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "姓名";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(87, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "读者编号";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(275, 482);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 44);
            this.button1.TabIndex = 11;
            this.button1.Text = "归还";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(392, 482);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 44);
            this.button2.TabIndex = 12;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_findReader
            // 
            this.btn_findReader.Location = new System.Drawing.Point(445, 32);
            this.btn_findReader.Name = "btn_findReader";
            this.btn_findReader.Size = new System.Drawing.Size(75, 39);
            this.btn_findReader.TabIndex = 13;
            this.btn_findReader.Text = "查询";
            this.btn_findReader.UseVisualStyleBackColor = true;
            this.btn_findReader.Click += new System.EventHandler(this.btn_findReader_Click);
            // 
            // rbtn_lose2
            // 
            this.rbtn_lose2.AutoSize = true;
            this.rbtn_lose2.Location = new System.Drawing.Point(392, 230);
            this.rbtn_lose2.Name = "rbtn_lose2";
            this.rbtn_lose2.Size = new System.Drawing.Size(73, 19);
            this.rbtn_lose2.TabIndex = 19;
            this.rbtn_lose2.Text = "已损坏";
            this.rbtn_lose2.UseVisualStyleBackColor = true;
            // 
            // rbtn_lose1
            // 
            this.rbtn_lose1.AutoSize = true;
            this.rbtn_lose1.Checked = true;
            this.rbtn_lose1.Location = new System.Drawing.Point(226, 229);
            this.rbtn_lose1.Name = "rbtn_lose1";
            this.rbtn_lose1.Size = new System.Drawing.Size(73, 19);
            this.rbtn_lose1.TabIndex = 18;
            this.rbtn_lose1.TabStop = true;
            this.rbtn_lose1.Text = "无损坏";
            this.rbtn_lose1.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("华文楷体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(45, 223);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(150, 26);
            this.label10.TabIndex = 17;
            this.label10.Text = "图书是否损坏";
            // 
            // Service_M2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 540);
            this.Controls.Add(this.rbtn_lose2);
            this.Controls.Add(this.rbtn_lose1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btn_findReader);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_findRID);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Name = "Service_M2";
            this.Text = "图书归还管理";
            this.Load += new System.EventHandler(this.Service_M2_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView lv_BorInfo;
        private System.Windows.Forms.ColumnHeader BorID;
        private System.Windows.Forms.ColumnHeader RID;
        private System.Windows.Forms.ColumnHeader MID;
        private System.Windows.Forms.ColumnHeader BName;
        private System.Windows.Forms.ColumnHeader BorDate;
        private System.Windows.Forms.ColumnHeader RetDue;
        private System.Windows.Forms.TextBox txt_findRID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.TextBox txt_RTolBorBookNum;
        private System.Windows.Forms.TextBox txt_RCurBorBookNum;
        private System.Windows.Forms.TextBox txt_RName;
        private System.Windows.Forms.TextBox txt_RID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_RType;
        private System.Windows.Forms.TextBox txt_ViolationNum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_findReader;
        private System.Windows.Forms.RadioButton rbtn_lose2;
        private System.Windows.Forms.RadioButton rbtn_lose1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}