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
        private readonly DbConnection _connection;
        public DbCurrentConnection(DbCommand command)
        {
            _connection = DbFactory.GetCurrentConnection();
            command.Connection = this._connection;
        }

        public void OpenConnection()
        {
            if(_connection.State != System.Data.ConnectionState.Open)
            {
                this._connection.Open();
            }
        }

        public void CloseConnection()
        {
            if (_connection.State != System.Data.ConnectionState.Closed)
            {
                this._connection.Close();
            }
        }

        public void Dispose()
        {
            CloseConnection();
        }
    }
}
