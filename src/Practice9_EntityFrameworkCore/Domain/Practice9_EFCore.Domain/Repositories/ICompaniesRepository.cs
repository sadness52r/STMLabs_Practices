using Microsoft.EntityFrameworkCore;
using Practice9_EFCore.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice9_EFCore.Domain.Repositories
{
    public interface ICompaniesRepository
    {
        Task<List<CompanyEntity>> GetByBuilding(Guid buildingId);
        Task<List<CompanyEntity>> GetByRubric(Guid rubricId);
        Task<CompanyEntity?> GetById(Guid id);
        Task<CompanyEntity?> GetByName(string name);
        Task<List<CompanyEntity>> GetInRadius(double radius, double xCenter, double yCenter);
        Task<List<CompanyEntity>> GetInRectangle(double xLeft, double yLeft, double xRight, double yRight);
        Task<List<CompanyEntity>> GetByInnerRubrics(Guid rubricId);
    }
}
