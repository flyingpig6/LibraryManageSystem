using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace LibraryMS
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (txt_UserName.Text.Trim() == "")
            {
                MessageBox.Show("请输入用户名！");
                txt_UserName.Focus();
            }
            else if (txt_Password.Text.Trim() == "")
            {
                MessageBox.Show("请输入密码！");
                txt_Password.Focus();
            }
            else
            {
                MySqlConnection conn = new MySqlConnection("server=localhost;database=my_library;UID=root;PWD=123456;port=3306");
                //存储用户信息
                string id=txt_UserName.Text.Trim();
                string pwd = txt_Password.Text.Trim();
                UserData ud = new UserData();
                int ans1 = ud.GetId(id);
                int ans2 = ud.GetPassword(pwd);
                
                conn.Open();
                String str = string.Format("select * from manager_info where MID='{0}' and MPWD='{1}'", txt_UserName.Text, txt_Password.Text);
                MySqlDataAdapter da = new MySqlDataAdapter(str, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                conn.Close();
                if (dt.Rows.Count > 0)
                {
                    this.Hide();
                    Frm_Main frm = new Frm_Main();
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("对不起，用户名或密码不正确！");
                }    
            }
        }
    }
}
