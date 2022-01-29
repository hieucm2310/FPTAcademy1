using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Common
{
    public static class DbContextExtension
    {
        public static List<T> ExecStore<T>(this DbContext _context, string storeName, Dictionary<string, string> mParams)
        {
            List<T> lst = new List<T>();
            try
            {
                var props = typeof(T).GetRuntimeProperties();
                var connectionString = _context.Database.GetDbConnection().ConnectionString;
                using (MySqlConnection cnn = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand(storeName, cnn))
                    {
                        cnn.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        foreach (var item in mParams)
                        {
                            cmd.Parameters.AddWithValue("@" + item.Key, item.Value);
                        }
                        MySqlDataReader reader = cmd.ExecuteReader();
                        var colMapping = reader.GetColumnSchema().Where(x => props.Any(y => y.Name.ToLower() == x.ColumnName.ToLower())).ToDictionary(key => key.ColumnName.ToLower());
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                try
                                {
                                    T obj = Activator.CreateInstance<T>();
                                    foreach (var prop in props)
                                    {
                                        var val = reader.GetValue(colMapping[prop.Name.ToLower()].ColumnOrdinal.Value);
                                        prop.SetValue(obj, val == DBNull.Value ? null : val);
                                    }
                                    lst.Add(obj);
                                }
                                catch (Exception ex)
                                {
                                    throw ex;
                                }
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
            }
            return lst;
        }
    }
}
