using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
namespace QuanLyThuVien
{
    public partial class frmLoaiDocGia : Form
    {
        public frmLoaiDocGia()
        {
            InitializeComponent();
        }

        LoaiDocGia_BUS LoaiDocGia_bus = new LoaiDocGia_BUS();

        private void frmLoaiDocGia_Load(object sender, EventArgs e)
        {
            dgvLoaiDG.DataSource = LoaiDocGia_bus.getLoaiDocGia();
        }
    }
}
