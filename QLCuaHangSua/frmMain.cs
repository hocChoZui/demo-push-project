using QLCuaHangSuaDTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCuaHangSua
{
    public partial class frmMain : Form
    {
        public NhanVienDTO nvDangNhap = null;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadThongTinDangNhap();
            frmDangNhap f = new frmDangNhap();
            f.MdiParent = this;
            f.Dock = DockStyle.Fill;
            f.Show();
        }

        public void LoadThongTinDangNhap()
        {
            if(nvDangNhap == null)
            {
                mnuPM.Enabled = false;
                picNVDN.Image = null;
                lblMaNV.Text = string.Empty;
                btnDNDX.Text = "Đăng Nhập";
                btnDNDX.Image = QLCuaHangSua.Properties.Resources.DangNhap;
            }    
            else
            {
                mnuPM.Enabled = true;
                if (File.Exists(nvDangNhap.HinhAnh))
                {
                    byte[] byteHA = File.ReadAllBytes(nvDangNhap.HinhAnh);
                    MemoryStream ms = new MemoryStream(byteHA);
                    picNVDN.Image = Image.FromStream(ms);
                }
                lblMaNV.Text = nvDangNhap.MaNV;
                btnDNDX.Text = "Đăng Xuất";
                btnDNDX.Image = QLCuaHangSua.Properties.Resources.DangXuat;
            }    
        }

        private void mnuBanHang_Click(object sender, EventArgs e)
        {
            if(this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }    
            frmBanHang f = new frmBanHang();
            f.MdiParent = this;
            f.Dock = DockStyle.Fill;
            f.Show();
        }

        private void btnDNDX_Click(object sender, EventArgs e)
        {
            //nếu có form con nào mở trước --> đóng
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            if (nvDangNhap != null)
            {
                nvDangNhap = null;
                LoadThongTinDangNhap();
            }            
                
            frmDangNhap f = new frmDangNhap();
            f.MdiParent = this;
            f.Dock = DockStyle.Fill;
            f.Show();
        }

        private void mnuSua_Click(object sender, EventArgs e)
        {
            //nếu có form con nào mở trước --> đóng
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            frmSua f = new frmSua();
            f.MdiParent = this;
            f.Dock = DockStyle.Fill;
            f.Show();
        }

        private void mnuBaoCao_Click(object sender, EventArgs e)
        {

        }
    }
}
