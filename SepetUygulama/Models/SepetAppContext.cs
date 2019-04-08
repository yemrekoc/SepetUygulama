using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SepetUygulama.Models
{
    public class SepetAppContext:DbContext
    {
        public SepetAppContext(DbContextOptions<SepetAppContext> options):base(options)
        {

        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
       
    }
}
