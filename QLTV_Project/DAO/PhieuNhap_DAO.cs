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
    public class PhieuNhap_DAO: ConnectDatabase
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

                if (soLuongOK != null) return gt+1;
                else return 0;
            }
            catch (Exception e)
            {

            }
            return 0;
        }

        public bool ThemPhieu(int maPhieu, int maNguoiLap, DateTime ngayLap)
        {
            try
            {
                // Ket noi
                string conn = ConnectDatabase.GetConnString();

                // Query string - vì mình để TV_ID là identity (giá trị tự tăng dần) nên ko cần fải insert ID
                string sql = "dbo.Phieu_PhieuNhap";
                SqlParameter[] pars =
                {
                    new SqlParameter("@maPhieu", SqlDbType.NVarChar) { Value = maPhieu },
                    new SqlParameter("@maNguoiLap", SqlDbType.Bit) { Value = maNguoiLap },
                    new SqlParameter("@ngayLap", SqlDbType.DateTime) { Value = ngayLap }
                };

                int soLuongOK = SqlHelper.ExecuteNonQuery(conn, sql, CommandType.StoredProcedure, pars);

                if (soLuongOK > 0) return true;

                return false;

                // Query và kiểm tra


            }
            catch (Exception e)
            {

            }
            return false;
        }

    }
}
