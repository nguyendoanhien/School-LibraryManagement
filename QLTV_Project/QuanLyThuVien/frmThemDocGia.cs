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
using DTO;
namespace QuanLyThuVien
{
    public partial class frmThemDocGia : Form
    {
        DocGia_BUS docgia_bus = new DocGia_BUS();
        public frmThemDocGia()
        {
            InitializeComponent();
            int mangdung = docgia_bus.MaMax();
            txtMaDG.Text = mangdung+1+"";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                picBoxAvatar.ImageLocation = ofd.FileName;
            }
        }

        private void frmThemDocGia_Load(object sender, EventArgs e)
        {
            LoaiDocGia_BUS loaidocgia_bus = new LoaiDocGia_BUS();
            foreach (DataRow dr in loaidocgia_bus.LoadCboLoaiDG().Rows)
            {
                cboLoaiDG.Items.Add(dr["TenLoaiDocGia"].ToString());
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            
            Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // check radiobutton
            bool GioiTinh;
            if (rdoGioiTinh.Checked)
                GioiTinh = true;
            else
                GioiTinh =  false;
            //check combobox
            var item = this.cboLoaiDG.GetItemText(this.cboLoaiDG.SelectedItem);
            string loaidg = item.ToString();
                
            
            int maloaidg = int.Parse(docgia_bus.TraVeGiaTriMaLoaiDG(loaidg));
             
            if(txtHoTen.Text != "" || txtEmail.Text != "")
            { 
                NguoiDung ng = new NguoiDung(0, txtHoTen.Text, GioiTinh, txtEmail.Text, dtmNgayTao.Value);
                if(docgia_bus.ThemNguoiDung(ng))
                {
                    int mangdung = docgia_bus.MaMax();
                    DocGia dg = new DocGia(mangdung, maloaidg);
                    if(docgia_bus.ThemDocGia(dg))
                        MessageBox.Show("Đã thêm đôc giả vào thành công");
                    btnThoat.Focus();
                }
                else
                {
                    MessageBox.Show("Không thành công");
                }
            }
            else
            {
                MessageBox.Show("Xin nhập thông tin đầy đủ");
            }
        }
    }
}
