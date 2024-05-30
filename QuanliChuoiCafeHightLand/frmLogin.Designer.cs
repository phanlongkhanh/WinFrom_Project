namespace QuanliChuoiCafeHightLand
{
    partial class frmLogin
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
			this.btnLogin = new System.Windows.Forms.Button();
			this.lblDangnhap = new System.Windows.Forms.Label();
			this.lblUser = new System.Windows.Forms.Label();
			this.btnOut = new System.Windows.Forms.Button();
			this.lblPass = new System.Windows.Forms.Label();
			this.txtpass = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.txtuser = new System.Windows.Forms.TextBox();
			this.checkUser = new System.Windows.Forms.CheckBox();
			this.checkAdmin = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnLogin
			// 
			this.btnLogin.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLogin.ForeColor = System.Drawing.Color.Sienna;
			this.btnLogin.Location = new System.Drawing.Point(287, 207);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(106, 25);
			this.btnLogin.TabIndex = 0;
			this.btnLogin.Text = "Đăng Nhập";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// lblDangnhap
			// 
			this.lblDangnhap.AutoSize = true;
			this.lblDangnhap.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.lblDangnhap.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDangnhap.ForeColor = System.Drawing.Color.Sienna;
			this.lblDangnhap.Location = new System.Drawing.Point(352, 54);
			this.lblDangnhap.Name = "lblDangnhap";
			this.lblDangnhap.Size = new System.Drawing.Size(147, 31);
			this.lblDangnhap.TabIndex = 4;
			this.lblDangnhap.Text = "Đăng Nhập";
			// 
			// lblUser
			// 
			this.lblUser.AutoSize = true;
			this.lblUser.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUser.ForeColor = System.Drawing.Color.Sienna;
			this.lblUser.Location = new System.Drawing.Point(260, 98);
			this.lblUser.Name = "lblUser";
			this.lblUser.Size = new System.Drawing.Size(92, 22);
			this.lblUser.TabIndex = 5;
			this.lblUser.Text = "Username";
			// 
			// btnOut
			// 
			this.btnOut.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOut.ForeColor = System.Drawing.Color.Sienna;
			this.btnOut.Location = new System.Drawing.Point(420, 207);
			this.btnOut.Name = "btnOut";
			this.btnOut.Size = new System.Drawing.Size(106, 25);
			this.btnOut.TabIndex = 7;
			this.btnOut.Text = "Thoát";
			this.btnOut.UseVisualStyleBackColor = true;
			this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
			// 
			// lblPass
			// 
			this.lblPass.AutoSize = true;
			this.lblPass.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPass.ForeColor = System.Drawing.Color.Sienna;
			this.lblPass.Location = new System.Drawing.Point(260, 134);
			this.lblPass.Name = "lblPass";
			this.lblPass.Size = new System.Drawing.Size(90, 22);
			this.lblPass.TabIndex = 6;
			this.lblPass.Text = "Password";
			// 
			// txtpass
			// 
			this.txtpass.BackColor = System.Drawing.SystemColors.Info;
			this.txtpass.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtpass.ForeColor = System.Drawing.Color.Black;
			this.txtpass.Location = new System.Drawing.Point(366, 135);
			this.txtpass.Name = "txtpass";
			this.txtpass.Size = new System.Drawing.Size(183, 24);
			this.txtpass.TabIndex = 8;
			this.txtpass.UseSystemPasswordChar = true;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::QuanliChuoiCafeHightLand.Properties.Resources.caffe;
			this.pictureBox1.Location = new System.Drawing.Point(628, 303);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(33, 36);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 9;
			this.pictureBox1.TabStop = false;
			// 
			// txtuser
			// 
			this.txtuser.BackColor = System.Drawing.SystemColors.Info;
			this.txtuser.ForeColor = System.Drawing.Color.Black;
			this.txtuser.Location = new System.Drawing.Point(366, 98);
			this.txtuser.Margin = new System.Windows.Forms.Padding(2);
			this.txtuser.Multiline = true;
			this.txtuser.Name = "txtuser";
			this.txtuser.Size = new System.Drawing.Size(183, 24);
			this.txtuser.TabIndex = 10;
			// 
			// checkUser
			// 
			this.checkUser.AutoSize = true;
			this.checkUser.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkUser.ForeColor = System.Drawing.Color.Sienna;
			this.checkUser.Location = new System.Drawing.Point(322, 173);
			this.checkUser.Margin = new System.Windows.Forms.Padding(2);
			this.checkUser.Name = "checkUser";
			this.checkUser.Size = new System.Drawing.Size(88, 21);
			this.checkUser.TabIndex = 11;
			this.checkUser.Text = "Nhân viên";
			this.checkUser.UseVisualStyleBackColor = true;
			this.checkUser.CheckedChanged += new System.EventHandler(this.ckbNhanvien_CheckedChanged);
			// 
			// checkAdmin
			// 
			this.checkAdmin.AutoSize = true;
			this.checkAdmin.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkAdmin.ForeColor = System.Drawing.Color.Sienna;
			this.checkAdmin.Location = new System.Drawing.Point(420, 173);
			this.checkAdmin.Margin = new System.Windows.Forms.Padding(2);
			this.checkAdmin.Name = "checkAdmin";
			this.checkAdmin.Size = new System.Drawing.Size(68, 21);
			this.checkAdmin.TabIndex = 12;
			this.checkAdmin.Text = "Admin";
			this.checkAdmin.UseVisualStyleBackColor = true;
			this.checkAdmin.CheckedChanged += new System.EventHandler(this.ckbadmin_CheckedChanged);
			// 
			// frmLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::QuanliChuoiCafeHightLand.Properties.Resources.cafeee;
			this.ClientSize = new System.Drawing.Size(826, 358);
			this.Controls.Add(this.checkAdmin);
			this.Controls.Add(this.checkUser);
			this.Controls.Add(this.txtuser);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.txtpass);
			this.Controls.Add(this.btnOut);
			this.Controls.Add(this.lblDangnhap);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.lblPass);
			this.Controls.Add(this.lblUser);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Đăng Nhập";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLogin_FormClosing);
			this.Load += new System.EventHandler(this.frmLogin_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblDangnhap;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.CheckBox checkUser;
        private System.Windows.Forms.CheckBox checkAdmin;
    }
}