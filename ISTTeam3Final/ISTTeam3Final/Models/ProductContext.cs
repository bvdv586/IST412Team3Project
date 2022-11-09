using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ISTTeam3Final.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext() : base("LogisticalEnterprises")
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

    }
}