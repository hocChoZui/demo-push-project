﻿using QLCuaHangSuaDAO;
using QLCuaHangSuaDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHangSuaBUS
{
    public class NhanVienBUS
    {
        public NhanVienDTO NhanVienDangNhap(string username, string pass)
        {
            NhanVienDAO nvDAO = new NhanVienDAO();
            return nvDAO.TimNhanVien(username, pass);
        }
    }
}
