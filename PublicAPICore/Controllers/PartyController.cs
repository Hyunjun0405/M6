using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using M6.Data;
using M6.Data.Models;
using M6.Business;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PublicAPICore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PartyController : Controller
    {
        //private IGenericRepository<공항> repository = null;

        public PartyController()
        {
            //this.repository = new GenericRepository<공항>();
        }

        //public PartyController(IGenericRepository<개체> repository)
        //{
        //    this._repository = new GenericRepository<개체>();
        //}
        // GET: api/<PartyController>
        [HttpGet]
        public ActionResult<IEnumerable<공항>> Index()
        {
            //var rs = repository.List();
            //return rs.ToList();
            return null;
        }

    }
}
