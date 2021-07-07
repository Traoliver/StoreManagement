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
    public partial class frm_nv_themkh : Form
    {
        clsKhachHang kh = new clsKhachHang();
        public frm_nv_themkh()
        {
            InitializeComponent();
            setNull();
        }

        void setNull()
        {
            txtmakh.Text = "";
            txtdc.Text = "";
            txtsdt.Text = "";
            txtemail.Text = "";
            txttenkh.Text = "";
            txtmakh.Focus();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if(txtmakh.Text == ""||txttenkh.Text ==  ""||txtsdt.Text==""||txtemail.Text==""||txtdc.Text=="")
            {
                MessageBox.Show("Bạn không thể để trống thông tin","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                kh.ThemmoiKhachHang(txtmakh.Text, txttenkh.Text, txtdc.Text, txtsdt.Text, txtemail.Text);
                MessageBox.Show("Thêm mới thành công");
                setNull();
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
