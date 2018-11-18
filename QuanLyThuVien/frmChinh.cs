using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class frmChinh : Form
    {
        public frmChinh()
        {
            InitializeComponent();
            this.sttTime.Text = Get_Day();
        }
        

        public string Get_Day()
        {
            string ngay = DateTime.Now.Day.ToString();
            string thang = DateTime.Now.Month.ToString();
            string nam = DateTime.Now.Year.ToString();
            string gio = DateTime.Now.Hour.ToString();
            string phut = DateTime.Now.Minute.ToString();
            string giay = DateTime.Now.Second.ToString();
            return ngay + "/" + thang + "/" + nam + " " + gio + ":" + phut + ":" + giay;

        }

        

        private void frmChinh_Load(object sender, EventArgs e)
        {
            //HideTabPage(tabPage4);
        }
        private void HideTabPage(TabPage tp)
        {
            if (tabControl1.TabPages.Contains(tp))
                tabControl1.TabPages.Remove(tp);
        }


       
    }
}
