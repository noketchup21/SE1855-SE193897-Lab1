using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DataAccessLayer
{
    public class MyStoreContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("\"Data Source=LAPTOP-JUBLI2B6\\\\SQLEXPRESS;Initial Catalog=SWP391_DB;User ID=SA;Password=12345;TrustServerCertificate=True;Encrypt=false;\"");
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<AccountMember> AccountMembers { get; set; }
    }
}
