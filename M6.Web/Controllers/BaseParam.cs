using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace M6.Web.Controllers
{
    public class BaseParam
    {

        protected SqlParameter[] sqlParam = null;

        public BaseParam()
        {
        }

        public static SqlParameter[] GetParameters(Dictionary<string, object> _paramDic)
        {
            int i = 0;
            SqlParameter[]  sqlParam = new SqlParameter[_paramDic.Count];

            foreach (var item in _paramDic)
            {
                sqlParam[i] = new SqlParameter();
                sqlParam[i].ParameterName = item.Key;
                sqlParam[i].Value = item.Value;

                i++;

            }
            return sqlParam;
        }

        public static SqlParameter[] GetParameters(DataTable _paramTable)
        {
            int i = 0;
            SqlParameter[] sqlParam = new SqlParameter[_paramTable.Rows.Count];

            foreach (DataRow item in _paramTable.Rows)
            {
                sqlParam[i] = new SqlParameter();
                sqlParam[i].ParameterName = item["Name"].ToString();
                sqlParam[i].Value = item["Value"].ToString();

                i++;

            }
            return sqlParam;
        }
    }

    public class Parmeter
    {
        public DataTable dt = null;

        public static DataTable Table()
        {

            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[] { new DataColumn("Name"),                                                   
                                                   new DataColumn("Value"),
                                                   new DataColumn("Type"),
                                                   new DataColumn("Size")
            }
            );
            dt.Columns["Value"].DataType = Type.GetType("System.Object");

            return dt;
        }

        public void ADD(string _name, object _value)
        {
            dt.Rows.Add(_name, _value, null);
        }

        public void ADD(string _name, object _value, string _type, int _size)
        {
            dt.Rows.Add(_name, _value, _type , _size);
        }       
    }
}