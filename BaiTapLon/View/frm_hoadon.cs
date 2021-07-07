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
    public partial class frm_hoadon : Form
    {
        clsHoaDon hd = new clsHoaDon();
        public frm_hoadon()
        {
            InitializeComponent();
        }
        bool cothem;
        public void SetNull()
        {
            txtmahd.Text = "";
            numbersoluong.Value = 0;

        }
        void khoa(bool a)
        {
            txtmahd.ReadOnly = a;
            numbersoluong.Enabled = !a;
            cbotenkh.Enabled = !a;
            dtngaymua.Enabled = !a;
            cbotensp.Enabled = !a;
        }
        void setButton(bool val)
        {
            btnthem.Enabled = val;
            btnxoa.Enabled = val;
            btnsua.Enabled = val;
            btnhuy.Enabled = !val;
            btnluu.Enabled = !val;
        }
        void HienThi()
        {
            DataTable dt = hd.LayDS();
            lsvHoaDon.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = lsvHoaDon.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
                lvi.SubItems.Add(dt.Rows[i][5].ToString());
                lvi.SubItems.Add(dt.Rows[i][6].ToString());
            }
        }
        void Hienthikh()
        {
            DataTable dt = hd.LayKH();
            cbotenkh.DataSource = dt;
            cbotenkh.DisplayMember = "tenkh";
            cbotenkh.ValueMember = "makh";
        }
        void Hienthisp()
        {
            DataTable dt = hd.Laysp();
            cbotensp.DataSource = dt;
            cbotensp.DisplayMember = "tensp";
            cbotensp.ValueMember = "masp";
        }
        private void frm_hoadon_Load(object sender, EventArgs e)
        {
            HienThi();
            Hienthikh();
            Hienthisp();
            setButton(true);
            khoa(true);
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            lsvHoaDon.Enabled = true;
            cothem = true;
            setButton(false);
            txtmahd.Focus();
            khoa(false);
            SetNull();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            lsvHoaDon.Enabled = true;
            if (lsvHoaDon.SelectedIndices.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc xóa không ? ", "Xóa hóa đơn! ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    hd.Xoa(lsvHoaDon.SelectedItems[0].SubItems[0].Text);
                    HienThi();
                    SetNull();
                    khoa(true);
                    setButton(true);
                }
            }
            else
                MessageBox.Show("Vui lòng chọn dòng cần xóa");
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            lsvHoaDon.Enabled = true;
            txtmahd.Enabled = true;
            if (lsvHoaDon.SelectedIndices.Count > 0)
            {
                txtmahd.Enabled = false;
                cothem = false;
                setButton(false);
                khoa(false);
                txtmahd.Focus();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 hóa đơn!", "Thông báo");
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            txtmahd.Enabled = true;
            string ngay = string.Format("{0:MM/dd/yyyy}", dtngaymua.Value);
            if (cothem == true)
            {
                hd.Them(txtmahd.Text, cbotenkh.SelectedValue.ToString(), cbotensp.SelectedValue.ToString(), ngay, numbersoluong.Text);
                HienThi();
                MessageBox.Show("Thêm mới thành công");
            }
            else
            {
                hd.capnhat(lsvHoaDon.SelectedItems[0].SubItems[0].Text, cbotenkh.SelectedValue.ToString(), cbotensp.SelectedValue.ToString(), ngay, numbersoluong.Value.ToString());
                MessageBox.Show("Cập nhật thành công");
            }
            HienThi();
            SetNull();
            setButton(true);
            khoa(true);
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            lsvHoaDon.Enabled = true;
            SetNull();
            setButton(true);
            khoa(true);
            txtmahd.Focus();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frm_hoadon_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát hóa đơn?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                e.Cancel = true;
        }

        private void lsvHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvHoaDon.SelectedIndices.Count > 0)
            {
                txtmahd.Text = lsvHoaDon.SelectedItems[0].SubItems[0].Text;
                cbotenkh.Text = lsvHoaDon.SelectedItems[0].SubItems[1].Text;
                cbotensp.Text = lsvHoaDon.SelectedItems[0].SubItems[2].Text;
                dtngaymua.Text = lsvHoaDon.SelectedItems[0].SubItems[3].Text;
                numbersoluong.Text = lsvHoaDon.SelectedItems[0].SubItems[4].Text;
            }
        }












    }
}
