#region
using System;
using System.Windows.Forms;
using BUS;
#endregion

namespace QuanLyThuVien
{
    public partial class frmNhaCungCap : Form
    {
        private readonly NCC_BUS NCC_bus = new NCC_BUS();

        public frmNhaCungCap()
        {
            InitializeComponent();
        }

        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            dgvNCC.DataSource = NCC_bus.getNCC();
        }
    }
}