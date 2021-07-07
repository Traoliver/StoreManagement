using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLon
{
    class Database
    {
        SqlConnection conn;
        SqlDataAdapter da;
        DataSet ds;
        public Database()
        {
            string chuoikn = @"Data Source=DESKTOP-SRP685D\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=True";
            conn = new SqlConnection(chuoikn);
        }

        public DataTable Docbang(string sqlStr)
        {
            da = new SqlDataAdapter(sqlStr, conn);
            ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }
        public void ThucHien(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            cmd.ExecuteNonQuery();

            conn.Close();
        }
        public SqlDataReader ExecuteReader(string sql)
        {

            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }
        
    }
}
