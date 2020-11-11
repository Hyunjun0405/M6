using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace M6.Web.Controllers
{
    public class BaseData : BaseConn
    {
       
        public static DataSet GetDataSet(CommandType _type, string _query)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = _query;
            command.CommandType = _type;
            SqlConnection staticConnection = StaticSqlConnection;
            command.Connection = staticConnection;
            SqlDataAdapter sqlAdapter = new SqlDataAdapter(command);
            DataSet ds = new DataSet();

            try
            {
                staticConnection.Open();
                sqlAdapter.Fill(ds);

                return ds;

            }
            catch
            {
                throw;
            }
            finally
            {
                staticConnection.Close();
                command.Dispose();
            }

        }

        public static DataSet GetDataSet(CommandType _type, string _query, DataTable _paramTable)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = _query;
            command.CommandType = _type;
            SqlConnection staticConnection = StaticSqlConnection;
            command.Connection = staticConnection;
            SqlDataAdapter sqlAdapter = new SqlDataAdapter(command);
            DataSet ds = new DataSet();

            try
            {
                SqlParameter[] sqlParameter = BaseParam.GetParameters(_paramTable);
                staticConnection.Open();
                sqlAdapter.Fill(ds);

                return ds;

            }
            catch
            {
                throw;
            }
            finally
            {
                staticConnection.Close();
                command.Dispose();
            }

        }

        public static DataSet GetDataSet(CommandType _type, string _query, Dictionary<string, object> _paramDic)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = _query;
            command.CommandType = _type;
            SqlConnection staticConnection = StaticSqlConnection;
            command.Connection = staticConnection;
            SqlDataAdapter sqlAdapter = new SqlDataAdapter(command);
            DataSet ds = new DataSet();

            try
            {
                SqlParameter[] sqlParameter = BaseParam.GetParameters(_paramDic);
                staticConnection.Open();
                sqlAdapter.Fill(ds);

                return ds;

            }
            catch
            {
                throw;
            }
            finally
            {
                staticConnection.Close();
                command.Dispose();
            }

        }        

        public static DataSet GetDataSet(CommandType _type, string _query, SqlParameter[] _sqlparameters)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = _query;
            command.CommandType = _type;
            SqlConnection staticConnection = StaticSqlConnection;
            command.Connection = staticConnection;
            SqlDataAdapter sqlAdapter = new SqlDataAdapter(command);

            DataSet ds = new DataSet();

            try
            {
                command.Parameters.AddRange(_sqlparameters);
                staticConnection.Open();
                sqlAdapter.Fill(ds);

                return ds;

            }
            catch
            {
                throw;
            }
            finally
            {
                staticConnection.Close();
                command.Dispose();
            }

        }
    }
}