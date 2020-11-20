using System;
using System.Data.Common;

namespace DataAccessLayer.Infrastructure
{
    internal class DbCurrentConnection : IDisposable
    {
        private readonly DbConnection _connection;

        //retorna a conexão da DBFactory de acordo com os dados do App.Config
        public DbCurrentConnection(DbCommand command)
        {
            _connection = DbFactory.GetCurrentConnection();
            command.Connection = this._connection;
        }

        //Abre a conexão no banco de dados
        public void OpenConnection()
        {
            if(_connection.State != System.Data.ConnectionState.Open)
            {
                this._connection.Open();
            }
        }

        //fecha a conexão no banco de dados
        public void CloseConnection()
        {
            if (_connection.State != System.Data.ConnectionState.Closed)
            {
                this._connection.Close();
            }
        }

        //descarta a conexao do banco de dados
        public void Dispose()
        {
            CloseConnection();
        }
    }
}
