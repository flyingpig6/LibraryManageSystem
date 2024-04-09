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
    public partial class Service_M1 : Form
    {
        public Service_M1()
        {
            InitializeComponent();
        }

        int if_Choose=-1;//用于判断是否两个表格都选中
        string isbn = "";
        string bid = "";
        string rid = "";

        protected void DataBind_Reader()
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;database=my_library;UID=root;PWD=123456;port=3306");
            conn.Open();
            string str = "select * from Reader_info";
            MySqlDataAdapter da = new MySqlDataAdapter(str, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            lv_Reader.Items.Clear();//先清空列表视图中的现有行
            foreach (DataRow dr in dt.Rows)
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

                lv_Reader.Items.Add(myitem);
            }
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
            lv_Book.Items.Clear();//先清空列表视图中的现有行
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

                lv_Book.Items.Add(myitem);
            }
        }

        private void Service_M1_Load(object sender, EventArgs e)
        {
            DataBind_Reader();//加载读者信息
            DataBind_Book();//加载书本信息
        }

        private void lv_Book_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_Book.SelectedItems.Count > 0)//如果有选中项
            {
                ListViewItem myitem = lv_Book.SelectedItems[0];//获取选中的第一行
                if_Choose++;
                isbn = myitem.SubItems[0].Text;//将选中行第一列的值赋值全局变量

            }
            
        }

        private void lv_Reader_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_Reader.SelectedItems.Count > 0)//如果有选中项
            {
                ListViewItem myitem = lv_Reader.SelectedItems[0];//获取选中的第一行
                if_Choose++;
                rid = myitem.SubItems[0].Text;//将选中行第一列的值赋值全局变量
            }
        }

        public void BorrowBook(string borID, string rID, string mID, string bID, DateTime borDate, DateTime retDue, int borNum)
        {
            using (MySqlConnection conn = new MySqlConnection("server=localhost;database=my_library;UID=root;PWD=123456;port=3306"))
            {
                conn.Open();

                // 开始事务
                MySqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    MySqlCommand cmd = conn.CreateCommand();
                    cmd.Transaction = transaction;

                    // 操作1: 插入借阅记录
                    cmd.CommandText = "INSERT INTO Book_Borrow_Info (BorID, RID, MID, BID, BorDate, RetDue, BorNum) " +
                        "VALUES (@BorID, @RID, @MID, @BID, @BorDate, @RetDue, @BorNum)";
                    cmd.Parameters.AddWithValue("@BorID", borID);
                    cmd.Parameters.AddWithValue("@RID", rID);
                    cmd.Parameters.AddWithValue("@MID", mID);
                    cmd.Parameters.AddWithValue("@BID", bID);
                    cmd.Parameters.AddWithValue("@BorDate", borDate);
                    cmd.Parameters.AddWithValue("@RetDue", retDue);
                    cmd.Parameters.AddWithValue("@BorNum", borNum);
                    cmd.ExecuteNonQuery();

                    // 操作2: 更新图书信息表
                    cmd.CommandText = "UPDATE Book_Info SET CurrentStock = CurrentStock - 1 WHERE ISBN = " +
                        "(SELECT ISBN FROM Library_Book_Info WHERE BID = @BID)";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@BID", bID);
                    cmd.ExecuteNonQuery();

                    // 操作3: 更新图书馆藏表
                    cmd.CommandText = "UPDATE Library_Book_Info SET BookState = '已借' WHERE BID = @BID";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@BID", bID);
                    cmd.ExecuteNonQuery();

                    // 操作4: 更新读者信息表
                    cmd.CommandText = "UPDATE Reader_Info SET BorBookNum = BorBookNum + 1 WHERE RID = @RID";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@RID", rID);
                    cmd.ExecuteNonQuery();

                    // 提交事务
                    transaction.Commit();
                    MessageBox.Show("恭喜您，借阅成功，借阅时间为1个月，请注意归还时间！");
                    Console.WriteLine("借阅成功!");
                    DataBind_Book();
                    DataBind_Reader();
                }
                catch (Exception ex)
                {
                    // 发生异常，回滚事务
                    transaction.Rollback();
                    Console.WriteLine("事务回滚: " + ex.Message);
                    Console.WriteLine("借阅失败!");
                    DataBind_Book();
                    DataBind_Reader();
                }
            }
        }

        public string GenerateNewBorID()
        {
            string newBorID = "";
            using (MySqlConnection conn = new MySqlConnection("server=localhost;database=my_library;UID=root;PWD=123456;port=3306"))
            {
                conn.Open();

                string query = "SELECT BorID FROM Book_Borrow_Info ORDER BY BorID DESC LIMIT 1";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    string lastBorID = result.ToString();
                    int numberPart = int.Parse(lastBorID.Substring(3)) + 1;
                    newBorID = "BOR" + numberPart.ToString("D3"); // 保证是三个数字
                }
                else
                {
                    // If there are no records, start from BOR001
                    newBorID = "BOR001";
                }
            }

            return newBorID;
        }

        // 补充：获取可借的馆藏图书ID
        private string GetAvailableBookID(string isbn)
        {
            using (MySqlConnection conn = new MySqlConnection("server=localhost;database=my_library;UID=root;PWD=123456;port=3306"))
            {
                conn.Open();

                string query = "SELECT BID FROM Library_Book_Info WHERE ISBN = @ISBN AND BookState = '可借' LIMIT 1";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ISBN", isbn);

                object result = cmd.ExecuteScalar();
                conn.Close();

                if (result != null)
                {
                    return result.ToString();
                }
                else
                {
                    return null;
                }
            }
        }

        private void btn_Borrow_Click(object sender, EventArgs e)
        {
            if (if_Choose <1)
            {
                MessageBox.Show("请同时选中待借阅的书籍和读者！");
            }
            else if(if_Choose >= 1) 
            {
                //获取相关信息string borID, string rID, string mID, string bID, DateTime borDate, DateTime retDue, int borNum
                string borID = GenerateNewBorID();
                string rID = rid;
                string mID = "M001";
    
                // 补充：从图书馆藏信息表中选取一条状态为"可借"的馆藏图书
                string bID = GetAvailableBookID(isbn);
                if (bID == null)
                {
                    MessageBox.Show("选中的图书没有可借的馆藏！");
                    return;
                }

                DateTime borDate = DateTime.Now;
                DateTime retDue = borDate.AddMonths(1);
                int borNum = 1;

                //调用图书借阅函数（事务）
                BorrowBook(borID,rID,mID,bID,borDate,retDue,borNum);
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
