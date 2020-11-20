using System.Configuration;
using System.Data.Common;

namespace DataAccessLayer.Infrastructure
{
    public class DbFactory
    {
        private readonly string _providerName;
        private readonly string _connectionString;
        private readonly DbProviderFactory _provider;

        private DbFactory()
        {
            string currentConnection = ConfigurationManager.AppSettings["CurrentConnection"];
            _providerName = ConfigurationManager.ConnectionStrings[currentConnection].ProviderName;
            _connectionString = ConfigurationManager.ConnectionStrings[currentConnection].ConnectionString;

            _provider = DbProviderFactories.GetFactory(_providerName);
        }

        private static DbFactory _instance;
        private static DbFactory GetInstance()
        {
            if (_instance == null)
                _instance = new DbFactory();

            return _instance;
        }

        public static DbCommand GetCurrentCommand()
        {
            return GetInstance()._provider.CreateCommand();
        }

        public static DbConnection GetCurrentConnection()
        {
            DbFactory factory = GetInstance();
            DbConnection connection = factory._provider.CreateConnection();
            connection.ConnectionString = factory._connectionString;

            return connection;
        }
    }
}
