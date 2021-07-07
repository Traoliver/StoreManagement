using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLon.View
{
    class clsHoaDon
    {
        Database db;
        public clsHoaDon()
        {
            db = new Database();
        }
        public DataTable LayDS()
        {
            string str = "select mahoadon,k.tenkh,s.tensp,ngaymua,soluong,s.giatiensp, SUM(soluong*giatiensp) from khachhang k, sanpham s, hoadon h where k.makh = h.makh and s.masp = h.masp group by mahoadon,k.tenkh,s.tensp,ngaymua,soluong,s.giatiensp";
            DataTable dt = new DataTable();
            dt = db.Docbang(str);
            return dt;
        }
        public DataTable LayKH()
        {
            string strSQL = "Select makh,tenkh from khachhang";
            DataTable dt = db.Docbang(strSQL);
            return dt;
        }
        public DataTable Laysp()
        {
            string strSQL = "Select masp,tensp from sanpham";
            DataTable dt = db.Docbang(strSQL);
            return dt;
        }
        public void Xoa(string ma)
        {
            string str = string.Format("delete from hoadon where mahoadon='{0}'", ma);
            db.ThucHien(str);
        }
        public void Them(string mahd, string makh, string msp, string ngaydat, string sl)
        {

            string str = string.Format("insert into hoadon values(N'{0}',N'{1}',N'{2}','{3}','{4}')", mahd, makh, msp, ngaydat, sl);
            db.ThucHien(str);
        }
        public void capnhat(string mahd, string makh, string msp, string ngaydat, string sl)
        {
            string str = string.Format("update hoadon set makh='{0}', masp='{1}',ngaymua='{2}',soluong={3} where mahoadon='{4}'", makh, msp, ngaydat, sl, mahd);
            db.ThucHien(str);
        }
    }
}
