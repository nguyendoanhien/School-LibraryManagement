#region
using System;
using System.Data;
using DAO;
#endregion

namespace BUS
{
    public class PhieuTra_BUS
    {
        private readonly PhieuTra_DAO phieuTra_DAO = new PhieuTra_DAO();

        public int MaPhieuTra()
        {
            return phieuTra_DAO.MaPhieuTra();
        }

        public DataTable LoadDanhSachMuon(string a, string MaPhieuMuon)
        {
            return phieuTra_DAO.LoadDanhsachMuon(a, MaPhieuMuon);
        }

        public double TienPhat(string MaDauSach, int ngay)
        {
            return phieuTra_DAO.TienPhat(MaDauSach, ngay);
        }

        public int SoSanhNgay(string a)
        {
            var time1 = DateTime.Parse(a).ToString();
            var time2 = DateTime.Now.ToString("t");

            if (DateTime.Compare(DateTime.Parse(time1), DateTime.Parse(time2)) < 0)
                return 1;
            return 0;
        }

        public int TinhNgay(string a, string b)
        {
            var t1 = Convert.ToDateTime(a);
            var t2 = Convert.ToDateTime(b);

            var t = 0;

            if (Convert.ToInt32(t2.Day) - Convert.ToInt32(t1.Day) <= 0)
                t = t + 0;
            else
                t = t + Math.Abs(Convert.ToInt32(t2.Day) - Convert.ToInt32(t1.Day));

            if (Convert.ToInt32(t2.Month) - Convert.ToInt32(t1.Month) <= 0)
                t = t + 0;
            else
                t = t + Math.Abs(Convert.ToInt32(t2.Month) - Convert.ToInt32(t1.Month)) * 30;

            if (Convert.ToInt32(t2.Year) - Convert.ToInt32(t1.Year) <= 0)
                t = t + 0;
            else
                return 300;


            return t;
        }

        public void ThemPhieuTra(string MaPhieuTra, string MaPhieuMuon, string MaDocGia)
        {
            phieuTra_DAO.ThemPhieuTra(MaPhieuTra, MaPhieuMuon, MaDocGia);
        }

        public void ThemPhieu(string b, string c)
        {
            phieuTra_DAO.ThemPhieu(b, c);
        }

        public void ThemPhieuTraChiTiet(int a, string maSach, int b, int c, string d, int e)
        {
            phieuTra_DAO.ThemPhieuTraChiTiet(a, maSach, b, c, d, e);
        }

        public void UPDATE_PhieuMuonChiTiet(int a, string maSach, int b)
        {
            phieuTra_DAO.UPDATE_PhieuMuonChiTiet(a, maSach, b);
        }

        public int KiemTraRong(string a)
        {
            return phieuTra_DAO.KiemTraRong(a);
        }
    }
}