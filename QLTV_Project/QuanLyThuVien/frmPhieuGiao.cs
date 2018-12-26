#region
using System;
using System.Windows.Forms;
#endregion

namespace QuanLyThuVien
{
    public partial class frmPhieuGiao : Form
    {
        public frmPhieuGiao()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}