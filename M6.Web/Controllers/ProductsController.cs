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
    public class ProductsController : ODataController
    {

        //private List<Product> products = new List<Product>()
        //{
        //    new Product()
        //    {
        //        ProductID = 1,
        //        ProductName = "Bread",
        //    }
        //};

        M6Context db = new M6Context();

        public List<M6.Web.Models.Product> Get()
        {
            return db.Products.ToList();
        }
    }
}
