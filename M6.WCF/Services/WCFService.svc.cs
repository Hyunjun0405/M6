using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using M6.Data.Command;

namespace M6.WCF
{
    [ServiceContract]
    public class WCFService 
    {
        //[OperationContract]
        //public virtual DataSet GetDataSet<T>(CommandType _type, string _query, T param)
        //{
        //    return DataProvider.GetDataSet<T>(_query, _type, param);
        //}

        [OperationContract(Name ="DataSetByQuery")]
        public virtual DataSet GetDataSet(string _query)
        {
            return DataProvider.GetDataSet(_query);
        }

        [OperationContract(Name = "DataSetByQueryWithType")]
        public virtual DataSet GetDataSet(string _query, CommandType _type)
        {
            return DataProvider.GetDataSet(_query, _type);
        }

        [OperationContract(Name = "DataSetByDataTable")]
        public virtual DataSet GetDataSet(string _query, CommandType _type, DataTable _datatable)
        {
            return DataProvider.GetDataSet<DataTable>(_query, _type, _datatable);
        }

        [OperationContract(Name = "DataSetBySqlParameterArray")]
        public virtual DataSet GetDataSet(string _query, CommandType _type, SqlParameter[] _sqlparameter)
        {
            return DataProvider.GetDataSet<SqlParameter[]>(_query, _type, _sqlparameter);
        }

        [OperationContract(Name = "DataSetByDictionary")]
        public virtual DataSet GetDataSet(string _query, CommandType _type, Dictionary<String, object> _dictionary)
        {
            return DataProvider.GetDataSet<Dictionary<String, object>>(_query, _type, _dictionary);
        }
        

    }
}
