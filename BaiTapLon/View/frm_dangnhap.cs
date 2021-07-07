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

namespace BaiTapLon.View
{
    public partial class frm_dangnhap : Form
    {
        clsPhanQuyen pq = new clsPhanQuyen();
        void Hienthiphanuyen()
        {
            DataTable dt = pq.LayRole();
            cbophanquyen.DataSource = dt;
            cbophanquyen.DisplayMember = "role";
            cbophanquyen.ValueMember = "username";
        }

        public frm_dangnhap()
        {
            InitializeComponent();
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void btnnhaplai_Click(object sender, EventArgs e)
        {
            txtuser.Clear();
            txtpass.Clear();
            txtuser.Focus();
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-SRP685D\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=True");
            try
            {
                conn.Open();
                string user = txtuser.Text;
                string pass = txtpass.Text;
                string role = cbophanquyen.Text;
                string sql = "select * from dangnhap where username='" + user + "' and password='" + pass + "' and role='"+role+"'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader read = cmd.ExecuteReader();
                if (read.Read() == true)
                {
                    if (role.Equals("Admin"))
                    {
                        MessageBox.Show("Đăng nhập thành công với tư cách admin", "Thông báo");
                        frm_trangchu trangchu = new frm_trangchu();
                        trangchu.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Đăng nhập thành công với tư cách nhân viên", "Thông báo");
                        frm_banhang banhang = new frm_banhang();
                        banhang.Show();
                        this.Hide();
                    }
                }
                else if (txtuser.Text.Length == 0)
                {

                    MessageBox.Show("Xin lỗi! Bạn phải nhập Tên Người Dùng vào", "Thông Báo!");
                }
                else
                {
                    MessageBox.Show("Bạn vừa nhập sai tên tài khoản hoặc mật khẩu hoặc bạn đã đăng nhập sai tư cách. Vui lòng kiểm tra lại!", "Thông Báo!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối");
            }

        }

        private void frm_dangnhap_Load(object sender, EventArgs e)
        {
            Hienthiphanuyen();
        }

       
    }
}
