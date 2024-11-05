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
    public partial class frmSua : Form
    {
        SanPhamSuaBUS sBUS = new SanPhamSuaBUS();
        List<SanPhamSuaDTO> lsSua;
        SanPhamSuaDTO sua;
        
        public frmSua()
        {
            InitializeComponent();
        }

        private void frmSua_Load(object sender, EventArgs e)
        {
            //Load Danh Loai Sua]
            LoaiSuaBUS lBUS = new LoaiSuaBUS();
            List<LoaiSuaDTO> lsLoai = lBUS.LayDanhSachLoai();
            cboLoaiSua.DataSource = lsLoai;
            cboLoaiSua.DisplayMember = "TenLoai";
            cboLoaiSua.ValueMember = "MaLoai";

            colLoai.DataSource = new List<LoaiSuaDTO>(lsLoai);
            colLoai.DisplayMember = "TenLoai";
            colLoai.ValueMember = "MaLoai";
            dgvSua.AutoGenerateColumns = false;
            LoadDanhSachSua();
        }

        private void LoadDanhSachSua()
        {
            lsSua = sBUS.LayTatCaSua();
            dgvSua.DataSource = lsSua;
        }

        private void dgvSua_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvSua.SelectedRows.Count > 0)
            {
                sua = (SanPhamSuaDTO) dgvSua.SelectedRows[0].DataBoundItem;
            }
            else
            {
                sua = null;
            }
            GanThongTinChiTiet();
        }

        private void GanThongTinChiTiet()
        {
            if(sua != null)
            {
                txtMaSua.Text = sua.MaSua;
                txtTenSua.Text = sua.TenSua;
                txtGia.Text = sua.GiaBan.ToString();
                txtNSX.Text = sua.NhaSanXuat;
                cboLoaiSua.SelectedValue = sua.MaLoai;
                rtbMoTa.Text = sua.MoTa;
                chkKinhdoanh.Checked = (sua.TrangThai == 1);
                if(File.Exists(sua.HinhAnh))
                {
                    pboHAnh.Image = DocHinh(sua.HinhAnh);
                }
                else
                {
                    pboHAnh.Image = null;
                }
            }
            else
            {
                txtGia.Clear();
                txtMaSua.Clear();
                txtNSX.Clear();
                txtTenSua.Clear();
                rtbMoTa.Clear();
                chkKinhdoanh.Checked = true;
                pboHAnh.Image = null;
            }
        }

        private Image DocHinh(string hinhAnh)
        {
            byte[] byteHA = File.ReadAllBytes(hinhAnh);
            MemoryStream ms = new MemoryStream(byteHA);
            return Image.FromStream(ms);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            sua = null;
            GanThongTinChiTiet();
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtTenSua.Text) || string.IsNullOrWhiteSpace(txtGia.Text))
            {
                MessageBox.Show("Vui lòng nhập tên và giá bán", "Thêm Mới");
                return; //thoát hàm
            }    
            LayThongTinSua();
            
            if(sBUS.ThemMoiSanPham(sua))
            {
                if(pboHAnh.Image != null)
                {
                    pboHAnh.Image.Save(sua.HinhAnh);
                }    
                MessageBox.Show("Thêm Sữa Mới Thành Công", "Thêm Mới");
                LoadDanhSachSua();
            }    
            else
            {
                MessageBox.Show("Thêm Mới Không Thành Công", "Thêm Mới", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }

        private void LayThongTinSua()
        {
            if(sua == null)
            {
                sua = new SanPhamSuaDTO();
                sua.MaSua = sBUS.MaSanPhamMoi();
                sua.HinhAnh = Program.pathSua + sua.MaSua + ".jpg";
            }
            sua.TenSua = txtTenSua.Text;
            sua.GiaBan = int.Parse(txtGia.Text);
            sua.MaLoai = (int)cboLoaiSua.SelectedValue;
            sua.NhaSanXuat = txtNSX.Text;
            sua.MoTa = rtbMoTa.Text;
            sua.TrangThai = (chkKinhdoanh.Checked ? 1 : 0);
        }

        private void pboHAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Hình Ảnh|*.jpg;*.png";
            DialogResult dr = ofd.ShowDialog();
            if(dr != DialogResult.Cancel)
            {
                pboHAnh.Image = DocHinh(ofd.FileName);
            }    
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(sua == null) //do mỗi lần chọn dòng trên datagridview --> ánh xạ sang đối tượng sữa, nếu không chọn --> null
            {
                MessageBox.Show("Vui lòng chọn thông tin sữa", "Cập Nhật");
            }    
            else
            {
                LayThongTinSua();
                if(sBUS.CapNhatSanPham(sua))
                {
                    if (pboHAnh.Image != null)
                    {
                        pboHAnh.Image.Save(sua.HinhAnh);
                    }
                    MessageBox.Show("Cập Nhật Sữa Thành Công", "Cập Nhật");
                    LoadDanhSachSua();
                }
                else
                {
                    MessageBox.Show("Cập Nhật Không Thành Công", "Cập Nhật", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }    
        }

        private void dgvSua_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
