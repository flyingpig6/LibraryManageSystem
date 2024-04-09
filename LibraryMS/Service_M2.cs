using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LibraryMS
{
    public partial class Service_M2 : Form
    {
        public Service_M2()
        {
            InitializeComponent();
        }

        string borid = "";
        string bid = "";
        // 获取当前日期
        DateTime ct = DateTime.Now;
        DateTime retDue;
        int overdueDays = 0;

        private void Service_M2_Load(object sender, EventArgs e)
        {

        }

        private void btn_findReader_Click(object sender, EventArgs e)
        {
            if(txt_findRID.Text.Length == 0)
            {
                MessageBox.Show("请输入读者编号！");
                return;
            }
            else
            {
                string RID=txt_findRID.Text.Trim();
                MySqlConnection conn = new MySqlConnection("server=localhost;database=my_library;UID=root;PWD=123456;port=3306");
                conn.Open();
                //填写ListView
                string str1 = string.Format("select * from book_borrow_info where RID='{0}'", RID);
                MySqlDataAdapter da1 = new MySqlDataAdapter(str1, conn);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);          
                lv_BorInfo.Items.Clear();//先清空列表视图中的现有行
                foreach (DataRow dr in dt1.Rows)
                {
                    //创建一个ListViewItem项，并为第一列赋值，读者编号
                    ListViewItem myitem = new ListViewItem(dr["BorID"].ToString());
                    myitem.SubItems.Add(dr["RID"].ToString());
                    myitem.SubItems.Add(dr["MID"].ToString());
                    myitem.SubItems.Add(dr["BID"].ToString());
                    myitem.SubItems.Add(dr["BorDate"].ToString());
                    myitem.SubItems.Add(dr["RetDue"].ToString());
                    
                    lv_BorInfo.Items.Add(myitem);
                }
                // 填写读者相关信息
                string str2 = string.Format("SELECT RName, CASE RTID WHEN 1 THEN '教师' WHEN 2 THEN '职工' WHEN 3 " +
                    "THEN '学生' ELSE '其他' END AS RType, BorBookNum, TolBorBookNum, ViolationNum FROM reader_info WHERE RID='{0}'", RID);
                MySqlDataAdapter da2 = new MySqlDataAdapter(str2, conn);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                if (dt2.Rows.Count > 0)
                {
                    DataRow row = dt2.Rows[0];
                    string RName = row["RName"].ToString();
                    string RType = row["RType"].ToString();
                    int BorBookNum = Convert.ToInt32(row["BorBookNum"]);
                    int TolBorBookNum = Convert.ToInt32(row["TolBorBookNum"]);
                    int ViolationNum = Convert.ToInt32(row["ViolationNum"]);

                    // 将值赋给相应的控件
                    txt_RID.Text = RID;
                    txt_RName.Text = RName;
                    txt_RType.Text = RType;
                    txt_RCurBorBookNum.Text = BorBookNum.ToString();
                    txt_RTolBorBookNum.Text = TolBorBookNum.ToString();
                    txt_ViolationNum.Text = ViolationNum.ToString();
                }
                else
                {
                    // 处理没有找到记录的情况
                    MessageBox.Show("没有找到相应的读者信息。");
                }
                //关闭连接
                conn.Close();
            }
        }

        private void lv_BorInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_BorInfo.SelectedItems.Count > 0)//如果有选中项
            {
                ListViewItem myitem = lv_BorInfo.SelectedItems[0];//获取选中的第一行

                borid = myitem.SubItems[0].Text;//将选中行第一列的值赋值全局变量，读者编号
                bid = myitem.SubItems[3].Text;
                if (DateTime.TryParse(myitem.SubItems[5].Text, out retDue))
                {
                    // retDue 现在包含解析后的日期时间
                    // 可以在此处使用 retDue
                }
                else
                {
                    // 解析失败的情况，可以在这里处理错误
                    MessageBox.Show("无法解析日期");
                }

            }
        }

        public string GenerateNewOverdueID()
        {
            string newOverdueID = "";
            using (MySqlConnection conn = new MySqlConnection("server=localhost;database=my_library;UID=root;PWD=123456;port=3306"))
            {
                conn.Open();

                string query = "SELECT OverdueID FROM Overdue_Fine_Info ORDER BY OverdueID DESC LIMIT 1";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    string lastOverdueID = result.ToString();
                    int numberPart = int.Parse(lastOverdueID.Substring(3)) + 1;
                    newOverdueID = "OVD" + numberPart.ToString("D3");
                }
                else
                {
                    newOverdueID = "OVD001";
                }

                conn.Close();
            }

            return newOverdueID;
        }

        public string GenerateNewDamageID()
        {
            string newDamageID = "";
            using (MySqlConnection conn = new MySqlConnection("server=localhost;database=my_library;UID=root;PWD=123456;port=3306"))
            {
                conn.Open();

                string query = "SELECT DamageID FROM Book_Damage_Info ORDER BY DamageID DESC LIMIT 1";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    string lastDamageID = result.ToString();
                    int numberPart = int.Parse(lastDamageID.Substring(3)) + 1;
                    newDamageID = "DAM" + numberPart.ToString("D3");
                }
                else
                {
                    newDamageID = "DAM001";
                }

                conn.Close();
            }

            return newDamageID;
        }

        public float CalculateOverdueFine(int overdueDays)
        {
            const float finePerDay = 0.5f;
            return overdueDays * finePerDay;
        }

        public float GetBookOriginalPrice(string isbn, string connectionString)
        {
            float originalPrice = 0.0f;
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT Price FROM Book_Info WHERE ISBN = @ISBN";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ISBN", isbn);

                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    originalPrice = Convert.ToSingle(result);
                }

                conn.Close();
            }

            return originalPrice;
        }

        public float CalculateDamageFine(string isbn, string connectionString)
        {
            const float damagePercentage = 0.30f; // 损坏罚款为原价的30%
            float originalPrice = GetBookOriginalPrice(isbn, connectionString);
            return originalPrice * damagePercentage;
        }


        public void ReturnBook(string retID, string rID, string mID, string bID, DateTime retDate, bool ifOverdue, bool ifDamage)
        {
            using (MySqlConnection conn = new MySqlConnection("server=localhost;database=my_library;UID=root;PWD=123456;port=3306"))
            {
                conn.Open();

                // 开始事务
                MySqlTransaction transaction = conn.BeginTransaction();
                string connString = "server=localhost;database=my_library;UID=root;PWD=123456;port=3306";

                try
                {
                    MySqlCommand cmd = conn.CreateCommand();
                    cmd.Transaction = transaction;

                    // 操作1: 插入归还记录
                    cmd.CommandText = "INSERT INTO Book_Return_Info (RetID, RID, MID, BID, RetDate, IfOverdue, IfDamage) " +
                        "VALUES (@RetID, @RID, @MID, @BID, @RetDate, @IfOverdue, @IfDamage)";
                    cmd.Parameters.AddWithValue("@RetID", retID);
                    cmd.Parameters.AddWithValue("@RID", rID);
                    cmd.Parameters.AddWithValue("@MID", mID);
                    cmd.Parameters.AddWithValue("@BID", bID);
                    cmd.Parameters.AddWithValue("@RetDate", retDate);
                    cmd.Parameters.AddWithValue("@IfOverdue", ifOverdue);
                    cmd.Parameters.AddWithValue("@IfDamage", ifDamage);
                    cmd.ExecuteNonQuery();

                    // 计算逾期天数
                    int overdueDays = 0;
                    if (ifOverdue)
                    {
                        overdueDays = (retDate - retDue).Days;
                    }

                    // 获取图书的ISBN和原价
                    cmd.CommandText = "SELECT ISBN FROM Library_Book_Info WHERE BID = @BID";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@BID", bID);
                    string isbn = Convert.ToString(cmd.ExecuteScalar());
                    float bookPrice = GetBookOriginalPrice(isbn, "server=localhost;database=my_library;UID=root;PWD=123456;port=3306");

                    // 判断并处理逾期或损坏情况
                    if (ifOverdue)
                    {
                        // 操作5: 插入逾期罚款记录
                        string overdueID = GenerateNewOverdueID();
                        float fineAmount = CalculateOverdueFine(overdueDays);
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@OverdueID", overdueID);
                        cmd.Parameters.AddWithValue("@BorID", bID);
                        cmd.Parameters.AddWithValue("@MID", mID);
                        cmd.Parameters.AddWithValue("@Fine", fineAmount);
                        cmd.Parameters.AddWithValue("@IfPay", false);
                        cmd.CommandText = "INSERT INTO Overdue_Fine_Info (OverdueID, BorID, MID, Fine, IfPay) VALUES (@OverdueID, @BorID, @MID, @Fine, @IfPay)";
                        cmd.ExecuteNonQuery();
                    }

                    if (ifDamage)
                    {
                        // 操作6: 插入损坏记录
                        string damageID = GenerateNewDamageID();
                        float damageFine = CalculateDamageFine(isbn, connString); // 使用正确的方法计算损坏罚款
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@DamageID", damageID);
                        cmd.Parameters.AddWithValue("@BorID", borid);
                        cmd.Parameters.AddWithValue("@MID", mID);
                        cmd.Parameters.AddWithValue("@Fine", damageFine);
                        cmd.Parameters.AddWithValue("@OperTime", DateTime.Now);
                        cmd.Parameters.AddWithValue("@IfPay", false);
                        cmd.CommandText = "INSERT INTO Book_Damage_Info (DamageID, BorID, MID, Fine, OperTime, IfPay) VALUES (@DamageID, @BorID, @MID, @Fine, @OperTime, @IfPay)";
                        cmd.ExecuteNonQuery();

                        // 更新图书状态为损坏
                        cmd.CommandText = "UPDATE Library_Book_Info SET BookState = '损坏' WHERE BID = @BID";
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@BID", bID);
                        cmd.ExecuteNonQuery();
                    }
                    else if (!ifDamage && !ifOverdue) // 仅当书籍未损坏且未逾期时，更新状态为可借
                    {
                        // 操作2: 更新图书馆藏信息
                        cmd.CommandText = "UPDATE Library_Book_Info SET BookState = '可借' WHERE BID = @BID";
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@BID", bID);
                        cmd.ExecuteNonQuery();
                    }
                    
                    // 操作3: 更新图书基本信息
                    cmd.CommandText = "UPDATE Book_Info SET CurrentStock = CurrentStock + 1 WHERE ISBN = @ISBN";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@ISBN", isbn);
                    cmd.ExecuteNonQuery();

                    // 操作4: 更新读者信息表
                    cmd.CommandText = "UPDATE Reader_Info SET BorBookNum = BorBookNum - 1, TolBorBookNum = TolBorBookNum + 1, ViolationNum = ViolationNum + 1 WHERE RID = @RID";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@RID", rID);
                    cmd.ExecuteNonQuery();

                    // 提交事务
                    transaction.Commit();
                    MessageBox.Show("图书归还成功！");
                    ClearText();
                }
                catch (Exception ex)
                {
                    // 发生异常，回滚事务
                    transaction.Rollback();
                    MessageBox.Show("图书归还失败：" + ex.Message);
                    ClearText();
                }
            }

        }

        public string GenerateNewRetID()
        {
            string newRetID = "";
            using (MySqlConnection conn = new MySqlConnection("server=localhost;database=my_library;UID=root;PWD=123456;port=3306"))
            {
                conn.Open();

                string query = "SELECT RetID FROM Book_Return_Info ORDER BY RetID DESC LIMIT 1";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    string lastRetID = result.ToString();
                    int numberPart = int.Parse(lastRetID.Substring(3)) + 1;
                    newRetID = "RET" + numberPart.ToString("D3"); // 保证是三个数字
                }
                else
                {
                    // 如果没有记录，从RET001开始
                    newRetID = "RET001";
                }

                conn.Close();
            }

            return newRetID;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            //获取相关信息retID, rID, mID, bID, retDate,ifOverdue, ifLose
            retDue = ct.AddYears(-1);
            string retID = GenerateNewRetID();
            string rID = txt_findRID.Text.Trim();
            string mID = "M001";

            string bID = bid;
            DateTime retDate = DateTime.Now;

            bool IfOverdue = retDate > retDue ? true : false;
            bool IfLose = rbtn_lose1.Checked ? false : true;
            if (retDate > retDue)
            {
                TimeSpan timeDiff = retDate - retDue;
                overdueDays = timeDiff.Days;
            }

            //调用图书借阅函数（事务）
            ReturnBook(retID, rID, mID, bID, retDate, IfOverdue, IfLose);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ClearText()
        {
            txt_findRID.Text = "";
            txt_RID.Text = "";
            txt_RName.Text = "";
            txt_RType.Text = "";
            txt_RCurBorBookNum.Text = "";
            txt_RTolBorBookNum.Text = "";
            txt_ViolationNum.Text = "";
            lv_BorInfo .Items.Clear();
        }
    }
}
