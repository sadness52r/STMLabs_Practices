using Microsoft.EntityFrameworkCore;
using Practice9_EFCore.Domain;
using Practice9_EFCore.Domain.Models;
using Practice9_EFCore.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice9_EFCore.Infrastructure.Repositories
{
    public class RubricsRepository : IRubricsRepository
    {
        private readonly CompaniesDbContext _dbContext;

        public RubricsRepository(CompaniesDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Guid>> GetAllSubRubrics(Guid id)
        {
            var subRubricsId = await _dbContext.Rubrics
                .AsNoTracking()
                .Where(r => r.ParentRubricId == id)
                .Select(r => r.Id)
                .ToListAsync();
            var recursiveSubRubrics = new List<Guid>(subRubricsId);
            foreach (var subRubricId in subRubricsId)
            {
                recursiveSubRubrics.AddRange(await GetAllSubRubrics(subRubricId));
            }
            return recursiveSubRubrics;
        }
        public async Task<List<RubricEntity>> GetRubricsWithHierarchy()
        {
            var rubrics = await _dbContext.Rubrics.AsNoTracking().ToListAsync();
            var rootRubrics = rubrics
                .Where(r => r.ParentRubricId == null)
                .ToList();
            var childRubrics = rubrics
                .Where(r => r.ParentRubricId != null)
                .ToList();
            var rubricDictionary = childRubrics
                .GroupBy(r => r.ParentRubricId)
                .ToDictionary(g => g.Key.Value, g => g.ToList());

            List<RubricEntity> BuildHierarchy(RubricEntity parentRubric)
            {
                var hierarchy = new List<RubricEntity>();
                if (rubricDictionary.TryGetValue(parentRubric.Id, out var childRubrics))
                {
                    foreach (var childRubric in childRubrics)
                    {
                        hierarchy.Add(childRubric);

                        var childHierarchy = BuildHierarchy(childRubric);
                        if (childHierarchy.Any())
                        {
                            childRubric.InnerRubrics.AddRange(childHierarchy);
                        }
                    }
                }
                return hierarchy;
            }

            var hierarchy = new List<RubricEntity>();
            foreach (var rootRubric in rootRubrics)
            {
                var rootHierarchy = BuildHierarchy(rootRubric);
                hierarchy.Add(rootRubric);
                if (rootHierarchy.Any())
                {
                    rootRubric.InnerRubrics.AddRange(rootHierarchy);
                }
            }
            return hierarchy;
        }
    }
}
