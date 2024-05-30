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
    public partial class frmPhieuXuat : Form
    {
        public frmPhieuXuat()
        {
            InitializeComponent();
        }

        public void load()
        {
            SqlConnection conn = new SqlConnection(DB.ConnectString);
            try
            {
                conn.Open();
                string sql = "Select * from PHIEUXUAT";
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

        private void frmPhieuXuat_Load(object sender, EventArgs e)
        {
            load();
        }

        private void btnOutPX_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Close();
        }

        private void btnThemPX_Click(object sender, EventArgs e)
        {
            int tongTien;
            if (txtMaPX.Text != "" && dtpNgayxuat.Text != "" && txtMaNV.Text != "" && txtMaKH.Text != "" && txtTongTien.Text != "" && (int.TryParse(txtTongTien.Text, out tongTien)))
            {
                SqlConnection conn = new SqlConnection(DB.ConnectString);
                conn.Open();
                string sqlThem = "insert  into PHIEUXUAT values (@MaPX ,@NgayXuat ,@MaNV ,@MaKH ,@TongTien)";
                SqlCommand cmd = new SqlCommand(sqlThem, conn);
                cmd.Parameters.AddWithValue("MaPX", txtMaPX.Text);
                cmd.Parameters.AddWithValue("NgayXuat", dtpNgayxuat.Text);
                cmd.Parameters.AddWithValue("MaNV", txtMaNV.Text);
                cmd.Parameters.AddWithValue("MaKH", txtMaKH.Text);
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

        private void btnXoaPX_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn có muốn xóa", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (thongbao == DialogResult.OK)
            {
                SqlConnection conn = new SqlConnection(DB.ConnectString);

                conn.Open();
                string sql = "delete from PHIEUXUAT where MaPX='" + txtMaPX.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công");
                load();
                conn.Close();
            }
        }

        private void btnSuaPX_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(DB.ConnectString);
            try
            {
                conn.Open();
                string sql = "Update PHIEUXUAT set NgayXuat= '" + dtpNgayxuat.Text + "' , MaNV=N'" + txtMaNV.Text + "', MaKH=N'" + txtMaKH.Text + "', TongTien='" + txtTongTien.Text + "' where MaPX= '" + txtMaPX.Text + "' ";
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
            txtMaPX.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
			dtpNgayxuat.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtMaNV.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtMaKH.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtTongTien.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtTongTien_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
