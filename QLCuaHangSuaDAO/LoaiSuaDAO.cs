using QLCuaHangSuaDTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHangSuaDAO
{
    public class LoaiSuaDAO
    {
        public List<LoaiSuaDTO> LayDanhSachLoai()
        {
            List<LoaiSuaDTO> lsResult = new List<LoaiSuaDTO>();
            string strTruyVan = "Select * From LoaiSua Where TrangThai = 1";
            //tao ket noi
            SqlConnection conn = DataProvider.TaoKetNoi();
            //thuc hien truy van -- >  datareader
            SqlDataReader sdr = DataProvider.TruyVan(strTruyVan, conn);
            //duyet tung dong cua datareader --> doi tuong --> do vao danh sach
            while(sdr.Read())
            {
                LoaiSuaDTO loai = new LoaiSuaDTO();
                loai.MaLoai = int.Parse(sdr["MaLoai"].ToString());
                loai.TenLoai = sdr["TenLoai"].ToString();
                lsResult.Add(loai);
            }
            sdr.Close();
            //dong ket noi
            conn.Close();
            return lsResult;
        }
    }
}
