using QLCuaHangSuaDAO;
using QLCuaHangSuaDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHangSuaBUS
{
    public class HoaDonBanBUS
    {
        HoaDonBanDAO hdbDAO = new HoaDonBanDAO();
        public int LapHoaDon(HoaDonBanDTO hd)
        {
            return hdbDAO.LuuHoaDon(hd);
        }
    }
}
