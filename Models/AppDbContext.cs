using AFFMUSA.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AFFMUSA.Models.Lists;

namespace MultiAplicacion.Models
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Client> Client { get; set; }

        public DbSet<Country> Country { get; set; }

        public DbSet<States> States { get; set; }
       
    }
}
