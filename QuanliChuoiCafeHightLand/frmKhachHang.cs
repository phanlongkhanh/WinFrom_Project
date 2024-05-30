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
    public partial class frmKhachHang : Form
    {
        SqlConnection connection;
        public frmKhachHang()
        {
            InitializeComponent();
        }
        void load_data_KH()
        {
            string sqlSelect = "select * from KHACHHANG";
            SqlCommand command = new SqlCommand(sqlSelect, connection);
            SqlDataReader reader = command.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            dgv_list_KH.DataSource = table;
        }

        private void bt_out_KH_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(DB.ConnectString);
            connection.Open();
            load_data_KH();
        }

        private void bt_add_KH_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text != "" && txtTenKH.Text != "" && txtDiachi.Text != "")
            {
                string sqlADD = "insert into KHACHHANG values (@MaKH, @TenKH, @DiaChi, @SDT, @Email, @MaLKH)";
                SqlCommand cmdADD = new SqlCommand(sqlADD, connection);
                cmdADD.Parameters.AddWithValue("@MaKH", txtMaKH.Text);
                cmdADD.Parameters.AddWithValue("@TenKH", txtTenKH.Text);
                cmdADD.Parameters.AddWithValue("@DiaChi", txtDiachi.Text);
                cmdADD.Parameters.AddWithValue("@SDT", txtsdt.Text);
                cmdADD.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmdADD.Parameters.AddWithValue("@MaLKH", txtLoaiKH.Text);

                if (cmdADD.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Thêm Thành Công");
                }
                load_data_KH();

            }
            else
            {
                MessageBox.Show("Thêm không thành công");
            }
        }

        private void bt_update_KH_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlUpdate = "update KHACHHANG set TenKH = @TenKH, DiaChi=@DiaChi, SDT=@SDT,Email= @Email, MaLKH=@MaLKH, MaQuyen=@MaQuyen,TenDangNhap= @TenDangNhap,MatKhau =  @MatKhau where MaKH = @MaKH";
                SqlCommand cmd = new SqlCommand(sqlUpdate, connection);
                cmd.Parameters.AddWithValue("@MaKH", txtMaKH.Text);
                cmd.Parameters.AddWithValue("@TenKH", txtTenKH.Text);
                cmd.Parameters.AddWithValue("@DiaChi", txtDiachi.Text);
                cmd.Parameters.AddWithValue("@SDT", txtsdt.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@MaLKH", txtLoaiKH.Text);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Cập nhật Thành Công");
                }
                load_data_KH();
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Cập nhật không Thành Công " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_clear_KH_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgv_list_KH.SelectedRows[0];
            string maKH = (string)row.Cells["MaKH"].Value;

            DialogResult result = MessageBox.Show("Bạn muốn xóa khách hàng có mã là " + maKH + " không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string sqlClear = "delete from KHACHHANG where @MaKH = MaKH";
                SqlCommand cmd = new SqlCommand(sqlClear, connection);
                cmd.Parameters.AddWithValue("@MaKH", txtMaKH.Text);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Xóa Thành Công");
                }
                load_data_KH();
            }
            else
            {
                MessageBox.Show("Xoa khong thanh cong");
            }
        }

        private void btnFindKH_Click(object sender, EventArgs e)
        {
            string strFind = "select * from KHACHHANG where MaKH = @MaKH";
            SqlCommand cmd = new SqlCommand(strFind, connection);

            cmd.Parameters.AddWithValue("@MaKH", txtMaKH.Text);
            cmd.Parameters.AddWithValue("@TenKH", txtTenKH.Text);
            cmd.Parameters.AddWithValue("@DiaChi", txtDiachi.Text);
            cmd.Parameters.AddWithValue("@SDT", txtsdt.Text);
            cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@MaLKH", txtLoaiKH.Text);

            cmd.ExecuteNonQuery();
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            dgv_list_KH.DataSource = table;
        }

        private void frmKhachHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            connection.Close();
        }

        private void dgv_list_KH_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            int i = 0;
            i = dgv_list_KH.CurrentRow.Index;
            txtMaKH.Text = dgv_list_KH.Rows[i].Cells[0].Value.ToString();
            txtTenKH.Text = dgv_list_KH.Rows[i].Cells[1].Value.ToString();
            txtDiachi.Text = dgv_list_KH.Rows[i].Cells[2].Value.ToString();
            txtsdt.Text = dgv_list_KH.Rows[i].Cells[3].Value.ToString();
            txtEmail.Text = dgv_list_KH.Rows[i].Cells[4].Value.ToString();
            txtLoaiKH.Text = dgv_list_KH.Rows[i].Cells[5].Value.ToString();
      
        }

        private void txtfindKH_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
