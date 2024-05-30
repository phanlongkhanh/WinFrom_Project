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
	public partial class frmCalamviec : Form
	{
		public frmCalamviec()
		{
			InitializeComponent();
		}

		string strconn = DB.ConnectString;
		SqlConnection conn = null;
		SqlDataAdapter sqladt;
		SqlCommand comm;
		DataTable data;
		SqlDataReader reader;

		private void LoadCANhanVien()
		{
			conn = new SqlConnection(strconn);
			try
			{
				if (conn.State == ConnectionState.Closed)
				{
					conn.Open();
				}
				comm = new SqlCommand();
				comm.CommandText = "SELECT * FROM QUANLICA";
				comm.CommandType = CommandType.Text;
				comm.Connection = conn;
				sqladt = new SqlDataAdapter(comm);
				data = new DataTable();
				sqladt.Fill(data);
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
				dataQuanLiCa.DataSource = data;
			}
		}
		private void LoadComboBoxMaNV()
		{
			conn = new SqlConnection(strconn);
			try
			{
				conn.Open();
				comm = new SqlCommand();
				comm.CommandText = "[dbo].[ThemDuLieuVaoComboboxNhanVien]";
				comm.CommandType = CommandType.StoredProcedure;
				comm.Connection = conn;
				sqladt = new SqlDataAdapter(comm);
				data = new DataTable();
				sqladt.Fill(data);
				cbbMaNV.DisplayMember = "MaNV";
			}
			catch (Exception ex)
			{
				MessageBox.Show("Tải Dữ liệu Vào Combobox không Thành Công " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				if (conn.State == ConnectionState.Open)
				{
					conn.Close();
				}
				cbbMaNV.DataSource = data;
			}
		}

	private void cbbMaNV_SelectedIndexChanged(object sender, EventArgs e)
		{
			conn = new SqlConnection(strconn);
			try
			{
				conn.Open();
				comm = new SqlCommand();
				comm.CommandText = "[dbo].[sp_LayTenNV]";
				comm.CommandType = CommandType.StoredProcedure;
				comm.Connection = conn;	
				SqlParameter MaNV = new SqlParameter("@MaNV", cbbMaNV.Text);
				comm.Parameters.Add(MaNV);

				SqlDataReader reader = comm.ExecuteReader();
				if (reader.Read())
				{		
					cbbTenNV.Text = reader["TenNV"].ToString();
				}			
			}
			catch (Exception ex)
			{
				MessageBox.Show("Tải Dữ liệu Vào Combobox không Thành Công " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				if (conn.State == ConnectionState.Open)
				{
					conn.Close();
				}			
			}
		}

		private void frmCalamviec_Load(object sender, EventArgs e)
		{
            LoadCANhanVien();
			LoadComboBoxMaNV();
		
		}

		private void XoaDuLieu()
		{
			txtMaCa.Clear();
			cbbMaNV.Text = "";
			cbbTenNV.Text = "";
			dtpNgay.Text = DateTime.Now.ToString();
			cbbCaLam.Text = "";
			cbbTenCa.Text = "";		
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			conn = new SqlConnection(strconn);
			try
			{
				conn.Open();
				comm = new SqlCommand();
				comm.CommandText = "[dbo].[ThemCaLamViec]";
				comm.CommandType = CommandType.StoredProcedure;
				comm.Connection = conn;

				// Cập Nhật Nhân Viên
				SqlParameter MaCa = new SqlParameter("@MaCa", txtMaCa.Text);
				SqlParameter MaNV = new SqlParameter("@MaNV", cbbMaNV.Text);
				SqlParameter TenNV = new SqlParameter("@TenNV", cbbTenNV.Text);
				SqlParameter NgaySinh = new SqlParameter("@Ngay", dtpNgay.Text);
				SqlParameter CaLam = new SqlParameter("@CaLam", cbbCaLam.Text);
				SqlParameter TenCa = new SqlParameter("@TenCa", cbbTenCa.Text);
			
			
				// Cập Nhật Nhân Viên Vào SQL
				comm.Parameters.Add(MaCa);
				comm.Parameters.Add(MaNV);
				comm.Parameters.Add(TenNV);
				comm.Parameters.Add(NgaySinh);
				comm.Parameters.Add(CaLam);
				comm.Parameters.Add(TenCa);

				// Xóa các dữ Liệu Sao Khi Cập Nhật
				XoaDuLieu();

				//Thực Thi
				if (comm.ExecuteNonQuery() > 0)
				{
					MessageBox.Show("Add Thành Công");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Tải Dữ liệu không Thành Công " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				conn.Close();
				LoadCANhanVien();
			}
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
				comm.CommandText = "[dbo].[XoaCaLamViec]";
				comm.CommandType = CommandType.StoredProcedure;
				comm.Connection = conn;
				// Xóa Nhân Viên
				SqlParameter MaNV = new SqlParameter("@MaCa", txtMaCa.Text);
				comm.Parameters.Add(MaNV);
				if (comm.ExecuteNonQuery() > 0)
				{
					MessageBox.Show("Xóa Thành Công");
				}
				// Xóa dữ Liệu sau khi click
				XoaDuLieu();
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
				LoadCANhanVien();
			}
		}

		private void dataQuanLiCa_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				int dong = dataQuanLiCa.CurrentCell.RowIndex;
				txtMaCa.Text = dataQuanLiCa.Rows[dong].Cells[0].Value.ToString();
				cbbMaNV.Text = dataQuanLiCa.Rows[dong].Cells[1].Value.ToString();
				cbbTenNV.Text = dataQuanLiCa.Rows[dong].Cells[2].Value.ToString();
				dtpNgay.Text = dataQuanLiCa.Rows[dong].Cells[3].Value.ToString();
				cbbCaLam.Text = dataQuanLiCa.Rows[dong].Cells[4].Value.ToString();
				cbbTenCa.Text = dataQuanLiCa.Rows[dong].Cells[5].Value.ToString();


			}
			catch (Exception ex)
			{
				MessageBox.Show("Click Không Thành Công " + ex.Message);
			}
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			conn = new SqlConnection(strconn);
			try
			{
				DialogResult result = MessageBox.Show("Bạn Có Chắc Chắn Muốn Xóa Không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (result == DialogResult.Yes)
				{
					conn.Open();
					comm = new SqlCommand();
					comm.CommandText = "[dbo].[SuaCaLamViec]";
					comm.CommandType = CommandType.StoredProcedure;
					comm.Connection = conn;

					// Cập Nhật Nhân Viên
					SqlParameter MaCa = new SqlParameter("@MaCa", txtMaCa.Text);
					SqlParameter MaNV = new SqlParameter("@MaNV", cbbMaNV.Text);
					SqlParameter TenNV = new SqlParameter("@TenNV", cbbTenNV.Text);
					SqlParameter NgaySinh = new SqlParameter("@Ngay", dtpNgay.Text);
					SqlParameter CaLam = new SqlParameter("@CaLam", cbbCaLam.Text);
					SqlParameter TenCa = new SqlParameter("@TenCa", cbbTenCa.Text);

					// Cập Nhật Nhân Viên Vào SQL
					comm.Parameters.Add(MaCa);
					comm.Parameters.Add(MaNV);
					comm.Parameters.Add(TenNV);
					comm.Parameters.Add(NgaySinh);
					comm.Parameters.Add(CaLam);
					comm.Parameters.Add(TenCa);

					// Xóa các dữ Liệu Sao Khi Cập Nhật
					XoaDuLieu();

					//Thực Thi
					if (comm.ExecuteNonQuery() > 0)
					{
						MessageBox.Show("Add Thành Công");
					}
				}
				
			}
			catch (Exception ex)
			{
				MessageBox.Show("Tải Dữ liệu không Thành Công " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				conn.Close();
				LoadCANhanVien();
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

		private void cbbTenNV_SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}
	}
}
