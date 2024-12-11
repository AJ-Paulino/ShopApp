using Microsoft.EntityFrameworkCore;
using ShopApp.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.DAL.Context
{
    public class ShopContext : DbContext
    {
        #region"Constructor"        
        public ShopContext (DbContextOptions<ShopContext> options) : base(options) 
        {

        }
        #endregion

        #region"DbSets"
        public DbSet<Custumers> Custumers { get; set; }
        public DbSet<Employees> Employees { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Products> Products { get; set; }
        #endregion
    }
}
