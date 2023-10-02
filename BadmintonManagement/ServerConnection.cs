using System.Data.SqlClient;

namespace BadmintonManagement
{
    internal class ServerConnection
    {
        private SqlConnection conn;

        public ServerConnection(SqlConnection conn)
        {
            this.conn = conn;
        }
    }
}