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
    public partial class frmKho : Form
    {
        public frmKho()
        {
            InitializeComponent();
        }
        public void load()
        {
            SqlConnection conn = new SqlConnection(DB.ConnectString);
            try
            {
                conn.Open();
                string sql = "SELECT *, '' FROM Kho";
                SqlDataAdapter dt = new SqlDataAdapter(sql, conn);
                DataTable tb = new DataTable();
                dt.Fill(tb);
                dataGridView1.DataSource = tb;
                conn.Close();
                dataGridView1.Columns[0].HeaderText = "Mã kho";
                dataGridView1.Columns[1].HeaderText = "Tên kho";
                dataGridView1.Columns[2].HeaderText = "Ghi chú";
                dataGridView1.Columns[1].Width = 250;
                dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối" + ex.Message);
            }
        }

        private void frmKho_Load(object sender, EventArgs e)
        {
            load();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            frmPhieuNhap nhap = new frmPhieuNhap();
            nhap.ShowDialog();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            frmPhieuXuat xuat = new frmPhieuXuat(); 
            xuat.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Close();
        }
    }
}
