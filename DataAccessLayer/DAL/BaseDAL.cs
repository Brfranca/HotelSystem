using Common;
using DataAccessLayer.Infrastructure;
using System.Collections.Generic;
using System.Data.Common;

namespace DataAccessLayer.DAL
{
    public class BaseDAL<T>
    {
        protected string _select;

        protected BaseDAL()
        {
            _select = $"SELECT * FROM {SqlGenerator<T>.GetTableName()}";
        }

        //Método genérico para inserir tabela no banco de dados
        public Response Insert<T>(T entity)
        {
            DbCommand command = SqlGenerator<T>.BuildInsertCommand(entity);
            return new DbExecuter().ExecuteQuery(command);
        }

        //Método genérico para inserir tabela no banco de dados e recuperar o ID gerado 
        public Response InsertScalar<T>(T entity)
        {
            DbCommand command = SqlGenerator<T>.BuildInsertCommand(entity);
            return new DbExecuter().ExecuteScalar(command);
        }

        //Método genérico para fazer o update no banco de dados
        public Response Update<T>(T entity)
        {
            DbCommand command = SqlGenerator<T>.BuildUpdateCommand(entity);
            return new DbExecuter().ExecuteQuery(command);
        }

        //Método genérico para deletar tabela no banco de dados
        public Response Delete<T>(T entity)
        {
            DbCommand command = SqlGenerator<T>.BuildDeleteCommand(entity);
            return new DbExecuter().ExecuteQuery(command);
        }

        //Método genérico para pegar todos os dados de uma dada tabela no banco de dados
        public QueryResponse<List<T>> GetAll()
        {
            DbCommand command = DbFactory.GetCurrentCommand();
            command.CommandText = _select;
            return new DbExecuter().GetAllData<T>(command);
        }

        //Método genérico para pegar todos os dados de um ID específico de uma dada tabela no banco de dados
        public QueryResponse<T> GetById(int id)
        {
            DbCommand command = DbFactory.GetCurrentCommand();
            command.CommandText = $"{_select} WHERE ID = @ID";
            command.Parameters.AddWithValue("@ID", id);
            return new DbExecuter().GetSingleData<T>(command);
        }

        //Método genérico para verificar se algum dado já foi cadastrado no banco de dados e o mesmo deveria ser único
        public bool Exist(string value, int id, string columnName)
        {
            DbCommand command = DbFactory.GetCurrentCommand();
            string and = "";
            if (id > 0)
            {
                command.Parameters.AddWithValue("@ID", id);
                and = "AND ID != @ID";
            }

            command.CommandText = $"{_select} WHERE {columnName} = @{columnName} {and}";
            command.Parameters.AddWithValue($"@{columnName}", value);
            return new DbExecuter().ExistData(command);
        }

        //Método genérico para deletar um conjunto de dados em uma dada tabela no banco de dados de acordo com o ID inserido
        public Response DeleteWhereId<T>(string field, int id)
        {
            DbCommand command = SqlGenerator<T>.BuildDeleteWhereIdCommand(field, id);
            return new DbExecuter().ExecuteQuery(command);
        }
    }
}
