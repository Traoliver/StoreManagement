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
    public partial class frm_thongke : Form
    {
        public frm_thongke()
        {
            InitializeComponent();
        }

        private void frm_thongke_Load(object sender, EventArgs e)
        {
            hienthiHoaDonTheoNgay();


        }

        private void hienthiHoaDonTheoNgay()
        {
            string sql = "SELECT hd.mahoadon, kh.tenkh, sp.tensp,hd.soluong, FORMAT(hd.ngaymua,'dd/MM/yyyy') as ngaymua, sp.giatiensp, (hd.soluong*sp.giatiensp) as thanhtien " +
                            "FROM hoadon as hd " +
                            "INNER JOIN khachhang as kh ON kh.makh = hd.makh " +
                            "INNER JOIN sanpham as sp ON sp.masp = hd.masp " +
                            "WHERE hd.ma IS NOT NULL " +
                            "AND hd.mahoadon != ''" +
                            "AND hd.mahoadon IS NOT NULL " +
                            "AND hd.ngaymua <= FORMAT(cast('" + dtpkngaykt.Value.Date.ToString() + "' as datetime),'yyyy-MM-dd') " +
                            "AND hd.ngaymua >= FORMAT(cast('" + dtpkngaybd.Value.Date.ToString() + "' as datetime),'yyyy-MM-dd') ";

            string chuoikn = @"Data Source=DESKTOP-SRP685D\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=True";
            SqlConnection sqlcon = new SqlConnection(chuoikn);
            sqlcon.Open();
          
            SqlDataAdapter sqlda = new SqlDataAdapter(sql, sqlcon);
            DataSet ds = new DataSet();
            sqlda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void dtpkngaykt_ValueChanged(object sender, EventArgs e)
        {
            hienthiHoaDonTheoNgay();
        }

        private void dtpkngaybd_ValueChanged(object sender, EventArgs e)
        {
            hienthiHoaDonTheoNgay();
        }

        private void frm_thongke_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult choose = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (choose == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}
