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
    public partial class frmPhieuNhap : Form
    {
        public frmPhieuNhap()
        {
            InitializeComponent();
        }
        public void load()
        {
            SqlConnection conn = new SqlConnection(DB.ConnectString);
            try
            {
                conn.Open();
                string sql = "Select * from PHIEUNHAP";
                SqlDataAdapter dt = new SqlDataAdapter(sql, conn);
                DataTable tb = new DataTable();
                dt.Fill(tb);
                dataGridView1.DataSource = tb;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối" + ex.Message);
            }
        }

        private void frmPhieuNhap_Load(object sender, EventArgs e)
        {
            load();
        }

        private void btnThoatPN_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Close();
        }

        private void btnThemPN_Click(object sender, EventArgs e)
        {
            int tongTien;
            if (txtMaPN.Text != "" && dtpNgaynhap.Text != "" && txtMaNV.Text != "" && txtMaNCC.Text != "" && txtTongTien.Text != "" && (int.TryParse(txtTongTien.Text, out tongTien)))
            {
                SqlConnection conn = new SqlConnection(DB.ConnectString);
                conn.Open();
                string sqlThem = "insert  into PHIEUNHAP values (@MaPN ,@NgayNhap ,@MaNV ,@MaNCC ,@TongTien)";
                SqlCommand cmd = new SqlCommand(sqlThem, conn);
                cmd.Parameters.AddWithValue("MaPN", txtMaPN.Text);
                cmd.Parameters.AddWithValue("NgayNhap", dtpNgaynhap.Text);
                cmd.Parameters.AddWithValue("MaNV", txtMaNV.Text);
                cmd.Parameters.AddWithValue("MaNCC", txtMaNCC.Text);
                cmd.Parameters.AddWithValue("TongTien", tongTien);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Cập Nhật Thành Công");
                }
                else MessageBox.Show("Cập nhật thất bại");
                load();
            }
            else MessageBox.Show("Vui lòng điền đầy đủ thông tin");
        }

        private void btnXoaPN_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn có muốn xóa", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (thongbao == DialogResult.OK)
            {
                SqlConnection conn = new SqlConnection(DB.ConnectString);

                conn.Open();
                string sql = "delete from PHIEUNHAP where MaPN='" + txtMaPN.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công");
                load();
                conn.Close();
            }
        }

        private void btnSuaPN_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(DB.ConnectString);
            try
            {
                conn.Open();
                string sql = "Update PHIEUNHAP set NgayNhap= '" + dtpNgaynhap.Text + "' , MaNV=N'" + txtMaNV.Text + "', MaNCC=N'" + txtMaNCC.Text + "', TongTien='" + txtTongTien.Text + "' where MaPN= '" + txtMaPN.Text + "' ";
                SqlCommand cmd = new SqlCommand(sql, conn);
                int kp = (int)cmd.ExecuteNonQuery();
                if (kp > 0)
                {
                    MessageBox.Show("Sửa thành công");
                    load();
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

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            txtMaPN.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            dtpNgaynhap.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtMaNV.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtMaNCC.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtTongTien.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
