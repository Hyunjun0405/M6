using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using M6.Data.Command;

namespace M6.WCF
{
    [ServiceContract]
    partial interface IWCFService 
    {
        //[OperationContract]
        //DataSet GetDataSet<T>(string _query, CommandType _type,  T param)
        //{
        //    return DataProvider.GetDataSet<T>(_query, _type, param);
        //}

        //[OperationContract]
        //DataSet GetDataSet(string _query);

        //[OperationContract]
        //DataSet GetDataSet(string _query, CommandType _type );

        //[OperationContract]
        //DataSet GetDataSet(string _query, CommandType _type, DataTable _datatable);

        //[OperationContract]
        //DataSet GetDataSet(string _query, CommandType _type, SqlParameter[] _sqlparameter);
       
        //[OperationContract]
        //DataSet GetDataSet(string _query, CommandType _type,  Dictionary<String, object> _dictionary);
       
    }
}
