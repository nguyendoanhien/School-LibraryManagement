#region
using System.Data;
using System.Data.SqlClient;
#endregion

namespace DAO
{
    public class NCC_DAO : ConnectDatabase
    {
        public DataTable getNCC()
        {
            var da = new SqlDataAdapter("SELECT * FROM NCC", _conn);
            var dtNCC = new DataTable();
            da.Fill(dtNCC);
            return dtNCC;
        }
    }
}