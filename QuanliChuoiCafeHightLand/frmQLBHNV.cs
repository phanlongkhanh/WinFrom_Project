using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanliChuoiCafeHightLand
{
    public partial class frmQLBHNV : Form
    {
        public frmQLBHNV()
        {
            InitializeComponent();
        }

		private void menuOderToolStripMenuItem_Click(object sender, EventArgs e)
		{
            frmMenuOder oder = new frmMenuOder();
            oder.Show();
		}

		private void toolStripComboBox1_Click(object sender, EventArgs e)
		{

		}

		private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmLogin login = new frmLogin();
			login.ShowDialog();
			this.Close();
		}
	}
}
