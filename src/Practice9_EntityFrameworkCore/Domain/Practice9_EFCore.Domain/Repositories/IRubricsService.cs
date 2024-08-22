using Practice9_EFCore.Domain.Models;

namespace Practice9_EFCore.Services
{
    public interface IRubricsService
    {
        Task<List<Guid>> GetAllSubRubrics(Guid id);
        Task<List<RubricEntity>> GetRubricsWithHierarchy();
    }
}