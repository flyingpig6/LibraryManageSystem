namespace LibraryMS
{
    partial class Info_M1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.cb_RT = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_RTele = new System.Windows.Forms.TextBox();
            this.txt_RName = new System.Windows.Forms.TextBox();
            this.txt_RPWD = new System.Windows.Forms.TextBox();
            this.txt_RID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rbtn_Sex2 = new System.Windows.Forms.RadioButton();
            this.rbtn_Sex1 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lv_Customer = new System.Windows.Forms.ListView();
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
            this.btn_Del = new System.Windows.Forms.Button();
            this.lbl_Note = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_Status);
            this.groupBox1.Controls.Add(this.btn_Cancel);
            this.groupBox1.Controls.Add(this.btn_Save);
            this.groupBox1.Controls.Add(this.cb_RT);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_RTele);
            this.groupBox1.Controls.Add(this.txt_RName);
            this.groupBox1.Controls.Add(this.txt_RPWD);
            this.groupBox1.Controls.Add(this.txt_RID);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.rbtn_Sex2);
            this.groupBox1.Controls.Add(this.rbtn_Sex1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(36, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(733, 222);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "编辑读者信息   状态：";
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
            this.btn_Cancel.Location = new System.Drawing.Point(359, 172);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(89, 34);
            this.btn_Cancel.TabIndex = 15;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(234, 172);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(85, 34);
            this.btn_Save.TabIndex = 14;
            this.btn_Save.Text = "保存";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // cb_RT
            // 
            this.cb_RT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_RT.FormattingEnabled = true;
            this.cb_RT.Items.AddRange(new object[] {
            "教师",
            "",
            "职工",
            "",
            "学生"});
            this.cb_RT.Location = new System.Drawing.Point(174, 130);
            this.cb_RT.Name = "cb_RT";
            this.cb_RT.Size = new System.Drawing.Size(145, 23);
            this.cb_RT.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(356, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "性别";
            // 
            // txt_RTele
            // 
            this.txt_RTele.Location = new System.Drawing.Point(445, 87);
            this.txt_RTele.Name = "txt_RTele";
            this.txt_RTele.Size = new System.Drawing.Size(150, 25);
            this.txt_RTele.TabIndex = 11;
            // 
            // txt_RName
            // 
            this.txt_RName.Location = new System.Drawing.Point(445, 43);
            this.txt_RName.Name = "txt_RName";
            this.txt_RName.Size = new System.Drawing.Size(150, 25);
            this.txt_RName.TabIndex = 10;
            // 
            // txt_RPWD
            // 
            this.txt_RPWD.Location = new System.Drawing.Point(174, 87);
            this.txt_RPWD.Name = "txt_RPWD";
            this.txt_RPWD.Size = new System.Drawing.Size(145, 25);
            this.txt_RPWD.TabIndex = 8;
            // 
            // txt_RID
            // 
            this.txt_RID.Location = new System.Drawing.Point(174, 43);
            this.txt_RID.Name = "txt_RID";
            this.txt_RID.Size = new System.Drawing.Size(145, 25);
            this.txt_RID.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(356, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "电话号码";
            // 
            // rbtn_Sex2
            // 
            this.rbtn_Sex2.AutoSize = true;
            this.rbtn_Sex2.Location = new System.Drawing.Point(552, 134);
            this.rbtn_Sex2.Name = "rbtn_Sex2";
            this.rbtn_Sex2.Size = new System.Drawing.Size(43, 19);
            this.rbtn_Sex2.TabIndex = 5;
            this.rbtn_Sex2.Text = "女";
            this.rbtn_Sex2.UseVisualStyleBackColor = true;
            // 
            // rbtn_Sex1
            // 
            this.rbtn_Sex1.AutoSize = true;
            this.rbtn_Sex1.Checked = true;
            this.rbtn_Sex1.Location = new System.Drawing.Point(445, 134);
            this.rbtn_Sex1.Name = "rbtn_Sex1";
            this.rbtn_Sex1.Size = new System.Drawing.Size(43, 19);
            this.rbtn_Sex1.TabIndex = 4;
            this.rbtn_Sex1.TabStop = true;
            this.rbtn_Sex1.Text = "男";
            this.rbtn_Sex1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(356, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "读者姓名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "读者类别";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "密码";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "读者编号";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lv_Customer);
            this.groupBox2.Controls.Add(this.btn_Del);
            this.groupBox2.Location = new System.Drawing.Point(36, 260);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(733, 228);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "读者信息列表";
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
            this.lv_Customer.FullRowSelect = true;
            this.lv_Customer.GridLines = true;
            this.lv_Customer.HideSelection = false;
            this.lv_Customer.Location = new System.Drawing.Point(6, 37);
            this.lv_Customer.MultiSelect = false;
            this.lv_Customer.Name = "lv_Customer";
            this.lv_Customer.Size = new System.Drawing.Size(721, 185);
            this.lv_Customer.TabIndex = 1;
            this.lv_Customer.UseCompatibleStateImageBehavior = false;
            this.lv_Customer.View = System.Windows.Forms.View.Details;
            this.lv_Customer.SelectedIndexChanged += new System.EventHandler(this.lv_Customer_SelectedIndexChanged);
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
            // lbl_Note
            // 
            this.lbl_Note.AutoSize = true;
            this.lbl_Note.Location = new System.Drawing.Point(314, 268);
            this.lbl_Note.Name = "lbl_Note";
            this.lbl_Note.Size = new System.Drawing.Size(0, 15);
            this.lbl_Note.TabIndex = 2;
            // 
            // Info_M1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 517);
            this.Controls.Add(this.lbl_Note);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Info_M1";
            this.Text = "读者信息管理";
            this.Load += new System.EventHandler(this.Info_M1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_RTele;
        private System.Windows.Forms.TextBox txt_RName;
        private System.Windows.Forms.TextBox txt_RPWD;
        private System.Windows.Forms.TextBox txt_RID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbtn_Sex2;
        private System.Windows.Forms.RadioButton rbtn_Sex1;
        private System.Windows.Forms.ComboBox cb_RT;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.Button btn_Del;
        private System.Windows.Forms.Label lbl_Note;
        private System.Windows.Forms.ListView lv_Customer;
        private System.Windows.Forms.ColumnHeader RID;
        private System.Windows.Forms.ColumnHeader RPWD;
        private System.Windows.Forms.ColumnHeader RTID;
        private System.Windows.Forms.ColumnHeader RName;
        private System.Windows.Forms.ColumnHeader BorBookNum;
        private System.Windows.Forms.ColumnHeader TolBorBookNum;
        private System.Windows.Forms.ColumnHeader RSex;
        private System.Windows.Forms.ColumnHeader RPhone;
        private System.Windows.Forms.ColumnHeader RegDate;
        private System.Windows.Forms.ColumnHeader ValDate;
        private System.Windows.Forms.ColumnHeader IfLost;
        private System.Windows.Forms.ColumnHeader ViolationNum;
        private System.Windows.Forms.ColumnHeader Remark;
        private System.Windows.Forms.Label label7;
    }
}