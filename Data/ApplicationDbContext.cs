using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PruebasNetCore.Models;

namespace PruebasNetCore.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<PruebasNetCore.Models.Client> Client { get; set; }
        public DbSet<PruebasNetCore.Models.Country> Country { get; set; }
    }
}
