namespace LibraryMS
{
    partial class Service_M3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_findReader = new System.Windows.Forms.Button();
            this.txt_findRID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lv_DamInfo = new System.Windows.Forms.ListView();
            this.damageID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BorID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Fine = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OperTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IfPay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Remark = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lv_OverdueInfo = new System.Windows.Forms.ListView();
            this.OverdueID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BorID2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MID2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Fine2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IfPay2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PayDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Remark2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_Manage = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "图书损坏赔偿规则";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(26, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(748, 74);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "图书馆规则手册";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(332, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "赔偿图书原价的30%。";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(332, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(256, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "罚款金额：每逾期一天，罚款0.5元。";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "图书逾期赔偿规则";
            // 
            // btn_findReader
            // 
            this.btn_findReader.Location = new System.Drawing.Point(439, 116);
            this.btn_findReader.Name = "btn_findReader";
            this.btn_findReader.Size = new System.Drawing.Size(75, 39);
            this.btn_findReader.TabIndex = 16;
            this.btn_findReader.Text = "查询";
            this.btn_findReader.UseVisualStyleBackColor = true;
            this.btn_findReader.Click += new System.EventHandler(this.btn_findReader_Click);
            // 
            // txt_findRID
            // 
            this.txt_findRID.Location = new System.Drawing.Point(225, 120);
            this.txt_findRID.Name = "txt_findRID";
            this.txt_findRID.Size = new System.Drawing.Size(131, 25);
            this.txt_findRID.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("华文楷体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(38, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 26);
            this.label5.TabIndex = 14;
            this.label5.Text = "请输入读者编号";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lv_DamInfo);
            this.groupBox2.Location = new System.Drawing.Point(32, 162);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(748, 130);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "损坏信息记录列表";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(404, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 15);
            this.label7.TabIndex = 2;
            // 
            // lv_DamInfo
            // 
            this.lv_DamInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.damageID,
            this.BorID,
            this.MID,
            this.Fine,
            this.OperTime,
            this.IfPay,
            this.Remark});
            this.lv_DamInfo.FullRowSelect = true;
            this.lv_DamInfo.GridLines = true;
            this.lv_DamInfo.HideSelection = false;
            this.lv_DamInfo.Location = new System.Drawing.Point(6, 30);
            this.lv_DamInfo.MultiSelect = false;
            this.lv_DamInfo.Name = "lv_DamInfo";
            this.lv_DamInfo.Size = new System.Drawing.Size(736, 94);
            this.lv_DamInfo.TabIndex = 1;
            this.lv_DamInfo.UseCompatibleStateImageBehavior = false;
            this.lv_DamInfo.View = System.Windows.Forms.View.Details;
            this.lv_DamInfo.SelectedIndexChanged += new System.EventHandler(this.lv_DamInfo_SelectedIndexChanged);
            // 
            // damageID
            // 
            this.damageID.Text = "损坏编号";
            this.damageID.Width = 92;
            // 
            // BorID
            // 
            this.BorID.Text = "借阅编号";
            this.BorID.Width = 93;
            // 
            // MID
            // 
            this.MID.Text = "管理员编号";
            this.MID.Width = 122;
            // 
            // Fine
            // 
            this.Fine.Text = "罚金";
            this.Fine.Width = 127;
            // 
            // OperTime
            // 
            this.OperTime.Text = "处理日期";
            this.OperTime.Width = 143;
            // 
            // IfPay
            // 
            this.IfPay.Text = "是否赔偿";
            this.IfPay.Width = 145;
            // 
            // Remark
            // 
            this.Remark.Text = "注释";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.lv_OverdueInfo);
            this.groupBox3.Location = new System.Drawing.Point(32, 308);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(748, 130);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "逾期归还信息记录列表";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(404, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 15);
            this.label6.TabIndex = 2;
            // 
            // lv_OverdueInfo
            // 
            this.lv_OverdueInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.OverdueID,
            this.BorID2,
            this.MID2,
            this.Fine2,
            this.IfPay2,
            this.PayDate,
            this.Remark2});
            this.lv_OverdueInfo.FullRowSelect = true;
            this.lv_OverdueInfo.GridLines = true;
            this.lv_OverdueInfo.HideSelection = false;
            this.lv_OverdueInfo.Location = new System.Drawing.Point(6, 26);
            this.lv_OverdueInfo.MultiSelect = false;
            this.lv_OverdueInfo.Name = "lv_OverdueInfo";
            this.lv_OverdueInfo.Size = new System.Drawing.Size(736, 94);
            this.lv_OverdueInfo.TabIndex = 1;
            this.lv_OverdueInfo.UseCompatibleStateImageBehavior = false;
            this.lv_OverdueInfo.View = System.Windows.Forms.View.Details;
            this.lv_OverdueInfo.SelectedIndexChanged += new System.EventHandler(this.lv_OverdueInfo_SelectedIndexChanged);
            // 
            // OverdueID
            // 
            this.OverdueID.Text = "超期编号";
            this.OverdueID.Width = 92;
            // 
            // BorID2
            // 
            this.BorID2.Text = "借阅编号";
            this.BorID2.Width = 93;
            // 
            // MID2
            // 
            this.MID2.Text = "管理员编号";
            this.MID2.Width = 122;
            // 
            // Fine2
            // 
            this.Fine2.Text = "罚金";
            this.Fine2.Width = 71;
            // 
            // IfPay2
            // 
            this.IfPay2.Text = "是否支付";
            this.IfPay2.Width = 90;
            // 
            // PayDate
            // 
            this.PayDate.Text = "支付日期";
            // 
            // Remark2
            // 
            this.Remark2.Text = "注释";
            this.Remark2.Width = 145;
            // 
            // btn_Manage
            // 
            this.btn_Manage.Location = new System.Drawing.Point(254, 445);
            this.btn_Manage.Name = "btn_Manage";
            this.btn_Manage.Size = new System.Drawing.Size(117, 43);
            this.btn_Manage.TabIndex = 19;
            this.btn_Manage.Text = "处理";
            this.btn_Manage.UseVisualStyleBackColor = true;
            this.btn_Manage.Click += new System.EventHandler(this.btn_Manage_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(421, 444);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(117, 43);
            this.btn_Cancel.TabIndex = 20;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // Service_M3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 522);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Manage);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_findReader);
            this.Controls.Add(this.txt_findRID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Name = "Service_M3";
            this.Text = "罚款缴费管理";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_findReader;
        private System.Windows.Forms.TextBox txt_findRID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView lv_DamInfo;
        private System.Windows.Forms.ColumnHeader damageID;
        private System.Windows.Forms.ColumnHeader BorID;
        private System.Windows.Forms.ColumnHeader MID;
        private System.Windows.Forms.ColumnHeader Fine;
        private System.Windows.Forms.ColumnHeader OperTime;
        private System.Windows.Forms.ColumnHeader IfPay;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView lv_OverdueInfo;
        private System.Windows.Forms.ColumnHeader OverdueID;
        private System.Windows.Forms.ColumnHeader BorID2;
        private System.Windows.Forms.ColumnHeader MID2;
        private System.Windows.Forms.ColumnHeader Fine2;
        private System.Windows.Forms.ColumnHeader IfPay2;
        private System.Windows.Forms.ColumnHeader Remark2;
        private System.Windows.Forms.Button btn_Manage;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.ColumnHeader Remark;
        private System.Windows.Forms.ColumnHeader PayDate;
    }
}