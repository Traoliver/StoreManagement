using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapLon
{
    public partial class frm_thongtinlhe : Form
    {
        public frm_thongtinlhe()
        {
            InitializeComponent();
        }


        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/profile.php?id=100008276288445");
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/hoang.este");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/search/top?q=phan%20th%E1%BB%8B%20ph%C6%B0%C6%A1ng%20nhi");
        }

        private void frm_thongtinlhe_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn thoát?","Thông báo", MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }
        }

    }
}
