using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Data.SqlClient;
using System.Data;
namespace BUS
{
    public class PhieuMuon_BUS
    {
        PhieuMuon_DAO phieuMuon_DAO = new PhieuMuon_DAO();
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
            bool kq = false;
            if(PhieuMuon_DAO.Insert_Phieu(maNguoiLap, ngayLap))
            {
                kq = true;
            }
            return kq;
        }
        public bool Insert_PhieuMuon(int maPhieuMuon, int maDocGia)
        {
            bool kq = false;
            if (PhieuMuon_DAO.Insert_PhieuMuon(maPhieuMuon, maDocGia))
            {
                kq = true;
            }
            return kq;
        }
        public bool Insert_PhieuMuonChiTiet(int maSach,int maPhieuMuon, int maDauSach, string ngayHenTra)
        {
            bool kq = false;
            if (PhieuMuon_DAO.Insert_PhieuMuonChiTiet(maSach, maPhieuMuon, maDauSach, ngayHenTra))
            {
                kq = true;
            }
            return kq;
        }
    }
}
