using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

using System.Data;
using System.Data.SqlClient;
namespace DAO
{
    public class DocGia_DAO : ConnectDatabase
    {
        public bool themNguoiDung(DTO.NguoiDung ng)
        {
            try
            {
                // Ket noi
                string conn = ConnectDatabase.GetConnString();

                // Query string - vì mình để TV_ID là identity (giá trị tự tăng dần) nên ko cần fải insert ID
                string sql = "INSERT INTO NguoiDung (HoVaTen,GioiTinh,Email,NgayTao) VALUES  (@HoVaTen, @GioiTinh, @Email, @NgayTao)";
                SqlParameter[] pars =
                {
                    new SqlParameter("@HoVaTen", SqlDbType.NVarChar) { Value = ng.HoVaTen },
                    new SqlParameter("@GioiTinh", SqlDbType.Bit) { Value = ng.GioiTinh },
                    new SqlParameter("@Email", SqlDbType.VarChar) { Value = ng.Email },
                    new SqlParameter("@NgayTao", SqlDbType.DateTime) { Value = ng.NgayTao }
                };
              
               int soLuongOK = SqlHelper.ExecuteNonQuery(conn, sql, CommandType.Text, pars);

                if (soLuongOK > 0) return true;

                return false;
              
                // Query và kiểm tra
              

            }
            catch (Exception e)
            {

            }
            finally
            {
                // Dong ket noi
                _conn.Close();
            }

            return false;
        }
    }
}
