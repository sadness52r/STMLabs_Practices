namespace Practice6_LINQ
{
    internal class Customer
    {
        private readonly int id;
        private readonly string? name;
        private readonly int cityId;

        public int Id => id;
        public string? Name => name;
        public int CityId => cityId;

        public Customer(int id, string? name, int cityId)
        {
            this.id = id;
            this.name = name;
            this.cityId = cityId;
        }
    }
}
