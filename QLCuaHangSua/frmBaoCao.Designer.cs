namespace QLCuaHangSua
{
    partial class frmBaoCao
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radDSSP = new System.Windows.Forms.RadioButton();
            this.radDSTheoLoai = new System.Windows.Forms.RadioButton();
            this.rsdNhomSP = new System.Windows.Forms.RadioButton();
            this.radHDB = new System.Windows.Forms.RadioButton();
            this.cboDSTheoLoai = new System.Windows.Forms.ComboBox();
            this.cboHDB = new System.Windows.Forms.ComboBox();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(234, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "THỐNG KÊ - BÁO CÁO";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnBaoCao);
            this.panel1.Controls.Add(this.cboHDB);
            this.panel1.Controls.Add(this.cboDSTheoLoai);
            this.panel1.Controls.Add(this.radHDB);
            this.panel1.Controls.Add(this.rsdNhomSP);
            this.panel1.Controls.Add(this.radDSTheoLoai);
            this.panel1.Controls.Add(this.radDSSP);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(38, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(715, 294);
            this.panel1.TabIndex = 1;
            // 
            // radDSSP
            // 
            this.radDSSP.AutoSize = true;
            this.radDSSP.Location = new System.Drawing.Point(136, 32);
            this.radDSSP.Name = "radDSSP";
            this.radDSSP.Size = new System.Drawing.Size(269, 24);
            this.radDSSP.TabIndex = 0;
            this.radDSSP.TabStop = true;
            this.radDSSP.Text = "Danh Sách Tất Cả Sản Phẩm Sữa";
            this.radDSSP.UseVisualStyleBackColor = true;
            // 
            // radDSTheoLoai
            // 
            this.radDSTheoLoai.AutoSize = true;
            this.radDSTheoLoai.Location = new System.Drawing.Point(136, 75);
            this.radDSTheoLoai.Name = "radDSTheoLoai";
            this.radDSTheoLoai.Size = new System.Drawing.Size(343, 24);
            this.radDSTheoLoai.TabIndex = 0;
            this.radDSTheoLoai.TabStop = true;
            this.radDSTheoLoai.Text = "Danh Sách Tất Cả Sản Phẩm Sữa Theo Loại";
            this.radDSTheoLoai.UseVisualStyleBackColor = true;
            // 
            // rsdNhomSP
            // 
            this.rsdNhomSP.AutoSize = true;
            this.rsdNhomSP.Location = new System.Drawing.Point(136, 121);
            this.rsdNhomSP.Name = "rsdNhomSP";
            this.rsdNhomSP.Size = new System.Drawing.Size(221, 24);
            this.rsdNhomSP.TabIndex = 0;
            this.rsdNhomSP.TabStop = true;
            this.rsdNhomSP.Text = "Nhóm Sản Phẩm Theo Loại";
            this.rsdNhomSP.UseVisualStyleBackColor = true;
            // 
            // radHDB
            // 
            this.radHDB.AutoSize = true;
            this.radHDB.Location = new System.Drawing.Point(136, 171);
            this.radHDB.Name = "radHDB";
            this.radHDB.Size = new System.Drawing.Size(124, 24);
            this.radHDB.TabIndex = 0;
            this.radHDB.TabStop = true;
            this.radHDB.Text = "Hóa Đơn Bán";
            this.radHDB.UseVisualStyleBackColor = true;
            // 
            // cboDSTheoLoai
            // 
            this.cboDSTheoLoai.FormattingEnabled = true;
            this.cboDSTheoLoai.Location = new System.Drawing.Point(503, 77);
            this.cboDSTheoLoai.Name = "cboDSTheoLoai";
            this.cboDSTheoLoai.Size = new System.Drawing.Size(166, 28);
            this.cboDSTheoLoai.TabIndex = 1;
            // 
            // cboHDB
            // 
            this.cboHDB.FormattingEnabled = true;
            this.cboHDB.Location = new System.Drawing.Point(314, 170);
            this.cboHDB.Name = "cboHDB";
            this.cboHDB.Size = new System.Drawing.Size(165, 28);
            this.cboHDB.TabIndex = 1;
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Location = new System.Drawing.Point(334, 226);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(101, 40);
            this.btnBaoCao.TabIndex = 2;
            this.btnBaoCao.Text = "Báo Cáo";
            this.btnBaoCao.UseVisualStyleBackColor = true;
            // 
            // frmBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBaoCao";
            this.Text = "frmBaoCao";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBaoCao;
        private System.Windows.Forms.ComboBox cboHDB;
        private System.Windows.Forms.ComboBox cboDSTheoLoai;
        private System.Windows.Forms.RadioButton radHDB;
        private System.Windows.Forms.RadioButton rsdNhomSP;
        private System.Windows.Forms.RadioButton radDSTheoLoai;
        private System.Windows.Forms.RadioButton radDSSP;
    }
}