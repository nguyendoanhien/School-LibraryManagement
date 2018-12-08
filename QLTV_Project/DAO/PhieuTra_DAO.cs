using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Data;


namespace DAO
{
    public class PhieuTra_DAO
    {
        public int MaPhieuNhap()
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
