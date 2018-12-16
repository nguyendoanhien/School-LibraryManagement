using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class NhanVien_DAO:ConnectDatabase
    {

        public static bool KiemTraNhanVien(NhanVien obj)
        {
            try
            {
                string conn = ConnectDatabase.GetConnString();
                // Query string - vì mình để TV_ID là identity (giá trị tự tăng dần) nên ko cần fải insert ID
                string sql = "dbo.NhanVien_KiemTra";
                SqlParameter[] pars =
                {
                    
                    new SqlParameter("@MaNhanVien", SqlDbType.Int) { Value = obj.MaNhanVien },
                    new SqlParameter("@MatKhau", SqlDbType.VarChar) { Value = obj.MatKhau },

                };

                SqlDataReader dr= SqlHelper.ExecuteReader(conn, sql, CommandType.StoredProcedure, pars);

                if (dr.HasRows) return true;

                return false;

            }
            catch (Exception ex)
            {
                return false;
            }
            
            
        }
    }
}
