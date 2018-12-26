#region
using System.Data;
using System.Data.SqlClient;
// Tiếp cận với database
#endregion

namespace DAO
{
    internal static class SqlHelper
    {
        /// <summary>
        ///     Set the connection, command, and then execute the command with non query.
        /// </summary>
        public static int ExecuteNonQuery(string connectionString, string commandText,
            CommandType commandType, params SqlParameter[] parameters)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand(commandText, conn))
                {
                    // There're three command types: StoredProcedure, Text, TableDirect. The TableDirect 
                    // type is only for OLE DB.  
                    cmd.CommandType = commandType;
                    cmd.Parameters.AddRange(parameters);

                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        ///     Set the connection, command, and then execute the command and only return one value.
        /// </summary>
        public static object ExecuteScalar(string connectionString, string commandText,
            CommandType commandType, params SqlParameter[] parameters)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                using (var cmd = new SqlCommand(commandText, conn))
                {
                    cmd.CommandType = commandType;
                    cmd.Parameters.AddRange(parameters);

                    conn.Open();
                    return cmd.ExecuteScalar();
                }
            }
        }

        /// <summary>
        ///     Set the connection, command, and then execute the command with query and return the reader.
        /// </summary>
        public static SqlDataReader ExecuteReader(string connectionString, string commandText,
            CommandType commandType, params SqlParameter[] parameters)
        {
            var conn = new SqlConnection(connectionString);

            using (var cmd = new SqlCommand(commandText, conn))
            {
                cmd.CommandType = commandType;
                cmd.Parameters.AddRange(parameters);

                conn.Open();
                // When using CommandBehavior.CloseConnection, the connection will be closed when the 
                // IDataReader is closed.
                var reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                return reader;
            }
        }
    }
}