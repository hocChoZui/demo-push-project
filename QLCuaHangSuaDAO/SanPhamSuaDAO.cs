using QLCuaHangSuaDTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHangSuaDAO
{
    public class SanPhamSuaDAO
    {
        public List<SanPhamSuaDTO> LayTatCaSanPhamSua()
        {
            List<SanPhamSuaDTO> lsSua = new List<SanPhamSuaDTO>();
            string strTruyVan = "Select * From SanPhamSua";
            SqlConnection conn = DataProvider.TaoKetNoi();
            SqlDataReader sdr = DataProvider.TruyVan(strTruyVan, conn);
            while(sdr.Read())
            {
                SanPhamSuaDTO s = new SanPhamSuaDTO();
                s.MaSua = sdr["MaSua"].ToString();    
                s.TenSua = sdr["TenSua"].ToString();
                s.GiaBan = int.Parse(sdr["GiaBan"].ToString());
                s.MaLoai = int.Parse(sdr["MaLoai"].ToString());
                s.NhaSanXuat = sdr["NhaSanXuat"].ToString();
                s.HinhAnh = sdr["HinhAnh"].ToString();
                s.MoTa = sdr["MoTa"].ToString();
                s.TrangThai = int.Parse(sdr["TrangThai"].ToString());
                lsSua.Add(s);
            }
            sdr.Close();
            conn.Close();

            return lsSua;
        }
        public bool ThemSanPhamSua(SanPhamSuaDTO sua)
        {
            try
            {
                string strInsert = "Insert Into SanPhamSua(MaSua,TenSua,GiaBan,MaLoai,HinhAnh,NhaSanXuat,MoTa,TrangThai) values ";
                strInsert += "(@MaDienThoai,@TenDienThoai,@GiaBan,@MaLoai,@HinhAnh,@NhaSanXuat,@MoTa,@TrangThai)";
                SqlParameter[] arrpars = new SqlParameter[8];
                arrpars[0] = new SqlParameter("MaSua", sua.MaSua);
                arrpars[1] = new SqlParameter("TenSua", sua.TenSua);
                arrpars[2] = new SqlParameter("GiaBan", sua.GiaBan);
                arrpars[3] = new SqlParameter("MaLoai", sua.MaLoai);
                arrpars[4] = new SqlParameter("HinhAnh", sua.HinhAnh);
                arrpars[5] = new SqlParameter("NhaSanXuat", sua.NhaSanXuat);
                arrpars[6] = new SqlParameter("MoTa", sua.MoTa);
                arrpars[7] = new SqlParameter("TrangThai", sua.TrangThai);

                SqlConnection conn = DataProvider.TaoKetNoi();
                bool kq = DataProvider.ThucThi(strInsert, arrpars, conn);
                conn.Close();
                return kq;
            }
            catch
            {
                return false;
            }
        }
        public bool CapNhatSanPhamSua(SanPhamSuaDTO sua)
        {
            try
            {
                string strUpdate = "Update SanphamSua set TenSua=@TenSua,GiaBan=@GiaBan,MaLoai=@MaLoai," +
                    " NhaSanXuat=@NhaSanXuat,MoTa=@MoTa, TrangThai=@TrangThai Where MaDienThoai=@MaDienThoai";
                SqlParameter[] arrpars = new SqlParameter[7];
                arrpars[0] = new SqlParameter("MaSua", sua.MaSua);
                arrpars[1] = new SqlParameter("TenSua", sua.TenSua  );
                arrpars[2] = new SqlParameter("GiaBan", sua.GiaBan);
                arrpars[3] = new SqlParameter("MaLoai", sua.MaLoai);
                arrpars[4] = new SqlParameter("NhaSanXuat", sua.NhaSanXuat);
                arrpars[5] = new SqlParameter("MoTa", sua.MoTa);
                arrpars[6] = new SqlParameter("TrangThai", sua.TrangThai);

                SqlConnection conn = DataProvider.TaoKetNoi();
                bool kq = DataProvider.ThucThi(strUpdate, arrpars, conn);
                conn.Close();
                return kq;
            }
            catch
            {
                return false;
            }
        }
        
        public string LayMaSuaLonNhat()
        {
            string strTruyVan = "Select Max(MaSua) From SanPhamSua";
            SqlConnection conn = DataProvider.TaoKetNoi();
            SqlDataReader sdr = DataProvider.TruyVan(strTruyVan, conn);
            sdr.Read();
            if(sdr.IsDBNull(0))
            {
                return "S0000";
            }
            return sdr[0].ToString();
        }
    }
}
