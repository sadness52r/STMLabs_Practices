using Practice9_EFCore.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice9_EFCore.Domain.Repositories
{
    public interface IRubricsRepository
    {
        Task<List<Guid>> GetAllSubRubrics(Guid id);
        Task<List<RubricEntity>> GetRubricsWithHierarchy();
    }
}
