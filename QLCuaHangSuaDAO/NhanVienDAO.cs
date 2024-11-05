using QLCuaHangSuaDTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHangSuaDAO
{
    public class NhanVienDAO
    {
        public NhanVienDTO TimNhanVien(string username,string pass)
        {
            NhanVienDTO nv = null;
            string strTruyVan = "Select * From NhanVien Where MaNV=@MaNV AND Password=@Password AND TrangThai=1";
            //Tao ket noi
            SqlConnection conn = DataProvider.TaoKetNoi();
            SqlParameter[] pars = new SqlParameter[2];
            pars[0] = new SqlParameter("MaNV", username);
            pars[1] = new SqlParameter("Password", pass);
            //Thuc thi va doc du lieu
            SqlDataReader sdr = DataProvider.TruyVan(strTruyVan,pars, conn);
            if(sdr.Read())
            {
                //Khoi tao nhan vien
                nv = new NhanVienDTO();
                //gan cac thong tin
                nv.MaNV = sdr["MaNV"].ToString();
                nv.Ho = sdr["Ho"].ToString();
                nv.Ten = sdr["Ten"].ToString();
                nv.NgaySinh = DateTime.Parse(sdr["NgaySinh"].ToString());
                nv.Password = sdr["Password"].ToString();
                nv.HinhAnh = sdr["HinhAnh"].ToString();
                nv.TrangThai = 1;
            }
            sdr.Close();
            conn.Close();
            return nv;
            
        }
    }
}
