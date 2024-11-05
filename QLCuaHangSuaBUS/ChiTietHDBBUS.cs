using QLCuaHangSuaDAO;
using QLCuaHangSuaDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHangSuaBUS
{
    public class ChiTietHDBBUS
    {
        ChiTietHDBDAO ctDAO=new ChiTietHDBDAO();
        public bool LuuChiTietHD(ChiTietHDBanDTO ct)
        {
            return ctDAO.LuuChiTietHDBan(ct);
        }
    }
}
