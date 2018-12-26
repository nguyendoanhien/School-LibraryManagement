#region
using System;
using System.Windows.Forms;
using BUS;
#endregion

namespace QuanLyThuVien
{
    public partial class frmLoaiDocGia : Form
    {
        public frmLoaiDocGia()
        {
            InitializeComponent();
        }

        private readonly LoaiDocGia_BUS LoaiDocGia_bus = new LoaiDocGia_BUS();

        private void frmLoaiDocGia_Load(object sender, EventArgs e)
        {
            dgvLoaiDG.DataSource = LoaiDocGia_bus.getLoaiDocGia();
        }
    }
}