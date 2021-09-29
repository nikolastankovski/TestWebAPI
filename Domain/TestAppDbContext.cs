using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class TestAppDbContext : DbContext
    {
        public TestAppDbContext(DbContextOptions options) : base() { }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Reference> References { get; set; }
        public DbSet<ReferenceType> ReferenceTypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {       
            optionsBuilder.UseSqlServer(
                @"Data Source=UNKNOWN\LOCALHOST;Initial Catalog=TestWebApp;Trusted_Connection=True",
                b => b.MigrationsAssembly("Test_WebApp")
            );
        }

    }
}
