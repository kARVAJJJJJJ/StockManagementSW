using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using StockManagementSW.Classes;

namespace StockManagementSW
{
    class StockDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Stock> Stocks { get; set; }    
        public DbSet<Storage> Storages { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
