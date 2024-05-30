using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanliChuoiCafeHightLand
{
    public partial class frmHoaDon : Form
    {
        public frmHoaDon()
        {
            InitializeComponent();
        }
        SqlConnection connection;

        public void load_data()
        {
            string sqlSelect = "SELECT *, '' FROM HOADON";
            SqlCommand command = new SqlCommand(sqlSelect, connection);
            SqlDataReader reader = command.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            dgv_listHoadon.DataSource = table;
            dgv_listHoadon.Columns[0].HeaderText = "Mã hoa don";
            dgv_listHoadon.Columns[1].HeaderText = "ngay nhan";
            dgv_listHoadon.Columns[2].HeaderText = "ma nhan vien";
            dgv_listHoadon.Columns[3].HeaderText = "ten nhan vien";
            dgv_listHoadon.Columns[4].HeaderText = "ma khach hang";
            dgv_listHoadon.Columns[5].HeaderText = "ten khach hang";
            dgv_listHoadon.Columns[6].HeaderText = "dien thoai";

        }
        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(DB.ConnectString);
            connection.Open();
            load_data();
            LoadNhanVien();
            LoadKhachHang();
            
        }
        public void LoadNhanVien()
        {
            connection = new SqlConnection(DB.ConnectString);
            connection.Open();

            String sql = "SELECT MaNV, TenNV, DiaChi, SDT, Email FROM NHANVIEN";
            SqlDataAdapter dap = new SqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            dap.Fill(ds, "NHANVIEN");

            cboMaNV.DisplayMember = "MaNV";
            cboTenNV.ValueMember = "TenNV";

            connection.Close();
        }

        public void LoadKhachHang() 
        {
            connection = new SqlConnection (DB.ConnectString);
            connection.Open();

            String sql = "SELECT MaKH, TenKH, DiaChi, SDT, Email, MaLKH FROM KHACHHANG";
            SqlDataAdapter dap = new SqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            dap.Fill(ds, "KHACHHANG");

            cboMaKH.DisplayMember = "MaKH";
            cboTenKH.ValueMember = "TenKH";
            cboSDT.ValueMember = "SDT";
            connection.Close();
        }
      
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(DB.ConnectString);
                connection.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ThemHoaDon";

                cmd.Parameters.AddWithValue("@MaHD", txtMahoadon.Text);
                cmd.Parameters.AddWithValue("@NgayThanhToan", dtpNgayThanhToan.Value);
                cmd.Parameters.AddWithValue("@MaNV", cboMaNV.SelectedValue);
                cmd.Parameters.AddWithValue("@TenNV", cboTenNV.SelectedValue);
                cmd.Parameters.AddWithValue("@MaKH", cboMaNV.SelectedValue);
                cmd.Parameters.AddWithValue("@TenKH", cboMaKH.SelectedValue);
                cmd.Parameters.AddWithValue("@DienThoai", cboMaKH.SelectedValue);
                cmd.Parameters.AddWithValue("@ThanhToan", txtThanhtien.Text);

                int kp = (int)cmd.ExecuteNonQuery();
                if (kp > 0)
                {
                    MessageBox.Show("Them thành công");
                    load_data();
                }
                connection.Close();
               

            }
            catch (Exception ex)
            {
                MessageBox.Show("Khong The Them");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(DB.ConnectString);
                connection.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SuaHoaDon";

                cmd.Parameters.AddWithValue("@MaHD", txtMahoadon.Text);
                cmd.Parameters.AddWithValue("@NgayThanhToan", dtpNgayThanhToan.Value);
                cmd.Parameters.AddWithValue("@MaNV", cboMaNV.SelectedValue);
                cmd.Parameters.AddWithValue("@TenNV", cboTenNV.SelectedValue);
                cmd.Parameters.AddWithValue("@MaKH", cboMaNV.SelectedValue);
                cmd.Parameters.AddWithValue("@TenKH", cboMaKH.SelectedValue);
                cmd.Parameters.AddWithValue("@DienThoai", cboMaKH.SelectedValue);
                cmd.Parameters.AddWithValue("@ThanhToan", txtThanhtien.Text);

                int kp = (int)cmd.ExecuteNonQuery();
                if (kp > 0)
                {
                    MessageBox.Show("Sửa thành công");
                    load_data();
                }
                connection.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Khong The Sua");
            }

        }
        private void XoaNhanVien()
        {
            txtMahoadon.Clear();
            cboMaNV.Items.Clear();
            cboTenNV.Items.Clear();
            cboMaKH.Items.Clear();
            cboTenKH.Items.Clear();
            cboSDT.Items.Clear();

        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(DB.ConnectString);
                connection.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "XoaHoaDon";

                // Xóa Nhân Viên

                SqlParameter MaHD = new SqlParameter("@MaHD", txtMahoadon.Text);
                cmd.Parameters.Add(MaHD);


                if (cmd.ExecuteNonQuery() > 0)
                {
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
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
                load_data();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thanh toán", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                connection = new SqlConnection(DB.ConnectString);
                connection.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaHD", txtMahoadon.Text);
                cmd.Parameters.AddWithValue("@NgayThanhToan", dtpNgayThanhToan.Value);
                cmd.Parameters.AddWithValue("@MaNV", cboMaNV.SelectedValue);
                cmd.Parameters.AddWithValue("@TenNV", cboTenNV.SelectedValue);
                cmd.Parameters.AddWithValue("@MaKH", cboMaNV.SelectedValue);
                cmd.Parameters.AddWithValue("@TenKH", cboMaKH.SelectedValue);
                cmd.Parameters.AddWithValue("@DienThoai", cboMaKH.SelectedValue);
                cmd.Parameters.AddWithValue("@ThanhToan", txtThanhtien.Text);
                cmd.Connection = connection;

                int kp = (int)cmd.ExecuteNonQuery();
                if (kp > 0)
                {
                    MessageBox.Show("Sửa thành công");
                }
                else
                {
                    MessageBox.Show("Sửa thành công");
                }
                connection.Close();

                load_data();
            }
        }

        private void btnHuyThanhtoan_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn hủy hóa đơn", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                connection = new SqlConnection(DB.ConnectString);
                connection.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "XoaHoaDon";
                cmd.Parameters.AddWithValue("@MaHD", txtMahoadon.Text);
                cmd.Connection = connection;
                cmd.ExecuteNonQuery();
                connection.Close();

                load_data();
            }
        }

        private void txtThanhtien_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
