using Entities.DataAnnotations;
using System;
using System.Data.Common;
using System.Reflection;
using System.Text;

namespace DataAccessLayer.Infrastructure
{
    public class SqlGenerator<T>
    {
        public static string GetTableName()
        {
            return typeof(T).GetCustomAttribute<TableName>().Text;
        }

        public static DbCommand BuildInsertCommand(T item)
        {
            StringBuilder command = new StringBuilder();
            command.AppendFormat("INSERT INTO {0} ({1}) VALUES ({2});SELECT SCOPE_IDENTITY();", GetTableName(), GetInsertFields(false), GetInsertFields(true));
            DbCommand dbCommand = DbFactory.GetCurrentCommand();
            GenerateInsertParameters(dbCommand, item);
            dbCommand.CommandText = command.ToString();
            return dbCommand;
        }

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

        public static DbCommand BuildUpdateCommand(T item)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendFormat("UPDATE {0} SET {1} WHERE ID = @ID", GetTableName(), GetUpdateFields());
            DbCommand command = DbFactory.GetCurrentCommand();
            command.CommandText = builder.ToString();
            GenerateUpdateParameters(command, item);
            return command;
        }


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

        public static DbCommand BuildDeleteCommand(T item)
        {
            DbCommand command = DbFactory.GetCurrentCommand();
            command.CommandText = string.Format("DELETE FROM {0} WHERE ID = @ID", GetTableName());
            object id = item.GetType().GetProperty("ID").GetValue(item, null);
            command.Parameters.AddWithValue("@ID", id);
            return command;
        }

        public static DbCommand BuildDeleteWhereIdCommand(string field, int id)
        {
            DbCommand command = DbFactory.GetCurrentCommand();
            command.CommandText = string.Format("DELETE FROM {0} WHERE "+ field + " = @FIELD", GetTableName());
            command.Parameters.AddWithValue($"@FIELD", id);
            return command;
        }
    }
}
