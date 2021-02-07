using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class MillenniumShopContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=EMIRHANDGNDMR;Database=MillenniumShop; Trusted_Connection = true");
        }

        private DbSet<Manager> Managers { get; set; }
        private DbSet<Product> Products { get; set; }
        private DbSet<Category> Categories { get; set; }
        private DbSet<Customer> Customers { get; set; }


    }
}
