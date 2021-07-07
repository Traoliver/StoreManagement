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
using DevComponents.DotNetBar;

namespace BaiTapLon.View
{
    public partial class frm_trangchu : DevComponents.DotNetBar.Office2007RibbonForm
    {
        DataSet ds;
        public frm_trangchu()
        {
            InitializeComponent();
        }

        private void frm_trangchu_Load(object sender, EventArgs e)
        {
            string chuoikn = @"Data Source=DESKTOP-SRP685D\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=True";
            SqlConnection sqlcon = new SqlConnection(chuoikn);
            string sql;
            sql = "select * from sanpham";
            SqlDataAdapter sqlda = new SqlDataAdapter(sql, sqlcon);
            ds = new DataSet();
            sqlda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string chuoikn = @"Data Source=DESKTOP-SRP685D\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=True";
            SqlConnection sqlcon = new SqlConnection(chuoikn);
            sqlcon.Open();
            string sql;
            sql = "select * from sanpham where tensp like N'" + txttk.Text + "%'";
            SqlDataAdapter sqlda = new SqlDataAdapter(sql, sqlcon);
            DataSet ds = new DataSet();
            sqlda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void txttk_KeyPress(object sender, KeyPressEventArgs e)
        {
            btnSearch_Click(sender, e);
        }

        private void btnkhachhang_Click(object sender, EventArgs e)
        {
            frm_khachhang kh = new frm_khachhang();
            kh.ShowDialog();
        }

        private void btnnhanvien_Click(object sender, EventArgs e)
        {
            frm_nhanvien nv = new frm_nhanvien();
            nv.ShowDialog();
        }

        private void btnnhacc_Click(object sender, EventArgs e)
        {
            frm_nhacc ncc = new frm_nhacc();
            ncc.ShowDialog();
        }

        private void btnsanpham_Click(object sender, EventArgs e)
        {
            frm_SanPham sp = new frm_SanPham();
            sp.ShowDialog();
        }

        private void btnhoadon_Click(object sender, EventArgs e)
        {
            frm_hoadon hd = new frm_hoadon();
            hd.ShowDialog();
        }


        private void btndangxuat_Click(object sender, EventArgs e)
        {
            frm_dangnhap dn = new frm_dangnhap();
            dn.Show();
            this.Hide();
        }

        private void btndoimk_Click(object sender, EventArgs e)
        {
            frm_doimk doimk = new frm_doimk();
            doimk.ShowDialog();
        }

        private void btnbcsp_Click(object sender, EventArgs e)
        {
            frm_bcsanpham bcsp = new frm_bcsanpham();
            bcsp.ShowDialog();
        }

        private void btnbchoadon_Click(object sender, EventArgs e)
        {
            frm_bchoadon bchd = new frm_bchoadon();
            bchd.ShowDialog();
        }

        private void frm_trangchu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult choose = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(choose == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void btnlhe_Click(object sender, EventArgs e)
        {
            frm_thongtinlhe lh = new frm_thongtinlhe();
            lh.ShowDialog();
        }
       
        private void buttonItem2_Click(object sender, EventArgs e)
        {
            styleManager1.ManagerStyle = eStyle.Office2010Blue;
        }

        private void buttonItem3_Click(object sender, EventArgs e)
        {
            styleManager1.ManagerStyle = eStyle.Office2010Black;
        }

        private void buttonItem4_Click(object sender, EventArgs e)
        {
            styleManager1.ManagerStyle = eStyle.Office2007Silver;
            }

        private void buttonItem5_Click(object sender, EventArgs e)
        {
            styleManager1.ManagerStyle = eStyle.VisualStudio2010Blue;
        }

        private void buttonItem6_Click(object sender, EventArgs e)
        {
            styleManager1.ManagerStyle = eStyle.Office2007VistaGlass;

        }

        private void buttonItem7_Click(object sender, EventArgs e)
        {
            styleManager1.ManagerStyle = eStyle.Office2007Black;
        }

        private void btnitemtkngay_Click(object sender, EventArgs e)
        {
            frm_thongke tk = new frm_thongke();
            tk.ShowDialog();
        }



    }
        
}
