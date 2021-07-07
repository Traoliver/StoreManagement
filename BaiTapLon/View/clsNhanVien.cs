using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLon.View
{
    class clsNhanVien
    {
        Database db;
        public clsNhanVien()
        {
            db = new Database();
        }
        public DataTable LayDSNhanvien()
        {
            string strSQL = "select *from nhanvien where manv=manv";
            DataTable dt = new DataTable();
            dt = db.Docbang(strSQL);

            return dt;
        }

        public void XoaNhanVien(string manv)
        {
            string sql = string.Format("Delete from nhanvien where manv ='{0}'", manv);
            db.ThucHien(sql);
        }

        public void ThemmoiNhanVien(string MaNV, string HoTen, string NgaySinh, string NgayNhanViec, string DiaChi, string Luong, string DienThoai, string Email, string index_gt)
        {
            string sql = string.Format("insert into nhanvien Values('{0}',N'{1}', '{2}', '{3}', N'{4}','{5}','{6}','{7}',N'{8}')", MaNV, HoTen, NgaySinh, NgayNhanViec, DiaChi, Luong, DienThoai, Email, index_gt);
            db.ThucHien(sql);
        }

        public void CapNhatNhanVien(string MaNV, string HoTen, string NgaySinh, string NgayNhanViec, string DiaChi, string Luong, string DienThoai, string Email, string index_gt)
        {

            string str = string.Format("Update nhanvien set manv ='{0}',hotennv =N'{1}', ngaysinhnv ='{2}',ngayvaolam='{3}', diachinv = N'{4}',luong='{5}',sdtnv = '{6}', email = '{7}',gioitinh=N'{8}'  where manv =  '{9}'", MaNV, HoTen, NgaySinh, NgayNhanViec, DiaChi, Luong, DienThoai, Email, index_gt, MaNV);
            db.ThucHien(str);
        }
    }
}
