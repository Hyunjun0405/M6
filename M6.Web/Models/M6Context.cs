using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using M6.Data.Models;

namespace M6.Web.Models
{
    public class M6Context : DbContext
    {
        public M6Context() 
            : base("name=M6Context")
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<코드> 코드 { get; set; }
    }
}