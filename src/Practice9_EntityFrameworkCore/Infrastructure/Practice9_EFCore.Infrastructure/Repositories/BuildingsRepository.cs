using Microsoft.EntityFrameworkCore;
using Practice9_EFCore.Domain;
using Practice9_EFCore.Domain.Models;
using Practice9_EFCore.Domain.Repositories;

namespace Practice9_EFCore.Infrastructure.Repositories
{
    public class BuildingsRepository : IBuildingsRepository
    {
        private readonly CompaniesDbContext _dbContext;

        public BuildingsRepository(CompaniesDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<BuildingEntity>> Get() => await _dbContext.Buildings.AsNoTracking().ToListAsync();
        public async Task<Guid> Add(Guid id, string address, double xPos, double yPos)
        {
            BuildingEntity building = new BuildingEntity
            {
                Id = id,
                Address = address,
                XPosition = xPos,
                YPosition = yPos
            };
            await _dbContext.AddAsync(building);
            await _dbContext.SaveChangesAsync();
            return building.Id;
        }
        public async Task<Guid> Update(Guid id, string address, double xPos, double yPos)
        {
            await _dbContext.Buildings
                .Where(building => building.Id == id)
                .ExecuteUpdateAsync(s => s
                .SetProperty(b => b.Address, address)
                .SetProperty(b => b.XPosition, xPos)
                .SetProperty(b => b.YPosition, yPos));
            await _dbContext.SaveChangesAsync();
            return id;
        }
        public async Task<Guid> Delete(Guid id)
        {
            await _dbContext.Buildings
                .Where(building => building.Id == id)
                .ExecuteDeleteAsync();
            await _dbContext.SaveChangesAsync();
            return id;
        }
    }
}
