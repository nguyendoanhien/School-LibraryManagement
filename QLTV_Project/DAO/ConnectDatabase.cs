#region
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
#endregion

namespace DAO
{
    public class ConnectDatabase
    {
        private static readonly string _connString =
            ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

        public static SqlConnection _conn = new SqlConnection(_connString);

        public static string GetConnString()
        {
            return _connString;
        }

        public static DataSet getdataset(string sql, string tenbang, SqlConnection _conn)
        {
            var ds = new DataSet();
            var da = new SqlDataAdapter(sql, _conn);
            da.Fill(ds, tenbang);
            return ds;
        }
    }
}