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

        public Response Insert<T>(T entity)
        {
            DbCommand command = SqlGenerator<T>.BuildInsertCommand(entity);
            return new DbExecuter().ExecuteQuery(command);
        }

        public Response InsertScalar<T>(T entity)
        {
            DbCommand command = SqlGenerator<T>.BuildInsertCommand(entity);
            return new DbExecuter().ExecuteScalar(command);
        }

        public Response Update<T>(T entity)
        {
            DbCommand command = SqlGenerator<T>.BuildUpdateCommand(entity);
            return new DbExecuter().ExecuteQuery(command);
        }

        public Response Delete<T>(T entity)
        {
            DbCommand command = SqlGenerator<T>.BuildDeleteCommand(entity);
            return new DbExecuter().ExecuteQuery(command);
        }

        public QueryResponse<List<T>> GetAll()
        {
            DbCommand command = DbFactory.GetCurrentCommand();
            command.CommandText = _select;
            return new DbExecuter().GetAllData<T>(command);
        }

        public QueryResponse<T> GetById(int id)
        {
            DbCommand command = DbFactory.GetCurrentCommand();
            command.CommandText = $"{_select} WHERE ID = @ID";
            command.Parameters.AddWithValue("@ID", id);
            return new DbExecuter().GetSingleData<T>(command);
        }

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
    }
}
