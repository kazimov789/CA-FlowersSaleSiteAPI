using Fiorella.Core.Entities;
using Fiorella.Data.Configurations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiorella.Data
{
    public class FiorellaDbContext: IdentityDbContext
    {
        public FiorellaDbContext(DbContextOptions<FiorellaDbContext> options) : base(options)
        {
        }

        public DbSet<Flowers> Flowers { get; set; }
        public DbSet<FlowerImages> FlowerImages { get; set; }
        public DbSet<Categorys> Categorys { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CategoryConfiguration).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }   
}
