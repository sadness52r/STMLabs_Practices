using Practice9_EFCore.Domain.Models;

namespace Practice9_EFCore.Services
{
    public interface ICompaniesService
    {
        Task<List<CompanyEntity>> GetByBuilding(Guid buildingId);
        Task<CompanyEntity?> GetById(Guid id);
        Task<List<CompanyEntity>> GetByInnerRubrics(Guid rubricId);
        Task<CompanyEntity?> GetByName(string name);
        Task<List<CompanyEntity>> GetByRubric(Guid rubricId);
        Task<List<CompanyEntity>> GetInRadius(double radius, double xCenter, double yCenter);
        Task<List<CompanyEntity>> GetInRectangle(double xLeft, double yLeft, double xRight, double yRight);
    }
}