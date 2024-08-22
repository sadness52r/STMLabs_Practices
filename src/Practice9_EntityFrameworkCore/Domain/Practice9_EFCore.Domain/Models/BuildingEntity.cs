using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice9_EFCore.Domain.Models
{
    public class BuildingEntity
    {
        public Guid Id { get; set; }
        public string Address { get; set; } = string.Empty;
        public double XPosition { get; set; }
        public double YPosition { get; set; }
        public List<CompanyEntity> Companies { get; set; } = [];
    }
}
