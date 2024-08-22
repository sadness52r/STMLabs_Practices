using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice9_EFCore.Domain.Models
{
    public class RubricEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public Guid? ParentRubricId { get; set; }
        public RubricEntity? ParentRubric { get; set; }
        public List<RubricEntity> InnerRubrics { get; set; } = [];
        public List<CompanyEntity> Companies { get; set; } = [];
    }
}
