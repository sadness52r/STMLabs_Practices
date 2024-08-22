using Microsoft.EntityFrameworkCore;
using Practice9_EFCore.Domain.Configurations;
using Practice9_EFCore.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice9_EFCore.Domain
{
    public class CompaniesDbContext(DbContextOptions<CompaniesDbContext> options) : DbContext(options)
    {
        public DbSet<BuildingEntity> Buildings { get; set; }
        public DbSet<CompanyEntity> Companies { get; set; }
        public DbSet<RubricEntity> Rubrics { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BuildingConfiguration());
            modelBuilder.ApplyConfiguration(new CompanyConfiguration());
            modelBuilder.ApplyConfiguration(new RubricConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
