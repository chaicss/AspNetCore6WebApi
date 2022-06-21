using AspNetCore6WebApi.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCore6WebApi.DataAccess.DatabaseContexts
{
    public class DbCustomerContext : DbContext
    {
        public DbSet<Customer> CustomerTable { get; set; }

        public DbCustomerContext(DbContextOptions<DbCustomerContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().ToTable("customer");
        }
    }
}
