using Practice9_EFCore.Domain.Models;
using Practice9_EFCore.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice9_EFCore.Services
{
    public class RubricsService : IRubricsService
    {
        private readonly IRubricsRepository _rubricsRepository;

        public RubricsService(IRubricsRepository rubricsRepository) => _rubricsRepository = rubricsRepository;

        public Task<List<Guid>> GetAllSubRubrics(Guid id) => _rubricsRepository.GetAllSubRubrics(id);
        public Task<List<RubricEntity>> GetRubricsWithHierarchy() => _rubricsRepository.GetRubricsWithHierarchy();
    }
}
