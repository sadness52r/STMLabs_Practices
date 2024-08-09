namespace Practice6_LINQ
{
    internal class Order
    {
        private readonly int id;
        private readonly Customer customer;
        private readonly decimal price;
        private readonly DateTime? date;

        public int Id => id;
        public Customer Customer => customer;
        public decimal Price => price;
        public DateTime? Date => date;

        public Order(int id, Customer customer, decimal price, DateTime? date)
        {
            this.id = id;
            this.customer = customer;
            this.price = price;
            this.date = date;
        }
    }
}
