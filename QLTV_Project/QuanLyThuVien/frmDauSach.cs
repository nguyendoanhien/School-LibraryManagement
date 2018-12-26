#region
using System;
using System.Windows.Forms;
using BUS;
#endregion

namespace QuanLyThuVien
{
    public partial class frmDauSach : Form
    {
        private DauSach_BUS dausach_bus = new DauSach_BUS();

        public frmDauSach()
        {
            InitializeComponent();
        }

        public void LoadDauSach()
        {
            dgvDSDauSach.DataSource = DauSach_BUS.LoadDauSach();
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
            var dgv = sender as DataGridView;
            if (dgvDSDauSach == null)
                return;
            if (dgvDSDauSach.CurrentRow.Selected)
            {
                var index = dgvDSDauSach.CurrentCell.RowIndex;
                var dgvselected = dgvDSDauSach.Rows[index].Cells[0].Value.ToString().Trim();
                MessageBox.Show(dgvselected);
            }
        }
    }
}