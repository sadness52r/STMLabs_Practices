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
    internal class BuildingConfiguration : IEntityTypeConfiguration<BuildingEntity>
    {
        public void Configure(EntityTypeBuilder<BuildingEntity> builder)
        {
            builder.HasKey(building => building.Id);
            builder
                .HasMany(building => building.Companies)
                .WithOne(company => company.Building)
                .HasForeignKey(company => company.BuildingId);
        }
    }
}
