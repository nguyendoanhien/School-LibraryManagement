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
    public partial class frmPhieuNhap : Form
    {
        PhieuNhap_BUS phieunhap_bus = new PhieuNhap_BUS();
        public frmPhieuNhap()
        {
            
            InitializeComponent();
            lblMaPhieuNhap.Text = phieunhap_bus.MaPhieuNhap()+"";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();

        }
        private void btnDSNCC_Click(object sender, EventArgs e)
        {
            frmNhaCungCap frm = new frmNhaCungCap();
            if(frm.ShowDialog() == DialogResult.OK )
            {
               
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void btnDSDauSach_Click(object sender, EventArgs e)
        {
            frmDauSach frm = new frmDauSach();
            if(frm.ShowDialog() == DialogResult.OK)
            {
                int index = frm.dgvDSDauSach.CurrentCell.RowIndex; 
                String dgvselected = frm.dgvDSDauSach.Rows[index].Cells[0].Value.ToString().Trim();
                MessageBox.Show(dgvselected);
            }
        }
    }
}
