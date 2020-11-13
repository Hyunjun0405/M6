using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using M6.Data.Models;
using M6.Web.Models;
using Microsoft.AspNet.OData;

namespace M6.Web.Controllers
{
    public class 코드Controller : ApiController
    {
        M6Context db = new M6Context();

        public List<코드> Get()
        {
            return db.코드.ToList();
        }
    }
}
