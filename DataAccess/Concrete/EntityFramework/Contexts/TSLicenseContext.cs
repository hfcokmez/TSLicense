using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.Contexts
{
    public class TSLicenseContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Server=DESKTOP-83EN9LJ\SQLEXPRESS;Database=TSLicense;Trusted_Connection=true");
        }
        public DbSet<Product> Product { get; set; }
        public DbSet<Group> ProductGroup { get; set; }
        public DbSet<Serial> ProductSerial { get; set; }
    }
}
