using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Web;

namespace M6.Data.Command
{
    public static class Converter
    {

        private static readonly IDictionary<Type, ICollection<PropertyInfo>> _Properties = new Dictionary<Type, ICollection<PropertyInfo>>();


        /// <summary>
        /// Converts a DataTable to a list with generic objects
        /// </summary>
        /// <typeparam name="T">Generic object</typeparam>
        /// <param name="table">DataTable</param>
        /// <returns>List with generic objects</returns>
        public static List<T> ToList<T>(this DataTable table) where T : class, new()
        {
            try
            {
                List<T> list = new List<T>();

                foreach (var row in table.AsEnumerable())
                {
                    T obj = new T();

                    foreach (var prop in obj.GetType().GetProperties())
                    {
                        try
                        {
                            PropertyInfo propertyInfo = obj.GetType().GetProperty(prop.Name);
                            propertyInfo.SetValue(obj, Convert.ChangeType(row[prop.Name], propertyInfo.PropertyType), null);
                        }
                        catch
                        {
                            continue;
                        }
                    }

                    list.Add(obj);
                }

                return list;
            }
            catch
            {
                return null;
            }
        }
        
        

        /// <summary>
        /// Converts a DataTable to a list with generic objects
        /// </summary>
        /// <typeparam name="T">Generic object</typeparam>
        /// <param name="table">DataTable</param>
        /// <returns>List with generic objects</returns>
        public static IEnumerable<T> ToIEnumerable<T>(this DataTable table) where T : class, new()
        {            
            try
            {
                var objType = typeof(T);
                ICollection<PropertyInfo> properties;

                lock (_Properties)
                {
                    if (!_Properties.TryGetValue(objType, out properties))
                    {
                        properties = objType.GetProperties().Where(property => property.CanWrite).ToList();
                        _Properties.Add(objType, properties);
                    }
                }

                var list = new List<T>(table.Rows.Count);

                foreach (var row in table.AsEnumerable().Skip(1))
                {
                    var obj = new T();

                    foreach (var prop in properties)
                    {
                        try
                        {
                            var propType = Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType;
                            var safeValue = row[prop.Name] == null ? null : Convert.ChangeType(row[prop.Name], propType);

                            prop.SetValue(obj, safeValue, null);
                        }
                        catch
                        {
                            // ignored
                        }
                    }

                    list.Add(obj);
                }

                return list;
            }
            catch
            {
                return Enumerable.Empty<T>();
            }
        }

        ///
        ///
        ///
        public static SqlParameter[] ToSqlParameters(this Dictionary<string, object> _Dictionary)
        {
            int i = 0;
            SqlParameter[] sqlParameter = new SqlParameter[_Dictionary.Count];

            foreach (var item in _Dictionary)
            {
                sqlParameter[i] = new SqlParameter();
                sqlParameter[i].ParameterName = item.Key;
                sqlParameter[i].Value = item.Value;

                i++;

            }
            return sqlParameter;
        }


        public static SqlParameter[] ToSqlParameters(this DataTable _DataTable)
        {
            int i = 0;
            SqlParameter[] sqlParameter = new SqlParameter[_DataTable.Rows.Count];

            foreach (DataRow item in _DataTable.Rows)
            {
                sqlParameter[i] = new SqlParameter();
                sqlParameter[i].ParameterName = item["Name"].ToString();
                sqlParameter[i].Value = item["Value"].ToString();

                i++;

            }
            return sqlParameter;
        }
    }
}