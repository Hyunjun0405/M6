using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using M6.Data;

namespace M6.Web.Controllers
{
    public class EntityController : ApiController
    {
        
        [HttpGet]
        public IHttpActionResult Get() 
        {
            DataTable dt = BaseData.GetDataSet(CommandType.Text, "SELECT TOP 10 * FROM 코드").Tables[0];
            //List<Employee> employeeList = dtTable.DataTableToList<Employee>();

            IEnumerable<기초코드> list = dt.ToIEnumerable<기초코드>().ToList();

            return Ok(list);            
        }

        [HttpGet]
        public IHttpActionResult GetData<T>(string _query, T param) where T : class
        {
            DataTable dt = BaseData.GetDataSet(CommandType.Text, _query).Tables[0];
            return Ok(dt.ToIEnumerable<CodeTypeOfExpression()>().ToList());
        }

        //[HttpGet]
        //public IHttpActionResult GetData<T>([FromBody] List<T> list) where T : class
        //{
        //    List<T> myList = new List<T>();
        //    IEnumerable<T> myEnumerable = myList;
        //    //List<T> listAgain = myList as List<T>() ?? myEnumerable.ToList();
        //    return Ok(myEnumerable);

        //}

        //[HttpGet]
        //public IHttpActionResult GetData<T>(string _query, List<T> list) where T : class
        //{
        //    List<T> myList = new List<T>();
        //    IEnumerable<T> myEnumerable = myList;
        //    //List<T> listAgain = myList as List<T>() ?? myEnumerable.ToList();
        //    return Ok(myEnumerable);

        //}

        //[HttpPost]
        //public DataSet GetData(CommandType _type, string _query)
        //{
        //    return BaseData.GetDataSet(_type, _query);
        //}

        //[HttpPost]
        //public DataSet GetData(CommandType _type, string _query, [FromBody] Dictionary<string, object> _paramDic)
        //{
        //    return BaseData.GetDataSet(_type, _query, _paramDic);
        //}

        //[HttpPost]
        //public DataSet GetData(CommandType _type, string _query, [FromBody] SqlParameter[] _sqlparameters)
        //{
        //    return BaseData.GetDataSet(_type, _query, _sqlparameters);
        //}

        //[HttpPost]
        //public DataSet GetData(CommandType _type, string _query, [FromBody] DataTable _paramTable)
        //{
        //    return BaseData.GetDataSet(_type, _query, _paramTable);
        //}
    }
}
