using Microsoft.EntityFrameworkCore;
using Practice9_EFCore.Domain.Models;
using Practice9_EFCore.Domain.Repositories;
using System.Net;

namespace Practice9_EFCore.Services
{
    public class BuildingsService : IBuildingsService
    {
        private readonly IBuildingsRepository _buildingsRepository;

        public BuildingsService(IBuildingsRepository buildingsRepository) => _buildingsRepository = buildingsRepository;

        public Task<List<BuildingEntity>> GetAllBuildingsAsync() => _buildingsRepository.Get();
        public Task<Guid> Add(Guid id, string address, double xPos, double yPos) => _buildingsRepository.Add(id, address, xPos, yPos);
        public Task<Guid> Update(Guid id, string address, double xPos, double yPos) => _buildingsRepository.Update(id, address, xPos, yPos);
        public Task<Guid> Delete(Guid id) => _buildingsRepository.Delete(id);
    }
}
