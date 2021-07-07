using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLon.View
{
    class clsSanPham
    {
        Database db;
        public clsSanPham()
        {
            db = new Database();
        }
        public DataTable LayDSSanPham()
        {
            string strSQL = "select * from sanpham";
            DataTable dt = new DataTable();
            dt = db.Docbang(strSQL);
            return dt;
        }
        public DataTable LayMaNCC()
        {
            string strSQL = "Select * from nhacungcap";
            DataTable dt = db.Docbang(strSQL);
            return dt;
        }
        public void XoaSanPham(string MaSanPham)
        {
            string sql = string.Format("Delete from sanpham where masp = N'{0}'", MaSanPham);
            db.ThucHien(sql);
        }
        public void ThemSanPham(string MaSanPham,string TenSanPham,string DonVi,string GiaTienSP,string index_mancc)
        {
            string sql = string.Format("Insert Into sanpham  Values(N'{0}',N'{1}',N'{2}','{3}',N'{4}')", MaSanPham, TenSanPham, DonVi, Convert.ToDouble(GiaTienSP), index_mancc);
            db.ThucHien(sql); 
        }
        public void CapNhatSanPham(string MaSanPham, string TenSanPham, string DonVi, string GiaTienSP, string index_mancc)
        {
            string str = string.Format("Update sanpham set masp = '{0}', tensp = N'{1}', donvi = N'{2}', giatiensp = N'{3}', mancc = '{4}' where masp = '{5}'", MaSanPham, TenSanPham, DonVi, Convert.ToDouble(GiaTienSP), index_mancc, MaSanPham);
            db.ThucHien(str);
        }
    }
}
