using Practice9_EFCore.Domain.Models;

namespace Practice9_EFCore.Contracts
{
    public record CompaniesResponse(
       Guid Id,
       string Name,
       List<string> Phones,
       BuildingEntity? Building,
       List<RubricEntity> Rubrics);
}
