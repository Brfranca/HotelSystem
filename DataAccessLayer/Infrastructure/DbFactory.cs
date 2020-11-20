using System.Configuration;
using System.Data.Common;

namespace DataAccessLayer.Infrastructure
{
    public class DbFactory
    {
        private readonly string _providerName;
        private readonly string _connectionString;
        private readonly DbProviderFactory _provider;

        //Construtor que retorna qual o banco de dados a ser tulizado de acordo com os dados do APP.config, já recuperando a connectionstring
        private DbFactory()
        {
            string currentConnection = ConfigurationManager.AppSettings["CurrentConnection"];
            _providerName = ConfigurationManager.ConnectionStrings[currentConnection].ProviderName;
            _connectionString = ConfigurationManager.ConnectionStrings[currentConnection].ConnectionString;

            _provider = DbProviderFactories.GetFactory(_providerName);
        }

        private static DbFactory _instance;
        //se a classe Db factory ainda está nula ele instancia novamente e recupera os dados do construtor
        private static DbFactory GetInstance()
        {
            if (_instance == null)
                _instance = new DbFactory();

            return _instance;
        }

        //Cria o comando que representa uma instrução ou procedimento armazenado para execução em um banco de dados
        public static DbCommand GetCurrentCommand()
        {
            return GetInstance()._provider.CreateCommand();
        }

        //Retorna a conexão com o banco de dados de acordo com o priverName e a connectionString do construtor
        public static DbConnection GetCurrentConnection()
        {
            DbFactory factory = GetInstance();
            DbConnection connection = factory._provider.CreateConnection();
            connection.ConnectionString = factory._connectionString;

            return connection;
        }
    }
}
