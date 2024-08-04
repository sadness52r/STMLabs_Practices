namespace Practice6_LINQ
{
    internal class Order
    {
        private readonly int id;
        private readonly string? customerId;
        private readonly decimal price;
        private readonly DateTime? date;

        public int Id => id;
        public string? CustomerId => customerId;
        public decimal Price => price;
        public DateTime? Date => date;

        public Order(int id, string? customerId, decimal price, DateTime? date)
        {
            this.id = id;
            this.customerId = customerId;
            this.price = price;
            this.date = date;
        }
    }
}
