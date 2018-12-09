using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
using System.Data.SqlClient;
using System.Data;
namespace BUS
{
    public class PhieuTra_BUS
    {
        PhieuTra_DAO phieuTra_DAO = new PhieuTra_DAO();
        public int MaPhieuTra()
        {
            return phieuTra_DAO.MaPhieuNhap();
        }

        public DataTable LoadSachMuon(int maPhieuMuon)
        {
            PhieuMuon_BUS phieuMuon_BUS = new PhieuMuon_BUS();
            return phieuMuon_BUS.LoadSachMuon(maPhieuMuon);
        }
    }
}
