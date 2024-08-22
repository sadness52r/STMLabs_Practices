namespace Practice9_EFCore.Domain.Models
{
    public class CompanyEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<string> Phones { get; set; } = [];
        public Guid BuildingId { get; set; }
        public BuildingEntity? Building { get; set; }
        public List<RubricEntity> Rubrics { get; set; } = [];
    }
}
