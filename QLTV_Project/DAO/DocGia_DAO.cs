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
                _conn.Open();

                // Query string - vì mình để TV_ID là identity (giá trị tự tăng dần) nên ko cần fải insert ID
                string SQL = string.Format("INSERT INTO NguoiDung (HoVaTen,GioiTinh,Email,NgayTao) VALUES  ('{0}', '{1}', '{2}', '{3}')", ng.HoVaTen, ng.GioiTinh, ng.Email, ng.NgayTao);

                // Command (mặc định command type = text nên chúng ta khỏi fải làm gì nhiều).
                SqlCommand cmd = new SqlCommand(SQL, _conn);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;

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
