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
    public partial class frm_bchoadon : Form
    {
        clsHoaDon hd = new clsHoaDon();
        public frm_bchoadon()
        {
            InitializeComponent();
        }

        void HienThi()
        {
            int dem = 0;
            double tong = 0;
            DataTable dt = hd.LayDS();
            lvbchoadon.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = lvbchoadon.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
                lvi.SubItems.Add(dt.Rows[i][5].ToString());
                lvi.SubItems.Add(dt.Rows[i][6].ToString());
                tong += Convert.ToDouble(dt.Rows[i][6].ToString());
                dem++;  
            }
            lbtong.Text = dem.ToString();
            lbtongtien.Text = tong.ToString() + " đ";
        }
        private void frm_bchoadon_Load(object sender, EventArgs e)
        {
            HienThi();
        }

        private void frm_bchoadon_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát hóa đơn?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                e.Cancel = true;
        }
    }
}
