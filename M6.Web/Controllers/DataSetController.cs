using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace M6.Web.Controllers
{
    public class DataSetController : ApiController
    {

        [HttpGet]
        public DataSet Get()
        {
            return BaseData.GetDataSet(CommandType.Text, "SELECT TOP 10 * FROM 코드");
        }

        [HttpGet]
        public DataSet GetData(string _query)
        {
            return BaseData.GetDataSet(CommandType.Text, _query);
        }

        [HttpPost]
        public DataSet GetData(CommandType _type, string _query)
        {
            return BaseData.GetDataSet(_type, _query);
        }        

        [HttpPost]
        public DataSet GetData(CommandType _type, string _query, [FromBody] Dictionary<string,object> _Dictionary)
        {
            return BaseData.GetDataSet<Dictionary<string, object>>(_type, _query, _Dictionary);
        }

        [HttpPost]
        public DataSet GetData(CommandType _type, string _query, [FromBody] SqlParameter[] _SqlParameters)
        {
            return BaseData.GetDataSet(_type, _query, _SqlParameters);
        }

        [HttpPost]
        public DataSet GetData(CommandType _type, string _query, [FromBody] DataTable _DataTable)
        {
            return BaseData.GetDataSet(_type, _query, _DataTable);
        }
    }
}
