namespace QuanliChuoiCafeHightLand
{
    partial class frmKhachHang
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
            this.txtLoaiKH = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgv_list_KH = new System.Windows.Forms.DataGridView();
            this.gb_listBan = new System.Windows.Forms.GroupBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtfindKH = new System.Windows.Forms.TextBox();
            this.bt_out_KH = new System.Windows.Forms.Button();
            this.btnFindKH = new System.Windows.Forms.Button();
            this.bt_clear_KH = new System.Windows.Forms.Button();
            this.bt_update_KH = new System.Windows.Forms.Button();
            this.bt_add_KH = new System.Windows.Forms.Button();
            this.gbkh = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list_KH)).BeginInit();
            this.gb_listBan.SuspendLayout();
            this.gbkh.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtLoaiKH
            // 
            this.txtLoaiKH.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtLoaiKH.Location = new System.Drawing.Point(91, 393);
            this.txtLoaiKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLoaiKH.Name = "txtLoaiKH";
            this.txtLoaiKH.Size = new System.Drawing.Size(247, 28);
            this.txtLoaiKH.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtEmail.Location = new System.Drawing.Point(91, 322);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(247, 28);
            this.txtEmail.TabIndex = 2;
            // 
            // txtsdt
            // 
            this.txtsdt.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtsdt.Location = new System.Drawing.Point(91, 258);
            this.txtsdt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(247, 28);
            this.txtsdt.TabIndex = 2;
            // 
            // txtDiachi
            // 
            this.txtDiachi.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtDiachi.Location = new System.Drawing.Point(91, 185);
            this.txtDiachi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(247, 28);
            this.txtDiachi.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 396);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Loại:";
            // 
            // dgv_list_KH
            // 
            this.dgv_list_KH.AllowUserToAddRows = false;
            this.dgv_list_KH.AllowUserToDeleteRows = false;
            this.dgv_list_KH.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_list_KH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_list_KH.Location = new System.Drawing.Point(8, 25);
            this.dgv_list_KH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_list_KH.Name = "dgv_list_KH";
            this.dgv_list_KH.ReadOnly = true;
            this.dgv_list_KH.RowHeadersWidth = 51;
            this.dgv_list_KH.RowTemplate.Height = 24;
            this.dgv_list_KH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_list_KH.Size = new System.Drawing.Size(965, 514);
            this.dgv_list_KH.TabIndex = 0;
            this.dgv_list_KH.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgv_list_KH_RowPrePaint);
            // 
            // gb_listBan
            // 
            this.gb_listBan.Controls.Add(this.dgv_list_KH);
            this.gb_listBan.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_listBan.Location = new System.Drawing.Point(373, 71);
            this.gb_listBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_listBan.Name = "gb_listBan";
            this.gb_listBan.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_listBan.Size = new System.Drawing.Size(979, 546);
            this.gb_listBan.TabIndex = 13;
            this.gb_listBan.TabStop = false;
            this.gb_listBan.Text = "Danh Sách Khách Hàng";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtTenKH.Location = new System.Drawing.Point(84, 126);
            this.txtTenKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(253, 28);
            this.txtTenKH.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Email:";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtMaKH.Location = new System.Drawing.Point(84, 62);
            this.txtMaKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(253, 28);
            this.txtMaKH.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "SDT:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Địa chỉ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã KH:";
            // 
            // txtfindKH
            // 
            this.txtfindKH.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtfindKH.Location = new System.Drawing.Point(373, 32);
            this.txtfindKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtfindKH.Name = "txtfindKH";
            this.txtfindKH.Size = new System.Drawing.Size(769, 28);
            this.txtfindKH.TabIndex = 15;
            this.txtfindKH.TextChanged += new System.EventHandler(this.txtfindKH_TextChanged);
            // 
            // bt_out_KH
            // 
            this.bt_out_KH.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bt_out_KH.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_out_KH.ForeColor = System.Drawing.Color.Black;
            this.bt_out_KH.Location = new System.Drawing.Point(1112, 636);
            this.bt_out_KH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_out_KH.Name = "bt_out_KH";
            this.bt_out_KH.Size = new System.Drawing.Size(185, 47);
            this.bt_out_KH.TabIndex = 16;
            this.bt_out_KH.Text = "Thoát";
            this.bt_out_KH.UseVisualStyleBackColor = false;
            this.bt_out_KH.Click += new System.EventHandler(this.bt_out_KH_Click);
            // 
            // btnFindKH
            // 
            this.btnFindKH.BackColor = System.Drawing.Color.LightCyan;
            this.btnFindKH.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindKH.ForeColor = System.Drawing.Color.Black;
            this.btnFindKH.Location = new System.Drawing.Point(1171, 25);
            this.btnFindKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFindKH.Name = "btnFindKH";
            this.btnFindKH.Size = new System.Drawing.Size(125, 41);
            this.btnFindKH.TabIndex = 17;
            this.btnFindKH.Text = "Tìm Kiếm";
            this.btnFindKH.UseVisualStyleBackColor = false;
            this.btnFindKH.Click += new System.EventHandler(this.btnFindKH_Click);
            // 
            // bt_clear_KH
            // 
            this.bt_clear_KH.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bt_clear_KH.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_clear_KH.ForeColor = System.Drawing.Color.Black;
            this.bt_clear_KH.Location = new System.Drawing.Point(871, 636);
            this.bt_clear_KH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_clear_KH.Name = "bt_clear_KH";
            this.bt_clear_KH.Size = new System.Drawing.Size(185, 47);
            this.bt_clear_KH.TabIndex = 18;
            this.bt_clear_KH.Text = "Xóa";
            this.bt_clear_KH.UseVisualStyleBackColor = false;
            this.bt_clear_KH.Click += new System.EventHandler(this.bt_clear_KH_Click);
            // 
            // bt_update_KH
            // 
            this.bt_update_KH.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bt_update_KH.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_update_KH.ForeColor = System.Drawing.Color.Black;
            this.bt_update_KH.Location = new System.Drawing.Point(628, 636);
            this.bt_update_KH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_update_KH.Name = "bt_update_KH";
            this.bt_update_KH.Size = new System.Drawing.Size(185, 47);
            this.bt_update_KH.TabIndex = 19;
            this.bt_update_KH.Text = "Cập Nhật";
            this.bt_update_KH.UseVisualStyleBackColor = false;
            this.bt_update_KH.Click += new System.EventHandler(this.bt_update_KH_Click);
            // 
            // bt_add_KH
            // 
            this.bt_add_KH.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bt_add_KH.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_add_KH.ForeColor = System.Drawing.Color.Black;
            this.bt_add_KH.Location = new System.Drawing.Point(373, 636);
            this.bt_add_KH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_add_KH.Name = "bt_add_KH";
            this.bt_add_KH.Size = new System.Drawing.Size(185, 47);
            this.bt_add_KH.TabIndex = 20;
            this.bt_add_KH.Text = "Thêm";
            this.bt_add_KH.UseVisualStyleBackColor = false;
            this.bt_add_KH.Click += new System.EventHandler(this.bt_add_KH_Click);
            // 
            // gbkh
            // 
            this.gbkh.Controls.Add(this.txtLoaiKH);
            this.gbkh.Controls.Add(this.txtEmail);
            this.gbkh.Controls.Add(this.txtsdt);
            this.gbkh.Controls.Add(this.txtDiachi);
            this.gbkh.Controls.Add(this.label6);
            this.gbkh.Controls.Add(this.txtTenKH);
            this.gbkh.Controls.Add(this.label5);
            this.gbkh.Controls.Add(this.txtMaKH);
            this.gbkh.Controls.Add(this.label4);
            this.gbkh.Controls.Add(this.label3);
            this.gbkh.Controls.Add(this.label2);
            this.gbkh.Controls.Add(this.label1);
            this.gbkh.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbkh.Location = new System.Drawing.Point(12, 71);
            this.gbkh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbkh.Name = "gbkh";
            this.gbkh.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbkh.Size = new System.Drawing.Size(343, 487);
            this.gbkh.TabIndex = 14;
            this.gbkh.TabStop = false;
            this.gbkh.Text = "Khách Hàng";
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1372, 706);
            this.Controls.Add(this.gb_listBan);
            this.Controls.Add(this.txtfindKH);
            this.Controls.Add(this.bt_out_KH);
            this.Controls.Add(this.btnFindKH);
            this.Controls.Add(this.bt_clear_KH);
            this.Controls.Add(this.bt_update_KH);
            this.Controls.Add(this.bt_add_KH);
            this.Controls.Add(this.gbkh);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KhachHang";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmKhachHang_FormClosing);
            this.Load += new System.EventHandler(this.frmKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list_KH)).EndInit();
            this.gb_listBan.ResumeLayout(false);
            this.gbkh.ResumeLayout(false);
            this.gbkh.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLoaiKH;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgv_list_KH;
        private System.Windows.Forms.GroupBox gb_listBan;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtfindKH;
        private System.Windows.Forms.Button bt_out_KH;
        private System.Windows.Forms.Button btnFindKH;
        private System.Windows.Forms.Button bt_clear_KH;
        private System.Windows.Forms.Button bt_update_KH;
        private System.Windows.Forms.Button bt_add_KH;
        private System.Windows.Forms.GroupBox gbkh;
    }
}