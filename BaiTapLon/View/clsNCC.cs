using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLon.View
{
    class clsNCC
    {
        Database db;
        public clsNCC()
        {
            db = new Database();
        }
        public DataTable LayDSNCC()
        {
            string strSQL = "select * from nhacungcap";
            DataTable dt = new DataTable();
            dt = db.Docbang(strSQL);
            return dt;
        }
        public void XoaNhaCC(string MaNhaCungCap)
        {
            string sql = string.Format("Delete from nhacungcap where mancc = '{0}'", MaNhaCungCap);
            db.ThucHien(sql);
        }
        public void ThemNhaCC(string MaNhaCungCap, string TenNhaCungCap, string sodienthoai, string diachi, string email)
        {
            string sql = string.Format("Insert into nhacungcap values(N'{0}',N'{1}','{2}',N'{3}',N'{4}')", MaNhaCungCap, TenNhaCungCap, Convert.ToInt32(sodienthoai), diachi, email);
            db.ThucHien(sql);
        }
        public void CapNhatNhaCC(string MaNhaCungCap, string TenNhaCungCap, string sodienthoai, string diachi, string email, string maCC)
        {
            string str = string.Format("Update nhacungcap set mancc = N'{0}', tenncc= N'{1}', sdtncc='{2}',diachincc=N'{3}, email =N'{4}' where mancc = '{5}'", MaNhaCungCap, TenNhaCungCap, Convert.ToInt32(sodienthoai), diachi, email, maCC);
            db.ThucHien(str);
        }
    }
}
