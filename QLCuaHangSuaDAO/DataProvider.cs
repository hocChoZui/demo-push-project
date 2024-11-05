using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHangSuaDAO
{
    public static class DataProvider
    {
        private static string strKetNoi = @"Data Source=SIMPLEDEVS\SQLEXPRESS06;Initial Catalog=CuaHangBanSua;Integrated Security=True;";

        public static SqlConnection TaoKetNoi()
        {
            try
            {
                SqlConnection conn = new SqlConnection(strKetNoi);
                conn.Open();
                return conn;
            }
            catch
            {
                throw new Exception("Lỗi Kết Nối Cơ Sở Dữ Liệu");
            }
        }

        public static SqlDataReader TruyVan(string strTruyVan,SqlConnection conn)
        {
            //try
            //{
                SqlCommand com = new SqlCommand(strTruyVan, conn);
                return com.ExecuteReader();
            //}
            //catch
            //{
            //    throw new Exception("Không Thể Lấy Dữ Liệu");
            //}
        }
        public static SqlDataReader TruyVan(string strTruyVan, SqlParameter[] arrParams,SqlConnection conn)
        {                                                
            try
            {
                SqlCommand com = new SqlCommand(strTruyVan, conn);
                com.Parameters.AddRange(arrParams);
                return com.ExecuteReader();
            }
            catch
            {
                throw new Exception("Lỗi Lấy Dữ Liệu");
            }
        }
        public static bool ThucThi(string strCauLenh, SqlConnection conn)
        {
            try
            {
                SqlCommand com = new SqlCommand(strCauLenh, conn);
                int kq = com.ExecuteNonQuery();
                return kq > 0;
            }
            catch
            {
                throw new Exception("Lỗi Thực Thi Cập Nhật Dữ Liệu");
            }
        }
        public static bool ThucThi(string strCauLenh, SqlParameter[] arrPrams, SqlConnection conn)
        {
            try
            {
                SqlCommand com = new SqlCommand(strCauLenh, conn);
                com.Parameters.AddRange(arrPrams);
                int kq = com.ExecuteNonQuery();
                return kq > 0;
            }
            catch
            {
                throw new Exception("Lỗi Thực Thi Cập Nhật Dữ Liệu");
            }
        }
    }
}
