#region
using System;
using System.Data;
using System.Data.SqlClient;
#endregion

namespace DAO
{
    public class PhieuTra_DAO
    {
        public int MaPhieuTra()
        {
            try
            {
                var conn = ConnectDatabase.GetConnString();
                var sql = "select MAX(MaPhieu) from Phieu";
                SqlParameter[] pars = { };
                var soLuongOK = SqlHelper.ExecuteScalar(conn, sql, CommandType.Text, pars);

                var gt = int.Parse(soLuongOK.ToString());

                if (soLuongOK != null) return gt + 1;
                return 0;
            }
            catch (Exception e)
            {
            }

            return 0;
        }

        public bool LuuPhieuTra()
        {
            var s = true;
            return s;
        }
    }
}