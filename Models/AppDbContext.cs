using AFFMUSA.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AFFMUSA.Models.Lists;
using PruebasNetCore.Models;

namespace MultiAplicacion.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Country> Countries { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>().HasData(
                new Client
                {
                    ClientID = 1,
                    Company_Name = "HR Company",
                    Contact_Name = "Julio",
                    Job_Title = "Encargado de Suministros",
                    Email = "julio@hrcompany.com",
                    Phone = "890-878-8979",
                    Ext = 123,
                    Fax = "7487583758",
                    City = "Texas",
                    ZipCode = 54000,
                    Notes = "good worker"
                });

            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    CountryID = 1,
                    CountryName = "United States"
                });
        }
    }
}
