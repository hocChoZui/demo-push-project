using QLCuaHangSuaBUS;
using QLCuaHangSuaDTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCuaHangSua
{
    public partial class frmDangNhap : Form
    {
        NhanVienBUS nvBUS = new NhanVienBUS();
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtMaNV.Text) || string.IsNullOrWhiteSpace(txtPass.Text))
            {
                MessageBox.Show("Vui lòng nhập thông tin đăng nhập");
            }
            else
            {
                NhanVienDTO nv = nvBUS.NhanVienDangNhap(txtMaNV.Text, Utils.MaHoaMD5(txtPass.Text));
                if(nv == null)
                {
                    MessageBox.Show("Thông tin đăng nhập chưa đúng");
                }    
                else
                {
                    frmMain f = (frmMain)this.MdiParent;
                    f.nvDangNhap = nv;
                    f.LoadThongTinDangNhap();
                    this.Close();
                }    
            }    
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
