using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LibraryMS
{
    public partial class Service_M3 : Form
    {
        public Service_M3()
        {
            InitializeComponent();
        }

        int thingNo = 0;

        private void btn_findReader_Click(object sender, EventArgs e)
        {
            if (txt_findRID.Text.Length == 0)
            {
                MessageBox.Show("请输入读者编号！");
                return;
            }
            else
            {
                string RID = txt_findRID.Text.Trim();
                MySqlConnection conn = new MySqlConnection("server=localhost;database=my_library;UID=root;PWD=123456;port=3306");
                try
                {
                    conn.Open();

                    // 查询Book_damage_Info表的SQL语句
                    string queryDamageInfo = "SELECT * FROM Book_damage_Info WHERE BorID IN (SELECT BorID FROM Book_Borrow_Info WHERE RID=@RID)";
                    MySqlCommand cmdDamageInfo = new MySqlCommand(queryDamageInfo, conn);
                    cmdDamageInfo.Parameters.AddWithValue("@RID", RID);

                    // 查询Overdue_Fine_Info表的SQL语句
                    string queryOverdueInfo = "SELECT * FROM Overdue_Fine_Info WHERE BorID IN (SELECT BorID FROM Book_Borrow_Info WHERE RID=@RID)";
                    MySqlCommand cmdOverdueInfo = new MySqlCommand(queryOverdueInfo, conn);
                    cmdOverdueInfo.Parameters.AddWithValue("@RID", RID);

                    // 填写ListView1
                    MySqlDataReader readerDamageInfo = cmdDamageInfo.ExecuteReader();
                    lv_DamInfo.Items.Clear();
                    while (readerDamageInfo.Read())
                    {
                        ListViewItem item = new ListViewItem(readerDamageInfo["DamageID"].ToString());
                        // 添加其他列信息
                        item.SubItems.Add(readerDamageInfo["BorID"].ToString());
                        item.SubItems.Add(readerDamageInfo["MID"].ToString());
                        item.SubItems.Add(readerDamageInfo["Fine"].ToString());
                        item.SubItems.Add(readerDamageInfo["OperTime"].ToString());
                        item.SubItems.Add(readerDamageInfo["IfPay"].ToString());
                        item.SubItems.Add(readerDamageInfo["Remark"].ToString());
                        // ...其他需要显示的字段
                        lv_DamInfo.Items.Add(item);
                    }
                    readerDamageInfo.Close();

                    // 填写ListView2
                    MySqlDataReader readerOverdueInfo = cmdOverdueInfo.ExecuteReader();
                    lv_OverdueInfo.Items.Clear();
                    while (readerOverdueInfo.Read())
                    {
                        ListViewItem item = new ListViewItem(readerOverdueInfo["OverdueID"].ToString());
                        // 添加其他列信息
                        item.SubItems.Add(readerOverdueInfo["BorID"].ToString());
                        item.SubItems.Add(readerOverdueInfo["MID"].ToString());
                        item.SubItems.Add(readerOverdueInfo["Fine"].ToString());
                        item.SubItems.Add(readerOverdueInfo["IfPay"].ToString());
                        item.SubItems.Add(readerOverdueInfo["PayDate"].ToString());
                        item.SubItems.Add(readerOverdueInfo["Remark"].ToString());
                        lv_OverdueInfo.Items.Add(item);
                    }
                    readerOverdueInfo.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("数据库操作出错：" + ex.Message);
                }
                finally
                {
                    //关闭连接
                    conn.Close();
                }
            }
        }

        private void lv_DamInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_DamInfo.SelectedItems.Count > 0)
            {
                // 当用户点击lv_DamInfo中的项时，设置thingNo为1
                thingNo = 1;
            }
        }

        private void lv_OverdueInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_DamInfo.SelectedItems.Count > 0)
            {
                // 当用户点击lv_OverInfo中的项时，设置thingNo为1
                thingNo = 2;
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_Manage_Click(object sender, EventArgs e)
        {
            if (thingNo == 0)
            {
                // 未选择任何项，不执行更新操作
                MessageBox.Show("请选择要处理的项（损坏信息或逾期信息）。");
                return;
            }

            MySqlConnection conn = new MySqlConnection("server=localhost;database=my_library;UID=root;PWD=123456;port=3306");
            conn.Open();
            MySqlTransaction transaction = conn.BeginTransaction(); // 开始事务

            try
            {
                if (thingNo == 1)
                {
                    // 处理损坏信息
                    // 获取选定的项
                    ListViewItem selectedItem = lv_DamInfo.SelectedItems[0];

                    // 获取选定项的DamageID
                    string damageID = selectedItem.SubItems[0].Text;

                    // 在这里执行对book_damage_info表格的更新操作，包括更新OperTime、IfPay和Remark
                    // 示例更新操作，将OperTime设置为当前时间，IfPay设置为true，Remark设置为处理完成
                    string updateQuery = "UPDATE Book_damage_Info SET OperTime = NOW(), IfPay = true, Remark = '处理完成' WHERE DamageID = @DamageID";
                    MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn);
                    updateCmd.Parameters.AddWithValue("@DamageID", damageID);
                    updateCmd.ExecuteNonQuery(); // 执行更新操作
                    this.Hide();
                }
                else if (thingNo == 2)
                {
                    // 处理逾期信息
                    // 获取选定的项
                    ListViewItem selectedItem = lv_OverdueInfo.SelectedItems[0];

                    // 获取选定项的OverdueID
                    string overdueID = selectedItem.SubItems[0].Text;

                    // 获取选定项的BorID，用于关联归还图书的信息
                    string borID = selectedItem.SubItems[1].Text;

                    MySqlConnection conn1 = new MySqlConnection("server=localhost;database=my_library;UID=root;PWD=123456;port=3306");
                    conn.Open();
                    MySqlTransaction transaction1 = conn.BeginTransaction(); // 开始事务

                    try
                    {
                        // 查询归还图书的信息，以获取RetDate
                        string queryRetDate = "SELECT RetDate FROM Book_Return_Info WHERE RetID = @RetID";
                        MySqlCommand cmdRetDate = new MySqlCommand(queryRetDate, conn1);
                        cmdRetDate.Parameters.AddWithValue("@RetID", borID);
                        DateTime retDate = (DateTime)cmdRetDate.ExecuteScalar();
                        // 计算罚款金额（假设按逾期时间计算，每天0.5单位罚款）
                        DateTime payDate = DateTime.Now;
                        double fine = (payDate - retDate).TotalDays * 0.5;
                        // 更新逾期信息表格
                        string updateQuery = "UPDATE Overdue_Fine_Info SET Fine = @Fine, OperTime = NOW(), IfPay = true, Remark = '处理完成' WHERE OverdueID = @OverdueID";
                        MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn1);
                        updateCmd.Parameters.AddWithValue("@OverdueID", overdueID);
                        updateCmd.Parameters.AddWithValue("@Fine", fine);
                        updateCmd.ExecuteNonQuery(); // 执行更新操作
                        transaction1.Commit(); // 提交事务，所有操作都成功执行
                        MessageBox.Show("处理完成。");
                        this.Hide();
                    }
                    catch (Exception ex)
                    {
                        transaction1.Rollback(); // 回滚事务，发生异常时撤销所有操作
                        MessageBox.Show("数据库操作出错：" + ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                        thingNo = 0; // 重置thingNo为0，以便下次操作
                    }
                }
                transaction.Commit(); // 提交事务，所有操作都成功执行
                MessageBox.Show("处理完成。");
            }
            catch (Exception ex)
            {
                transaction.Rollback(); // 回滚事务，发生异常时撤销所有操作
                MessageBox.Show("数据库操作出错：" + ex.Message);
            }
            finally
            {
                conn.Close();
                thingNo = 0; // 重置thingNo为0，以便下次操作
            }
        }
    }
}
