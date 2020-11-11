using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


namespace M6.PublicAPI
{
    public class DAO : BaseConn
    {
        public DAO()
        {
        }

        #region Method
        public static DataSet FillDataSet(string _query)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = _query;
            command.CommandType = CommandType.Text;
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

        public static DataSet FillDataSet(string _procedure, DataTable _paramTable)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = _procedure;
            command.CommandType = CommandType.StoredProcedure;
            SqlConnection staticConnection = StaticSqlConnection;
            command.Connection = staticConnection;
            SqlDataAdapter sqlAdapter = new SqlDataAdapter(command);
            DataSet ds = new DataSet();

            try
            {
                SqlParameter[] sqlParameter = ParameterHelper.GetParameters(_paramTable);
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
      
        public static DataSet FillDataSet(string _procedure, params SqlParameter[] _sqlparameters)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = _procedure;
            command.CommandType = CommandType.StoredProcedure;
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

        public static DataSet FillDataSet(string _procedure, Dictionary<string, object> _paramDic)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = _procedure;
            command.CommandType = CommandType.StoredProcedure;
            SqlConnection staticConnection = StaticSqlConnection;
            command.Connection = staticConnection;
            SqlDataAdapter sqlAdapter = new SqlDataAdapter(command);
            DataSet ds = new DataSet();

            try
            {
                SqlParameter[] sqlParameter = ParameterHelper.GetParameters(_paramDic);
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

        public static DataSet FillDataSet(string _procedure, Dictionary<string, string> _paramDic)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = _procedure;
            command.CommandType = CommandType.StoredProcedure;
            SqlConnection staticConnection = StaticSqlConnection;
            command.Connection = staticConnection;
            SqlDataAdapter sqlAdapter = new SqlDataAdapter(command);
            DataSet ds = new DataSet();

            try
            {
                SqlParameter[] sqlParameter = ParameterHelper.GetParameters(_paramDic);
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

        #endregion
    }
}