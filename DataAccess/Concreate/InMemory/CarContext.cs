using Entities.Concreate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //Context : Db tabloları ile proje classlarını bağlamak
    public class CarContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=SQL_ReCapProject;Trusted_Connection=true");
        }

        public DbSet<Car> Products { get; set; }
        public DbSet<Color> Categories { get; set; }
        public DbSet<Brand> Customers { get; set; }


    }
}