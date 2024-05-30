using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanliChuoiCafeHightLand
{
    public partial class frmBan : Form
    {
        public frmBan()
        {
            InitializeComponent();
        }

        SqlConnection connection;

        void load_data()
        {
            string sqlSelect = "select MaBan, TenBan, MaKhuVuc, TenKhuVuc = (SELECT TenKhuVuc FROM KHUVUC WHERE KHUVUC.MaKhuVuc = BAN.MaKhuVuc), '' from BAN";
            SqlCommand command = new SqlCommand(sqlSelect, connection);
            SqlDataReader reader = command.ExecuteReader();
            DataTable table = new DataTable();

            table.Load(reader);

            dgv_listBan.DataSource = table;
            dgv_listBan.Columns[0].HeaderText = "Mã bàn";
            dgv_listBan.Columns[1].HeaderText = "Tên bàn";
            dgv_listBan.Columns[2].HeaderText = "Mã khu vực";
            dgv_listBan.Columns[3].HeaderText = "Tên khu vực";
            dgv_listBan.Columns[4].HeaderText = "Ghi chú";
            dgv_listBan.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }
        private void btnTroVe_Click(object sender, EventArgs e)
		{
            this.Close();
        }

		private void frmBan_Load(object sender, EventArgs e)
		{
            connection = new SqlConnection(DB.ConnectString);
            connection.Open();
            load_data();
        }

		private void btn_clearBan_Click(object sender, EventArgs e)
		{
            DataGridViewRow row = dgv_listBan.SelectedRows[0];
            string maBan = (string)row.Cells["MaBan"].Value;

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa bàn " + maBan + " không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string sqlClear = "delete from BAN where @MaBan= MaBan";
                SqlCommand cmd = new SqlCommand(sqlClear, connection);
                cmd.Parameters.AddWithValue("@MaBan", maBan);
                cmd.Parameters.AddWithValue("@TenBan", txt_tenBan.Text);
                cmd.Parameters.AddWithValue("@MaKhuVuc", txt_maKhuVuc.Text);
                cmd.ExecuteNonQuery();
                load_data();
            }
        }

		private void btn_updateBan_Click(object sender, EventArgs e)
		{

            if (txt_tenBan.Text != "" && txt_maKhuVuc.Text != "")
            {
                string sqlUpdate = "update BAN set TenBan = @TenBan, MaKhuVuc = @MaKhuVuc where MaBan = @MaBan";
                SqlCommand cmd = new SqlCommand(sqlUpdate, connection);
                cmd.Parameters.AddWithValue("@MaBan", txt_maBan.Text);
                cmd.Parameters.AddWithValue("@TenBan", txt_tenBan.Text);
                cmd.Parameters.AddWithValue("@MaKhuVuc", txt_maKhuVuc.Text);
                cmd.ExecuteNonQuery();
                load_data();
            }
            else
            {
                MessageBox.Show("Điền đầy đủ thông tin bàn");
            }

        }

		private void btn_addBan_Click(object sender, EventArgs e)
		{
            if (txt_maBan.Text != "" && txt_tenBan.Text != "" && txt_maKhuVuc.Text != "")
            {
                string sqlADD = "insert into BAN values (@MaBan, @TenBan, @MaKhuVuc)";
                SqlCommand cmd = new SqlCommand(sqlADD, connection);
                cmd.Parameters.AddWithValue("@MaBan", txt_maBan.Text);
                cmd.Parameters.AddWithValue("@TenBan", txt_tenBan.Text);
                cmd.Parameters.AddWithValue("@MaKhuVuc", txt_maKhuVuc.Text);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Cập Nhật Thành Công");
                }
                load_data();

                //Làm trống textbox
                txt_maBan.Text = "";
                txt_tenBan.Text = "";
                txt_maKhuVuc.Text = "";
            }
            else MessageBox.Show("Điền đầy đủ thông tin bàn");
        }

        private void dgv_listBan_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            int i = dgv_listBan.CurrentRow.Index;
            txt_maBan.Text = dgv_listBan.Rows[i].Cells[0].Value.ToString();
            txt_tenBan.Text = dgv_listBan.Rows[i].Cells[1].Value.ToString();
            txt_maKhuVuc.Text = dgv_listBan.Rows[i].Cells[2].Value.ToString();
        }

        private void bt_find_Click(object sender, EventArgs e)
        {
            string strFind = "select MaBan, TenBan, MaKhuVuc, TenKhuVuc = (SELECT TenKhuVuc FROM KHUVUC WHERE KHUVUC.MaKhuVuc = BAN.MaKhuVuc), '' from BAN where MaBan LIKE @TuKhoa OR TenBan LIKE @TuKhoa OR MaKhuVuc LIKE @TuKhoa";
            SqlCommand cmdFind = new SqlCommand(strFind, connection);
            cmdFind.Parameters.AddWithValue("TuKhoa", "%" + txt_find.Text + "%");
            SqlDataReader reader = cmdFind.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            dgv_listBan.DataSource = table;
        }

        private void txt_find_TextChanged(object sender, EventArgs e)
        {
            if (txt_find.Text != "")
            {
                string strFind = "select MaBan, TenBan, MaKhuVuc, TenKhuVuc = (SELECT TenKhuVuc FROM KHUVUC WHERE KHUVUC.MaKhuVuc = BAN.MaKhuVuc), '' from BAN where MaBan LIKE @TuKhoa OR TenBan LIKE @TuKhoa OR MaKhuVuc LIKE @TuKhoa";
                SqlCommand cmdFind = new SqlCommand(strFind, connection);
                cmdFind.Parameters.AddWithValue("TuKhoa", "%" + txt_find.Text + "%");
                SqlDataReader reader = cmdFind.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(reader);
                dgv_listBan.DataSource = table;
            }
            else load_data();
        }

        private void dgv_listBan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_find_Click(object sender, EventArgs e)
        {
            if (txt_find.Text == "Nhập từ khóa cần tìm")
            { txt_find.Text = ""; }
        }

        private void txt_maBan_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
