using QLCuaHangSuaBUS;
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
    public partial class frmBanHang : Form
    {
        List<SanPhamSuaDTO> lsSua;
        SanPhamSuaDTO suaChon;  
        List<ChiTietHDBanDTO> lsChiTiet = new List<ChiTietHDBanDTO>();
        HoaDonBanDTO hoaDon;
        HoaDonBanBUS hdbBUS = new HoaDonBanBUS();
        ChiTietHDBBUS cthdBUS = new ChiTietHDBBUS();

        public frmBanHang()
        {
            InitializeComponent();
        }

        private void frmBanHang_Load(object sender, EventArgs e)
        {
            dgvCTHD.AutoGenerateColumns = false;
            LoadLoaiSua();
            LoadDanhSachSanPham();
            colTenSua.DataSource = lsSua;
            colTenSua.DisplayMember = "TenSua";
            colTenSua.ValueMember = "MaSua";
        }

        private void LoadLoaiSua()
        {
            LoaiSuaBUS loaiBUS = new LoaiSuaBUS();
            List<LoaiSuaDTO> lsLoai = loaiBUS.LayDanhSachLoai();
            cboLoaiSua.DataSource = lsLoai;
            cboLoaiSua.DisplayMember = "TenLoai";
            cboLoaiSua.ValueMember = "MaLoai";
        }

        private void LoadDanhSachSanPham()
        {
            SanPhamSuaBUS suaBUS = new SanPhamSuaBUS();//đẩy ll hình ảnh và tt sảnpham vô listview
            imlSua.Images.Clear();//clear ds trc đó
            lsSua = suaBUS.LayTatCaSua();
            lsSua = lsSua.FindAll(o => o.TrangThai == 1);
            foreach (SanPhamSuaDTO s in lsSua)//nếu sữa có hình ảnh
            {
                Image img = Utils.DocHinh(s.HinhAnh);
                if (File.Exists(s.HinhAnh))
                {
                    imlSua.Images.Add(s.MaSua, img);
                }
                ListViewItem lvi = new ListViewItem();
                lvi.Text = s.TenSua;
                lvi.ImageKey = s.MaSua;
                lvwSua.Items.Add(lvi);
            }
        }

        private void lvwSua_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lvwSua.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lvwSua.SelectedItems[0];
                suaChon = lsSua.Find(o => o.MaSua == lvi.ImageKey);
            }
            else
            {
                suaChon = null;
            }
            HienThi();
        }

        private void HienThi()
        {
            if (suaChon != null)
            {
                txtMaSua.Text = suaChon.MaSua;
                txtTenSua.Text = suaChon.TenSua;
                txtGia.Text = suaChon.GiaBan.ToString("#,##0 VND");
                txtNSX.Text = suaChon.NhaSanXuat;
                cboLoaiSua.SelectedValue = suaChon.MaLoai;
                rtbMoTa.Text = suaChon.MoTa;
                if(File.Exists(suaChon.HinhAnh))
                {
                    pboHAnh.Image = Utils.DocHinh(suaChon.HinhAnh);
                }
                else
                {
                    pboHAnh.Image = null;
                }
            }
            else
            {
                txtGia.Clear();
                txtTenSua.Clear();
                txtNSX.Clear();
                rtbMoTa.Clear();
                pboHAnh.Image = null;
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(txtMaSua.Text))
            {
                suaChon = lsSua.Find(o => o.MaSua.ToLower() == txtMaSua.Text.ToLower());
                if(suaChon==null)
                {
                    MessageBox.Show("Khong tim thay thong tin san pham");
                }
                HienThi();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (hoaDon != null)
                return;
            if(suaChon!=null)
            {

                ChiTietHDBanDTO ct = lsChiTiet.Find(o => o.MaSanPham == suaChon.MaSua);
                if (ct == null)
                {
                    ct = new ChiTietHDBanDTO();
                    ct.MaSanPham = suaChon.MaSua;
                    ct.DonGia = suaChon.GiaBan;
                    ct.SoLuong = (int)nudSoluong.Value;
                    lsChiTiet.Add(ct);
                }
                else
                {
                    ct.SoLuong += (int)nudSoluong.Value;
                }
                dgvCTHD.DataSource = null;
                dgvCTHD.DataSource = lsChiTiet;
                txtTongTien.Text = lsChiTiet.Sum(o => o.ThanhTien).ToString();
            }
        }



        private void btnXoaCT_Click(object sender, EventArgs e)
        {
            if (hoaDon != null)
                return;
            if (dgvCTHD.SelectedRows.Count > 0)
            {
                ChiTietHDBanDTO ct = dgvCTHD.SelectedRows[0].DataBoundItem as ChiTietHDBanDTO;
                lsChiTiet.Remove(ct);
                dgvCTHD.DataSource = null;
                dgvCTHD.DataSource = lsChiTiet;
                txtTongTien.Text = lsChiTiet.Sum(o => o.ThanhTien).ToString();


            }
        }

        private void lvwSua_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (hoaDon != null)
                return;
            if(lvwSua.SelectedItems.Count > 0)
            {
                suaChon = lsSua.Find(o => o.MaSua == lvwSua.SelectedItems[0].ImageKey);
                ChiTietHDBanDTO ct = lsChiTiet.Find(o => o.MaSanPham == suaChon.MaSua);
                if(ct == null)
                {
                    ct = new ChiTietHDBanDTO();
                    ct.MaSanPham = suaChon.MaSua;
                    ct.DonGia = suaChon.GiaBan;
                    ct.SoLuong = 1;
                    lsChiTiet.Add(ct);
                }
                else
                {
                    ct.SoLuong = 1;

                }
                dgvCTHD.DataSource = null;
                dgvCTHD.DataSource = lsChiTiet;
                txtTongTien.Text = lsChiTiet.Sum(o => o.ThanhTien).ToString();
            }
        }

        private void btnLapHD_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Kiểm tra các sản phẩm đã thêm vào hóa đơn!\n nếu đầy đủ nhấn YES để lập hóa đơn", "Lập Hóa Đơn", MessageBoxButtons.YesNo);
            if(dr == DialogResult.Yes)
            {
                if(lsChiTiet.Count > 0)
                {
                    hoaDon = new HoaDonBanDTO();//ma hoa don tu tang nen khong can tao ma hoa don
                    hoaDon.MaNV = ((frmMain)this.MdiParent).nvDangNhap.MaNV;
                    hoaDon.TongTien = lsChiTiet.Sum(o => o.ThanhTien);
                    int mhd = hdbBUS.LapHoaDon(hoaDon);
                    foreach (ChiTietHDBanDTO ct in lsChiTiet)
                    {
                        ct.MaHDBan=mhd;
                        cthdBUS.LuuChiTietHD(ct);
                    }
                    hoaDon.MaHDBan = mhd;
                    MessageBox.Show($"Hóa đơn đã lập thành công vói mã '{mhd}'", "Lập Hóa Đơn");
                }
                else
                {
                    MessageBox.Show("Phải có sản phẩm mới lập hóa đơn","Lập Hóa Đơn");
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            hoaDon = null;
            lsChiTiet.Clear();
            dgvCTHD.DataSource = null;
        }
    }
}
