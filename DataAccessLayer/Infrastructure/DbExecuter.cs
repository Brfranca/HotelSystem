using Common;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Infrastructure
{
    internal class DbExecuter
    {
        public Response Execute(DbCommand command)
        {
            try
            {
                using (DbCurrentConnection connection = new DbCurrentConnection(command))
                {
                    connection.OpenConnection();

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        return Response.CreateSuccess("Operação efetuada com sucesso!");
                    }
                    return Response.CreateFailure("Erro ao efetuar a operação.");
                }
            }
            catch (Exception ex)
            {
                return Response.CreateFailureException("Ocorreu um erro, contate o administrador.", ex);
            }
        }

        public QueryResponse<List<T>> GetAllData<T>(DbCommand command)
        {
            try
            {
                using (DbCurrentConnection connection = new DbCurrentConnection(command))
                {
                    connection.OpenConnection();
                    DbDataReader reader = command.ExecuteReader();
                    DataTable table = new DataTable();

                    table.Load(reader);
                    if (table.Rows.Count == 0)
                    {
                        List<T> datan = new List<T>();
                        return QueryResponse<List<T>>.CreateSuccess(datan, "Nenhum registro cadastrado.");
                    }

                    List<T> data = table.ConvertDataTable<T>();
                    return QueryResponse<List<T>>.CreateSuccess(data, "Dados retornados com sucesso.");
                }
            }
            catch (Exception ex)
            {
                return QueryResponse<List<T>>.CreateFailureException("Ocorreu um erro, contate o administrador.", ex);
            }
        }

        public QueryResponse<T> GetSingleData<T>(DbCommand command)
        {
            try
            {
                using (DbCurrentConnection connection = new DbCurrentConnection(command))
                {
                    connection.OpenConnection();
                    DbDataReader reader = command.ExecuteReader();
                    DataTable table = new DataTable();
                    table.Load(reader);
                    if (table.Rows.Count == 0)
                    {
                        return QueryResponse<T>.CreateFailure("Registro não encontrado.");
                    }

                    T data = table.ConvertDataTable<T>().FirstOrDefault();
                    return QueryResponse<T>.CreateSuccess(data, "Dados retornados com sucesso.");
                }
            }
            catch (Exception ex)
            {
                return QueryResponse<T>.CreateFailureException("Ocorreu um erro, contate o administrador.", ex);
            }
        }

        public bool ExistData(DbCommand command)
        {
            try
            {
                using (DbCurrentConnection connection = new DbCurrentConnection(command))
                {
                    connection.OpenConnection();
                    return command.ExecuteReader().HasRows;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
