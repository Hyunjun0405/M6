using System;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Text;
using System.Web.Services;
using System.Web.Script.Services;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.Collections;

namespace M6.PublicAPI
{
    [WebService(Description ="", Namespace ="http://tempuri.org")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    [ScriptService]
    public partial class DataService :  System.Web.Services.WebService
    {
        [WebMethod(Description = "last modified at 2020-07-24 12:00", EnableSession = true)]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public DataSet GetDataSetByQuery(string _query)
        {
            return DAO.FillDataSet( _query);

        }

        [WebMethod(Description = "last modified at 2020-07-24 12:00", EnableSession = true)]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public DataSet GetDataSetByTable( string _procedure, DataTable _paramTable)
        {
            return DAO.FillDataSet(_procedure, _paramTable);

        }

        [WebMethod(Description = "last modified at 2020-07-24 12:00", EnableSession = true)]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public DataSet GetDataSetBySqlParameter(string _procedure, SqlParameter[] _sqlparameters)
        {
            return DAO.FillDataSet(_procedure, _sqlparameters);

        }

        //[WebMethod(Description = "last modified at 2020-07-24 12:00", EnableSession = true)]
        //[ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        //public DataSet GetDataSetByDictionay(string _procedure, Dictionary<string, string> _paramDic)
        //{
        //    return DAO.FillDataSet(_procedure, _paramDic);
        //}

        //[WebMethod(Description = "last modified at 2020-07-24 12:00", EnableSession = true)]
        //[ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        //public DataSet GetDataSetByHashTable(string _procedure, Hashtable _paramHash)
        //{
        //    return new DataSet();
        //}

        [WebMethod(Description = "last modified at 2020-07-24 12:00", EnableSession = true)]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public DataSet GetDataSetByObjectArray(string _procedure, Object [][] _paramObjectArray)
        {
            return new DataSet();
        }

    }
}