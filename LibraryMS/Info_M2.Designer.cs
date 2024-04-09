namespace LibraryMS
{
    partial class Info_M2
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
            this.PID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ConPerson = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ConPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Fax = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Province = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.City = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.District = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Street = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HouseNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_Del = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_District = new System.Windows.Forms.TextBox();
            this.txt_HouseNum = new System.Windows.Forms.TextBox();
            this.txt_Street = new System.Windows.Forms.TextBox();
            this.txt_City = new System.Windows.Forms.TextBox();
            this.txt_Province = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_ConPerson = new System.Windows.Forms.TextBox();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.txt_PFax = new System.Windows.Forms.TextBox();
            this.txt_PPhone = new System.Windows.Forms.TextBox();
            this.txt_PName = new System.Windows.Forms.TextBox();
            this.txt_PID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lable1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Note
            // 
            this.lbl_Note.AutoSize = true;
            this.lbl_Note.Location = new System.Drawing.Point(312, 234);
            this.lbl_Note.Name = "lbl_Note";
            this.lbl_Note.Size = new System.Drawing.Size(0, 15);
            this.lbl_Note.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lv_Customer);
            this.groupBox2.Controls.Add(this.btn_Del);
            this.groupBox2.Location = new System.Drawing.Point(34, 316);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(733, 218);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "出版社信息列表";
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
            this.PID,
            this.PName,
            this.ConPerson,
            this.ConPhone,
            this.Fax,
            this.Province,
            this.City,
            this.District,
            this.Street,
            this.HouseNum});
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
            // PID
            // 
            this.PID.Text = "出版社编号";
            this.PID.Width = 95;
            // 
            // PName
            // 
            this.PName.Text = "出版社名称";
            this.PName.Width = 93;
            // 
            // ConPerson
            // 
            this.ConPerson.Text = "联系人";
            this.ConPerson.Width = 78;
            // 
            // ConPhone
            // 
            this.ConPhone.Text = "联系电话";
            this.ConPhone.Width = 75;
            // 
            // Fax
            // 
            this.Fax.Text = "传真号码";
            this.Fax.Width = 79;
            // 
            // Province
            // 
            this.Province.Text = "省份";
            this.Province.Width = 74;
            // 
            // City
            // 
            this.City.Text = "城市";
            this.City.Width = 80;
            // 
            // District
            // 
            this.District.Text = "区（县）";
            this.District.Width = 81;
            // 
            // Street
            // 
            this.Street.Text = "街道";
            this.Street.Width = 88;
            // 
            // HouseNum
            // 
            this.HouseNum.Text = "门牌号";
            this.HouseNum.Width = 90;
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
            this.groupBox1.Controls.Add(this.txt_District);
            this.groupBox1.Controls.Add(this.txt_HouseNum);
            this.groupBox1.Controls.Add(this.txt_Street);
            this.groupBox1.Controls.Add(this.txt_City);
            this.groupBox1.Controls.Add(this.txt_Province);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txt_ConPerson);
            this.groupBox1.Controls.Add(this.lbl_Status);
            this.groupBox1.Controls.Add(this.btn_Cancel);
            this.groupBox1.Controls.Add(this.btn_Save);
            this.groupBox1.Controls.Add(this.txt_PFax);
            this.groupBox1.Controls.Add(this.txt_PPhone);
            this.groupBox1.Controls.Add(this.txt_PName);
            this.groupBox1.Controls.Add(this.txt_PID);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lable1);
            this.groupBox1.Location = new System.Drawing.Point(34, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(733, 265);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "编辑出版社信息   状态：";
            // 
            // txt_District
            // 
            this.txt_District.Location = new System.Drawing.Point(467, 105);
            this.txt_District.Name = "txt_District";
            this.txt_District.Size = new System.Drawing.Size(145, 25);
            this.txt_District.TabIndex = 27;
            // 
            // txt_HouseNum
            // 
            this.txt_HouseNum.Location = new System.Drawing.Point(467, 168);
            this.txt_HouseNum.Name = "txt_HouseNum";
            this.txt_HouseNum.Size = new System.Drawing.Size(145, 25);
            this.txt_HouseNum.TabIndex = 26;
            // 
            // txt_Street
            // 
            this.txt_Street.Location = new System.Drawing.Point(467, 137);
            this.txt_Street.Name = "txt_Street";
            this.txt_Street.Size = new System.Drawing.Size(145, 25);
            this.txt_Street.TabIndex = 25;
            // 
            // txt_City
            // 
            this.txt_City.Location = new System.Drawing.Point(467, 74);
            this.txt_City.Name = "txt_City";
            this.txt_City.Size = new System.Drawing.Size(145, 25);
            this.txt_City.TabIndex = 24;
            // 
            // txt_Province
            // 
            this.txt_Province.Location = new System.Drawing.Point(467, 43);
            this.txt_Province.Name = "txt_Province";
            this.txt_Province.Size = new System.Drawing.Size(145, 25);
            this.txt_Province.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(378, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "门牌号";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(379, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 21;
            this.label6.Text = "街道";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(379, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 20;
            this.label8.Text = "区（县）";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(379, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 15);
            this.label9.TabIndex = 19;
            this.label9.Text = "城市";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(378, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 15);
            this.label10.TabIndex = 18;
            this.label10.Text = "省份";
            // 
            // txt_ConPerson
            // 
            this.txt_ConPerson.Location = new System.Drawing.Point(174, 105);
            this.txt_ConPerson.Name = "txt_ConPerson";
            this.txt_ConPerson.Size = new System.Drawing.Size(145, 25);
            this.txt_ConPerson.TabIndex = 17;
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
            // txt_PFax
            // 
            this.txt_PFax.Location = new System.Drawing.Point(174, 168);
            this.txt_PFax.Name = "txt_PFax";
            this.txt_PFax.Size = new System.Drawing.Size(145, 25);
            this.txt_PFax.TabIndex = 11;
            // 
            // txt_PPhone
            // 
            this.txt_PPhone.Location = new System.Drawing.Point(174, 137);
            this.txt_PPhone.Name = "txt_PPhone";
            this.txt_PPhone.Size = new System.Drawing.Size(145, 25);
            this.txt_PPhone.TabIndex = 10;
            // 
            // txt_PName
            // 
            this.txt_PName.Location = new System.Drawing.Point(174, 74);
            this.txt_PName.Name = "txt_PName";
            this.txt_PName.Size = new System.Drawing.Size(145, 25);
            this.txt_PName.TabIndex = 8;
            // 
            // txt_PID
            // 
            this.txt_PID.Location = new System.Drawing.Point(174, 43);
            this.txt_PID.Name = "txt_PID";
            this.txt_PID.Size = new System.Drawing.Size(145, 25);
            this.txt_PID.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "传真号码";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "联系电话";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "联系人";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "出版社名称";
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Location = new System.Drawing.Point(85, 53);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(82, 15);
            this.lable1.TabIndex = 0;
            this.lable1.Text = "出版社编号";
            // 
            // Info_M2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 555);
            this.Controls.Add(this.lbl_Note);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Info_M2";
            this.Text = "出版社信息管理";
            this.Load += new System.EventHandler(this.Info_M2_Load);
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
        private System.Windows.Forms.ColumnHeader PID;
        private System.Windows.Forms.ColumnHeader PName;
        private System.Windows.Forms.ColumnHeader ConPerson;
        private System.Windows.Forms.ColumnHeader ConPhone;
        private System.Windows.Forms.ColumnHeader Fax;
        private System.Windows.Forms.ColumnHeader Province;
        private System.Windows.Forms.ColumnHeader City;
        private System.Windows.Forms.ColumnHeader District;
        private System.Windows.Forms.ColumnHeader Street;
        private System.Windows.Forms.ColumnHeader HouseNum;
        private System.Windows.Forms.Button btn_Del;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox txt_PFax;
        private System.Windows.Forms.TextBox txt_PPhone;
        private System.Windows.Forms.TextBox txt_PName;
        private System.Windows.Forms.TextBox txt_PID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.TextBox txt_ConPerson;
        private System.Windows.Forms.TextBox txt_District;
        private System.Windows.Forms.TextBox txt_HouseNum;
        private System.Windows.Forms.TextBox txt_Street;
        private System.Windows.Forms.TextBox txt_City;
        private System.Windows.Forms.TextBox txt_Province;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}