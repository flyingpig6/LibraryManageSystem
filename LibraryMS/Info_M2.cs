using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LibraryMS
{
    public partial class Info_M2 : Form
    {
        public Info_M2()
        {
            InitializeComponent();
            lbl_Status.Text = "添加";
        }

        string pid = "";//定义全局变量，用于存储出版社编号

        private void lv_Customer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_Customer.SelectedItems.Count > 0)//如果有选中项
            {
                ListViewItem myitem = lv_Customer.SelectedItems[0];//获取选中的第一行

                pid = myitem.SubItems[0].Text;//将选中行第一列的值赋值全局变量，读者编号
                txt_PID.Text = myitem.SubItems[0].Text;
                txt_PName.Text = myitem.SubItems[1].Text;
                txt_ConPerson.Text = myitem.SubItems[2].Text;
                txt_PPhone.Text= myitem.SubItems[3].Text;
                txt_PFax.Text = myitem.SubItems[4].Text;
                txt_Province.Text= myitem.SubItems[5].Text;
                txt_City.Text= myitem.SubItems[6].Text;
                txt_District.Text= myitem.SubItems[7].Text;
                txt_Street.Text= myitem.SubItems[8].Text;
                txt_HouseNum.Text= myitem.SubItems[9].Text;

           
                lbl_Status.Text = "修改";
            }
        }

        //加载出版社信息
        protected void DataBind_Publisher()
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;database=my_library;UID=root;PWD=123456;port=3306");
            conn.Open();
            string str = "select * from publishing_house_info";
            MySqlDataAdapter da = new MySqlDataAdapter(str, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            lv_Customer.Items.Clear();//先清空列表视图中的现有行
            foreach (DataRow dr in dt.Rows)
            {
                //创建一个ListViewItem项，并为第一列赋值，读者编号
                ListViewItem myitem = new ListViewItem(dr["PID"].ToString());
                myitem.SubItems.Add(dr["PName"].ToString());
                myitem.SubItems.Add(dr["ConPerson"].ToString());
                myitem.SubItems.Add(dr["ConPhone"].ToString());
                myitem.SubItems.Add(dr["Fax"].ToString());
                myitem.SubItems.Add(dr["Province"].ToString());
                myitem.SubItems.Add(dr["City"].ToString());
                myitem.SubItems.Add(dr["District"].ToString());
                myitem.SubItems.Add(dr["Street"].ToString());
                myitem.SubItems.Add(dr["HouseNum"].ToString());

                lv_Customer.Items.Add(myitem);
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            string PID = txt_PID.Text.Trim();
            string PName = txt_PName.Text.Trim();
            string ConPerson = txt_ConPerson.Text.Trim();
            string ConPhone = txt_PPhone.Text.Trim();
            string Fax = txt_PFax.Text.Trim();
            string Province = txt_Province.Text.Trim();
            string City = txt_City.Text.Trim();
            string District = txt_District.Text.Trim();
            string Street=txt_Street.Text.Trim();
            string HouseNum = txt_HouseNum.Text.Trim();

            if (PID == "" || PName == "" || ConPerson == "" || ConPhone == "" || Fax == ""|| Province == "" || City == "" ||District ==""|| HouseNum=="")
            {
                MessageBox.Show("请补充完整读者信息！");
            }
            else if (lbl_Status.Text == "添加")
            //else
            {
                MySqlConnection conn = new MySqlConnection("server=localhost;database=my_library;UID=root;PWD=123456;port=3306");
                conn.Open();
                string str = string.Format("insert into publishing_house_info values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')", PID, PName,ConPerson,ConPhone,Fax,Province,City,District,Street,HouseNum);
                MySqlCommand cmd = new MySqlCommand(str, conn);
                int i = cmd.ExecuteNonQuery();
                conn.Close();

                if (i > 0)
                {
                    lbl_Note.Text = "恭喜您，出版社信息添加成功";
                    lbl_Note.ForeColor = Color.Blue;
                    ClearTextBox();
                    DataBind_Publisher();
                }
            }
            else//修改状态
            {
                MySqlConnection conn = new MySqlConnection("server=localhost;database=my_library;UID=root;PWD=123456;port=3306");
                conn.Open();
                string str = string.Format("update publishing_house_info set PID='{0}',PName='{1}',ConPerson='{2}',ConPhone='{3}',Fax='{4}',Province='{5}',City='{6}',District='{7}',Street='{8}',HouseNum='{9}' where PID='{10}'", 
                    PID,PName,ConPerson,ConPhone,Fax,Province,City,District,Street,HouseNum,pid);
                MySqlCommand cmd = new MySqlCommand(str, conn);
                int i = cmd.ExecuteNonQuery();
                conn.Close();
                if (i > 0)
                {
                    lbl_Note.Text = "恭喜你，出版社信息修改成功！";
                    lbl_Note.ForeColor = Color.Blue;
                    ClearTextBox();
                    DataBind_Publisher();//重新加载客户信息
                }
                else
                {
                    lbl_Note.Text = "对不起，出版社信息修改失败！";
                    lbl_Note.ForeColor = Color.Red;
                }
            }
        }
        protected void ClearTextBox()
        {
            txt_PID.Text = "";
            txt_PName.Text = "";
            txt_ConPerson.Text = "";
            txt_PPhone.Text = "";
            txt_PFax.Text = "";
            txt_Province.Text = "";
            txt_ConPerson.Text = "";
            txt_City.Text = "";
            txt_District.Text = "";
            txt_Street.Text = "";
            txt_HouseNum.Text = "";

            lbl_Status.Text = "添加";
            pid = "";
        }

        private void Info_M2_Load(object sender, EventArgs e)
        {
            DataBind_Publisher();//加载读者信息
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            if (pid == "")
            {
                MessageBox.Show("请先选择要删除的出版社信息");
            }
            else
            {
                //弹出删除确认提示框
                DialogResult result = MessageBox.Show("确定要删除选中的出版社信息？", "删除提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    MySqlConnection conn = new MySqlConnection("server=localhost;database=my_library;UID=root;PWD=123456;port=3306");
                    conn.Open();
                    string str = string.Format("delete from publishing_house_info where PID='{0}'", pid);
                    MySqlCommand cmd = new MySqlCommand(str, conn);
                    int i = cmd.ExecuteNonQuery();
                    conn.Close();
                    if (i > 0)
                    {
                        lbl_Note.Text = "恭喜你，出版社信息删除成功！";
                        lbl_Note.ForeColor = Color.Blue;
                        ClearTextBox();
                        DataBind_Publisher();//重新加载客户信息
                    }
                    else
                    {
                        lbl_Note.Text = "对不起，出版社信息删除失败！";
                        lbl_Note.ForeColor = Color.Red;
                    }
                }
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            ClearTextBox();
            lbl_Note.Text = "";
        }
    }
}
