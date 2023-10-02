using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TranMinhMann_31_ThiCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tiệnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cậtNhậtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDingDang frmDingDang = new frmDingDang();  
            frmDingDang.Show();
        }

        private void cậtNhậtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
         

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String hotensv = " Trần Minh Mẫn";
            String mssv = " 1223360122";
            String monthi = "Lập Trình Windowrs 2 -c#"; 
            lblinfo.Text = " Họ và Tên: " + hotensv;
            lblinfo.Text += "\nMSSV" + mssv;
            lblinfo.Text += "\nMonThi" + monthi;
            lblinfo.Text += "\nTime" + System.DateTime.Now.ToString();
        }

        private void giớiThiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
