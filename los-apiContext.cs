using los_api;
using los_api.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APITutorials
{
    public class los_apiContext : DbContext
    {
        public los_apiContext(DbContextOptions<los_apiContext> options)
           : base(options)
        {
        }

        public DbSet<Product> Product { get; set; }
        public DbSet<Stock> Stock { get; set; }
    }
}
