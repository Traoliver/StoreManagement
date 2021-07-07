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
    public partial class frm_nhanvien : Form
    {
        bool cothem;
        clsNhanVien nv = new clsNhanVien();
        public frm_nhanvien()
        {
            InitializeComponent();
        }

        void HienthiNhanvien()
        {
            DataTable dt = nv.LayDSNhanvien();
            lstNhanVien.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = lstNhanVien.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
                lvi.SubItems.Add(dt.Rows[i][5].ToString());
                lvi.SubItems.Add(dt.Rows[i][6].ToString());
                lvi.SubItems.Add(dt.Rows[i][7].ToString());
                lvi.SubItems.Add(dt.Rows[i][8].ToString());
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
            txtmanv.Text = "";
            txttennv.Text = "";
            txtdc.Text = "";
            txtsdt.Text = "";
            txtemail.Text = "";
            txtluong.Text = "";
        }
        public void Khoa(bool a)
        {
            txtmanv.ReadOnly = a;
            txtdc.ReadOnly = a;
            txttennv.ReadOnly = a;
            txtsdt.ReadOnly = a;
            txtemail.ReadOnly = a;
            txtluong.ReadOnly = a;
        }
        public void Khoa1(bool a)
        {
            txtmanv.ReadOnly = !a;
            txtdc.ReadOnly = a;
            txttennv.ReadOnly = a;
            txtsdt.ReadOnly = a;
            txtemail.ReadOnly = a;
            txtluong.ReadOnly = a;
        }


        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frm_nhanvien_Load(object sender, EventArgs e)
        {
            setButton(true);
            HienthiNhanvien();
            setNull();
            Khoa(true);
            Dictionary<string, string> test = new Dictionary<string, string>();
            test.Add("Nam", "Nam");
            test.Add("Nữ", "Nữ");
            test.Add("Khác", "Khác");
            cbogioitinh.DataSource = new BindingSource(test, null);
            cbogioitinh.DisplayMember = "Value";
            cbogioitinh.ValueMember = "Key";
        }

        private void lstNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstNhanVien.SelectedIndices.Count > 0)
            {
                txtmanv.Text = lstNhanVien.SelectedItems[0].SubItems[0].Text;
                txttennv.Text = lstNhanVien.SelectedItems[0].SubItems[1].Text;
                dtngaysinh.Value = DateTime.Parse(lstNhanVien.SelectedItems[0].SubItems[2].Text);
                dtngayvaolam.Value = DateTime.Parse(lstNhanVien.SelectedItems[0].SubItems[3].Text);
                txtdc.Text = lstNhanVien.SelectedItems[0].SubItems[4].Text;
                txtluong.Text = lstNhanVien.SelectedItems[0].SubItems[5].Text;
                txtsdt.Text = lstNhanVien.SelectedItems[0].SubItems[6].Text;
                txtemail.Text = lstNhanVien.SelectedItems[0].SubItems[7].Text;
                cbogioitinh.SelectedIndex = cbogioitinh.FindString(lstNhanVien.SelectedItems[0].SubItems[8].Text);
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            cothem = true;
            setButton(false);
            setNull();
            Khoa(false);
            txtmanv.Focus();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (lstNhanVien.SelectedIndices.Count > 0)
            {
                cothem = false;
                setButton(false);
                Khoa1(false);
                txttennv.Focus();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 Nhân viên", "Thông báo");
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (lstNhanVien.SelectedIndices.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc xóa không ? ", "Xóa nhân viên", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    nv.XoaNhanVien(lstNhanVien.SelectedItems[0].SubItems[0].Text);
                    HienthiNhanvien();
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
            string ngay = String.Format("{0:MM/dd/yyyy}", dtngaysinh.Value);
            string ngaynhanviec = string.Format("{0:MM/dd/yyyy}", dtngayvaolam.Value);
            if (cothem)
            {
                nv.ThemmoiNhanVien(txtmanv.Text, txttennv.Text, ngay, ngaynhanviec, txtdc.Text, txtluong.Text, txtsdt.Text, txtemail.Text, cbogioitinh.SelectedValue.ToString());
                MessageBox.Show("Thêm mới thành công");
            }
            else
            {
                nv.CapNhatNhanVien(lstNhanVien.SelectedItems[0].SubItems[0].Text, txttennv.Text, ngay, ngaynhanviec, txtdc.Text, txtluong.Text, txtsdt.Text, txtemail.Text, cbogioitinh.SelectedValue.ToString());
                MessageBox.Show("Cập nhật thành công");
            }
            HienthiNhanvien();
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

        private void txttennv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtsdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void frm_nhanvien_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát quản lý nhân viên?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                e.Cancel = true;
        }

        


    }
}
