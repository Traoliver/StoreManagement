using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLon.View
{
    class clsPhanQuyen
    {
        Database db;
        public clsPhanQuyen()
        {
            db = new Database();
        }
        
        public DataTable LayRole()
        {
            string strSQL = "Select username, role from dangnhap";
            DataTable dt = db.Docbang(strSQL);
            return dt;
        }
    }
}
