using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeExerciseGAC.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeExerciseGAC.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }

        public DbSet<Customers> Customer { get; set; }
        public DbSet<Manufacturer > Manufacturers { get; set; }
        public DbSet<Products> Product { get; set; }
        public DbSet<SalesOrder> SalesOrders { get; set; }
        public DbSet<SalesOrderDetails> SalsOrderDetail { get; set; }
    }
}
