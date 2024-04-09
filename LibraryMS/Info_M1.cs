using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace LibraryMS
{
    public partial class Info_M1 : Form
    {

        public Info_M1()
        {
            InitializeComponent();
            lbl_Status.Text = "添加";
        }

        string readerid = "";//定义全局变量，用于存储客户编号

        private void lv_Customer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_Customer.SelectedItems.Count > 0)//如果有选中项
            {
                ListViewItem myitem = lv_Customer.SelectedItems[0];//获取选中的第一行

                readerid = myitem.SubItems[0].Text;//将选中行第一列的值赋值全局变量，读者编号
                txt_RID.Text = myitem.SubItems[0].Text;
                txt_RPWD.Text = myitem.SubItems[1].Text;
                txt_RName.Text = myitem.SubItems[3].Text;
                txt_RTele.Text = myitem.SubItems[5].Text;
                rbtn_Sex1.Checked = myitem.SubItems[4].Text=="男"?true:false;
                rbtn_Sex2.Checked = myitem.SubItems[4].Text =="女"?true:false;

                // 根据ListView中的值设置ComboBox选中项
                string rtValue = myitem.SubItems[2].Text;
                switch (rtValue)
                {
                    case "教师":
                        cb_RT.SelectedItem = "教师";
                        break;
                    case "职工":
                        cb_RT.SelectedItem = "职工";
                        break;
                    case "学生":
                        cb_RT.SelectedItem = "学生";
                        break;
                    default:
                        cb_RT.SelectedIndex = -1; // 没有匹配项时不选择任何项
                        break;
                }

                lbl_Status.Text = "修改";
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            string RID=txt_RID.Text.Trim();
            string RPWD=txt_RPWD.Text.Trim();
            string RT=cb_RT.Text.Trim();
            string RName = txt_RName.Text.Trim();
            int RSex = rbtn_Sex1.Checked ? 2: 1;
            string RPhone = txt_RTele.Text.Trim();
            DateTime RegDate= DateTime.Now;
            DateTime ValDate = DateTime.Now.AddYears(10);
            int BorBookNum = 0;
            int TolBorBookNum = 0;
            int IfLost = 0;
            int ViolationNum = 0;
            string Remark = "";

            int RTID = 0;
            if(RT== "教师")
            {
                RTID = 1;
            }
            else if (RT == "职工")
            {
                RTID = 2;
            }
            else if(RT=="学生")
            {
                RTID = 3;
            }

            if (RID == "" || RPWD == "" || RTID == 0 || RName == "" || RPhone == "")
            {
                MessageBox.Show("请补充完整读者信息！");
            }
            else if(lbl_Status.Text=="添加")
            //else
            {
                MySqlConnection conn = new MySqlConnection("server=localhost;database=my_library;UID=root;PWD=123456;port=3306");
                conn.Open();
                string str = string.Format("insert into Reader_info values('{0}','{1}',{2},'{3}',{4},'{5}','{6}','{7}',{8},{9},{10},{11},'{12}')",
                    RID,RPWD,RTID,RName,RSex,RPhone,RegDate,ValDate,BorBookNum,TolBorBookNum,IfLost,ViolationNum,Remark);
                MySqlCommand cmd = new MySqlCommand(str,conn);
                int i=cmd.ExecuteNonQuery();
                conn.Close();
                
                if (i > 0)
                {
                    lbl_Note.Text = "恭喜您，读者信息添加成功";
                    lbl_Note.ForeColor = Color.Blue;
                    ClearTextBox();
                    DataBind_Reader();
                }
            }
            else//修改状态
            {
                MySqlConnection conn = new MySqlConnection("server=localhost;database=my_library;UID=root;PWD=123456;port=3306");
                conn.Open();
                string str = string.Format("update reader_info set RPWD='{0}',RTID={1},RName='{2}',RPhone='{3}',RSex={4} where RID='{5}'",
                    RPWD,RTID,RName,RPhone,RSex,readerid);
                MySqlCommand cmd = new MySqlCommand(str,conn);
                int i=cmd.ExecuteNonQuery();
                conn.Close();
                if (i > 0)
                {
                    lbl_Note.Text = "恭喜你，读者信息修改成功！";
                    lbl_Note.ForeColor= Color.Blue;
                    ClearTextBox() ;
                    DataBind_Reader();//重新加载客户信息
                }
                else
                {
                    lbl_Note.Text = "对不起，读者信息修改失败！";
                    lbl_Note.ForeColor= Color.Red;
                }
            }
        }
        protected void ClearTextBox()
        {
            txt_RID.Text = "";
            txt_RPWD.Text = "";
            txt_RName.Text = "";
            txt_RTele.Text = "";
            rbtn_Sex1.Checked = true;
            rbtn_Sex2.Checked = false;
            cb_RT.Text = "";
            lbl_Status.Text = "添加";
            readerid = "";
        }

        //加载读者信息
        protected void DataBind_Reader()
        { 
            MySqlConnection conn = new MySqlConnection("server=localhost;database=my_library;UID=root;PWD=123456;port=3306");
            conn.Open();
            string str = "select * from Reader_info";
            MySqlDataAdapter da = new MySqlDataAdapter(str, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            lv_Customer.Items.Clear();//先清空列表视图中的现有行
            foreach(DataRow dr in dt.Rows)
            {
                //创建一个ListViewItem项，并为第一列赋值，读者编号
                ListViewItem myitem = new ListViewItem(dr["RID"].ToString());
                myitem.SubItems.Add(dr["RPWD"].ToString());
                //myitem.SubItems.Add(dr["RTID"].ToString());
                // 判断RTID的值，然后添加对应的字符串
                string rtidDisplayText = "";
                switch (dr["RTID"].ToString())
                {
                    case "1":
                        rtidDisplayText = "教师";
                        break;
                    case "2":
                        rtidDisplayText = "职工";
                        break;
                    case "3":
                        rtidDisplayText = "学生";
                        break;
                    default:
                        rtidDisplayText = "未知"; // 或者根据实际情况使用其他默认值
                        break;
                }
                myitem.SubItems.Add(rtidDisplayText); // 添加处理过的RTID文本

                myitem.SubItems.Add(dr["RName"].ToString());
                //myitem.SubItems.Add(dr["RSex"].ToString());
                string rtsexDisplayText = "";
                switch (dr["RSex"].ToString())
                {
                    case "1":
                        rtsexDisplayText = "女";
                        break;
                    case "2":
                        rtsexDisplayText = "男";
                        break;
                    default:
                        rtsexDisplayText = "未知"; // 或者根据实际情况使用其他默认值
                        break;
                }
                myitem.SubItems.Add(rtsexDisplayText); // 添加处理过的RTID文本

                myitem.SubItems.Add(dr["RPhone"].ToString());

                myitem.SubItems.Add(dr["RegDate"].ToString());
                myitem.SubItems.Add(dr["ValDate"].ToString());
                myitem.SubItems.Add(dr["BorBookNum"].ToString());
                myitem.SubItems.Add(dr["TolBorBookNum"].ToString());
                myitem.SubItems.Add(dr["IfLost"].ToString());
                myitem.SubItems.Add(dr["ViolationNum"].ToString()); 
                myitem.SubItems.Add(dr["Remark"].ToString());

                lv_Customer.Items.Add(myitem);
            }
        }

        private void Info_M1_Load(object sender, EventArgs e)
        {
            DataBind_Reader();//加载读者信息
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            if(readerid == "")
            {
                MessageBox.Show("请先选择要删除的客户信息");
            }
            else
            {
                //弹出删除确认提示框
                DialogResult result = MessageBox.Show("确定要删除选中的读者信息？","删除提示",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if(result == DialogResult.Yes)
                {
                    MySqlConnection conn = new MySqlConnection("server=localhost;database=my_library;UID=root;PWD=123456;port=3306");
                    conn.Open();
                    string str = string.Format("delete from reader_info where RID='{0}'", readerid);
                    MySqlCommand cmd = new MySqlCommand(str, conn);
                    int i = cmd.ExecuteNonQuery();
                    conn.Close();
                    if (i > 0)
                    {
                        lbl_Note.Text = "恭喜你，读者信息删除成功！";
                        lbl_Note.ForeColor = Color.Blue;
                        ClearTextBox();
                        DataBind_Reader();//重新加载客户信息
                    }
                    else
                    {
                        lbl_Note.Text = "对不起，读者信息删除失败！";
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
