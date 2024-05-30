namespace QuanliChuoiCafeHightLand
{
    partial class frmBan
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
			this.txt_find = new System.Windows.Forms.TextBox();
			this.bt_find = new System.Windows.Forms.Button();
			this.btn_clearBan = new System.Windows.Forms.Button();
			this.btn_updateBan = new System.Windows.Forms.Button();
			this.btn_addBan = new System.Windows.Forms.Button();
			this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
			this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.dgv_listBan = new System.Windows.Forms.DataGridView();
			this.gb_listBan = new System.Windows.Forms.GroupBox();
			this.txt_maKhuVuc = new System.Windows.Forms.TextBox();
			this.txt_tenBan = new System.Windows.Forms.TextBox();
			this.txt_maBan = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btn_outBan = new System.Windows.Forms.Button();
			this.gb_Ban = new System.Windows.Forms.GroupBox();
			this.btnTroVe = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgv_listBan)).BeginInit();
			this.gb_listBan.SuspendLayout();
			this.gb_Ban.SuspendLayout();
			this.SuspendLayout();
			// 
			// txt_find
			// 
			this.txt_find.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_find.Location = new System.Drawing.Point(488, 24);
			this.txt_find.Margin = new System.Windows.Forms.Padding(2);
			this.txt_find.Name = "txt_find";
			this.txt_find.Size = new System.Drawing.Size(366, 23);
			this.txt_find.TabIndex = 16;
			this.txt_find.Text = "Nhập từ khóa cần tìm";
			// 
			// bt_find
			// 
			this.bt_find.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.bt_find.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bt_find.ForeColor = System.Drawing.Color.Black;
			this.bt_find.Location = new System.Drawing.Point(873, 19);
			this.bt_find.Name = "bt_find";
			this.bt_find.Size = new System.Drawing.Size(101, 29);
			this.bt_find.TabIndex = 17;
			this.bt_find.Text = "Tìm Kiếm";
			this.bt_find.UseVisualStyleBackColor = false;
			// 
			// btn_clearBan
			// 
			this.btn_clearBan.BackColor = System.Drawing.Color.Cyan;
			this.btn_clearBan.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_clearBan.ForeColor = System.Drawing.Color.Black;
			this.btn_clearBan.Location = new System.Drawing.Point(305, 279);
			this.btn_clearBan.Name = "btn_clearBan";
			this.btn_clearBan.Size = new System.Drawing.Size(106, 35);
			this.btn_clearBan.TabIndex = 14;
			this.btn_clearBan.Text = "Xóa";
			this.btn_clearBan.UseVisualStyleBackColor = false;
			this.btn_clearBan.Click += new System.EventHandler(this.btn_clearBan_Click);
			// 
			// btn_updateBan
			// 
			this.btn_updateBan.BackColor = System.Drawing.Color.Cyan;
			this.btn_updateBan.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_updateBan.ForeColor = System.Drawing.Color.Black;
			this.btn_updateBan.Location = new System.Drawing.Point(174, 279);
			this.btn_updateBan.Name = "btn_updateBan";
			this.btn_updateBan.Size = new System.Drawing.Size(106, 35);
			this.btn_updateBan.TabIndex = 13;
			this.btn_updateBan.Text = "Cập Nhật";
			this.btn_updateBan.UseVisualStyleBackColor = false;
			this.btn_updateBan.Click += new System.EventHandler(this.btn_updateBan_Click);
			// 
			// btn_addBan
			// 
			this.btn_addBan.BackColor = System.Drawing.Color.Cyan;
			this.btn_addBan.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_addBan.ForeColor = System.Drawing.Color.Black;
			this.btn_addBan.Location = new System.Drawing.Point(40, 279);
			this.btn_addBan.Name = "btn_addBan";
			this.btn_addBan.Size = new System.Drawing.Size(106, 35);
			this.btn_addBan.TabIndex = 12;
			this.btn_addBan.Text = "Thêm";
			this.btn_addBan.UseVisualStyleBackColor = false;
			this.btn_addBan.Click += new System.EventHandler(this.btn_addBan_Click);
			// 
			// dgv_listBan
			// 
			this.dgv_listBan.AllowUserToAddRows = false;
			this.dgv_listBan.AllowUserToDeleteRows = false;
			this.dgv_listBan.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
			this.dgv_listBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_listBan.Location = new System.Drawing.Point(4, 21);
			this.dgv_listBan.Margin = new System.Windows.Forms.Padding(2);
			this.dgv_listBan.Name = "dgv_listBan";
			this.dgv_listBan.ReadOnly = true;
			this.dgv_listBan.RowHeadersWidth = 51;
			this.dgv_listBan.RowTemplate.Height = 24;
			this.dgv_listBan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgv_listBan.Size = new System.Drawing.Size(546, 230);
			this.dgv_listBan.TabIndex = 0;
			// 
			// gb_listBan
			// 
			this.gb_listBan.BackColor = System.Drawing.Color.MintCream;
			this.gb_listBan.Controls.Add(this.dgv_listBan);
			this.gb_listBan.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gb_listBan.Location = new System.Drawing.Point(456, 59);
			this.gb_listBan.Margin = new System.Windows.Forms.Padding(2);
			this.gb_listBan.Name = "gb_listBan";
			this.gb_listBan.Padding = new System.Windows.Forms.Padding(2);
			this.gb_listBan.Size = new System.Drawing.Size(556, 255);
			this.gb_listBan.TabIndex = 10;
			this.gb_listBan.TabStop = false;
			this.gb_listBan.Text = "Danh Sách Bàn";
			// 
			// txt_maKhuVuc
			// 
			this.txt_maKhuVuc.Location = new System.Drawing.Point(127, 141);
			this.txt_maKhuVuc.Margin = new System.Windows.Forms.Padding(2);
			this.txt_maKhuVuc.Name = "txt_maKhuVuc";
			this.txt_maKhuVuc.Size = new System.Drawing.Size(282, 24);
			this.txt_maKhuVuc.TabIndex = 3;
			// 
			// txt_tenBan
			// 
			this.txt_tenBan.Location = new System.Drawing.Point(127, 90);
			this.txt_tenBan.Margin = new System.Windows.Forms.Padding(2);
			this.txt_tenBan.Name = "txt_tenBan";
			this.txt_tenBan.Size = new System.Drawing.Size(282, 24);
			this.txt_tenBan.TabIndex = 2;
			// 
			// txt_maBan
			// 
			this.txt_maBan.Location = new System.Drawing.Point(127, 43);
			this.txt_maBan.Margin = new System.Windows.Forms.Padding(2);
			this.txt_maBan.Name = "txt_maBan";
			this.txt_maBan.Size = new System.Drawing.Size(282, 24);
			this.txt_maBan.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(22, 144);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(101, 17);
			this.label3.TabIndex = 1;
			this.label3.Text = "Mã Khu Vực: ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(22, 93);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(73, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Tên Bàn: ";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(22, 50);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 17);
			this.label1.TabIndex = 1;
			this.label1.Text = "Mã Bàn:";
			// 
			// btn_outBan
			// 
			this.btn_outBan.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.btn_outBan.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_outBan.ForeColor = System.Drawing.Color.Black;
			this.btn_outBan.Location = new System.Drawing.Point(34, 487);
			this.btn_outBan.Name = "btn_outBan";
			this.btn_outBan.Size = new System.Drawing.Size(106, 35);
			this.btn_outBan.TabIndex = 15;
			this.btn_outBan.Text = "Thoát";
			this.btn_outBan.UseVisualStyleBackColor = false;
			// 
			// gb_Ban
			// 
			this.gb_Ban.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.gb_Ban.BackgroundImage = global::QuanliChuoiCafeHightLand.Properties.Resources.cafeee;
			this.gb_Ban.Controls.Add(this.txt_maKhuVuc);
			this.gb_Ban.Controls.Add(this.txt_tenBan);
			this.gb_Ban.Controls.Add(this.txt_maBan);
			this.gb_Ban.Controls.Add(this.label3);
			this.gb_Ban.Controls.Add(this.label2);
			this.gb_Ban.Controls.Add(this.label1);
			this.gb_Ban.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gb_Ban.Location = new System.Drawing.Point(9, 59);
			this.gb_Ban.Margin = new System.Windows.Forms.Padding(2);
			this.gb_Ban.Name = "gb_Ban";
			this.gb_Ban.Padding = new System.Windows.Forms.Padding(2);
			this.gb_Ban.Size = new System.Drawing.Size(428, 215);
			this.gb_Ban.TabIndex = 11;
			this.gb_Ban.TabStop = false;
			this.gb_Ban.Text = "Số Bàn";
			// 
			// btnTroVe
			// 
			this.btnTroVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTroVe.Location = new System.Drawing.Point(9, 1);
			this.btnTroVe.Name = "btnTroVe";
			this.btnTroVe.Size = new System.Drawing.Size(61, 27);
			this.btnTroVe.TabIndex = 19;
			this.btnTroVe.Text = "<==";
			this.btnTroVe.UseVisualStyleBackColor = true;
			this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
			// 
			// frmBan
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.MintCream;
			this.BackgroundImage = global::QuanliChuoiCafeHightLand.Properties.Resources.cafeee;
			this.ClientSize = new System.Drawing.Size(1023, 358);
			this.Controls.Add(this.btnTroVe);
			this.Controls.Add(this.txt_find);
			this.Controls.Add(this.bt_find);
			this.Controls.Add(this.btn_clearBan);
			this.Controls.Add(this.btn_updateBan);
			this.Controls.Add(this.btn_addBan);
			this.Controls.Add(this.gb_listBan);
			this.Controls.Add(this.btn_outBan);
			this.Controls.Add(this.gb_Ban);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "frmBan";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmBan";
			this.Load += new System.EventHandler(this.frmBan_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgv_listBan)).EndInit();
			this.gb_listBan.ResumeLayout(false);
			this.gb_Ban.ResumeLayout(false);
			this.gb_Ban.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_find;
        private System.Windows.Forms.Button bt_find;
        private System.Windows.Forms.Button btn_clearBan;
        private System.Windows.Forms.Button btn_updateBan;
        private System.Windows.Forms.Button btn_addBan;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dgv_listBan;
        private System.Windows.Forms.GroupBox gb_listBan;
        private System.Windows.Forms.TextBox txt_maKhuVuc;
        private System.Windows.Forms.TextBox txt_tenBan;
        private System.Windows.Forms.TextBox txt_maBan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_outBan;
        private System.Windows.Forms.GroupBox gb_Ban;
		private System.Windows.Forms.Button btnTroVe;
	}
}