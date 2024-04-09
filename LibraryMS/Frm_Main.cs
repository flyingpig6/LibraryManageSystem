using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryMS
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Info_M4 iM4 = new Info_M4();
            iM4.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Service_M2 sM2 = new Service_M2();
            sM2.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Service_M3 sM3 = new Service_M3();
            sM3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Info_M1 iM1 = new Info_M1();
            iM1.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Info_M2 iM2 = new Info_M2();
            iM2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Info_M3 iM3 = new Info_M3();
            iM3.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Service_M1 sM1 = new Service_M1();
            sM1.Show();
        }
    }
}
