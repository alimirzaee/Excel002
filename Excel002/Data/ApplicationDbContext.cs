using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Excel002.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Excel002.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
 
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }

        public ApplicationDbContext( )          
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                /*IConfigurationRoot configuration = new ConfigurationBuilder()
                   .SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("~/appsettings.json")
                   .Build();*/
                var connectionString = "Server=(localdb)\\mssqllocaldb;Database=Excel002-Db;Trusted_Connection=True;MultipleActiveResultSets=true";// configuration.GetConnectionString("Server=(localdb)\\mssqllocaldb;Database=Excel002-Db;Trusted_Connection=True;MultipleActiveResultSets=true");
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        public DbSet<AppFile> File { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<City> Cities { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Excel002.Models.InvoiceItem> InvoiceItem { get; set; }
    }
}
