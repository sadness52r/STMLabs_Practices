namespace Practice6_LINQ
{
    internal class Order
    {
        private readonly int id;
        private readonly int customerId;
        private readonly decimal price;
        private readonly DateTime? date;

        public int Id => id;
        public int CustomerId => customerId;
        public decimal Price => price;
        public DateTime? Date => date;

        public Order(int id, int customerId, decimal price, DateTime? date)
        {
            this.id = id;
            this.customerId = customerId;
            this.price = price;
            this.date = date;
        }
    }
}
