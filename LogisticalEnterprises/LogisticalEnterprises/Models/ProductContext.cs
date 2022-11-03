using System.Data.Entity;


namespace LogisticalEnterprises.Models
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
