using Practice9_EFCore.Domain.Models;
using Practice9_EFCore.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice9_EFCore.Services
{
    public class CompaniesService : ICompaniesService
    {
        private readonly ICompaniesRepository _companiesRepository;

        public CompaniesService(ICompaniesRepository companiesRepository) => _companiesRepository = companiesRepository;

        public Task<List<CompanyEntity>> GetByBuilding(Guid buildingId) => _companiesRepository.GetByBuilding(buildingId);
        public Task<List<CompanyEntity>> GetByRubric(Guid rubricId) => _companiesRepository.GetByRubric(rubricId);
        public Task<CompanyEntity?> GetById(Guid id) => _companiesRepository.GetById(id);
        public Task<CompanyEntity?> GetByName(string name) => _companiesRepository.GetByName(name);
        public Task<List<CompanyEntity>> GetInRadius(double radius, double xCenter, double yCenter) =>
            _companiesRepository.GetInRadius(radius, xCenter, yCenter);
        public Task<List<CompanyEntity>> GetInRectangle(double xLeft, double yLeft, double xRight, double yRight) =>
            _companiesRepository.GetInRectangle(xLeft, yLeft, xRight, yRight);
        public Task<List<CompanyEntity>> GetByInnerRubrics(Guid rubricId) => _companiesRepository.GetByInnerRubrics(rubricId);
    }
}
