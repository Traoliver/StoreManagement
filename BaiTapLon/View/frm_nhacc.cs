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
    public partial class frm_nhacc : Form
    {
        bool cothem;
        clsNCC cc = new clsNCC();
        public frm_nhacc()
        {
            InitializeComponent();
        }

        void setNull()
        {
            txtmancc.Text = "";
            txttenncc.Text = "";
            txtsdt.Text = "";
            txtdiachi.Text = "";
            txtemail.Text = "";

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
        public void Khoa(bool a)
        {
            txtmancc.ReadOnly = a;
            txttenncc.ReadOnly = a;
            txtsdt.ReadOnly = a;
            txtdiachi.ReadOnly = a;
            txtemail.ReadOnly = a;

        }
        void HienThiNhaCC()
        {
            DataTable dt = cc.LayDSNCC();
            lstNhaCC.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi = lstNhaCC.Items.Add(dt.Rows[i][0].ToString());
                lvi.SubItems.Add(dt.Rows[i][1].ToString());
                lvi.SubItems.Add(dt.Rows[i][2].ToString());
                lvi.SubItems.Add(dt.Rows[i][3].ToString());
                lvi.SubItems.Add(dt.Rows[i][4].ToString());
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtmancc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnthem_Click_1(object sender, EventArgs e)
        {
            cothem = true;
            setButton(false);
            Khoa(false);
            setNull();
            txtmancc.Focus();
        }

        private void btnsua_Click_1(object sender, EventArgs e)
        {
            if (lstNhaCC.SelectedIndices.Count > 0)
            {
                cothem = false;
                setButton(false);
                Khoa(false);
                txtmancc.Focus();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 nhà cung cấp", "Thông báo");
            }
        }

        private void btnxoa_Click_1(object sender, EventArgs e)
        {
            if (lstNhaCC.SelectedIndices.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc xóa không ? ", "Xóa nhà cung cung", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    cc.XoaNhaCC(lstNhaCC.SelectedItems[0].SubItems[0].Text);
                    lstNhaCC.Items.RemoveAt(lstNhaCC.SelectedIndices[0]);
                    HienThiNhaCC();
                    setNull();
                    Khoa(true);
                    setButton(true);
                }
            }
            else
                MessageBox.Show("Bạn phải chọn mẫu tin cần xóa");
        }

        private void btnhuy_Click_1(object sender, EventArgs e)
        {
            setButton(true);
            setNull();
            Khoa(true);
        }

        private void frm_nhacc_Load(object sender, EventArgs e)
        {
            setButton(true);
            setNull();
            Khoa(true);
            HienThiNhaCC();
        }


        private void frm_nhacc_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát Quản lý nhà cung cấp? ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                e.Cancel = true;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (cothem)
            {
                cc.ThemNhaCC(txtmancc.Text, txttenncc.Text, txtsdt.Text, txtdiachi.Text, txtemail.Text);
                MessageBox.Show("Thêm mới thành công");
            }
            else
            {
                cc.CapNhatNhaCC(txtmancc.Text, txttenncc.Text, txtsdt.Text, txtdiachi.Text, txtemail.Text, lstNhaCC.SelectedItems[0].SubItems[0].Text);
                MessageBox.Show("Cập nhật thành công");
            }
            HienThiNhaCC();
            setNull();
            setButton(true);
            Khoa(true);
        }

        private void lstNhaCC_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (lstNhaCC.SelectedIndices.Count > 0)
            {
                txtmancc.Text = lstNhaCC.SelectedItems[0].SubItems[0].Text;
                txttenncc.Text = lstNhaCC.SelectedItems[0].SubItems[1].Text;
                txtsdt.Text = lstNhaCC.SelectedItems[0].SubItems[2].Text;
                txtdiachi.Text = lstNhaCC.SelectedItems[0].SubItems[3].Text;
                txtemail.Text = lstNhaCC.SelectedItems[0].SubItems[4].Text;


            }
        }
    }
}
