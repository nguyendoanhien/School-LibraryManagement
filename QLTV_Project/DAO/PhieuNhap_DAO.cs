#region
using System;
using System.Data;
using System.Data.SqlClient;
#endregion

namespace DAO
{
    public class PhieuNhap_DAO : ConnectDatabase
    {
        public int MaPhieuNhap()
        {
            try
            {
                var conn = GetConnString();
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

        public bool ThemPhieu(int maPhieu, int maNguoiLap, DateTime ngayLap)
        {
            try
            {
                // Ket noi
                var conn = GetConnString();

                // Query string - vì mình để TV_ID là identity (giá trị tự tăng dần) nên ko cần fải insert ID
                var sql = "dbo.Phieu_PhieuNhap";
                SqlParameter[] pars =
                {
                    new SqlParameter("@maPhieu", SqlDbType.NVarChar) {Value = maPhieu},
                    new SqlParameter("@maNguoiLap", SqlDbType.Bit) {Value = maNguoiLap},
                    new SqlParameter("@ngayLap", SqlDbType.DateTime) {Value = ngayLap}
                };

                var soLuongOK = SqlHelper.ExecuteNonQuery(conn, sql, CommandType.StoredProcedure, pars);

                if (soLuongOK > 0) return true;

                return false;

                // Query và kiểm tra
            }
            catch (Exception e)
            {
            }

            return false;
        }

        public bool XoaDauSach(int gtxoa)
        {
            var s = true;
            return s;
        }
    }
}