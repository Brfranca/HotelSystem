﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Reflection;

namespace DataAccessLayer.Infrastructure
{
    public static class DbExtensions
    {
        //Método que simula o AddWithValue do sql command para um banco de dados genérico
        public static void AddWithValue(this DbParameterCollection collection, string nome, object valor)
        {
            DbParameter parametro = DbFactory.GetCurrentCommand().CreateParameter();
            parametro.ParameterName = nome;
            parametro.Value = valor;
            collection.Add(parametro);
        }

        //Converte a DataTable para uma lista genérica
        public static List<T> ConvertDataTable<T>(this DataTable dt)
        {
            List<T> data = new List<T>();
            foreach (DataRow row in dt.Rows)
            {
                T item = GetItem<T>(row);
                data.Add(item);
            }
            return data;
        }

        //Retorna um item genérico de uma linha da datatable
        public static T GetItem<T>(this DataRow dr)
        {
            Type temp = typeof(T);
            T obj = Activator.CreateInstance<T>();

            foreach (DataColumn column in dr.Table.Columns)
            {
                PropertyInfo pro = temp.GetProperties()
                    .FirstOrDefault(x => x.Name.ToUpper() == column.ColumnName.ToUpper());
                if (dr[column.ColumnName] != DBNull.Value)
                {
                    pro.SetValue(obj, dr[column.ColumnName], null);
                }
            }
            return obj;
        }
    }
}
