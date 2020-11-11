using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using M6.Data;
using M6.Data.Models;
namespace PublicAPICore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NorthWindController : Controller
    {
        //private IGenericRepository<Categories> repository = null;

        public NorthWindController()
        {
            //this.repository = new GenericRepository<Categories>();
        }

        //public PartyController(IGenericRepository<개체> repository)
        //{
        //    this._repository = new GenericRepository<개체>();
        //}
        // GET: api/<PartyController>
        [HttpGet]
        public ActionResult<IEnumerable<Categories>> Index()
        {
            //var rs = repository.List();
            //return rs.ToList();

            return null;
        }

    }
}

