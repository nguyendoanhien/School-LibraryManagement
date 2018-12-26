#region
using System.Data;
using System.Data.SqlClient;
#endregion

namespace DAO
{
    public class LoaiDocGia_DAO : ConnectDatabase
    {
        private SqlCommand cmd;

        public DataTable getLoaiDocGia()
        {
            var da = new SqlDataAdapter("SELECT * FROM DocGiaLoai", _conn);
            var dtDocGiaLoai = new DataTable();
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
            var dt = new DataTable();
            var da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
    }
}