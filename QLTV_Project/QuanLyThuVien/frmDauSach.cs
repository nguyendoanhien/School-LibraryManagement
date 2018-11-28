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
    public partial class frmDauSach : Form
    {
        DauSach_BUS dausach_bus = new DauSach_BUS();
        public frmDauSach()
        {
            InitializeComponent();
        }


        public void LoadDauSach()
        {
            dgvDSDauSach.DataSource = dausach_bus.LoadDauSach();
        }

        private void frmDauSach_Load(object sender, EventArgs e)
        {
            LoadDauSach();
        }

        private void dgvDSDauSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //int index = dgvDSDauSach.CurrentCell.RowIndex;
            //String dgvselected = dgvDSDauSach.Rows[index].Cells[0].Value.ToString().Trim();
            //MessageBox.Show(dgvselected);
            DataGridView dgv = sender as DataGridView;
            if (dgvDSDauSach == null)
                return;
            if (dgvDSDauSach.CurrentRow.Selected)
            {
                int index = dgvDSDauSach.CurrentCell.RowIndex;
                String dgvselected = dgvDSDauSach.Rows[index].Cells[0].Value.ToString().Trim();
                MessageBox.Show(dgvselected);
            }
        }
    }
}
