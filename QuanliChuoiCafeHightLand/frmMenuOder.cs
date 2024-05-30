using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;
using System.Diagnostics;

namespace QuanliChuoiCafeHightLand
{
	public partial class frmMenuOder : Form
	{
		public frmMenuOder()
		{
			InitializeComponent();
		}
		string strconn = DB.ConnectString;
		SqlConnection conn = null;
		SqlDataAdapter sqladt;
		SqlCommand comm;
		DataTable data;
		
		private void frmMenuOder_Load(object sender, EventArgs e)
		{

			
		}

		private void lvThongTin_SelectedIndexChanged(object sender, EventArgs e)
		{
			int dong = lvThongTin.SelectedIndices[0];
			nbSuaSoLuong.Value = lvThongTin.Items[dong].SubItems[1].ToString().Length-18;
		}
		private void btnThemMon1_Click(object sender, EventArgs e)
		{
			if (nb1.Value.ToString() == "0")
			{
				MessageBox.Show("Vui Lòng Chọn Số Lượng !", "Err", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{		
				ListViewItem item = lvThongTin.Items.Add(lb1.Text);
				item.SubItems.Add(nb1.Value.ToString());
				item.SubItems.Add("29000");
				string giatien = txtMatCha.Text;
				float giaso = float.Parse(giatien);
				int soluong = int.Parse(nb1.Value.ToString());
				double TongGia = giaso * soluong;
				item.SubItems.Add(TongGia.ToString());
				nb1.Value = 0;
				int sum = 0;
				foreach (ListViewItem item1 in lvThongTin.Items)
				{
					int thanhtien = Convert.ToInt32(item1.SubItems[3].Text);
					sum += thanhtien;

				}
				txtThanhtien.Text = sum.ToString();
				txtTongTien.Text = sum.ToString("c");
			}
		}

		private void btnThemMon2_Click(object sender, EventArgs e)
		{

			if (nb2.Value.ToString() == "0")
			{
				MessageBox.Show("Vui Lòng Chọn Số Lượng !", "Err", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				ListViewItem item = lvThongTin.Items.Add(lb2.Text);
				item.SubItems.Add(nb2.Value.ToString());
				item.SubItems.Add(txtHongTra.Text);
				string giatien = txtHongTra.Text;
				float giaso = float.Parse(giatien);
				int soluong = int.Parse(nb2.Value.ToString());
				double TongGia = giaso * soluong;
				item.SubItems.Add(TongGia.ToString());
				nb2.Value = 0;
				int sum = 0;
				foreach (ListViewItem item1 in lvThongTin.Items)
				{
					int thanhtien = Convert.ToInt32(item1.SubItems[3].Text);
					sum += thanhtien;

				}
				txtThanhtien.Text = sum.ToString();
                txtTongTien.Text = sum.ToString("c");
            }
		}

		private void btnThemMon3_Click(object sender, EventArgs e)
		{

			if (nb3.Value.ToString() == "0")
			{
				MessageBox.Show("Vui Lòng Chọn Số Lượng !", "Err", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				ListViewItem item = lvThongTin.Items.Add(lb3.Text);
				item.SubItems.Add(nb3.Value.ToString());
				item.SubItems.Add(txtTDCS.Text);
				string giatien = txtTDCS.Text;
				float giaso = float.Parse(giatien);
				int soluong = int.Parse(nb3.Value.ToString());
				double TongGia = giaso * soluong;
				item.SubItems.Add(TongGia.ToString());
				nb3.Value = 0;
				int sum = 0;
				foreach (ListViewItem item1 in lvThongTin.Items)
				{
					int thanhtien = Convert.ToInt32(item1.SubItems[3].Text);
					sum += thanhtien;

				}
				txtThanhtien.Text = sum.ToString();
				txtTongTien.Text = sum.ToString("c");
			}
		}

		private void btnThemMon4_Click(object sender, EventArgs e)
		{

			if (nb4.Value.ToString() == "0")
			{
				MessageBox.Show("Vui Lòng Chọn Số Lượng !", "Err", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				ListViewItem item = lvThongTin.Items.Add(lb4.Text);
				item.SubItems.Add(nb4.Value.ToString());
				item.SubItems.Add(txtSoda.Text);
				string giatien = txtSoda.Text;
				float giaso = float.Parse(giatien);
				int soluong = int.Parse(nb4.Value.ToString());
				double TongGia = giaso * soluong;
				item.SubItems.Add(TongGia.ToString());
				nb4.Value = 0;
				int sum = 0;
				foreach (ListViewItem item1 in lvThongTin.Items)
				{
					int thanhtien = Convert.ToInt32(item1.SubItems[3].Text);
					sum += thanhtien;

				}
				txtThanhtien.Text = sum.ToString();
				txtTongTien.Text = sum.ToString("c");
			}
		}

		private void btnThemMon5_Click(object sender, EventArgs e)
		{

			if (nb5.Value.ToString() == "0")
			{
				MessageBox.Show("Vui Lòng Chọn Số Lượng !", "Err", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				ListViewItem item = lvThongTin.Items.Add(lb5.Text);
				item.SubItems.Add(nb5.Value.ToString());
				item.SubItems.Add(txtBacXiu.Text);
				string giatien = txtBacXiu.Text;
				float giaso = float.Parse(giatien);
				int soluong = int.Parse(nb5.Value.ToString());
				double TongGia = giaso * soluong;
				item.SubItems.Add(TongGia.ToString());
				nb5.Value = 0;
				int sum = 0;
				foreach (ListViewItem item1 in lvThongTin.Items)
				{
					int thanhtien = Convert.ToInt32(item1.SubItems[3].Text);
					sum += thanhtien;

				}
				txtThanhtien.Text = sum.ToString();
				txtTongTien.Text = sum.ToString("c");
			}
		}

		private void btnThemMon6_Click(object sender, EventArgs e)
		{

			if (nb6.Value.ToString() == "0")
			{
				MessageBox.Show("Vui Lòng Chọn Số Lượng !", "Err", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				ListViewItem item = lvThongTin.Items.Add(lb6.Text);
				item.SubItems.Add(nb6.Value.ToString());
				item.SubItems.Add(txtCafeSua.Text);
				string giatien = txtCafeSua.Text;
				float giaso = float.Parse(giatien);
				int soluong = int.Parse(nb6.Value.ToString());
				double TongGia = giaso * soluong;
				item.SubItems.Add(TongGia.ToString());
				nb6.Value = 0;
				int sum = 0;
				foreach (ListViewItem item1 in lvThongTin.Items)
				{
					int thanhtien = Convert.ToInt32(item1.SubItems[3].Text);
					sum += thanhtien;

				}
				txtThanhtien.Text = sum.ToString();
				txtTongTien.Text = sum.ToString("c");
			}
		}

		private void btnThemMon7_Click(object sender, EventArgs e)
		{

			if (nb7.Value.ToString() == "0")
			{
				MessageBox.Show("Vui Lòng Chọn Số Lượng !", "Err", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				ListViewItem item = lvThongTin.Items.Add(lb7.Text);
				item.SubItems.Add(nb7.Value.ToString());
				item.SubItems.Add(txtCPCN.Text);
				string giatien = txtCPCN.Text;
				float giaso = float.Parse(giatien);
				int soluong = int.Parse(nb7.Value.ToString());
				double TongGia = giaso * soluong;
				item.SubItems.Add(TongGia.ToString());
				nb7.Value = 0;
				int sum = 0;
				foreach (ListViewItem item1 in lvThongTin.Items)
				{
					int thanhtien = Convert.ToInt32(item1.SubItems[3].Text);
					sum += thanhtien;

				}
				txtThanhtien.Text = sum.ToString();
				txtTongTien.Text = sum.ToString("c");
			}
		}

		private void btnThemMon8_Click(object sender, EventArgs e)
		{

			if (nb8.Value.ToString() == "0")
			{
				MessageBox.Show("Vui Lòng Chọn Số Lượng !", "Err", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				ListViewItem item = lvThongTin.Items.Add(lb8.Text);
				item.SubItems.Add(nb8.Value.ToString());
				item.SubItems.Add(txtTraDau.Text);
				string giatien = txtTraDau.Text;
				float giaso = float.Parse(giatien);
				int soluong = int.Parse(nb8.Value.ToString());
				double TongGia = giaso * soluong;
				item.SubItems.Add(TongGia.ToString());
				nb8.Value = 0;
				int sum = 0;
				foreach (ListViewItem item1 in lvThongTin.Items)
				{
					int thanhtien = Convert.ToInt32(item1.SubItems[3].Text);
					sum += thanhtien;

				}
				txtThanhtien.Text = sum.ToString();
				txtTongTien.Text = sum.ToString("c");
			}
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			if (lvThongTin.SelectedItems.Count == 0)
			{
				// Hiển thị thông báo lỗi
				MessageBox.Show("Bạn chưa chọn item nào để xóa!");
				return;
			}
			// Xóa item được chọn
			while(lvThongTin.SelectedItems.Count == 1)
			{
				int count = lvThongTin.Items.Count;
				for (int i = 0; i < count; i++)
				{
					lvThongTin.Items.RemoveAt(i);
				}
				return;
			}
			

		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			// Kiểm tra xem có item nào được chọn hay không
			if (lvThongTin.SelectedItems.Count == 0)
			{
				// Hiển thị thông báo lỗi
				MessageBox.Show("Bạn chưa chọn item nào để sửa!");
				return;
			}
			if (nbSuaSoLuong.Value == 0)
			{
				MessageBox.Show("Vui Lòng Chọn Số Lượng !", "Error", MessageBoxButtons.OK);
			}
			else
			{
				int sum = 0;
				// Lấy item được chọn
				ListViewItem item = lvThongTin.SelectedItems[0];
				// Lấy giá trị của các subitem		
				item.SubItems[1].Text = nbSuaSoLuong.Value.ToString();
				int giatien = int.Parse(item.SubItems[1].Text) * int.Parse(item.SubItems[2].Text);
				item.SubItems[3].Text = giatien.ToString();
				sum += int.Parse(item.SubItems[1].Text) * int.Parse(item.SubItems[2].Text);
				txtThanhtien.Text = sum.ToString();
				int doigiatri = int.Parse(txtThanhtien.Text);
				txtTongTien.Text = doigiatri.ToString("c");
				nbSuaSoLuong.Value = 0;
			}
			
		}
		private void btnThemMon9_Click(object sender, EventArgs e)
		{
			if (nb9.Value.ToString() == "0")
			{
				MessageBox.Show("Vui Lòng Chọn Số Lượng !", "Err", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				ListViewItem item = lvThongTin.Items.Add(lb9.Text);
				item.SubItems.Add(nb9.Value.ToString());
				item.SubItems.Add(txtBTC.Text);
				string giatien = txtBTC.Text;
				float giaso = float.Parse(giatien);
				int soluong = int.Parse(nb9.Value.ToString());
				double TongGia = giaso * soluong;
				item.SubItems.Add(TongGia.ToString());
				nb9.Value = 0;
				int sum = 0;
				foreach (ListViewItem item1 in lvThongTin.Items)
				{
					int thanhtien = Convert.ToInt32(item1.SubItems[3].Text);
					sum += thanhtien;

				}
				txtThanhtien.Text = sum.ToString();
				txtTongTien.Text = sum.ToString("c");
			}
		}

		private void btnThemMon10_Click(object sender, EventArgs e)
		{
			if (nb10.Value.ToString() == "0")
			{
				MessageBox.Show("Vui Lòng Chọn Số Lượng !", "Err", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				ListViewItem item = lvThongTin.Items.Add(lb10.Text);
				item.SubItems.Add(nb10.Value.ToString());
				item.SubItems.Add(txtBanhPlan.Text);
				string giatien = txtBanhPlan.Text;
				float giaso = float.Parse(giatien);
				int soluong = int.Parse(nb10.Value.ToString());
				double TongGia = giaso * soluong;
				item.SubItems.Add(TongGia.ToString());
				nb10.Value = 0;
				int sum = 0;
				foreach (ListViewItem item1 in lvThongTin.Items)
				{
					int thanhtien = Convert.ToInt32(item1.SubItems[3].Text);
					sum += thanhtien;

				}
				txtThanhtien.Text = sum.ToString();
				txtTongTien.Text = sum.ToString("c");
			}
		}

		private void btnThemMon11_Click(object sender, EventArgs e)
		{
			if (nb11.Value.ToString() == "0")
			{
				MessageBox.Show("Vui Lòng Chọn Số Lượng !", "Err", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				ListViewItem item = lvThongTin.Items.Add(lb11.Text);
				item.SubItems.Add(nb11.Value.ToString());
				item.SubItems.Add(txtSuKem.Text);
				string giatien = txtSuKem.Text;
				float giaso = float.Parse(giatien);
				int soluong = int.Parse(nb11.Value.ToString());
				double TongGia = giaso * soluong;
				item.SubItems.Add(TongGia.ToString());
				nb11.Value = 0;
				int sum = 0;
				foreach (ListViewItem item1 in lvThongTin.Items)
				{
					int thanhtien = Convert.ToInt32(item1.SubItems[3].Text);
					sum += thanhtien;

				}
				txtThanhtien.Text = sum.ToString();
				txtTongTien.Text = sum.ToString("c");
			}
		}

		private void btnThemMon12_Click(object sender, EventArgs e)
		{
			if (nb12.Value.ToString() == "0")
			{
				MessageBox.Show("Vui Lòng Chọn Số Lượng !", "Err", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				ListViewItem item = lvThongTin.Items.Add(lb12.Text);
				item.SubItems.Add(nb12.Value.ToString());
				item.SubItems.Add(txtDonut.Text);
				string giatien = txtDonut.Text;
				float giaso = float.Parse(giatien);
				int soluong = int.Parse(nb12.Value.ToString());
				double TongGia = giaso * soluong;
				item.SubItems.Add(TongGia.ToString());
				nb12.Value = 0;
				int sum = 0;
				foreach (ListViewItem item1 in lvThongTin.Items)
				{
					int thanhtien = Convert.ToInt32(item1.SubItems[3].Text);
					sum += thanhtien;

				}
				txtThanhtien.Text = sum.ToString();
				txtTongTien.Text = sum.ToString("c");
			}
		}

		private void btnThemMon13_Click(object sender, EventArgs e)
		{
			if (nb13.Value.ToString() == "0")
			{
				MessageBox.Show("Vui Lòng Chọn Số Lượng !", "Err", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				ListViewItem item = lvThongTin.Items.Add(lb13.Text);
				item.SubItems.Add(nb13.Value.ToString());
				item.SubItems.Add(txtBLTM.Text);
				string giatien = txtBLTM.Text;
				float giaso = float.Parse(giatien);
				int soluong = int.Parse(nb13.Value.ToString());
				double TongGia = giaso * soluong;
				item.SubItems.Add(TongGia.ToString());
				nb13.Value = 0;
				int sum = 0;
				foreach (ListViewItem item1 in lvThongTin.Items)
				{
					int thanhtien = Convert.ToInt32(item1.SubItems[3].Text);
					sum += thanhtien;

				}
				txtThanhtien.Text = sum.ToString();
				txtTongTien.Text = sum.ToString("c");
			}
		}

		private void btnThemMon14_Click(object sender, EventArgs e)
		{
			if (nb14.Value.ToString() == "0")
			{
				MessageBox.Show("Vui Lòng Chọn Số Lượng !", "Err", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				ListViewItem item = lvThongTin.Items.Add(lb14.Text);
				item.SubItems.Add(nb14.Value.ToString());
				item.SubItems.Add(txtBTC.Text);
				string giatien = txtBTC.Text;
				float giaso = float.Parse(giatien);
				int soluong = int.Parse(nb14.Value.ToString());
				double TongGia = giaso * soluong;
				item.SubItems.Add(TongGia.ToString());
				nb14.Value = 0;
				int sum = 0;
				foreach (ListViewItem item1 in lvThongTin.Items)
				{
					int thanhtien = Convert.ToInt32(item1.SubItems[3].Text);
					sum += thanhtien;

				}
				txtThanhtien.Text = sum.ToString();
				txtTongTien.Text = sum.ToString("c");
			}
		}

		private void btnThemMon15_Click(object sender, EventArgs e)
		{
			if (nb15.Value.ToString() == "0")
			{
				MessageBox.Show("Vui Lòng Chọn Số Lượng !", "Err", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				ListViewItem item = lvThongTin.Items.Add(lb15.Text);
				item.SubItems.Add(nb15.Value.ToString());
				item.SubItems.Add(txtSnack.Text);
				string giatien = txtSnack.Text;
				float giaso = float.Parse(giatien);
				int soluong = int.Parse(nb15.Value.ToString());
				double TongGia = giaso * soluong;
				item.SubItems.Add(TongGia.ToString());
				nb15.Value = 0;
				int sum = 0;
				foreach (ListViewItem item1 in lvThongTin.Items)
				{
					int thanhtien = Convert.ToInt32(item1.SubItems[3].Text);
					sum += thanhtien;

				}
				txtThanhtien.Text = sum.ToString();
				txtTongTien.Text = sum.ToString("c");
			}
		}

		private void btnThemMon16_Click(object sender, EventArgs e)
		{
			if (nb16.Value.ToString() == "0")
			{
				MessageBox.Show("Vui Lòng Chọn Số Lượng !", "Err", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				ListViewItem item = lvThongTin.Items.Add(lb16.Text);
				item.SubItems.Add(nb16.Value.ToString());
				item.SubItems.Add(txtXL.Text);
				string giatien = txtXL.Text;
				float giaso = float.Parse(giatien);
				int soluong = int.Parse(nb16.Value.ToString());
				double TongGia = giaso * soluong;
				item.SubItems.Add(TongGia.ToString());
				nb16.Value = 0;
				int sum = 0;
				foreach (ListViewItem item1 in lvThongTin.Items)
				{
					int thanhtien = Convert.ToInt32(item1.SubItems[3].Text);
					sum += thanhtien;

				}
				txtThanhtien.Text = sum.ToString();
				txtTongTien.Text = sum.ToString("c");
			}
		}
		private void btnApdung_Click(object sender, EventArgs e)
		{
			if (cbbVoucher.Text == "" || txtTongTien.Text == "")
			{
				MessageBox.Show("Áp Dụng Không Thành Công Do Chưa Đủ Thông Dữ Liệu !","Error",MessageBoxButtons.OK);
			}
			else
			{
				int giamgia = 0;
				int sotien = 0;
				if (cbbVoucher.Text == cbbVoucher.Items[0].ToString())
				{
					giamgia = ((int.Parse(txtThanhtien.Text) * 5) / 100);
					sotien = int.Parse(txtThanhtien.Text) - giamgia;
					txtTongTien.Text = sotien.ToString("c");
				}
				if (cbbVoucher.Text == cbbVoucher.Items[1].ToString())
				{
					giamgia = ((int.Parse(txtThanhtien.Text) * 10) / 100);
					sotien = int.Parse(txtThanhtien.Text) - giamgia;
					txtTongTien.Text = sotien.ToString("c");
				}
				if (cbbVoucher.Text == cbbVoucher.Items[2].ToString())
				{
					giamgia = ((int.Parse(txtThanhtien.Text) * 15) / 100);
					sotien = int.Parse(txtThanhtien.Text) - giamgia;
					txtTongTien.Text = sotien.ToString("c");
				}
			}
		}
		private void cbbVoucher_SelectedIndexChanged(object sender, EventArgs e)
		{
			cbbVoucher.Text = "";
		}
		private void txtTongTien_TextChanged(object sender, EventArgs e)
		{

		}
		private void button3_Click(object sender, EventArgs e)
		{
			DialogResult rd = MessageBox.Show("Bạn Có Muốn Thoát Không ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (rd == DialogResult.Yes)
			{
				Close();
			}
		}
		private void btnThanhToan_Click(object sender, EventArgs e)
		{
			
				if (txtTongTien.Text == "" || txtThanhtien.Text == "")
				{
					MessageBox.Show("Không Có Sản Phẩm Để Thanh Toán", "Thông Báo", MessageBoxButtons.OK);
				}
				else
				{
					foreach (ListViewItem item in lvThongTin.Items)
					{
						MessageBox.Show(" Phiếu Hóa Đơn Thanh Toán" + " \n\n\n Tên Sản Phẩm : " + item.SubItems[0].Text + "\n Số Lượng : " + item.SubItems[1].Text + "\n Thành Tiền : " + item.SubItems[3].Text + "\n Voucher : " + cbbVoucher.Text + "\n Tổng Chi Phí Là : " + txtTongTien.Text + "\n\n\n Thanh Toán Thành Công", "Phiếu Thanh Toán", MessageBoxButtons.OK);
					}
					int count = lvThongTin.Items.Count;
					for (int i = 0; i < count; i++)
					{
						lvThongTin.Items.RemoveAt(i);
					}
					nbSuaSoLuong.Value = 0;
					txtThanhtien.Clear();
					txtTongTien.Clear();
					cbbVoucher.Text = "";
					// Thêm Dữ Liệu Vào From hóa Đơn
					DialogResult rd = MessageBox.Show("Bạn Muốn In Hóa Đơn Không ?", "Hóa Đơn", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					if (rd == DialogResult.Yes)
					{
						frmHoaDon hoadon = new frmHoaDon();
						hoadon.Show();
					}
					else
					{
						MessageBox.Show("Thanh Toán Thành Công", "Hóa Đơn", MessageBoxButtons.OK);
					}
				}
			}	
		}
	}

