using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHangSuaDTO
{
    public class ChiTietHDBanDTO
    {
        public int MaHDBan { get; set; }
        public string MaSanPham { get; set; }
        public int DonGia { get; set; }
        public int SoLuong { get; set; }

        public double ThanhTien
        {
            get { return SoLuong * DonGia; }
        }
    }
}
