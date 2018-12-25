using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Data.SqlClient;
using System.Data;

namespace BUS
{
    public class DauSach_BUS
    {
        
        public static  DataTable LoadDauSach()
        {
            return DauSach_DAO.LoadDauSach();
        }

        public static DataTable TimSach(string mucTim, string tenTim)
        {
            return DauSach_DAO.TimSach(mucTim, tenTim);
        }

        public static DataTable LoadSachMuon(int maDauSach)
        {
            return DauSach_DAO.LoadSachMuon(maDauSach);
        }

        public static DataTable LoadDtgvSachMuon(int maSach, int maDocGia)
        {
            return DauSach_DAO.LoadDtgvMuon( maSach, maDocGia);
        }

    }
}
