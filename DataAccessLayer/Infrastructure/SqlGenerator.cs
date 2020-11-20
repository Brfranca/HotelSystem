using Entities.DataAnnotations;
using System;
using System.Data.Common;
using System.Reflection;
using System.Text;

namespace DataAccessLayer.Infrastructure
{
    public class SqlGenerator<T>
    {
        //Método que recupera o nome na tabela no banco de dados de acordo com a classe utilizada
        public static string GetTableName()
        {
            return typeof(T).GetCustomAttribute<TableName>().Text;
        }

        //Cria o comando de insert no banco de dados, aonde {0] pega o nome da tabela como primeiro item a ser adicionado no comando, os campos que serão inseridos e depois os valores que os dados campos irão receber
        public static DbCommand BuildInsertCommand(T item)
        {
            StringBuilder command = new StringBuilder();
            command.AppendFormat("INSERT INTO {0} ({1}) VALUES ({2});SELECT SCOPE_IDENTITY();", GetTableName(), GetInsertFields(false), GetInsertFields(true));
            DbCommand dbCommand = DbFactory.GetCurrentCommand();
            GenerateInsertParameters(dbCommand, item);
            dbCommand.CommandText = command.ToString();
            return dbCommand;
        }

        //Cria a sintaxe que o command.AddWithValue recebe para inserir os valores na tabela de banco de dados, que só ocorrerá se a propriedade nao tiver o NonEdiTable 
        private static void GenerateInsertParameters(DbCommand command, T item)
        {
            foreach (PropertyInfo propriedade in typeof(T).GetProperties())
            {
                if (propriedade.GetCustomAttribute<NonEditable>() == null)
                {
                    if (propriedade.GetValue(item) == "" || propriedade.GetValue(item) == null)
                    {
                        command.Parameters.AddWithValue("@" + propriedade.Name, DBNull.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@" + propriedade.Name, propriedade.GetValue(item));
                    }
                }
            }
        }

        //Método que cria a sintaxe para informar quais colunas receberão valores ou quais valores serão inserido, se o parametro for false indica a coluna, se for true indica os valores a serem inseridos
        private static string GetInsertFields(bool isParameters)
        {
            StringBuilder builder = new StringBuilder();

            foreach (var item in typeof(T).GetProperties())
            {
                if (item.GetCustomAttribute<NonEditable>() == null)
                {
                    if (isParameters)
                    {
                        builder.Append("@" + item.Name + ",");
                    }
                    else
                    {
                        builder.Append(item.Name + ",");
                    }
                }
            }
            builder = builder.Remove(builder.Length - 1, 1);
            return builder.ToString();
        }

        //Método genérico que cria o comando de update no banco de dados, aonde {0} pega o nome da tabela como primeiro item a ser adicionado no comando e depois os campos que serão inseridos

        public static DbCommand BuildUpdateCommand(T item)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendFormat("UPDATE {0} SET {1} WHERE ID = @ID", GetTableName(), GetUpdateFields());
            DbCommand command = DbFactory.GetCurrentCommand();
            command.CommandText = builder.ToString();
            GenerateUpdateParameters(command, item);
            return command;
        }

        //Método genérico que cria a sintaxe do comando a ser inserido para atualizar uma dada tabela no banco de daos
        private static string GetUpdateFields()
        {
            StringBuilder builder = new StringBuilder();
            foreach (PropertyInfo item in typeof(T).GetProperties())
            {
                if (item.GetCustomAttribute<NonEditable>() == null)
                {
                    builder.Append(item.Name + " = @" + item.Name + ",");
                }
            }
            return builder.ToString(0, builder.Length - 1);
        }

        //Cria a sintaxe que o command.AddWithValue recebe para atualizar os valores na tabela de banco de dados, que só ocorrerá se a propriedade nao tiver o NonEdiTable 

        private static void GenerateUpdateParameters(DbCommand command, T item)
        {
            foreach (PropertyInfo propriedade in typeof(T).GetProperties())
            {
                if (propriedade.GetCustomAttribute<NonEditable>() == null)
                {
                    if (propriedade.GetValue(item) == null || propriedade.GetValue(item) == "")
                    {
                        command.Parameters.AddWithValue("@" + propriedade.Name, DBNull.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@" + propriedade.Name, propriedade.GetValue(item));
                    }
                }
            }
            object id = item.GetType().GetProperty("ID").GetValue(item, null);
            command.Parameters.AddWithValue("@ID", id);
        }

        //Método genérico que cria o comando de delete no banco de dados, aonde {0} pega o nome da tabela como primeiro item a ser adicionado no comando
        public static DbCommand BuildDeleteCommand(T item)
        {
            DbCommand command = DbFactory.GetCurrentCommand();
            command.CommandText = string.Format("DELETE FROM {0} WHERE ID = @ID", GetTableName());
            object id = item.GetType().GetProperty("ID").GetValue(item, null);
            command.Parameters.AddWithValue("@ID", id);
            return command;
        }

        //Método genérico que deleta uma dada tabela associativa
        public static DbCommand BuildDeleteWhereIdCommand(string field, int id)
        {
            DbCommand command = DbFactory.GetCurrentCommand();
            command.CommandText = string.Format("DELETE FROM {0} WHERE "+ field + " = @FIELD", GetTableName());
            command.Parameters.AddWithValue($"@FIELD", id);
            return command;
        }
    }
}
