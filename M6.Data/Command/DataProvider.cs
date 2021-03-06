﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


namespace M6.Data.Command

{
    public class DataProvider : ConnectionProvider
    {
        //public static DataSet GetDateSet()
        //{
        //    return null;
        //}

        //public static DataSet GetDataSet(CommandType _type, string _query)
        //{
        //    DataSet ds = new DataSet();
        //    SqlConnection staticConnection = StaticSqlConnection;
        //    SqlCommand command = new SqlCommand(_query, staticConnection);
        //    SqlDataAdapter sqlAdapter = new SqlDataAdapter(command);
        //    command.CommandType = _type;
        //    try
        //    {
        //        staticConnection.Open();
        //        sqlAdapter.Fill(ds);
        //        return ds;

        //    }
        //    catch
        //    {
        //        throw;
        //    }
        //    finally
        //    {
        //        staticConnection.Close();
        //        command.Dispose();
        //    }

        //}

        //public static DataSet GetDataSet(CommandType _type, string _query, DataTable _DataTable)
        //{
        //    DataSet ds = new DataSet();
        //    SqlConnection staticConnection = StaticSqlConnection;
        //    SqlCommand command = new SqlCommand(_query, staticConnection);
        //    SqlDataAdapter sqlAdapter = new SqlDataAdapter(command);
        //    command.CommandType = _type;
        //    command.Parameters.AddRange(_DataTable.ToSqlParameters());
        //    try
        //    {
        //        staticConnection.Open();
        //        sqlAdapter.Fill(ds);
        //        return ds;
        //    }
        //    catch
        //    {
        //        throw;
        //    }
        //    finally
        //    {
        //        staticConnection.Close();
        //        command.Dispose();
        //    }

        //}

        //public static DataSet GetDataSet(CommandType _type, string _query, Dictionary<string, object> _Dictionary)
        //{
        //    DataSet ds = new DataSet();
        //    SqlConnection staticConnection = StaticSqlConnection;
        //    SqlCommand command = new SqlCommand(_query, staticConnection);
        //    SqlDataAdapter sqlAdapter = new SqlDataAdapter(command);
        //    command.CommandType = _type;
        //    command.Parameters.AddRange(_Dictionary.ToSqlParameters());
        //    try
        //    {
        //        staticConnection.Open();
        //        sqlAdapter.Fill(ds);
        //        return ds;
        //    }
        //    catch
        //    {
        //        throw;
        //    }
        //    finally
        //    {
        //        staticConnection.Close();
        //        command.Dispose();
        //    }

        //}

        //public static DataSet GetDataSet(CommandType _type, string _query, SqlParameter[] _SqlParameters)
        //{

        //    DataSet ds = new DataSet();
        //    SqlConnection staticConnection = StaticSqlConnection;
        //    SqlCommand command = new SqlCommand(_query, staticConnection);
        //    SqlDataAdapter sqlAdapter = new SqlDataAdapter(command);
        //    command.CommandType = _type;
        //    command.Parameters.AddRange(_SqlParameters);
        //    try
        //    {
        //        staticConnection.Open();
        //        sqlAdapter.Fill(ds);
        //        return ds;
        //    }
        //    catch
        //    {
        //        throw;
        //    }
        //    finally
        //    {
        //        staticConnection.Close();
        //        command.Dispose();
        //    }

        //}

        public static DataSet GetDataSet(string _query)
        {

            DataSet ds = new DataSet();
            SqlConnection staticConnection = StaticSqlConnection;
            SqlCommand command = new SqlCommand(_query, staticConnection);
            SqlDataAdapter sqlAdapter = new SqlDataAdapter(command);
            command.CommandType = CommandType.Text;

            try
            {
                StaticSqlConnection.Open();
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

        public static DataSet GetDataSet(string _query, CommandType _type)
        {

            DataSet ds = new DataSet();
            SqlConnection staticConnection = StaticSqlConnection;
            SqlCommand command = new SqlCommand(_query, staticConnection);
            SqlDataAdapter sqlAdapter = new SqlDataAdapter(command);
            command.CommandType = CommandType.Text;

            try
            {
                StaticSqlConnection.Open();
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

        public static DataSet GetDataSet<T>(string _query, CommandType _type,  T param)
        {

            DataSet ds = new DataSet();
            SqlConnection staticConnection = StaticSqlConnection;
            SqlCommand command = new SqlCommand(_query, staticConnection);
            SqlDataAdapter sqlAdapter = new SqlDataAdapter(command);
            command.CommandType = _type;

            if (typeof(T) == typeof(DataTable))
            {
                DataTable datatable = param as DataTable;
                command.Parameters.AddRange(datatable.ToSqlParameters());
            }
            else if (typeof(T) == typeof(Dictionary<string, object>))
            {
                Dictionary<string, object> dictionary = param as Dictionary<string, object>;
                command.Parameters.AddRange(dictionary.ToSqlParameters());
            }
            else if (typeof(T) == typeof(SqlParameter[]))
            {
                SqlParameter[] sqlparameters = param as SqlParameter[];
                command.Parameters.AddRange(sqlparameters);
            }


            try
            {
                StaticSqlConnection.Open();
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