using QLCuaHangSuaDTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHangSuaDAO
{
    public class HoaDonBanDAO
    {
        public int LuuHoaDon(HoaDonBanDTO hd)
        {
            string sql = "Insert into HoaDonBan(MaNV, NgayLap,TongTien,TrangThai) values (@MaNV,GetDate(),@TongTien,1); SELECT CAST(SCOPE_IDENTITY() as INT);";
            SqlConnection conn = DataProvider.TaoKetNoi();
            SqlCommand com = new SqlCommand(sql, conn);
            com.Parameters.AddWithValue("MaNV", hd.MaNV);
            com.Parameters.AddWithValue("TongTien", hd.TongTien);
            int kq = (int)com.ExecuteScalar();
            conn.Close();
            return kq;
        }
    }
}
