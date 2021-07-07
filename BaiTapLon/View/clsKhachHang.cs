using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLon.View
{
    class clsKhachHang
    {
        Database db;
        public clsKhachHang()
        {
            db = new Database();
        }
        public DataTable LayDSKhachHang()
        {
            string strSQL = "select * from khachhang where makh=makh";
            DataTable dt = new DataTable();
            dt = db.Docbang(strSQL);
            return dt;
        }

        public void XoaKhachHang(string makh)
        {
            string sql = string.Format("Delete from khachhang where makh ='{0}'", makh);
            db.ThucHien(sql);
        }

        public void ThemmoiKhachHang(string MaKH, string HoTen, string DiaChi, string DienThoai, string Email)
        {
            string sql = string.Format("insert into khachhang Values('{0}',N'{1}', N'{2}','{3}','{4}')", MaKH, HoTen, DiaChi, DienThoai, Email);
            db.ThucHien(sql);
        }

        public void CapNhatKhachHang(string MaKH, string HoTen, string DiaChi, string DienThoai, string Email)
        {

            string str = string.Format("update khachhang set makh =N'{0}',tenkh =N'{1}', diachi = N'{2}', dienthoai ='{3}', email =N'{4}' where makh = N'{5}'", MaKH, HoTen, DiaChi, DienThoai, Email, MaKH);
            db.ThucHien(str);
        }
    }
}
