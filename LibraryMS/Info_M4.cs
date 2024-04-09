using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryMS
{
    public partial class Info_M4 : Form
    {
        public Info_M4()
        {
            InitializeComponent();
            lbl_Status.Text = "添加";
        }

        string lbid = "";//定义全局变量，用于存储图书编号

        private void btn_Save_Click(object sender, EventArgs e)
        {
            string BID = txt_BID.Text.Trim();
            string ISBN = txt_ISBN.Text.Trim();
            DateTime StorageTime = DateTime.Now;
            string BookState = txt_BookState.Text.Trim();

            if (BID== "" || ISBN == "" || BookState == "" )
            {
                MessageBox.Show("请补充完整图书馆藏信息！");
            }
            else if (lbl_Status.Text == "添加")
            //else
            {
                MySqlConnection conn = new MySqlConnection("server=localhost;database=my_library;UID=root;PWD=123456;port=3306");
                conn.Open();
                string str = string.Format("insert into library_book_info values('{0}','{1}','{2}','{3}')", BID,ISBN,StorageTime,BookState);
                MySqlCommand cmd = new MySqlCommand(str, conn);
                int i = cmd.ExecuteNonQuery();
                conn.Close();

                if (i > 0)
                {
                    lbl_Note.Text = "恭喜您，图书馆藏信息添加成功";
                    lbl_Note.ForeColor = Color.Blue;
                    ClearTextBox();
                    DataBind_LBook();
                }
            }
            else//修改状态
            {
                MySqlConnection conn = new MySqlConnection("server=localhost;database=my_library;UID=root;PWD=123456;port=3306");
                conn.Open();
                string str = string.Format("update library_book_info set BID='{0}',ISBN='{1}',StorageTime='{2}',BookState='{3}' where BID='{4}'",
                     BID,ISBN, StorageTime,BookState,lbid);
                MySqlCommand cmd = new MySqlCommand(str, conn);
                int i = cmd.ExecuteNonQuery();
                conn.Close();


                if (i > 0)
                {
                    lbl_Note.Text = "恭喜你，图书馆藏信息修改成功！";
                    lbl_Note.ForeColor = Color.Blue;
                    ClearTextBox();
                    DataBind_LBook();//重新加载客户信息
                }
                else
                {
                    lbl_Note.Text = "对不起，图书馆藏信息修改失败！";
                    lbl_Note.ForeColor = Color.Red;
                }
            }
        }

        protected void ClearTextBox()
        {
            txt_ISBN.Text = "";
            txt_BID.Text = "";
            txt_StorageTime.Text = "";
            txt_BookState.Text = "";
     
            lbl_Status.Text = "添加";
            lbid = "";
        }

        protected void DataBind_LBook()
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;database=my_library;UID=root;PWD=123456;port=3306");
            conn.Open();
            string str = "select * from library_book_info";
            MySqlDataAdapter da = new MySqlDataAdapter(str, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            lv_Customer.Items.Clear();//先清空列表视图中的现有行
            foreach (DataRow dr in dt.Rows)
            {
                //创建一个ListViewItem项，并为第一列赋值，读者编号
                ListViewItem myitem = new ListViewItem(dr["BID"].ToString());
                myitem.SubItems.Add(dr["ISBN"].ToString());
                myitem.SubItems.Add(dr["StorageTime"].ToString());
                myitem.SubItems.Add(dr["BookState"].ToString());
                
                lv_Customer.Items.Add(myitem);
            }
        }

        private void Info_M4_Load(object sender, EventArgs e)
        {
            DataBind_LBook();
        }

        private void lv_Customer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_Customer.SelectedItems.Count > 0)//如果有选中项
            {
                ListViewItem myitem = lv_Customer.SelectedItems[0];//获取选中的第一行

                lbid = myitem.SubItems[0].Text;//将选中行第一列的值赋值全局变量，读者编号
                txt_BID.Text = myitem.SubItems[0].Text;
                txt_ISBN.Text = myitem.SubItems[1].Text;
                txt_StorageTime.Text = myitem.SubItems[2].Text;
                txt_BookState.Text = myitem.SubItems[3].Text;
         
                lbl_Status.Text = "修改";
            }
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            if (lbid == "")
            {
                MessageBox.Show("请先选择要删除的图书馆藏信息");
            }
            else
            {
                //弹出删除确认提示框
                DialogResult result = MessageBox.Show("确定要删除选中的图书馆藏信息？", "删除提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    MySqlConnection conn = new MySqlConnection("server=localhost;database=my_library;UID=root;PWD=123456;port=3306");
                    conn.Open();
                    string str = string.Format("delete from library_book_info where BID='{0}'", lbid);
                    MySqlCommand cmd = new MySqlCommand(str, conn);
                    int i = cmd.ExecuteNonQuery();
                    conn.Close();
                    if (i > 0)
                    {
                        lbl_Note.Text = "恭喜你，图书馆藏信息删除成功！";
                        lbl_Note.ForeColor = Color.Blue;
                        ClearTextBox();
                        DataBind_LBook();//重新加载客户信息
                    }
                    else
                    {
                        lbl_Note.Text = "对不起，图书馆藏信息删除失败！";
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
