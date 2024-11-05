namespace QLCuaHangSua
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mnuPM = new System.Windows.Forms.MenuStrip();
            this.mnuBanHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSua = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLoaiSua = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBaoCao = new System.Windows.Forms.ToolStripMenuItem();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.btnDNDX = new System.Windows.Forms.Button();
            this.picNVDN = new System.Windows.Forms.PictureBox();
            this.mnuPM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNVDN)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuPM
            // 
            this.mnuPM.Dock = System.Windows.Forms.DockStyle.Left;
            this.mnuPM.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuPM.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuPM.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBanHang,
            this.mnuHoaDon,
            this.mnuQuanLy,
            this.mnuBaoCao});
            this.mnuPM.Location = new System.Drawing.Point(0, 0);
            this.mnuPM.Name = "mnuPM";
            this.mnuPM.Size = new System.Drawing.Size(185, 706);
            this.mnuPM.TabIndex = 0;
            this.mnuPM.Text = "menuStrip1";
            // 
            // mnuBanHang
            // 
            this.mnuBanHang.Image = global::QLCuaHangSua.Properties.Resources.BanHang;
            this.mnuBanHang.Name = "mnuBanHang";
            this.mnuBanHang.Size = new System.Drawing.Size(168, 36);
            this.mnuBanHang.Text = "BÁN HÀNG";
            this.mnuBanHang.Click += new System.EventHandler(this.mnuBanHang_Click);
            // 
            // mnuHoaDon
            // 
            this.mnuHoaDon.Image = global::QLCuaHangSua.Properties.Resources.HoaDon;
            this.mnuHoaDon.Name = "mnuHoaDon";
            this.mnuHoaDon.Size = new System.Drawing.Size(168, 36);
            this.mnuHoaDon.Text = "HOÁ ĐƠN";
            // 
            // mnuQuanLy
            // 
            this.mnuQuanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSua,
            this.mnuLoaiSua,
            this.mnuNhanVien});
            this.mnuQuanLy.Image = global::QLCuaHangSua.Properties.Resources.Management;
            this.mnuQuanLy.Name = "mnuQuanLy";
            this.mnuQuanLy.Size = new System.Drawing.Size(168, 36);
            this.mnuQuanLy.Text = "QUẢN LÝ";
            // 
            // mnuSua
            // 
            this.mnuSua.Image = global::QLCuaHangSua.Properties.Resources.s22;
            this.mnuSua.Name = "mnuSua";
            this.mnuSua.Size = new System.Drawing.Size(238, 36);
            this.mnuSua.Text = "SỮA";
            this.mnuSua.Click += new System.EventHandler(this.mnuSua_Click);
            // 
            // mnuLoaiSua
            // 
            this.mnuLoaiSua.Image = global::QLCuaHangSua.Properties.Resources.LoaiSua;
            this.mnuLoaiSua.Name = "mnuLoaiSua";
            this.mnuLoaiSua.Size = new System.Drawing.Size(238, 36);
            this.mnuLoaiSua.Text = "LOẠI SỮA";
            // 
            // mnuNhanVien
            // 
            this.mnuNhanVien.Image = global::QLCuaHangSua.Properties.Resources.StudentIcon;
            this.mnuNhanVien.Name = "mnuNhanVien";
            this.mnuNhanVien.Size = new System.Drawing.Size(238, 36);
            this.mnuNhanVien.Text = "NHÂN VIÊN";
            // 
            // mnuBaoCao
            // 
            this.mnuBaoCao.Image = global::QLCuaHangSua.Properties.Resources.HDNhap;
            this.mnuBaoCao.Name = "mnuBaoCao";
            this.mnuBaoCao.Size = new System.Drawing.Size(168, 36);
            this.mnuBaoCao.Text = "BÁO CÁO";
            this.mnuBaoCao.Click += new System.EventHandler(this.mnuBaoCao_Click);
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNV.ForeColor = System.Drawing.Color.Red;
            this.lblMaNV.Location = new System.Drawing.Point(16, 457);
            this.lblMaNV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(153, 29);
            this.lblMaNV.TabIndex = 3;
            this.lblMaNV.Text = "0123456789";
            // 
            // btnDNDX
            // 
            this.btnDNDX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDNDX.Image = global::QLCuaHangSua.Properties.Resources.DangNhap;
            this.btnDNDX.Location = new System.Drawing.Point(16, 592);
            this.btnDNDX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDNDX.Name = "btnDNDX";
            this.btnDNDX.Size = new System.Drawing.Size(167, 65);
            this.btnDNDX.TabIndex = 4;
            this.btnDNDX.Text = "Đăng Nhập";
            this.btnDNDX.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDNDX.UseVisualStyleBackColor = true;
            this.btnDNDX.Click += new System.EventHandler(this.btnDNDX_Click);
            // 
            // picNVDN
            // 
            this.picNVDN.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picNVDN.Location = new System.Drawing.Point(16, 313);
            this.picNVDN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picNVDN.Name = "picNVDN";
            this.picNVDN.Size = new System.Drawing.Size(165, 127);
            this.picNVDN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picNVDN.TabIndex = 2;
            this.picNVDN.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 706);
            this.Controls.Add(this.btnDNDX);
            this.Controls.Add(this.lblMaNV);
            this.Controls.Add(this.picNVDN);
            this.Controls.Add(this.mnuPM);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuPM;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMain";
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mnuPM.ResumeLayout(false);
            this.mnuPM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNVDN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuPM;
        private System.Windows.Forms.ToolStripMenuItem mnuBanHang;
        private System.Windows.Forms.ToolStripMenuItem mnuHoaDon;
        private System.Windows.Forms.ToolStripMenuItem mnuQuanLy;
        private System.Windows.Forms.ToolStripMenuItem mnuSua;
        private System.Windows.Forms.ToolStripMenuItem mnuLoaiSua;
        private System.Windows.Forms.ToolStripMenuItem mnuNhanVien;
        private System.Windows.Forms.ToolStripMenuItem mnuBaoCao;
        private System.Windows.Forms.PictureBox picNVDN;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.Button btnDNDX;
    }
}

