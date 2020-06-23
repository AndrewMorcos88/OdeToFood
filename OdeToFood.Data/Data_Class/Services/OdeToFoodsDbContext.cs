using OdeToFood.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Services
{
   public class OdeToFoodsDbContext : DbContext
    {
        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
