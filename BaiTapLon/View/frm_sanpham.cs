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
    public partial class frm_SanPham : Form
    {
        clsSanPham sp = new clsSanPham();
        bool cothem;
        public frm_SanPham()
        {
            InitializeComponent();
        }

        void HienthiSanPham()
        {
            DataTable dt = sp.LayDSSanPham();
            lvsSanpham.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = lvsSanpham.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
               
               
            }
        }

        void setNull()
        {
            txtmasp.Text = "";
            txttensp.Text = "";
            txtdonvi.Text = "";
            txtgiatien.Text = "";
            cbMaNCC.Text = "";
            
        }
        void setButton(bool val)
        {
            btnthem.Enabled = val;
            btnxoa.Enabled = val;
            btnsua.Enabled = val;
            btnthoat.Enabled = val;
            btnluu.Enabled = !val;
            btnhuy.Enabled = !val;
        }
        void HienthiMaNCC()
        {
            DataTable dt = sp.LayMaNCC();
            cbMaNCC.DataSource = dt;
            cbMaNCC.DisplayMember = "tenncc";
            cbMaNCC.ValueMember = "mancc";
        }
        public void Khoa(bool a)
        {
            txtmasp.ReadOnly = a;
            txttensp.ReadOnly = a;
            txtdonvi.ReadOnly = a;
            txtgiatien.ReadOnly = a;
            cbMaNCC.Enabled = !a;
       
        }
        public void Khoa1(bool a)
        {
            txtmasp.ReadOnly = !a;
            txttensp.ReadOnly = a;
            txtdonvi.ReadOnly = a;
            txtgiatien.ReadOnly = a;
            cbMaNCC.Enabled = !a;
            
        }
        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frm_SanPham_Load(object sender, EventArgs e)
        {
            HienthiSanPham();
            HienthiMaNCC();
            setButton(true);
            setNull();
            Khoa(true);
        }

        private void lvsSanpham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvsSanpham.SelectedIndices.Count > 0)
            {
                txtmasp.Text = lvsSanpham.SelectedItems[0].SubItems[0].Text;
                txttensp.Text = lvsSanpham.SelectedItems[0].SubItems[1].Text;
                txtdonvi.Text = lvsSanpham.SelectedItems[0].SubItems[2].Text;
                txtgiatien.Text = lvsSanpham.SelectedItems[0].SubItems[3].Text;
                cbMaNCC.SelectedIndex = cbMaNCC.FindString(lvsSanpham.SelectedItems[0].SubItems[4].Text);

            }
        }

        private void txtgiatien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void frm_SanPham_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát Quản lý sản phẩm?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                e.Cancel = true;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            cothem = true;
            setButton(false);
            Khoa(false);
            setNull();
            txtmasp.Focus();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (lvsSanpham.SelectedIndices.Count > 0)
            {
                cothem = false;
                setButton(false);
                Khoa1(false);
                txttensp.Focus();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 Sản phẩm", "Thông báo");
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (lvsSanpham.SelectedIndices.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc xóa không ? ", "Xóa Tài Khoản", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    sp.XoaSanPham(lvsSanpham.SelectedItems[0].SubItems[0].Text);
                    lvsSanpham.Items.RemoveAt(lvsSanpham.SelectedIndices[0]);
                    HienthiMaNCC();
                    setNull();
                    Khoa(true);
                    setButton(true);
                }
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (cothem)
            {
                sp.ThemSanPham(txtmasp.Text, txttensp.Text, txtdonvi.Text, txtgiatien.Text, cbMaNCC.SelectedItem.ToString());
                MessageBox.Show("Thêm mới thành công");
            }
            else
            {
                sp.CapNhatSanPham(txtmasp.Text, txttensp.Text, txtdonvi.Text, txtgiatien.Text, cbMaNCC.SelectedItem.ToString());
                MessageBox.Show(" Cập nhật thành công");
            }

            HienthiSanPham();
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
    }
}
