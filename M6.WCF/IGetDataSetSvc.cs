using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using M6.Data;

namespace M6.WCF
{
    [ServiceContract]
    public partial interface IGetDataSetSvc
    {

        [OperationContract]
        DataSet GetDataSet<T>(CommandType _type, string _query, T param);

        //[OperationContract]
        //DataSet GetDataSet(string _query);

        //[OperationContract]
        //DataSet GetDataSet(CommandType _type, string _query);

        //[OperationContract]
        //DataSet GetDataSet(CommandType _type, string _query, DataTable _DataTable);

        //[OperationContract]
        //DataSet GetDataSet(CommandType _type, string _query, Dictionary<string, object> _Dictionary);

        //[OperationContract]
        //DataSet GetDataSet(CommandType _type, string _query, SqlParameter[] _SqlParameters);

        //[OperationContract]
        //DataSet GetDataSet<T>(CommandType _type, string _query, T param);
    }
}