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
    public partial class frmBaoCaoThongKe : Form
    {
        SqlConnection conn;
        public frmBaoCaoThongKe()
        {
            InitializeComponent();
        }
        private void BaoCao_Load(object sender, EventArgs e)
        {
            dtp_TuNgay.Format = DateTimePickerFormat.Custom;
            dtp_TuNgay.CustomFormat = "dd/MM/yyyy";
            dtp_Denngay.Format = DateTimePickerFormat.Custom;
            dtp_Denngay.CustomFormat = "dd/MM/yyyy";

        }
        private void btnXemBaoCao_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(DB.ConnectString);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "BaoCaoDoanhThu";
            cmd.Parameters.AddWithValue("@TuNgay", dtp_TuNgay.Value.ToString("yyyy-MM-dd "));
            cmd.Parameters.AddWithValue("@DenNgay", dtp_Denngay.Value.ToString("yyyy-MM-dd "));
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgvBaoCao.DataSource = table;
            conn.Close();

            txt_TongCong.Text = TinhTong();
        }

        private string TinhTong()
        {
            try
            {
                conn = new SqlConnection(DB.ConnectString);
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "TinhTongThanhTien";
                cmd.Parameters.AddWithValue("@TuNgay", dtp_TuNgay.Value.ToString("yyyy-MM-dd "));
                cmd.Parameters.AddWithValue("@DenNgay", dtp_Denngay.Value.ToString("yyyy-MM-dd "));
                var data = cmd.ExecuteScalar().ToString();
                conn.Close();
                return data;
            }
            catch (Exception ex)
            {
                return "0";
            }

        }
    }
}
