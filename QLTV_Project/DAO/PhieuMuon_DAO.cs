using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Data.SqlClient;
using System.Data;
namespace DAO
{
    public class PhieuMuon_DAO
    {
        public DataTable LoadSachMuon(int maPhieuMuon)
        {
            try
            {
                // Ket noi
                string conn = ConnectDatabase.GetConnString();
                
                // Query string - vì mình để TV_ID là identity (giá trị tự tăng dần) nên ko cần fải insert ID
                string sql = "LoadSachMuon";
                SqlParameter[] pars = { new SqlParameter("@maphieumuon", SqlDbType.Int) { Value = maPhieuMuon } };
                SqlDataReader soLuongOK = SqlHelper.ExecuteReader(conn, sql, CommandType.StoredProcedure, pars);

                var dataTable = new DataTable();
                dataTable.Load(soLuongOK);
                if (dataTable.Rows.Count > 0) return dataTable;

                // Query và kiểm tra


            }
            catch (Exception e)
            {

            }
            return null;
        }

        public static int MaPhieuMuon()
        {
            try
            {
                string conn = ConnectDatabase.GetConnString();
                string sql = "select MAX(MaPhieu) from Phieu";
                SqlParameter[] pars = { };
                var soLuongOK = SqlHelper.ExecuteScalar(conn, sql, CommandType.Text, pars);

                int gt = int.Parse(soLuongOK.ToString());

                if (soLuongOK != null) return gt + 1;
                else return 0;
            }
            catch (Exception e)
            {

            }
            return 0;
        }

    }
}
