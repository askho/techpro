using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace lab.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext() : base("ProductDB") { }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Product { get; set; }
    }
}