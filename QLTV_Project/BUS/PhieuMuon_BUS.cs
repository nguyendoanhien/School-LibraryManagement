#region
using System;
using System.Data;
using DAO;
#endregion

namespace BUS
{
    public class PhieuMuon_BUS
    {
        private readonly PhieuMuon_DAO phieuMuon_DAO = new PhieuMuon_DAO();

        public DataTable LoadSachMuon(int maPhieuMuon)
        {
            return phieuMuon_DAO.LoadSachMuon(maPhieuMuon);
        }

        public int LayMaPhieuMuon()
        {
            return PhieuMuon_DAO.MaPhieuMuon();
        }

        public bool Insert_Phieu(int maNguoiLap, DateTime ngayLap)
        {
            var kq = false;
            if (PhieuMuon_DAO.Insert_Phieu(maNguoiLap, ngayLap)) kq = true;
            return kq;
        }

        public bool Insert_PhieuMuon(int maPhieuMuon, int maDocGia)
        {
            var kq = false;
            if (PhieuMuon_DAO.Insert_PhieuMuon(maPhieuMuon, maDocGia)) kq = true;
            return kq;
        }

        public bool Insert_PhieuMuonChiTiet(int maSach, int maPhieuMuon, int maDauSach, string ngayHenTra)
        {
            var kq = false;
            if (PhieuMuon_DAO.Insert_PhieuMuonChiTiet(maSach, maPhieuMuon, maDauSach, ngayHenTra)) kq = true;
            return kq;
        }
    }
}