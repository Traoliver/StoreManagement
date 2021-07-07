using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapLon.View
{
    public partial class frm_khachhang : Form
    {
        bool cothem;
        clsKhachHang kh = new clsKhachHang();
        public frm_khachhang()
        {
            InitializeComponent();
        }

        void HienthiKhachHang()
        {
            DataTable dt = kh.LayDSKhachHang();
            lstKhachHang.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = lstKhachHang.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
            }
        }
        void setButton(bool val)
        {
            btnthem.Enabled = val;
            btnxoa.Enabled = val;
            btnsua.Enabled = val;
            btnluu.Enabled = !val;
            btnhuy.Enabled = !val;
        }
        void setNull()
        {
            txtmakh.Text = "";
            txtdc.Text = "";
            txtsdt.Text = "";
            txtemail.Text = "";
            txttenkh.Text = "";
        }
        public void Khoa(bool a)
        {
            txtmakh.ReadOnly = a;
            txttenkh.ReadOnly = a;
            txtdc.ReadOnly = a;
            txtsdt.ReadOnly = a;
            txtemail.ReadOnly = a;
        }
        public void Khoa1(bool a)
        {
            txtmakh.ReadOnly = !a;
            txttenkh.ReadOnly = a;
            txtdc.ReadOnly = a;
            txtsdt.ReadOnly = a;
            txtemail.ReadOnly = a;
        }
        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frm_khachhang_Load(object sender, EventArgs e)
        {
            setButton(true);
            HienthiKhachHang();
            setNull();
            Khoa(true);
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            cothem = true;
            setButton(false);
            setNull();
            Khoa(false);
            txtmakh.Focus();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (lstKhachHang.SelectedIndices.Count > 0)
            {
                cothem = false;
                setButton(false);
                Khoa1(false);
                txttenkh.Focus();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 Khách Hàng", "Thông báo");
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (lstKhachHang.SelectedIndices.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc xóa không ? ", "Xóa khách hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    kh.XoaKhachHang(lstKhachHang.SelectedItems[0].SubItems[0].Text);
                    HienthiKhachHang();
                    setNull();
                    Khoa(true);
                    setButton(true);
                }
            }
            else
                MessageBox.Show("Bạn phải chọn mẩu tin cần xóa");
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (cothem)
            {
                kh.ThemmoiKhachHang(txtmakh.Text, txttenkh.Text, txtdc.Text, txtsdt.Text, txtemail.Text);
                MessageBox.Show("Thêm mới thành công");
            }
            else
            {
                kh.CapNhatKhachHang(txtmakh.Text, txttenkh.Text, txtdc.Text, txtsdt.Text, txtemail.Text);
                MessageBox.Show("Cập nhật thành công");
            }
            HienthiKhachHang();
            setNull();
            setButton(true);
            Khoa(true);
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            setButton(true);
            setNull();
            Khoa(true);
        }

        private void txtsdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void lstKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstKhachHang.SelectedIndices.Count > 0)
            {
                txtmakh.Text = lstKhachHang.SelectedItems[0].SubItems[0].Text;
                txttenkh.Text = lstKhachHang.SelectedItems[0].SubItems[1].Text;
                txtdc.Text = lstKhachHang.SelectedItems[0].SubItems[2].Text;
                txtsdt.Text = lstKhachHang.SelectedItems[0].SubItems[3].Text;
                txtemail.Text = lstKhachHang.SelectedItems[0].SubItems[4].Text;

            }
        }

        private void txttenkh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void frm_khachhang_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát quản lý khách hàng?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                e.Cancel = true;
        }

        
    }
}
