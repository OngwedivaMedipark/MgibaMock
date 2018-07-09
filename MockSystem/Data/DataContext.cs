using Microsoft.EntityFrameworkCore;
using MockSystem.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MockSystem.Data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<User> User { get; set; }
        public DbSet<Hospital> Hospital { get; set; }
    }
}
