using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QuanliChuoiCafeHightLand
{
    public partial class frmLogin : Form
    {
        /*ma quyen
         * 1:admin
         * 2:nhan vien
         */
        public static string UserName = "";
        public frmLogin()
        {
            InitializeComponent();
        }
		string strconn = DB.ConnectString;
		SqlConnection conn = null;
		SqlCommand comm;
		DataTable data;
		SqlDataAdapter sqladr;
        SqlDataReader reader;

		private void btnLogin_Click(object sender, EventArgs e)
        {
			if (checkAdmin.Checked == false && checkUser.Checked == false)
			{
				MessageBox.Show("Bạn Chưa chọn Vai Trò cho đăng nhập !!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			if (txtpass.Text == "" || txtuser.Text == "")
            {
                MessageBox.Show("Bạn Chưa Nhập Mật Khẩu Hoặc Tài Khoản !!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
				if (checkAdmin.Checked == true)
				{
					XuLyDangNhapAdmin();
				}
				if (checkUser.Checked == true)
				{
					XuLyDangNhapUser();
				}
			}		        
		}

        private void btnOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if( MessageBox.Show("Ban co muon thoat chuong trinh?", "Thong bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK )  
            {
                e.Cancel = true;
            }
        }
        public static int Role;

        private void XuLyDangNhapAdmin()
        {
            conn = new SqlConnection(strconn);
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                comm = new SqlCommand();
                comm.CommandText = "[dbo].[PhanQuyenAdmin]";
                comm.CommandType = CommandType.StoredProcedure;
                comm.Connection = conn;
                SqlParameter User = new SqlParameter("@username", txtuser.Text);
				SqlParameter PassWord = new SqlParameter("@password", txtuser.Text);
				comm.Parameters.Add(User);
                comm.Parameters.Add(PassWord);
                reader = comm.ExecuteReader();            
               
                if (reader.Read())
                {                  
						frmQLBH QLBH = new frmQLBH();
						QLBH.ShowDialog();				            
                }
                else
                {
                    MessageBox.Show("Sai Tài Khoản Hoặc Mật Khẩu ! Vui Lòng Nhập Lại !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
				MessageBox.Show("Không Tải Được Dữ Liệu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
            finally
            {
                conn.Close();          
            }
        }

		private void XuLyDangNhapUser()
		{
			conn = new SqlConnection(strconn);
			try
			{
				if (conn.State == ConnectionState.Closed)
				{
					conn.Open();
				}
				comm = new SqlCommand();
				comm.CommandText = "[dbo].[PhanQuyenUser]";
				comm.CommandType = CommandType.StoredProcedure;
				comm.Connection = conn;
				SqlParameter User = new SqlParameter("@username", txtuser.Text);
				SqlParameter PassWord = new SqlParameter("@password", txtuser.Text);
				comm.Parameters.Add(User);
				comm.Parameters.Add(PassWord);
				reader = comm.ExecuteReader();

				if (reader.Read())
				{
					frmQLBHNV QLBHNV = new frmQLBHNV();
					QLBHNV.ShowDialog();
				}
				else
				{
					MessageBox.Show("Sai Tài Khoản Hoặc Mật Khẩu ! Vui Lòng Nhập Lại !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Không Tải Được Dữ Liệu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				conn.Close();
			}
		}

		private void ckbNhanvien_CheckedChanged(object sender, EventArgs e)
        {
            if(checkUser.Checked)
            {
                checkAdmin.Checked = false;
            }
        }

        private void ckbadmin_CheckedChanged(object sender, EventArgs e)
        {
            if (checkAdmin.Checked)
            {
                checkUser.Checked = false;
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
           
        }
    }
}
