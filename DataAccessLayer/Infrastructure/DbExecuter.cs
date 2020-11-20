using Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;

namespace DataAccessLayer.Infrastructure
{
    internal class DbExecuter
    {
        //Executa a consulta e retorna a primeira coluna da primeira linha no conjunto de resultados retornado pela consulta.
        public Response ExecuteScalar(DbCommand command)
        {
            try
            {
                using (DbCurrentConnection connection = new DbCurrentConnection(command))
                {
                    connection.OpenConnection();

                    int id = Convert.ToInt32(command.ExecuteScalar());
                    if (id > 0)
                    {
                        return Response.CreateSuccess("Operação efetuada com sucesso!", id);
                    }
                    return Response.CreateFailure("Erro ao efetuar a operação.");
                }
            }
            catch (Exception ex)
            {
                return Response.CreateFailureException("Ocorreu um erro, contate o administrador.", ex);
            }
        }

        //executa a instrução no banco de dados e caso o numero de linhas afetados nao seja maior que zero retorna um response de erro
        public Response ExecuteQuery(DbCommand command)
        {
            try
            {
                using (DbCurrentConnection connection = new DbCurrentConnection(command))
                {
                    connection.OpenConnection();

                    int lineAffects = command.ExecuteNonQuery();
                    if (lineAffects > 0)
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

        //Retorna uma lista de genérica com todos os dados de uma dada tabela
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

        //Retorna os dados de uma linha específica na tabela de banco de dados
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

        //verifica se um determinado dado já existe no banco de dados
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
