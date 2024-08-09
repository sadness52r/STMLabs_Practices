namespace Practice6_LINQ
{
    internal class Customer
    {
        private readonly int id;
        private readonly string? name;
        private readonly City city;

        public int Id => id;
        public string? Name => name;
        public City City => city;

        public Customer(int id, string? name, City city)
        {
            this.id = id;
            this.name = name;
            this.city = city;
        }
    }
}
