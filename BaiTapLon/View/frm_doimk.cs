using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapLon
{
    public partial class frm_doimk : Form
    {
        string strCnn = @"Data Source=DESKTOP-SRP685D\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=True";
        public frm_doimk()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn = new SqlConnection(strCnn);
            SqlDataAdapter Dadoimatkhau = new SqlDataAdapter("select * from dangnhap where username  ='" + txtTK.Text + "'", conn);
            DataTable dtdoimatkhau = new DataTable();
            dtdoimatkhau.Clear();
            Dadoimatkhau.Fill(dtdoimatkhau);
            try
            {
                SqlCommand cmd = new SqlCommand();
                if (txtTK.Text == "" && txtMKCu.Text == "" && txtMKMoi.Text == "" && txtNLMK.Text == "") MessageBox.Show("Bạn chưa nhập thông tin.", "Thông Báo");
                else if (txtTK.Text == "") MessageBox.Show("Bạn chưa nhập tên tài khoản.", "Thông Báo");
                else if (txtMKCu.Text == "") MessageBox.Show("Bạn chưa nhập mật hiên tại.", "Thông Báo");
                else if (txtMKMoi.Text == "") MessageBox.Show("Bạn chưa nhập mật khẩu mới.", "Thông Báo");
                else if (txtNLMK.Text == "") MessageBox.Show("Bạn chưa nhập lại mật khẩu mới.", "Thông Báo");
                else
                    if ((txtTK.Text == dtdoimatkhau.Rows[0]["username"].ToString()) && (txtMKCu.Text == dtdoimatkhau.Rows[0]["password"].ToString()) && (txtMKMoi.Text == txtNLMK.Text))
                    {
                        conn.Open();
                        cmd.Connection = conn;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = System.String.Concat("update dangnhap set password =N'" + txtMKMoi.Text + "'where username =N'" + txtTK.Text + "'");
                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thay đổi mật khẩu thành công!", "Thông Báo");
                        this.Hide();
                        this.Close();
                    }
                    else
                    { MessageBox.Show("Tên hoặc mật khẩu nhập không đúng!", "thông báo"); }
            }
            catch (SqlException)
            {
                MessageBox.Show("Có lỗi xảy ra, vui lòng xem lại thông tin nhập!", "Thông báo");
            }
            conn.Close();
        }

        private void frm_doimk_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                e.Cancel = true;
        }
    }
}
