using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WAD_T2104E_NguyenHoangSon.Models
{
    public class ProductDBContext: DbContext
    {
        public ProductDBContext() : base("name=productDBConnection")
        {

        }
        public DbSet<Product> products { get; set; }
        public DbSet<Category> categories { get; set; }
    }
}