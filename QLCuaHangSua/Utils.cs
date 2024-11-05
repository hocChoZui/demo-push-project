using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace QLCuaHangSua
{
    public static class Utils
    {
        public static string MaHoaMD5(string strChuoi)
        {
            MD5 md5Hash = MD5.Create();
            //chuyển chuỗi sang mảng byte
            byte[] mang = Encoding.UTF8.GetBytes(strChuoi);
            //băm mảng chuỗi
            byte[] data = md5Hash.ComputeHash(mang);
            string str = "";
            //lần lượt chuyển sang hệ 16
            for(int i = 0; i < data.Length; i++)
            {
                str += data[i].ToString("x2");
            }
            return str;
        }

        public static Image DocHinh(string hinhAnh)
        {
            if(File.Exists(hinhAnh))
            {

                byte[] byteHinh=File.ReadAllBytes(hinhAnh);
                MemoryStream ms = new MemoryStream(byteHinh);
                return Image.FromStream(ms);
            }
            return null;
        }
    }
}
