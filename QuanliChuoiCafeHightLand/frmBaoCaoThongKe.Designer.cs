﻿namespace QuanliChuoiCafeHightLand
{
    partial class frmBaoCaoThongKe
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
			this.btnXemBaoCao = new System.Windows.Forms.Button();
			this.dgvBaoCao = new System.Windows.Forms.DataGridView();
			this.dtp_TuNgay = new System.Windows.Forms.DateTimePicker();
			this.cbo_Kbaocao = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.NgayVao = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Ban = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.KhuVuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.KhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ThucDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dtp_Denngay = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txt_TongCong = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvBaoCao)).BeginInit();
			this.SuspendLayout();
			// 
			// btnXemBaoCao
			// 
			this.btnXemBaoCao.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.btnXemBaoCao.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnXemBaoCao.ForeColor = System.Drawing.Color.Black;
			this.btnXemBaoCao.Location = new System.Drawing.Point(768, 19);
			this.btnXemBaoCao.Margin = new System.Windows.Forms.Padding(2);
			this.btnXemBaoCao.Name = "btnXemBaoCao";
			this.btnXemBaoCao.Size = new System.Drawing.Size(111, 28);
			this.btnXemBaoCao.TabIndex = 12;
			this.btnXemBaoCao.Text = "Xem báo cáo";
			this.btnXemBaoCao.UseVisualStyleBackColor = false;
			this.btnXemBaoCao.Click += new System.EventHandler(this.btnXemBaoCao_Click);
			// 
			// dgvBaoCao
			// 
			this.dgvBaoCao.AllowUserToAddRows = false;
			this.dgvBaoCao.AllowUserToDeleteRows = false;
			this.dgvBaoCao.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
			this.dgvBaoCao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvBaoCao.Location = new System.Drawing.Point(20, 71);
			this.dgvBaoCao.Margin = new System.Windows.Forms.Padding(2);
			this.dgvBaoCao.Name = "dgvBaoCao";
			this.dgvBaoCao.ReadOnly = true;
			this.dgvBaoCao.RowHeadersWidth = 51;
			this.dgvBaoCao.RowTemplate.Height = 24;
			this.dgvBaoCao.Size = new System.Drawing.Size(878, 423);
			this.dgvBaoCao.TabIndex = 15;
			// 
			// dtp_TuNgay
			// 
			this.dtp_TuNgay.CustomFormat = "dd/MM/yyyy";
			this.dtp_TuNgay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtp_TuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtp_TuNgay.Location = new System.Drawing.Point(329, 21);
			this.dtp_TuNgay.Margin = new System.Windows.Forms.Padding(2);
			this.dtp_TuNgay.Name = "dtp_TuNgay";
			this.dtp_TuNgay.Size = new System.Drawing.Size(151, 26);
			this.dtp_TuNgay.TabIndex = 14;
			// 
			// cbo_Kbaocao
			// 
			this.cbo_Kbaocao.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbo_Kbaocao.FormattingEnabled = true;
			this.cbo_Kbaocao.Items.AddRange(new object[] {
            "Hôm nay",
            "Tuần này",
            "Tháng này",
            "Tùy chỉnh"});
			this.cbo_Kbaocao.Location = new System.Drawing.Point(123, 21);
			this.cbo_Kbaocao.Margin = new System.Windows.Forms.Padding(2);
			this.cbo_Kbaocao.Name = "cbo_Kbaocao";
			this.cbo_Kbaocao.Size = new System.Drawing.Size(111, 27);
			this.cbo_Kbaocao.TabIndex = 22;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(35, 520);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(78, 19);
			this.label5.TabIndex = 21;
			this.label5.Text = "Tổng cộng";
			// 
			// NgayVao
			// 
			this.NgayVao.DataPropertyName = "NgayVao";
			this.NgayVao.HeaderText = "Ngày vào";
			this.NgayVao.MinimumWidth = 6;
			this.NgayVao.Name = "NgayVao";
			this.NgayVao.ReadOnly = true;
			this.NgayVao.Width = 125;
			// 
			// Ban
			// 
			this.Ban.DataPropertyName = "TenBan";
			this.Ban.HeaderText = "Bàn";
			this.Ban.MinimumWidth = 6;
			this.Ban.Name = "Ban";
			this.Ban.ReadOnly = true;
			this.Ban.Width = 125;
			// 
			// KhuVuc
			// 
			this.KhuVuc.DataPropertyName = "TenKhuVuc";
			this.KhuVuc.HeaderText = "Khu vực";
			this.KhuVuc.MinimumWidth = 6;
			this.KhuVuc.Name = "KhuVuc";
			this.KhuVuc.ReadOnly = true;
			this.KhuVuc.Width = 125;
			// 
			// KhachHang
			// 
			this.KhachHang.DataPropertyName = "TenKH";
			this.KhachHang.HeaderText = "Khách hàng";
			this.KhachHang.MinimumWidth = 6;
			this.KhachHang.Name = "KhachHang";
			this.KhachHang.ReadOnly = true;
			this.KhachHang.Width = 125;
			// 
			// NhanVien
			// 
			this.NhanVien.DataPropertyName = "TenNV";
			this.NhanVien.HeaderText = "Nhân viên";
			this.NhanVien.MinimumWidth = 6;
			this.NhanVien.Name = "NhanVien";
			this.NhanVien.ReadOnly = true;
			this.NhanVien.Width = 125;
			// 
			// ThucDon
			// 
			this.ThucDon.DataPropertyName = "TenThucDon";
			this.ThucDon.HeaderText = "Thực đơn";
			this.ThucDon.MinimumWidth = 6;
			this.ThucDon.Name = "ThucDon";
			this.ThucDon.ReadOnly = true;
			this.ThucDon.Width = 125;
			// 
			// Gia
			// 
			this.Gia.DataPropertyName = "Gia";
			this.Gia.HeaderText = "Giá";
			this.Gia.MinimumWidth = 6;
			this.Gia.Name = "Gia";
			this.Gia.ReadOnly = true;
			this.Gia.Width = 125;
			// 
			// SoLuong
			// 
			this.SoLuong.DataPropertyName = "SoLuong";
			this.SoLuong.HeaderText = "Số lượng";
			this.SoLuong.MinimumWidth = 6;
			this.SoLuong.Name = "SoLuong";
			this.SoLuong.ReadOnly = true;
			this.SoLuong.Width = 125;
			// 
			// ThanhTien
			// 
			this.ThanhTien.DataPropertyName = "ThanhTien";
			this.ThanhTien.HeaderText = "Thành tiền";
			this.ThanhTien.MinimumWidth = 6;
			this.ThanhTien.Name = "ThanhTien";
			this.ThanhTien.ReadOnly = true;
			this.ThanhTien.Width = 125;
			// 
			// dtp_Denngay
			// 
			this.dtp_Denngay.CustomFormat = "dd/MM/yyyy";
			this.dtp_Denngay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtp_Denngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtp_Denngay.Location = new System.Drawing.Point(588, 20);
			this.dtp_Denngay.Margin = new System.Windows.Forms.Padding(2);
			this.dtp_Denngay.Name = "dtp_Denngay";
			this.dtp_Denngay.Size = new System.Drawing.Size(151, 26);
			this.dtp_Denngay.TabIndex = 16;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(29, 24);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(84, 19);
			this.label2.TabIndex = 17;
			this.label2.Text = "Kỳ báo cáo";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(249, 24);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(65, 19);
			this.label3.TabIndex = 18;
			this.label3.Text = "Từ ngày";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(501, 24);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(73, 19);
			this.label4.TabIndex = 19;
			this.label4.Text = "Đến ngày";
			// 
			// txt_TongCong
			// 
			this.txt_TongCong.Location = new System.Drawing.Point(146, 522);
			this.txt_TongCong.Margin = new System.Windows.Forms.Padding(2);
			this.txt_TongCong.Name = "txt_TongCong";
			this.txt_TongCong.Size = new System.Drawing.Size(152, 20);
			this.txt_TongCong.TabIndex = 20;
			// 
			// frmBaoCaoThongKe
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(912, 567);
			this.Controls.Add(this.cbo_Kbaocao);
			this.Controls.Add(this.txt_TongCong);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dtp_Denngay);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.dgvBaoCao);
			this.Controls.Add(this.dtp_TuNgay);
			this.Controls.Add(this.btnXemBaoCao);
			this.Name = "frmBaoCaoThongKe";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "BaoCaoThongKe";
			((System.ComponentModel.ISupportInitialize)(this.dgvBaoCao)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXemBaoCao;
        private System.Windows.Forms.DataGridView dgvBaoCao;
        private System.Windows.Forms.DateTimePicker dtp_TuNgay;
        private System.Windows.Forms.ComboBox cbo_Kbaocao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayVao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ban;
        private System.Windows.Forms.DataGridViewTextBoxColumn KhuVuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn KhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThucDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.DateTimePicker dtp_Denngay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_TongCong;
    }
}