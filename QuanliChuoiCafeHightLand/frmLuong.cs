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
    public partial class frmLuong : Form
    {
        public frmLuong()
        {
            InitializeComponent();
        }
        SqlConnection connection;

        void load_data()
        {
            string sqlSelect = "Select * From LUONG";
            SqlCommand command = new SqlCommand(sqlSelect, connection);
            SqlDataReader reader = command.ExecuteReader();
            DataTable table = new DataTable();

            table.Load(reader);

            dgv_tinhluong.DataSource = table;
            dgv_tinhluong.Columns[0].HeaderText = "Mã Nhân Viên";
            dgv_tinhluong.Columns[1].HeaderText = "Tên Nhân Viên";
            dgv_tinhluong.Columns[2].HeaderText = "Số Ca";
            dgv_tinhluong.Columns[3].HeaderText = "Ngày";
            dgv_tinhluong.Columns[4].HeaderText = "Ghi Chú";
            dgv_tinhluong.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void frmLuong_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(DB.ConnectString);
            connection.Open();
            load_data();
        }
        private void bt_them_Click_1(object sender, EventArgs e)
        {
            if (txtmanhanvien.Text != "" && txtTenNV.Text != "" && txtsoca.Text != "")
            {
                MessageBox.Show("Bạn Chưa Nhập Đầy Đủ Thông Tin", "Err", MessageBoxButtons.OK);
            }
            else
            {
                string sqlADD = "INSERT INTO LUONG(MaNV, TenNV, SoCa, TongTien, NgayNhan) VALUES(@MaNV, @TenNV, @SoCa, @TongTien, @NgayNhan)";
                SqlCommand cmd = new SqlCommand(sqlADD, connection);
                cmd.Parameters.AddWithValue("@MaNV", txtmanhanvien.Text);
                cmd.Parameters.AddWithValue("@TenNV", txtTenNV.Text);
                cmd.Parameters.AddWithValue("@SoCa", txtsoca.Text);
                cmd.Parameters.AddWithValue("@TongTien", txttongtien.Text);
                cmd.Parameters.AddWithValue("@NgayNhan", dtpNgayNhan.Text);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Thêm Thành Công");
                }
                load_data();

                //Làm trống textbox
                txtmanhanvien.Text = "";
                txtTenNV.Text = "";
                txtsoca.Text = "";
                txttongtien.Text = "";
                dtpNgayNhan.Text = "";

            }
        }
        private void bt_sua_Click(object sender, EventArgs e)
        {
            if (txtmanhanvien.Text != "")
            {
                if (txtTenNV.Text != "")
                {
                    string sqlupdate = "UPDATE LUONG SET MaNV = @MaNV, TenNV = @TenNV, SoCa = @SoCa, TongTien = @TongTien, NgayNhan = @NgayNhan WHERE MaNV = @MaNV";
                    SqlCommand cmd = new SqlCommand(sqlupdate, connection);
                    cmd.Parameters.AddWithValue("@MaNV", txtmanhanvien.Text);
                    cmd.Parameters.AddWithValue("@TenNV", txtTenNV.Text);
                    cmd.Parameters.AddWithValue("@SoCa", txtsoca.Text);
                    cmd.Parameters.AddWithValue("@TongTien", txttongtien.Text);
                    cmd.Parameters.AddWithValue("@NgayNhan", dtpNgayNhan.Text);
                    cmd.ExecuteNonQuery();
                    load_data();
                }
                else
                {
                    MessageBox.Show("Nhap day du thong tin");
                }
            }
            else
            {
                if (txtTenNV.Text != "")
                {
                    DataGridViewRow row = dgv_tinhluong.SelectedRows[0];
                    string maNV = (string)row.Cells["MaNV"].Value;

                    string sqlupdate = "UPDATE LUONG SET MaNV = @MaNV, TenNV = @TenNV, SoCa = @SoCa, TongTien = @TongTien, NgayNhan = @NgayNhan WHERE MaNV = @MaNV";
                    SqlCommand cmd = new SqlCommand(sqlupdate, connection);
                    cmd.Parameters.AddWithValue("@MaNV", maNV);
                    cmd.Parameters.AddWithValue("@TenNV", txtTenNV.Text);
                    cmd.Parameters.AddWithValue("@SoCa", txtsoca.Text);
                    cmd.Parameters.AddWithValue("@TongTien", txttongtien.Text);
                    cmd.Parameters.AddWithValue("@NgayNhan", dtpNgayNhan.Text);
                    cmd.ExecuteNonQuery();
                    load_data();
                }
                else
                {
                    MessageBox.Show("nhap day du thong tin");
                }
            }
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgv_tinhluong.SelectedRows[0];
            string maNV = (string)row.Cells["MaNV"].Value;

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn Xoa mã là " + maNV + " không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string sqlClear = "DELETE LUONG WHERE MaNV = @MaNV";
                SqlCommand cmd = new SqlCommand(sqlClear, connection);
                cmd.Parameters.AddWithValue("@MaNV", maNV);
                cmd.ExecuteNonQuery();
                load_data();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLuong_FormClosing(object sender, FormClosingEventArgs e)
        {
            connection.Close();
        }

        private void dgv_tinhluong_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            int i = dgv_tinhluong.CurrentRow.Index;
            txtmanhanvien.Text = dgv_tinhluong.Rows[i].Cells[0].Value.ToString();
            txtTenNV.Text = dgv_tinhluong.Rows[i].Cells[1].Value.ToString();
            txtsoca.Text = dgv_tinhluong.Rows[i].Cells[2].Value.ToString();
            txttongtien.Text = dgv_tinhluong.Rows[i].Cells[3].Value.ToString();
            dtpNgayNhan.Text = dgv_tinhluong.Rows[i].Cells[4].Value.ToString();
        }
    }
}
