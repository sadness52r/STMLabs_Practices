namespace Practice6_LINQ
{
    internal class City
    {
        private readonly int id;
        private readonly string? name;
        private readonly int cityCode;

        public int Id => id;
        public string? Name => name;
        public int CityCode => cityCode;

        public City(int id, string? name, int cityCode)
        {
            this.id = id;
            this.name = name;
            this.cityCode = cityCode;
        }
    }
}
