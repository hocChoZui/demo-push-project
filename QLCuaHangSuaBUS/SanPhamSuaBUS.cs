using QLCuaHangSuaDAO;
using QLCuaHangSuaDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHangSuaBUS
{
    public class SanPhamSuaBUS
    {
        public List<SanPhamSuaDTO> LayTatCaSua()
        {
            SanPhamSuaDAO dao = new SanPhamSuaDAO();
            return dao.LayTatCaSanPhamSua();
        }
        public string MaSanPhamMoi()
        {
            SanPhamSuaDAO dao = new SanPhamSuaDAO();
            //Tạo mã sữa
            string max = dao.LayMaSuaLonNhat();
            int maso = int.Parse(max.Substring(1));
            maso++;
            return "S" + maso.ToString("0000");
        }
        public bool ThemMoiSanPham(SanPhamSuaDTO sua)
        {
            
            SanPhamSuaDAO dao = new SanPhamSuaDAO();
            return dao.ThemSanPhamSua(sua);
        }
        public bool CapNhatSanPham(SanPhamSuaDTO sua)
        {

            SanPhamSuaDAO dao = new SanPhamSuaDAO();
            return dao.CapNhatSanPhamSua(sua);
        }
    }
}
