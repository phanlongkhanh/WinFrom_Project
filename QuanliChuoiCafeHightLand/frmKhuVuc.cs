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
    public partial class frmKhuVuc : Form
    {
        public frmKhuVuc()
        {
            InitializeComponent();
        }
        SqlConnection connection;
        void load_data()
        {
            string sqlSelect = "SELECT *, '' FROM KHUVUC";
            SqlCommand command = new SqlCommand(sqlSelect, connection);
            SqlDataReader reader = command.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            dgv_listKV.DataSource = table;
            dgv_listKV.Columns[0].HeaderText = "Mã khu vực";
            dgv_listKV.Columns[1].HeaderText = "Tên khu vực";
            dgv_listKV.Columns[2].HeaderText = "Ghi chú";
            dgv_listKV.Columns[0].Width = 200;
            dgv_listKV.Columns[1].Width = 200;
            dgv_listKV.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void frmKhuVuc_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(DB.ConnectString);
            connection.Open();
            load_data();
        }

        private void btn_themKV_Click(object sender, EventArgs e)
        {

            if (txt_MaKV.Text != "" && txt_tenKV.Text != "")
            {
                string sqlADD = "insert into KHUVUC values (@MaKhuVuc, @TenKhuVuc)";
                SqlCommand cmd = new SqlCommand(sqlADD, connection);
                cmd.Parameters.AddWithValue("@MaKhuVuc", txt_MaKV.Text);
                cmd.Parameters.AddWithValue("@TenKhuVuc", txt_tenKV.Text);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Cập Nhật Thành Công");
                }
                load_data();

                //Làm trống textbox
                txt_MaKV.Text = "";
                txt_tenKV.Text = "";
            }
            else
            {
                MessageBox.Show("Điền Mã khu vực và tên khu vực");
            }
        }

        private void btn_thoatKV_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_xoaKV_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgv_listKV.SelectedRows[0];
            string maKV = (string)row.Cells["MaKhuVuc"].Value;

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa khu vực có mã là " + maKV + " không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string sqlClear = "DELETE FROM KHUVUC WHERE @MaKhuVuc = MaKhuVuc";
                SqlCommand cmd = new SqlCommand(sqlClear, connection);
                cmd.Parameters.AddWithValue("@MaKhuVuc", maKV);
                cmd.ExecuteNonQuery();
                load_data();
            }
        }

        private void btn_capnhatKV_Click(object sender, EventArgs e)
        {
            if (txt_MaKV.Text != "")
            {
                if (txt_tenKV.Text != "")
                {
                    string sqlupdate = "UPDATE KHUVUC SET TenKhuVuc = @TenKhuVuc WHERE MaKhuVuc = @MaKhuVuc";
                    SqlCommand cmd = new SqlCommand(sqlupdate, connection);
                    cmd.Parameters.AddWithValue("@MaKhuVuc", txt_MaKV.Text);
                    cmd.Parameters.AddWithValue("@TenKhuVuc", txt_tenKV.Text);
                    cmd.ExecuteNonQuery();
                    load_data();
                }
                else
                {
                    MessageBox.Show("Điền tên khu vực");
                }
            }
            else
            {
                if (txt_tenKV.Text != "")
                {
                    DataGridViewRow row = dgv_listKV.SelectedRows[0];
                    string maKV = (string)row.Cells["MaKhuVuc"].Value;

                    string sqlupdate = "UPDATE KHUVUC SET TenKhuVuc = @TenKhuVuc WHERE MaKhuVuc = @MaKhuVuc";
                    SqlCommand cmd = new SqlCommand(sqlupdate, connection);
                    cmd.Parameters.AddWithValue("@MaKhuVuc", maKV);
                    cmd.Parameters.AddWithValue("@TenKhuVuc", txt_tenKV.Text);
                    cmd.ExecuteNonQuery();
                    load_data();
                }
                else
                {
                    MessageBox.Show("Điền tên khu vực");
                }
            }

        }

        private void btn_timkiemKV_Click(object sender, EventArgs e)
        {
            //Làm mới data
            load_data();

            string strFind = "SELECT *, '' FROM KHUVUC WHERE MaKhuVuc = @MaKhuVuc";
            SqlCommand command = new SqlCommand(strFind, connection);

            command.Parameters.AddWithValue("MaKhuVuc", txt_timkiemKV.Text);
            command.Parameters.AddWithValue("TenKhuVuc", txt_tenKV.Text);

            command.ExecuteNonQuery();

            SqlDataReader reader = command.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader); 
            dgv_listKV.DataSource = table;
        }

        private void frmKhuVuc_FormClosing(object sender, FormClosingEventArgs e)
        {
            connection.Close();
        }

        private void txt_timkiemKV_TextChanged(object sender, EventArgs e)
        {
            if (txt_timkiemKV.Text != "")
            {
                string strFind = "SELECT *, '' FROM KHUVUC WHERE MaKhuVuc = @MaKhuVuc";
                SqlCommand command = new SqlCommand(strFind, connection);

                command.Parameters.AddWithValue("MaKhuVuc", txt_timkiemKV.Text);
                command.Parameters.AddWithValue("TenKhuVuc", txt_tenKV.Text);

                command.ExecuteNonQuery();

                SqlDataReader reader = command.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(reader);
                dgv_listKV.DataSource = table;
            }
            else
            {
                load_data();
            }
                
        }

        private void dgv_listKV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
