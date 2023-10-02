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
    public partial class frmDingDang : Form
    {
        public frmDingDang()
        {
            InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void định_dạng_Load(object sender, EventArgs e)
        {
            radRed.Checked = true;
            radRed.ForeColor = Color.Red;
        }

        private void radblack_CheckedChanged(object sender, EventArgs e)
        {
            txtlaptrinh.ForeColor = Color.Black;
        }

        private void radblue_CheckedChanged(object sender, EventArgs e)
        {
            txtlaptrinh.ForeColor = Color.Blue;
        }

        private void radgreen_CheckedChanged(object sender, EventArgs e)
        {
            txtlaptrinh.ForeColor = Color.Green;
        }

        private void radred_CheckedChanged(object sender, EventArgs e)
        {
            txtlaptrinh.ForeColor = Color.Red;
        }

        private void chkblod_CheckedChanged(object sender, EventArgs e)
        {
            txtlaptrinh.Font = new Font(txtlaptrinh.Font.Name, txtlaptrinh.Font.Size, txtlaptrinh.Font.Style ^ FontStyle.Bold);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            txtlaptrinh.Font = new Font(txtlaptrinh.Font.Name, txtlaptrinh.Font.Size, txtlaptrinh.Font.Style ^ FontStyle.Italic);
        }

        private void chkgachchan_CheckedChanged(object sender, EventArgs e)
        {
            txtlaptrinh.Font = new Font(txtlaptrinh.Font.Name, txtlaptrinh.Font.Size, txtlaptrinh.Font.Style ^ FontStyle.Underline);
        }
    }
}
