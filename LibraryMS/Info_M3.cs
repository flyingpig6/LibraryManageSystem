using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryMS
{
    public partial class Info_M3 : Form
    {
        public Info_M3()
        {
            InitializeComponent();
            lbl_Status.Text = "添加";
        }

        string bid = "";//定义全局变量，用于存储图书编号

        private void lv_Customer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_Customer.SelectedItems.Count > 0)//如果有选中项
            {
                ListViewItem myitem = lv_Customer.SelectedItems[0];//获取选中的第一行

                bid = myitem.SubItems[0].Text;//将选中行第一列的值赋值全局变量，读者编号
                txt_ISBN.Text = myitem.SubItems[0].Text;
                txt_PID.Text = myitem.SubItems[1].Text;
                txt_BName.Text = myitem.SubItems[2].Text;
                txt_BType.Text = myitem.SubItems[3].Text;
                txt_BAuthor.Text = myitem.SubItems[4].Text;
                txt_BEdition.Text = myitem.SubItems[5].Text;
                txt_BPubDate.Text = myitem.SubItems[6].Text;
                txt_BPrice.Text = myitem.SubItems[7].Text;
                txt_BCurStock.Text = myitem.SubItems[9].Text;
                txt_BTolStock.Text = myitem.SubItems[10].Text;


                lbl_Status.Text = "修改";
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            string ISBN = txt_ISBN.Text.Trim();
            string PID = txt_PID.Text.Trim();
            string BookName = txt_BName.Text.Trim();
            string Type = txt_BType.Text.Trim();
            string Author = txt_BAuthor.Text.Trim();
            string strEdition = txt_BEdition.Text.Trim();
            int Edition = int.Parse(strEdition);
            DateTime PubDate = DateTime.Now;
            float Price = float.Parse(txt_BPrice.Text.Trim());
            int CurrentStock = int.Parse(txt_BCurStock.Text.Trim());
            int TotalStock = int.Parse(txt_BTolStock.Text.Trim());
            string Summary = "";

            if (ISBN == "" || PID == "" || BookName == "" || Type == "" || Author == "" || strEdition == "" )
            {
                MessageBox.Show("请补充完整图书馆藏信息！");
            }
            else if (lbl_Status.Text == "添加")
            //else
            {
                MySqlConnection conn = new MySqlConnection("server=localhost;database=my_library;UID=root;PWD=123456;port=3306");
                conn.Open();
                string str = string.Format("insert into book_info values('{0}','{1}','{2}','{3}','{4}',{5},'{6}',{7},'{8}',{9},{10})", ISBN,PID, BookName, Type, Author, Edition, PubDate, Price,Summary, CurrentStock, TotalStock);
                MySqlCommand cmd = new MySqlCommand(str, conn);
                int i = cmd.ExecuteNonQuery();
                conn.Close();

                if (i > 0)
                {
                    lbl_Note.Text = "恭喜您，图书信息添加成功";
                    lbl_Note.ForeColor = Color.Blue;
                    ClearTextBox();
                    DataBind_Book();
                }
            }
            else//修改状态
            {
                MySqlConnection conn = new MySqlConnection("server=localhost;database=my_library;UID=root;PWD=123456;port=3306");
                conn.Open();
                string str = string.Format("update book_info set ISBN='{0}',PID='{1}',BookName='{2}',Type='{3}',Author='{4}',Edition={5},PubDate='{6}',Price={7},CurrentStock={8},TotalStock={9} where ISBN='{10}'",
                     ISBN, PID, BookName, Type, Author, Edition, PubDate, Price, CurrentStock, TotalStock,bid);
                MySqlCommand cmd = new MySqlCommand(str, conn);
                int i = cmd.ExecuteNonQuery();
                conn.Close();


                if (i > 0)
                {
                    lbl_Note.Text = "恭喜你，图书信息修改成功！";
                    lbl_Note.ForeColor = Color.Blue;
                    ClearTextBox();
                    DataBind_Book();//重新加载客户信息
                }
                else
                {
                    lbl_Note.Text = "对不起，图书信息修改失败！";
                    lbl_Note.ForeColor = Color.Red;
                }
            }
        }
        protected void ClearTextBox()
        {
            txt_ISBN.Text = "";
            txt_PID.Text = "";
            txt_BName.Text = "";
            txt_BType.Text = "";
            txt_BAuthor.Text = "";
            txt_BEdition.Text = "";
            txt_BPubDate.Text = "";
            txt_BPrice.Text = "";
            txt_BCurStock.Text = "";
            txt_BTolStock.Text = "";

            lbl_Status.Text = "添加";
            bid = "";
        }

        protected void DataBind_Book()
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;database=my_library;UID=root;PWD=123456;port=3306");
            conn.Open();
            string str = "select * from book_info";
            MySqlDataAdapter da = new MySqlDataAdapter(str, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            lv_Customer.Items.Clear();//先清空列表视图中的现有行
            foreach (DataRow dr in dt.Rows)
            {
                //创建一个ListViewItem项，并为第一列赋值，读者编号
                ListViewItem myitem = new ListViewItem(dr["ISBN"].ToString());
                myitem.SubItems.Add(dr["PID"].ToString());
                myitem.SubItems.Add(dr["BookName"].ToString());
                myitem.SubItems.Add(dr["Type"].ToString());
                myitem.SubItems.Add(dr["Author"].ToString());
                myitem.SubItems.Add(dr["Edition"].ToString());
                myitem.SubItems.Add(dr["PubDate"].ToString());
                myitem.SubItems.Add(dr["Price"].ToString());
                myitem.SubItems.Add(dr["Summary"].ToString());
                myitem.SubItems.Add(dr["CurrentStock"].ToString());
                myitem.SubItems.Add(dr["TotalStock"].ToString());

                lv_Customer.Items.Add(myitem);
            }
        }

        private void Info_M3_Load(object sender, EventArgs e)
        {
            DataBind_Book();
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            if (bid == "")
            {
                MessageBox.Show("请先选择要删除的图书信息");
            }
            else
            {
                //弹出删除确认提示框
                DialogResult result = MessageBox.Show("确定要删除选中的图书信息？", "删除提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    MySqlConnection conn = new MySqlConnection("server=localhost;database=my_library;UID=root;PWD=123456;port=3306");
                    conn.Open();
                    string str = string.Format("delete from book_info where ISBN='{0}'", bid);
                    MySqlCommand cmd = new MySqlCommand(str, conn);
                    int i = cmd.ExecuteNonQuery();
                    conn.Close();
                    if (i > 0)
                    {
                        lbl_Note.Text = "恭喜你，图书信息删除成功！";
                        lbl_Note.ForeColor = Color.Blue;
                        ClearTextBox();
                        DataBind_Book();//重新加载客户信息
                    }
                    else
                    {
                        lbl_Note.Text = "对不起，图书信息删除失败！";
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
