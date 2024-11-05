namespace QLCuaHangSua
{
    partial class frmBanHang
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
            this.components = new System.ComponentModel.Container();
            this.colDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenSua = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colMaSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.imlSua = new System.Windows.Forms.ImageList(this.components);
            this.lvwSua = new System.Windows.Forms.ListView();
            this.nudSoluong = new System.Windows.Forms.NumericUpDown();
            this.txtMaSua = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pboHAnh = new System.Windows.Forms.PictureBox();
            this.rtbMoTa = new System.Windows.Forms.RichTextBox();
            this.txtNSX = new System.Windows.Forms.TextBox();
            this.cboLoaiSua = new System.Windows.Forms.ComboBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtTenSua = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnInHD = new System.Windows.Forms.Button();
            this.dgvCTHD = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoaCT = new System.Windows.Forms.Button();
            this.btnLapHD = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoluong)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboHAnh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).BeginInit();
            this.SuspendLayout();
            // 
            // colDonGia
            // 
            this.colDonGia.DataPropertyName = "DonGia";
            this.colDonGia.HeaderText = "Đơn giá";
            this.colDonGia.Name = "colDonGia";
            this.colDonGia.Width = 125;
            // 
            // colTenSua
            // 
            this.colTenSua.DataPropertyName = "MaSanPham";
            this.colTenSua.HeaderText = "Tên sữa";
            this.colTenSua.Name = "colTenSua";
            this.colTenSua.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colTenSua.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colTenSua.Width = 125;
            // 
            // colMaSanPham
            // 
            this.colMaSanPham.DataPropertyName = "MaSanPham";
            this.colMaSanPham.HeaderText = "Mã sữa";
            this.colMaSanPham.Name = "colMaSanPham";
            this.colMaSanPham.Width = 125;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(406, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 43;
            this.label8.Text = "Số lượng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã SP:";
            // 
            // colSoLuong
            // 
            this.colSoLuong.DataPropertyName = "SoLuong";
            this.colSoLuong.HeaderText = "Số lượng";
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.Width = 125;
            // 
            // colThanhTien
            // 
            this.colThanhTien.DataPropertyName = "ThanhTien";
            this.colThanhTien.HeaderText = "Thành tiền";
            this.colThanhTien.Name = "colThanhTien";
            this.colThanhTien.Width = 125;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTongTien.Location = new System.Drawing.Point(308, 453);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(2);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(158, 20);
            this.txtTongTien.TabIndex = 47;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(240, 454);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 46;
            this.label9.Text = "Tổng tiền:";
            // 
            // imlSua
            // 
            this.imlSua.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imlSua.ImageSize = new System.Drawing.Size(60, 60);
            this.imlSua.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lvwSua
            // 
            this.lvwSua.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lvwSua.HideSelection = false;
            this.lvwSua.LargeImageList = this.imlSua;
            this.lvwSua.Location = new System.Drawing.Point(10, 46);
            this.lvwSua.Margin = new System.Windows.Forms.Padding(2);
            this.lvwSua.Name = "lvwSua";
            this.lvwSua.Size = new System.Drawing.Size(228, 392);
            this.lvwSua.TabIndex = 45;
            this.lvwSua.UseCompatibleStateImageBehavior = false;
            this.lvwSua.SelectedIndexChanged += new System.EventHandler(this.lvwSua_SelectedIndexChanged);
            this.lvwSua.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvwSua_MouseDoubleClick);
            // 
            // nudSoluong
            // 
            this.nudSoluong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nudSoluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSoluong.Location = new System.Drawing.Point(464, 193);
            this.nudSoluong.Margin = new System.Windows.Forms.Padding(2);
            this.nudSoluong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSoluong.Name = "nudSoluong";
            this.nudSoluong.Size = new System.Drawing.Size(68, 23);
            this.nudSoluong.TabIndex = 44;
            this.nudSoluong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtMaSua
            // 
            this.txtMaSua.Location = new System.Drawing.Point(65, 14);
            this.txtMaSua.Name = "txtMaSua";
            this.txtMaSua.Size = new System.Drawing.Size(100, 20);
            this.txtMaSua.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(218, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Mô tả:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pboHAnh);
            this.panel1.Controls.Add(this.rtbMoTa);
            this.panel1.Controls.Add(this.txtNSX);
            this.panel1.Controls.Add(this.cboLoaiSua);
            this.panel1.Controls.Add(this.txtGia);
            this.panel1.Controls.Add(this.txtTenSua);
            this.panel1.Controls.Add(this.btnTim);
            this.panel1.Controls.Add(this.txtMaSua);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(242, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 132);
            this.panel1.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Nhà SX:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(218, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Loại Sữa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Giá Bán:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tên SP:";
            // 
            // pboHAnh
            // 
            this.pboHAnh.Image = global::QLCuaHangSua.Properties.Resources.s22;
            this.pboHAnh.Location = new System.Drawing.Point(468, 17);
            this.pboHAnh.Name = "pboHAnh";
            this.pboHAnh.Size = new System.Drawing.Size(100, 102);
            this.pboHAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboHAnh.TabIndex = 10;
            this.pboHAnh.TabStop = false;
            // 
            // rtbMoTa
            // 
            this.rtbMoTa.Location = new System.Drawing.Point(268, 96);
            this.rtbMoTa.Name = "rtbMoTa";
            this.rtbMoTa.ReadOnly = true;
            this.rtbMoTa.Size = new System.Drawing.Size(194, 24);
            this.rtbMoTa.TabIndex = 7;
            this.rtbMoTa.Text = "";
            // 
            // txtNSX
            // 
            this.txtNSX.Location = new System.Drawing.Point(65, 96);
            this.txtNSX.Name = "txtNSX";
            this.txtNSX.ReadOnly = true;
            this.txtNSX.Size = new System.Drawing.Size(141, 20);
            this.txtNSX.TabIndex = 6;
            // 
            // cboLoaiSua
            // 
            this.cboLoaiSua.Enabled = false;
            this.cboLoaiSua.FormattingEnabled = true;
            this.cboLoaiSua.Location = new System.Drawing.Point(268, 56);
            this.cboLoaiSua.Name = "cboLoaiSua";
            this.cboLoaiSua.Size = new System.Drawing.Size(194, 21);
            this.cboLoaiSua.TabIndex = 5;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(65, 57);
            this.txtGia.Name = "txtGia";
            this.txtGia.ReadOnly = true;
            this.txtGia.Size = new System.Drawing.Size(141, 20);
            this.txtGia.TabIndex = 4;
            // 
            // txtTenSua
            // 
            this.txtTenSua.Location = new System.Drawing.Point(268, 19);
            this.txtTenSua.Name = "txtTenSua";
            this.txtTenSua.ReadOnly = true;
            this.txtTenSua.Size = new System.Drawing.Size(194, 20);
            this.txtTenSua.TabIndex = 3;
            // 
            // btnTim
            // 
            this.btnTim.Image = global::QLCuaHangSua.Properties.Resources.search;
            this.btnTim.Location = new System.Drawing.Point(171, 8);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(35, 31);
            this.btnTim.TabIndex = 2;
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnInHD
            // 
            this.btnInHD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInHD.Location = new System.Drawing.Point(615, 443);
            this.btnInHD.Name = "btnInHD";
            this.btnInHD.Size = new System.Drawing.Size(104, 38);
            this.btnInHD.TabIndex = 40;
            this.btnInHD.Text = "In Hóa Đơn";
            this.btnInHD.UseVisualStyleBackColor = true;
            // 
            // dgvCTHD
            // 
            this.dgvCTHD.AllowUserToAddRows = false;
            this.dgvCTHD.AllowUserToDeleteRows = false;
            this.dgvCTHD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaSanPham,
            this.colTenSua,
            this.colDonGia,
            this.colSoLuong,
            this.colThanhTien});
            this.dgvCTHD.Location = new System.Drawing.Point(242, 228);
            this.dgvCTHD.Name = "dgvCTHD";
            this.dgvCTHD.RowHeadersVisible = false;
            this.dgvCTHD.RowHeadersWidth = 51;
            this.dgvCTHD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCTHD.Size = new System.Drawing.Size(579, 209);
            this.dgvCTHD.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(374, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 25);
            this.label1.TabIndex = 36;
            this.label1.Text = "QUẢN LÝ BÁN SỮA";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLamMoi.Image = global::QLCuaHangSua.Properties.Resources.reset;
            this.btnLamMoi.Location = new System.Drawing.Point(727, 444);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(84, 37);
            this.btnLamMoi.TabIndex = 48;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnXoaCT
            // 
            this.btnXoaCT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXoaCT.Image = global::QLCuaHangSua.Properties.Resources.minus;
            this.btnXoaCT.Location = new System.Drawing.Point(604, 184);
            this.btnXoaCT.Name = "btnXoaCT";
            this.btnXoaCT.Size = new System.Drawing.Size(39, 37);
            this.btnXoaCT.TabIndex = 41;
            this.btnXoaCT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaCT.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnXoaCT.UseVisualStyleBackColor = true;
            this.btnXoaCT.Click += new System.EventHandler(this.btnXoaCT_Click);
            // 
            // btnLapHD
            // 
            this.btnLapHD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLapHD.Image = global::QLCuaHangSua.Properties.Resources.save;
            this.btnLapHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLapHD.Location = new System.Drawing.Point(493, 442);
            this.btnLapHD.Name = "btnLapHD";
            this.btnLapHD.Size = new System.Drawing.Size(116, 37);
            this.btnLapHD.TabIndex = 39;
            this.btnLapHD.Text = "Lập Hóa Đơn";
            this.btnLapHD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLapHD.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLapHD.UseVisualStyleBackColor = true;
            this.btnLapHD.Click += new System.EventHandler(this.btnLapHD_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAdd.Image = global::QLCuaHangSua.Properties.Resources.add;
            this.btnAdd.Location = new System.Drawing.Point(545, 187);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(42, 34);
            this.btnAdd.TabIndex = 42;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 491);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lvwSua);
            this.Controls.Add(this.nudSoluong);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnInHD);
            this.Controls.Add(this.btnXoaCT);
            this.Controls.Add(this.btnLapHD);
            this.Controls.Add(this.dgvCTHD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmBanHang";
            this.Text = "frmBanHang";
            this.Load += new System.EventHandler(this.frmBanHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudSoluong)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboHAnh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonGia;
        private System.Windows.Forms.DataGridViewComboBoxColumn colTenSua;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSanPham;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThanhTien;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ImageList imlSua;
        private System.Windows.Forms.ListView lvwSua;
        private System.Windows.Forms.NumericUpDown nudSoluong;
        private System.Windows.Forms.TextBox txtMaSua;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pboHAnh;
        private System.Windows.Forms.RichTextBox rtbMoTa;
        private System.Windows.Forms.TextBox txtNSX;
        private System.Windows.Forms.ComboBox cboLoaiSua;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtTenSua;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnInHD;
        private System.Windows.Forms.Button btnXoaCT;
        private System.Windows.Forms.Button btnLapHD;
        private System.Windows.Forms.DataGridView dgvCTHD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
    }
}