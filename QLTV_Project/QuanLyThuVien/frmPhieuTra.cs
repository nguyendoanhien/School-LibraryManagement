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
    public partial class frmPhieuTra : Form
    {
        public frmPhieuTra()
        {
            InitializeComponent();
            HienThi();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        PhieuTra_BUS phieuTra_BUS = new PhieuTra_BUS();
        public void HienThi()
        {
            lblMaPhieuTra.Text = phieuTra_BUS.MaPhieuTra() + "";
        }

        public void HienThiSachDangMuon()
        {

        }
    }
}
