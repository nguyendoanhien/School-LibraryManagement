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
    public class LoaiDocGia_DAO:ConnectDatabase
    {
        SqlCommand cmd;
        public DataTable getLoaiDocGia()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM DocGiaLoai", _conn);
            DataTable dtDocGiaLoai = new DataTable();
            da.Fill(dtDocGiaLoai);
            return dtDocGiaLoai;
        }

        public DataTable LoadCbo()
        {
            _conn.Open();
            cmd = _conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT TenLoaiDocGia FROM DocGiaLoai order by TenLoaiDocGia asc";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
    }
}
