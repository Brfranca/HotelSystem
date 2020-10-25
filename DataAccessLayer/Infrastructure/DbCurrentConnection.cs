using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Infrastructure
{
    internal class DbCurrentConnection : IDisposable
    {
        private DbConnection conn;

        public DbCurrentConnection(DbCommand command)
        {
            conn = DbFactory.GetCurrentConnection();
            command.Connection = this.conn;
        }

        public void OpenConnection()
        {
            if(conn.State != System.Data.ConnectionState.Open)
            {
                this.conn.Open();
            }
        }

        public void CloseConnection()
        {
            if (conn.State != System.Data.ConnectionState.Closed)
            {
                this.conn.Close();
            }
        }

        public void Dispose()
        {
            CloseConnection();
        }
    }
}
