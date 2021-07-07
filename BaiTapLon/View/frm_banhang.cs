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
    public partial class frm_banhang : Form
    {
        DataSet ds;
        clsHoaDon hd = new clsHoaDon();
        private double giaca = 0.0;
        public frm_banhang()
        {
            InitializeComponent();
            timer1.Start();
        }

        void Hienthikh()
        {
            DataTable dt = hd.LayKH();
            cbotkkh.DataSource = dt;
            cbotkkh.DisplayMember = "tenkh";
            cbotkkh.ValueMember = "makh";
        }

        private void dataGridViewHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            themSanPham();
        }

        private void themSanPham()
        {
            //this.dataGridViewHoaDon.Rows.
            bool exict = false;
           
            foreach (DataGridViewRow item in dataGridViewHoaDon.Rows)
            {
                if (item.Cells[0].Value != null)
                {
                    if (item.Cells[0].Value.Equals(dataGridViewSanPham.CurrentRow.Cells[0].Value.ToString()))
                    {
                        item.Cells[2].Value = Convert.ToString(Convert.ToUInt32(item.Cells[2].Value) + 1 );
                        item.Cells[4].Value = Convert.ToString(Convert.ToUInt32(item.Cells[2].Value) * Convert.ToUInt32(item.Cells[3].Value));
                        this.giaca += Convert.ToDouble(item.Cells[4].Value);
                        exict = true;
                        break;
                    }
                }
            }

            if (!exict)
            {
                this.dataGridViewHoaDon.Rows.Add(
              dataGridViewSanPham.CurrentRow.Cells[0].Value.ToString()
              , dataGridViewSanPham.CurrentRow.Cells[1].Value.ToString()
              , "1"
              , dataGridViewSanPham.CurrentRow.Cells[2].Value.ToString()
              , Convert.ToString(Convert.ToUInt32( dataGridViewSanPham.CurrentRow.Cells[2].Value.ToString()))
              );
                giaca += Convert.ToUInt32(dataGridViewSanPham.CurrentRow.Cells[2].Value.ToString());
            }
            txtthanhtien.Text = this.giaca.ToString();
        }

        private void frm_banhang_Load(object sender, EventArgs e)
        {
            string chuoikn = @"Data Source=DESKTOP-SRP685D\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=True";
            SqlConnection sqlcon = new SqlConnection(chuoikn);
            string sql;
            sql = "select masp,tensp,giatiensp from sanpham";
            SqlDataAdapter sqlda = new SqlDataAdapter(sql, sqlcon);
            ds = new DataSet();
            sqlda.Fill(ds);
            dataGridViewSanPham.DataSource = ds.Tables[0];
            Hienthikh();
        }

        private void txttksp_KeyPress(object sender, KeyPressEventArgs e)
        {
            btnsearch_Click(sender, e);
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            string chuoikn = @"Data Source=DESKTOP-SRP685D\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=True";
            SqlConnection sqlcon = new SqlConnection(chuoikn);
            sqlcon.Open();
            string sql;
            sql = "select masp,tensp,giatiensp from sanpham where tensp like N'" + txttksp.Text + "%'";
            SqlDataAdapter sqlda = new SqlDataAdapter(sql, sqlcon);
            DataSet ds = new DataSet();
            sqlda.Fill(ds);
            dataGridViewSanPham.DataSource = ds.Tables[0];
        }

        private void btnthanhtoan_Click(object sender, EventArgs e)
        {
            if (txtmahd.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã hóa đơn!");
            }
            else
            {
                string sql = "";
                int i = 0;
                string chuoikn = @"Data Source=DESKTOP-SRP685D\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=True";
                SqlConnection sqlcon = new SqlConnection(chuoikn);
                sqlcon.Open();
                foreach (DataGridViewRow item in dataGridViewHoaDon.Rows)
                {
                    if (item.Cells[0].Value != null)
                    {
                        sql = "INSERT INTO [QuanLyBanHang].[dbo].[hoadon] ([ma] ,[makh] ,[masp] ,[ngaymua] ,[soluong] ,[mahoadon])"
                            + "VALUES  ('" + DateTime.Now.Ticks + "',  '"
                            + this.cbotkkh.SelectedValue + "'  ,'"
                            + item.Cells[0].Value + "','"
                            + DateTime.Now.Date + "'  ,'"
                            + item.Cells[2].Value + "' ,'"
                            + txtmahd.Text + "')  ";
                        SqlCommand command = new SqlCommand(sql, sqlcon);

                        SqlDataAdapter sqlda = new SqlDataAdapter();

                        sqlda.InsertCommand = command;

                        sqlda.InsertCommand.ExecuteNonQuery();
                        i = 1;
                    }

                }
                if (i == 1)
                {
                    MessageBox.Show("Thanh toán thành công!");
                    dataGridViewHoaDon.Rows.Clear();
                    txtmahd.Clear();
                }
                else
                    MessageBox.Show("Bạn phải chọn sản phẩm cần mua!");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            //this.lbDateTime.Text = datetime.ToString("dd/MM/yyyy HH:mm:ss");
            this.labelGioBig.Text = datetime.ToString("HH:mm:ss");
            this.lbNgayThangBig.Text = datetime.ToString("dd/MM/yyyy");
            this.lbDateBig.Text = datetime.ToString("dddd");
        }

        private void btndangxuat_Click(object sender, EventArgs e)
        {
            frm_dangnhap dn = new frm_dangnhap();
            this.Hide();
            dn.ShowDialog();
            
        }

        private void btnhuydonhang_Click(object sender, EventArgs e)
        {
            dataGridViewHoaDon.Rows.Clear();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridViewHoaDon.SelectedRows)
            {
                DataGridViewRow row = dataGridViewHoaDon.Rows[item.Index];
                dataGridViewHoaDon.Rows.RemoveAt(item.Index); //remove row in datagridview
            }
        }

        private void btnthemkh_Click(object sender, EventArgs e)
        {
            frm_nv_themkh nvkh = new frm_nv_themkh();
            nvkh.ShowDialog();
            frm_banhang_Load(sender, e);
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            giaca = 0.0;
            foreach (DataGridViewRow item in dataGridViewHoaDon.Rows)
            {
                 this.giaca += Convert.ToDouble(item.Cells[4].Value);
            }
            txtthanhtien.Text = this.giaca.ToString();
        }
    }
}
