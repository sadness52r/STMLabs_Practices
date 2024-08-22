using Practice9_EFCore.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice9_EFCore.Domain.Repositories
{
    public interface IBuildingsService
    {
        public Task<List<BuildingEntity>> GetAllBuildingsAsync();
        public Task<Guid> Add(Guid id, string address, double xPos, double yPos);
        public Task<Guid> Update(Guid id, string address, double xPos, double yPos);
        public Task<Guid> Delete(Guid id);
    }
}
