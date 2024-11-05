using QLCuaHangSuaDTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHangSuaDAO
{
    public class ChiTietHDBDAO
    {
        public bool LuuChiTietHDBan(ChiTietHDBanDTO ct)
        {
            try
            {
                string insert = "Insert Into ChiTietHDBan(MaHDBan,MaSanPham,DonGia,SoLuong) values (@MaHDBan,@MaSanPham,@DonGia,@SoLuong)";
                SqlParameter[] sp = new SqlParameter[4];
                {
                    sp[0] = new SqlParameter("MaHDBan", ct.MaHDBan);
                    sp[1] = new SqlParameter("MaSanPham", ct.MaSanPham);
                    sp[2] = new SqlParameter("DonGia", ct.DonGia);
                    sp[3] = new SqlParameter("SoLuong", ct.SoLuong);
                    SqlConnection conn = DataProvider.TaoKetNoi();
                    bool kq = DataProvider.ThucThi(insert, sp, conn);
                    conn.Close();
                    return kq;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
