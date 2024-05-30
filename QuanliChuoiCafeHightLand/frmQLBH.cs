using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanliChuoiCafeHightLand
{
    public partial class frmQLBH : Form
    {
        public frmQLBH()
        {
            InitializeComponent();
        }

        private void tsmiDangXuat_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.ShowDialog();
			this.Close();
		}

        private void tsmiNhanVien_Click(object sender, EventArgs e)
        {
            frmNhanVien nv = new frmNhanVien();
            nv.ShowDialog();
          
            nv.StartPosition = FormStartPosition.CenterScreen;
        }

        private void tsmiKhachHang_Click(object sender, EventArgs e)
        {
            frmKhachHang kh = new frmKhachHang();   
            kh.ShowDialog();
		
			kh.StartPosition = FormStartPosition.CenterScreen;
		}

        private void tsmiKho_Click(object sender, EventArgs e)
        {
            frmKho k = new frmKho();    
            k.ShowDialog();
			
			k.StartPosition = FormStartPosition.CenterScreen;
		}

        private void tsmiBan_Click(object sender, EventArgs e)
        {
            frmBan b = new frmBan();
            b.ShowDialog();
			
			b.StartPosition = FormStartPosition.CenterScreen;
		}

        private void tsmiKhuVuc_Click(object sender, EventArgs e)
        {
            frmKhuVuc kv = new frmKhuVuc();
            kv.ShowDialog();
			
			kv.StartPosition = FormStartPosition.CenterScreen;
		}

        private void tsmiDoanhThu_Click(object sender, EventArgs e)
        {
		}

        private void tsmiCaLamViec_Click(object sender, EventArgs e)
        {
            frmCalamviec clv = new frmCalamviec();
            clv.ShowDialog();
        }

        private void tsmiLuong_Click(object sender, EventArgs e)
        {
            frmLuong l = new frmLuong();
            l.ShowDialog();
        }

        private void tsmiBaoCaoTK_Click(object sender, EventArgs e)
        {
            frmBaoCaoThongKe bctk = new frmBaoCaoThongKe();
            bctk.ShowDialog();
        }

        private void tsmiHoaDon_Click(object sender, EventArgs e)
        {
            frmHoaDon hd = new frmHoaDon();
            hd.ShowDialog();
        }

        private void tsmiThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ban chac chan muon thoat", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void tsmiMenu_Click(object sender, EventArgs e)
        {
            frmMenu mn = new frmMenu();
            mn.ShowDialog();
        }

		private void goiMonToolStripMenuItem_Click(object sender, EventArgs e)
		{
            frmMenuOder oder = new frmMenuOder();
            oder.ShowDialog();
			oder.StartPosition = FormStartPosition.CenterScreen;
		}


		private void thôngTinNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmReportDanhSachNhanVien rptdsnv = new frmReportDanhSachNhanVien();
			rptdsnv.ShowDialog();
		}

		private void caLàmViệcToolStripMenuItem_Click(object sender, EventArgs e)
		{
            frmReportDanhSachCaLamViec rptDanhSachCaLamViec = new frmReportDanhSachCaLamViec();
            rptDanhSachCaLamViec.ShowDialog();
		}

		private void inThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}
	}
}
