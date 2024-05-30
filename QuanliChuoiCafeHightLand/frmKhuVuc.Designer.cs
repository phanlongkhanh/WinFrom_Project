namespace QuanliChuoiCafeHightLand
{
    partial class frmKhuVuc
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
            this.txt_tenKV = new System.Windows.Forms.TextBox();
            this.txt_MaKV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_timkiemKV = new System.Windows.Forms.TextBox();
            this.btn_thoatKV = new System.Windows.Forms.Button();
            this.btn_timkiemKV = new System.Windows.Forms.Button();
            this.btn_xoaKV = new System.Windows.Forms.Button();
            this.btn_capnhatKV = new System.Windows.Forms.Button();
            this.btn_themKV = new System.Windows.Forms.Button();
            this.gb_listBan = new System.Windows.Forms.GroupBox();
            this.dgv_listKV = new System.Windows.Forms.DataGridView();
            this.gb_listBan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listKV)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_tenKV
            // 
            this.txt_tenKV.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.txt_tenKV.Location = new System.Drawing.Point(723, 76);
            this.txt_tenKV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_tenKV.Name = "txt_tenKV";
            this.txt_tenKV.Size = new System.Drawing.Size(296, 28);
            this.txt_tenKV.TabIndex = 23;
            // 
            // txt_MaKV
            // 
            this.txt_MaKV.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.txt_MaKV.Location = new System.Drawing.Point(223, 76);
            this.txt_MaKV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_MaKV.Name = "txt_MaKV";
            this.txt_MaKV.Size = new System.Drawing.Size(285, 28);
            this.txt_MaKV.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(551, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 22);
            this.label2.TabIndex = 21;
            this.label2.Text = "Tên khu vực:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 22);
            this.label1.TabIndex = 22;
            this.label1.Text = "Mã khu vực:";
            // 
            // txt_timkiemKV
            // 
            this.txt_timkiemKV.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.txt_timkiemKV.Location = new System.Drawing.Point(53, 17);
            this.txt_timkiemKV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_timkiemKV.Name = "txt_timkiemKV";
            this.txt_timkiemKV.Size = new System.Drawing.Size(779, 28);
            this.txt_timkiemKV.TabIndex = 15;
            // 
            // btn_thoatKV
            // 
            this.btn_thoatKV.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_thoatKV.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoatKV.ForeColor = System.Drawing.Color.Black;
            this.btn_thoatKV.Location = new System.Drawing.Point(824, 594);
            this.btn_thoatKV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_thoatKV.Name = "btn_thoatKV";
            this.btn_thoatKV.Size = new System.Drawing.Size(176, 39);
            this.btn_thoatKV.TabIndex = 16;
            this.btn_thoatKV.Text = "Thoát";
            this.btn_thoatKV.UseVisualStyleBackColor = false;
            this.btn_thoatKV.Click += new System.EventHandler(this.btn_thoatKV_Click);
            // 
            // btn_timkiemKV
            // 
            this.btn_timkiemKV.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_timkiemKV.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timkiemKV.ForeColor = System.Drawing.Color.White;
            this.btn_timkiemKV.Location = new System.Drawing.Point(849, 12);
            this.btn_timkiemKV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_timkiemKV.Name = "btn_timkiemKV";
            this.btn_timkiemKV.Size = new System.Drawing.Size(151, 37);
            this.btn_timkiemKV.TabIndex = 17;
            this.btn_timkiemKV.Text = "Tìm Kiếm";
            this.btn_timkiemKV.UseVisualStyleBackColor = false;
            this.btn_timkiemKV.Click += new System.EventHandler(this.btn_timkiemKV_Click);
            // 
            // btn_xoaKV
            // 
            this.btn_xoaKV.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_xoaKV.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoaKV.ForeColor = System.Drawing.Color.Black;
            this.btn_xoaKV.Location = new System.Drawing.Point(564, 594);
            this.btn_xoaKV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_xoaKV.Name = "btn_xoaKV";
            this.btn_xoaKV.Size = new System.Drawing.Size(176, 39);
            this.btn_xoaKV.TabIndex = 18;
            this.btn_xoaKV.Text = "Xóa";
            this.btn_xoaKV.UseVisualStyleBackColor = false;
            this.btn_xoaKV.Click += new System.EventHandler(this.btn_xoaKV_Click);
            // 
            // btn_capnhatKV
            // 
            this.btn_capnhatKV.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_capnhatKV.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_capnhatKV.ForeColor = System.Drawing.Color.Black;
            this.btn_capnhatKV.Location = new System.Drawing.Point(304, 594);
            this.btn_capnhatKV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_capnhatKV.Name = "btn_capnhatKV";
            this.btn_capnhatKV.Size = new System.Drawing.Size(176, 39);
            this.btn_capnhatKV.TabIndex = 19;
            this.btn_capnhatKV.Text = "Cập Nhật";
            this.btn_capnhatKV.UseVisualStyleBackColor = false;
            this.btn_capnhatKV.Click += new System.EventHandler(this.btn_capnhatKV_Click);
            // 
            // btn_themKV
            // 
            this.btn_themKV.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_themKV.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_themKV.ForeColor = System.Drawing.Color.Black;
            this.btn_themKV.Location = new System.Drawing.Point(53, 594);
            this.btn_themKV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_themKV.Name = "btn_themKV";
            this.btn_themKV.Size = new System.Drawing.Size(176, 39);
            this.btn_themKV.TabIndex = 20;
            this.btn_themKV.Text = "Thêm";
            this.btn_themKV.UseVisualStyleBackColor = false;
            this.btn_themKV.Click += new System.EventHandler(this.btn_themKV_Click);
            // 
            // gb_listBan
            // 
            this.gb_listBan.Controls.Add(this.dgv_listKV);
            this.gb_listBan.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_listBan.Location = new System.Drawing.Point(48, 129);
            this.gb_listBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_listBan.Name = "gb_listBan";
            this.gb_listBan.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_listBan.Size = new System.Drawing.Size(973, 443);
            this.gb_listBan.TabIndex = 14;
            this.gb_listBan.TabStop = false;
            this.gb_listBan.Text = "Danh Sách Khu Vực";
            // 
            // dgv_listKV
            // 
            this.dgv_listKV.AllowUserToAddRows = false;
            this.dgv_listKV.AllowUserToDeleteRows = false;
            this.dgv_listKV.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_listKV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listKV.Location = new System.Drawing.Point(9, 26);
            this.dgv_listKV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_listKV.Name = "dgv_listKV";
            this.dgv_listKV.ReadOnly = true;
            this.dgv_listKV.RowHeadersWidth = 51;
            this.dgv_listKV.RowTemplate.Height = 24;
            this.dgv_listKV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_listKV.Size = new System.Drawing.Size(959, 412);
            this.dgv_listKV.TabIndex = 0;
            // 
            // frmKhuVuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 671);
            this.Controls.Add(this.txt_tenKV);
            this.Controls.Add(this.txt_MaKV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_timkiemKV);
            this.Controls.Add(this.btn_thoatKV);
            this.Controls.Add(this.btn_timkiemKV);
            this.Controls.Add(this.btn_xoaKV);
            this.Controls.Add(this.btn_capnhatKV);
            this.Controls.Add(this.btn_themKV);
            this.Controls.Add(this.gb_listBan);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmKhuVuc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmKhuVuc";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmKhuVuc_FormClosing);
            this.Load += new System.EventHandler(this.frmKhuVuc_Load);
            this.gb_listBan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listKV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_tenKV;
        private System.Windows.Forms.TextBox txt_MaKV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_timkiemKV;
        private System.Windows.Forms.Button btn_thoatKV;
        private System.Windows.Forms.Button btn_timkiemKV;
        private System.Windows.Forms.Button btn_xoaKV;
        private System.Windows.Forms.Button btn_capnhatKV;
        private System.Windows.Forms.Button btn_themKV;
        private System.Windows.Forms.GroupBox gb_listBan;
        private System.Windows.Forms.DataGridView dgv_listKV;
    }
}