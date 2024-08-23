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

            var building1Id = Guid.NewGuid();
            var building2Id = Guid.NewGuid();
            modelBuilder.Entity<BuildingEntity>().HasData(
                new BuildingEntity { Id = building1Id, Address = "Блюхера, 32/1", XPosition = 32.5, YPosition = 12.6 },
                new BuildingEntity { Id = building2Id, Address = "Сахарова, 72/15", XPosition = 231.32, YPosition = 1.5 }
            );

            // Создание тестовых данных для RubricEntity
            var rubric1Id = Guid.NewGuid(); // Еда
            var rubric2Id = Guid.NewGuid(); // Полуфабрикаты оптом
            var rubric3Id = Guid.NewGuid(); // Мясная продукция

            modelBuilder.Entity<RubricEntity>().HasData(
                new RubricEntity { Id = rubric1Id, Name = "Еда" },
                new RubricEntity { Id = rubric2Id, Name = "Полуфабрикаты оптом", ParentRubricId = rubric1Id },
                new RubricEntity { Id = rubric3Id, Name = "Мясная продукция", ParentRubricId = rubric2Id }
            );

            // Создание тестовых данных для CompanyEntity
            var company1Id = Guid.NewGuid();
            var company2Id = Guid.NewGuid();

            modelBuilder.Entity<CompanyEntity>().HasData(
                new CompanyEntity { Id = company1Id, Name = "ООО Рога и Копыта", BuildingId = building1Id, Phones = ["2-222-222", "3-333-333"] },
                new CompanyEntity { Id = company2Id, Name = "ООО Мясной Продукт", BuildingId = building2Id, Phones = ["8-923-666-13-13"] }
            );

            // Связывание компаний с рубриками
            modelBuilder.Entity<CompanyEntity>()
                .HasMany(c => c.Rubrics)
                .WithMany(r => r.Companies)
                .UsingEntity(j => j.HasData(
                    new { CompaniesId = company1Id, RubricsId = rubric2Id },
                    new { CompaniesId = company2Id, RubricsId = rubric3Id }
                ));
        }
    }
}
