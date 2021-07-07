using BaiTapLon.View;
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
    public partial class frm_bcsanpham : Form
    {

        clsSanPham sp = new clsSanPham();
        public frm_bcsanpham()
        {
            InitializeComponent();
        }

        void HienthiSanPham()
        {
            int dem = 0;
            DataTable dt = sp.LayDSSanPham();
            lvbcsp.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = lvbcsp.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
                dem++;
            }
            lbtong.Text = dem.ToString();
        }

        private void frm_bcsanpham_Load(object sender, EventArgs e)
        {
            HienthiSanPham();
        }

        private void frm_bcsanpham_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát báo cáo sản phẩm?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                e.Cancel = true;
        }
    }
}
