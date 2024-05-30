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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }
        public void loadMenu()
        {
            SqlConnection conn = new SqlConnection(DB.ConnectString);
            try
            {
                conn.Open();
                string sql = "Select * from MENU";
                SqlDataAdapter dt = new SqlDataAdapter(sql, conn);
                DataTable tb = new DataTable();
                dt.Fill(tb);
                dataGridViewMENU.DataSource = tb;
                dataGridViewMENU.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối" + ex.Message);
            }
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            loadMenu();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(DB.ConnectString);
            try
            {
                if (txtMaThucDon.Text != "" && txtTenThucDon.Text != "" && txtGia.Text != "")
                {
                    conn.Open();
                    string sql = "insert into MENU values('" + txtMaThucDon.Text + "','" + txtTenThucDon + "','" + txtGia.Text + "')";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    int kp = (int)cmd.ExecuteNonQuery();
                    if (kp > 0)
                    {
                        MessageBox.Show("Thêm thành công");
                        loadMenu();
                    }
                    else
                        MessageBox.Show("Thêm thất bại");
                    conn.Close();

                }
                else
                    MessageBox.Show("Chưa nhập đủ thông tin");


            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối" + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(DB.ConnectString);
            try
            {
                conn.Open();
                string sql = "Update MENU set Gia= '" + txtGia.Text + "' , TenThucDon=N'" + txtTenThucDon.Text + "'  where MaThucDon= '" + txtMaThucDon.Text + "' ";
                SqlCommand cmd = new SqlCommand(sql, conn);
                int kp = (int)cmd.ExecuteNonQuery();
                if (kp > 0)
                {
                    MessageBox.Show("Sửa thành công");
                    loadMenu();
                }
                else
                    MessageBox.Show("Sửa thất bại");

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối" + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult thongbao = MessageBox.Show("Bạn có muốn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (thongbao == DialogResult.Yes)
            {
                SqlConnection conn = new SqlConnection(DB.ConnectString);

                conn.Open();
                string sql = "delete from MENU where MaThucDon='" + txtMaThucDon.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công");
                loadMenu();
                conn.Close();
            }
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtMaThucDon.Clear();
            txtTenThucDon.Clear();
            txtGia.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Close();
        }

        private void dataGridViewMENU_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            txtMaThucDon.Text = dataGridViewMENU.CurrentRow.Cells[0].Value.ToString();
            txtTenThucDon.Text = dataGridViewMENU.CurrentRow.Cells[1].Value.ToString();
            txtGia.Text = dataGridViewMENU.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
