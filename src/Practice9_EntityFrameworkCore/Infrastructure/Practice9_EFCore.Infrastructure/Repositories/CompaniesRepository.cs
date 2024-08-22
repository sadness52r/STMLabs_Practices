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
    public class CompaniesRepository : ICompaniesRepository
    {
        private readonly CompaniesDbContext _dbContext;
        private readonly RubricsRepository _rubricsRepository;

        public CompaniesRepository(CompaniesDbContext dbContext)
        {
            _dbContext = dbContext;
            _rubricsRepository = new RubricsRepository(dbContext);
        }

        public async Task<List<CompanyEntity>> GetByBuilding(Guid buildingId) => await _dbContext.Companies
            .AsNoTracking()
            .Where(company => company.BuildingId == buildingId)
            .ToListAsync();
        public async Task<List<CompanyEntity>> GetByRubric(Guid rubricId) => await _dbContext.Companies
            .AsNoTracking()
            .Where(company => company.Rubrics.Any(rubric => rubric.Id == rubricId))
            .ToListAsync();
        public async Task<CompanyEntity?> GetById(Guid id) => await _dbContext.Companies
            .AsNoTracking()
            .FirstOrDefaultAsync(company => company.Id == id);
        public async Task<CompanyEntity?> GetByName(string name) => await _dbContext.Companies
            .AsNoTracking()
            .FirstOrDefaultAsync(company => company.Name == name);
        public async Task<List<CompanyEntity>> GetInRadius(double radius, double xCenter, double yCenter) => await _dbContext.Companies
            .AsNoTracking()
            .Where(company => company.Building != null && 
            CheckInRadius(radius, company.Building.XPosition, company.Building.YPosition, xCenter, yCenter))
            .ToListAsync();
        public async Task<List<CompanyEntity>> GetInRectangle(double xLeft, double yLeft, double xRight, double yRight) => await _dbContext.Companies
            .AsNoTracking()
            .Where(company => company.Building != null &&
            CheckInRectangle(xLeft, yLeft, xRight, yRight, company.Building.XPosition, company.Building.YPosition))
            .ToListAsync();
        public async Task<List<CompanyEntity>> GetByInnerRubrics(Guid rubricId)
        {
            var allSubRubricsId = await _rubricsRepository.GetAllSubRubrics(rubricId);
            return await _dbContext.Rubrics
                .AsNoTracking()
                .Where(r => allSubRubricsId.Contains(r.Id))
                .SelectMany(r => r.Companies)
                .Distinct()
                .ToListAsync();
        }

        private bool CheckInRadius(double radius, double x, double y, double xCenter, double yCenter) => 
            (x - xCenter) * (x - xCenter) + (y - yCenter) * (y - yCenter) <= radius * radius;
        private bool CheckInRectangle(double xLeft, double yLeft, double xRight, double yRight, double x, double y) =>
            x >= xLeft && x <= xRight && y <= yLeft && y >= yRight;
    }
}
