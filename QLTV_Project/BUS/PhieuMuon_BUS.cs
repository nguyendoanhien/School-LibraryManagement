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
    }
}
