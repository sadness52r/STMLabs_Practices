using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Practice9_EFCore.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice9_EFCore.Domain.Configurations
{
    internal class CompanyConfiguration : IEntityTypeConfiguration<CompanyEntity>
    {
        public void Configure(EntityTypeBuilder<CompanyEntity> builder)
        {
            builder.HasKey(company =>  company.Id);
            builder
                .HasOne(company => company.Building)
                .WithMany(building => building.Companies)
                .HasForeignKey(company => company.BuildingId);
            builder
                .HasMany(company => company.Rubrics)
                .WithMany(rubric => rubric.Companies);
        }
    }
}
