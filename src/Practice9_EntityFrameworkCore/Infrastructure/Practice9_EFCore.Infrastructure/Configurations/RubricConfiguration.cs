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
    internal class RubricConfiguration : IEntityTypeConfiguration<RubricEntity>
    {
        public void Configure(EntityTypeBuilder<RubricEntity> builder)
        {
            builder.HasKey(rubric => rubric.Id);
            builder
                .HasOne(rubric => rubric.ParentRubric)
                .WithMany(parentRubric => parentRubric.InnerRubrics)
                .HasForeignKey(rubric => rubric.ParentRubricId);
            builder
                .HasMany(rubric => rubric.Companies)
                .WithMany(company => company.Rubrics);
        }
    }
}
