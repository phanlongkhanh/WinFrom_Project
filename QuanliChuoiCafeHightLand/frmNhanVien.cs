using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanliChuoiCafeHightLand
{
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

		string strconn = DB.ConnectString;
        SqlConnection conn = null;
        SqlCommand comm;
		DataTable data;
        SqlDataAdapter sqladr;

		// Form Load NhanVien
     	private void frmNhanVien_Load(object sender, EventArgs e)
		{
			
			LoadDuLieuNhanVien();
			dataNhanVien.Columns[0].HeaderText = "Mã Nhân Viên";
			dataNhanVien.Columns[1].HeaderText = "Tên Nhân Viên";
			dataNhanVien.Columns[2].HeaderText = "Giới Tính";
			dataNhanVien.Columns[3].HeaderText = "Địa Chỉ";
			dataNhanVien.Columns[4].HeaderText = "Số Điện Thoại";
			dataNhanVien.Columns[5].HeaderText = "Email	";
			dataNhanVien.Columns[6].HeaderText = "Tài Khoản";
			dataNhanVien.Columns[7].HeaderText = "Mật khẩu";
			dataNhanVien.Columns[8].HeaderText = "Mã Quyền";

		}

		
		private void LoadDuLieuNhanVien()
        {
            conn = new SqlConnection(strconn);
            try
            {
                conn.Open();
                comm = new SqlCommand();
                comm.CommandText = "select * from [dbo].[NHANVIEN]";
                comm.CommandType = CommandType.Text;
                comm.Connection = conn;   
                sqladr = new SqlDataAdapter(comm);
				data = new DataTable();
				sqladr.Fill(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tải Dữ liệu không Thành Công " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
               if (conn.State == ConnectionState.Open)
				{
					conn.Close();
				}
               dataNhanVien.DataSource = data;
            }
        }
		// Thêm Nhân Viên
		private void btnThem_Click(object sender, EventArgs e)
		{
            conn = new SqlConnection(strconn);
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                comm = new SqlCommand();
                comm.CommandText = "[dbo].[ThemNhanVien]";
                comm.CommandType = CommandType.StoredProcedure;
                comm.Connection = conn;

				if(txtMaNV.Text == "" || txtHoten.Text == "" || txtDiachi.Text == "")
				{
					MessageBox.Show("Bạn Chưa Nhập Đầy Đủ Thông Tin", "Err", MessageBoxButtons.OK);
				}
                else
                {
                    // Thêm Nhân Viên
                    SqlParameter MaNV = new SqlParameter("@MaNV", txtMaNV.Text);
                    comm.Parameters.Add(MaNV);
                    SqlParameter Hoten = new SqlParameter("@TenNV", txtHoten.Text);
                    comm.Parameters.Add(Hoten);
                    if (rdbNam.Checked == true)
                    {
                        SqlParameter GioiTinh = new SqlParameter("@GioiTinh", rdbNam.Text);
                        comm.Parameters.Add(GioiTinh);
                    }
                    else
                    {
                        SqlParameter GioiTinh = new SqlParameter("@GioiTinh", rdbNu.Text);
                        comm.Parameters.Add(GioiTinh);
                    }
                    SqlParameter DiaChi = new SqlParameter("@DiaChi", txtDiachi.Text);
                    comm.Parameters.Add(DiaChi);
                    SqlParameter SDT = new SqlParameter("@SDT", txtSDT.Text);
                    comm.Parameters.Add(SDT);
                    SqlParameter Email = new SqlParameter("@Email", txtEmail.Text);
                    comm.Parameters.Add(Email);
                    SqlParameter Tendangnhap = new SqlParameter("@TenDangNhap", txtDangNhap.Text);
                    comm.Parameters.Add(Tendangnhap);
                    SqlParameter MatKhau = new SqlParameter("@MatKhau", txtMatKhau.Text);
                    comm.Parameters.Add(MatKhau);
                    if (cbbMaQuyen.Text == cbbMaQuyen.Items[0].ToString())
                    {
                        SqlParameter MaQuyen = new SqlParameter("@MaQuyen", cbbMaQuyen.Text);
                        comm.Parameters.Add(MaQuyen);
                    }
                    else
                    {
                        SqlParameter MaQuyen = new SqlParameter("@MaQuyen", cbbMaQuyen.Text);
                        comm.Parameters.Add(MaQuyen);
                    }
                    //Xóa dữ liêu Nhân Viên Vừa Thêm Trên Textbox
                    XoaNhanVien();
                    //Thực Thi
                    if (comm.ExecuteNonQuery() > 0)
                    {
						MessageBox.Show("Thêm Thành Công ");
                    }
                }        
				
			}
            catch (Exception ex)
            {
				MessageBox.Show("Thêm Không Thành Công " +ex.Message,"Err",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
            finally
            {
				if (conn.State == ConnectionState.Open)
				{
					conn.Close();
				}
				dataNhanVien.DataSource = data;
				LoadDuLieuNhanVien();
            }

		}

		// Data Dữ Liệu Nhân Viên
		private void dataNhanVien_Click(object sender, EventArgs e)
		{
			try
			{
				int dong = dataNhanVien.CurrentCell.RowIndex;
				txtMaNV.Text = dataNhanVien.Rows[dong].Cells[0].Value.ToString();
				txtHoten.Text = dataNhanVien.Rows[dong].Cells[1].Value.ToString();
				if (dataNhanVien.Rows[dong].Cells[2].Value.Equals(rdbNam.Text = "Nam"))
				{
					rdbNam.Checked = true;
				}
				else
				{
					rdbNu.Checked = true;
				}
				txtDiachi.Text = dataNhanVien.Rows[dong].Cells[3].Value.ToString();
				txtSDT.Text = dataNhanVien.Rows[dong].Cells[4].Value.ToString();
				txtEmail.Text = dataNhanVien.Rows[dong].Cells[5].Value.ToString();
				txtDangNhap.Text = dataNhanVien.Rows[dong].Cells[6].Value.ToString();
				txtMatKhau.Text = dataNhanVien.Rows[dong].Cells[7].Value.ToString();
				cbbMaQuyen.Text = dataNhanVien.Rows[dong].Cells[8].Value.ToString();

			}
			catch (Exception ex)
			{
				MessageBox.Show("Click Không Thành Công " + ex.Message);
			}
			
		}

		// Cập Nhật Lại Sinh Viên
		private void btnCapNhat_Click(object sender, EventArgs e)
		{
			conn = new SqlConnection(strconn);
			try
			{			
					conn.Open();
					comm = new SqlCommand();
					comm.CommandText = "[dbo].[SuaNhanVien]";
					comm.CommandType = CommandType.StoredProcedure;
					comm.Connection = conn;

					// Cập Nhật Nhân Viên
					SqlParameter MaNV = new SqlParameter("@MaNV", txtMaNV.Text);
					SqlParameter Hoten = new SqlParameter("@TenNV", txtHoten.Text);
					if (rdbNam.Checked == true)
					{
						SqlParameter GioiTinh = new SqlParameter("@GioiTinh", rdbNam.Text);
						comm.Parameters.Add(GioiTinh);
					}
					else
					{
						SqlParameter GioiTinh = new SqlParameter("@GioiTinh", rdbNu.Text);
						comm.Parameters.Add(GioiTinh);
					}
					SqlParameter DiaChi = new SqlParameter("@DiaChi", txtDiachi.Text);
					SqlParameter SDT = new SqlParameter("@SDT", txtSDT.Text);
					SqlParameter Email = new SqlParameter("@Email", txtEmail.Text);
					SqlParameter Tendangnhap = new SqlParameter("@TenDangNhap", txtDangNhap.Text);
					SqlParameter MatKhau = new SqlParameter("@MatKhau", txtMatKhau.Text);
					if (cbbMaQuyen.Text == cbbMaQuyen.Items[0].ToString())
					{
						SqlParameter MaQuyen = new SqlParameter("@MaQuyen", cbbMaQuyen.Text);
						comm.Parameters.Add(MaQuyen);
					}
					else
					{
						SqlParameter MaQuyen = new SqlParameter("@MaQuyen", cbbMaQuyen.Text);
						comm.Parameters.Add(MaQuyen);
					}

					// Cập Nhật Nhân Viên Vào SQL
					comm.Parameters.Add(MaNV);
					comm.Parameters.Add(Hoten);
					comm.Parameters.Add(DiaChi);
					comm.Parameters.Add(SDT);
					comm.Parameters.Add(Email);
					comm.Parameters.Add(Tendangnhap);
					comm.Parameters.Add(MatKhau);

					// Xóa các dữ Liệu Sao Khi Cập Nhật
					XoaNhanVien();

					//Thực Thi
					if (comm.ExecuteNonQuery() > 0)
					{
						MessageBox.Show("Cập Nhật Thành Công");
					}			
			}
			catch (Exception ex)
			{
				MessageBox.Show("Tải Dữ liệu không Thành Công " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				conn.Close();
				dataNhanVien.DataSource = data;
				LoadDuLieuNhanVien();

			}
		}
		private void XoaNhanVien()
		{
			txtMaNV.Clear();
			txtHoten.Clear();
			rdbNam.Checked = true;
			txtDiachi.Clear();
			txtSDT.Clear();
			txtEmail.Clear();
			txtDangNhap.Clear();
			txtMatKhau.Clear();
			cbbMaQuyen.Text = " ";
			txtMaNV.Focus();
		}
		
		private void btnXoa_Click(object sender, EventArgs e)
		{		
			conn = new SqlConnection(strconn);
			try
			{
					if (conn.State == ConnectionState.Closed)
					{
						conn.Open();
					}
					comm = new SqlCommand();
					comm.CommandText = "[dbo].[XoaNhanVien]";
					comm.CommandType = CommandType.StoredProcedure;
					comm.Connection = conn;
					// Xóa Nhân Viên
					SqlParameter MaNV = new SqlParameter("@MaNV", txtMaNV.Text);
					comm.Parameters.Add(MaNV);
					if (comm.ExecuteNonQuery() > 0)
					{
						comm.ExecuteNonQuery();
						MessageBox.Show("Xóa Thành Công");
					}
					// Xóa dữ Liệu sau khi click
					XoaNhanVien();				
			}
			catch (Exception ex)
			{
				MessageBox.Show("Xóa Dữ liệu không Thành Công " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				if (conn.State == ConnectionState.Open)
				{
					conn.Close();
				}
				dataNhanVien.DataSource = data;
				LoadDuLieuNhanVien();
			}
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Bạn Có Chắc Chắn Muốn Thoát Không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes)
			{
				this.Close();
			}
		}

		private void btnTimkiemnv_Click(object sender, EventArgs e)
		{
			conn = new SqlConnection(strconn);
			try
			{
				if (conn.State == ConnectionState.Closed)
				{
					conn.Open();
				}
				comm = new SqlCommand();
				comm.CommandText = "[dbo].[TimNhanVienTheoMa]";
				comm.CommandType = CommandType.StoredProcedure;
				comm.Connection = conn;

				// Tìm Nhân Viên	
				SqlParameter MaNV = new SqlParameter("@MaNV", txtTimKiem.Text);
				comm.Parameters.Add(MaNV);

				if (comm.ExecuteNonQuery() > 0)
				{
					MessageBox.Show("Tìm Thành Công");
				}
				sqladr = new SqlDataAdapter(comm);
				sqladr.Fill(data);

				// Xóa dữ Liệu sau khi click
				txtTimKiem.Clear();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Tìm Dữ liệu không Thành Công " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				if (conn.State == ConnectionState.Open)
				{
					conn.Close();
				}
				dataNhanVien.DataSource = data;
			}
		}

		private void txtTimKiem_TextChanged(object sender, EventArgs e)
		{		
		}
        private void dataNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
