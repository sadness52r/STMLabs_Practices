using Practice6_LINQ;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Customer> customers = new List<Customer>() 
        {
            new Customer(1, "Kirill", 2),
            new Customer(2, "Darya", 2),
            new Customer(3, "Meow", 1),
            new Customer(4, "Vlad", 1),
        };
        List<Order> orders = new List<Order>() 
        {
            new Order(1, 1, 2500, new DateTime(2002, 3, 23)),
            new Order(2, 3, 5678, new DateTime(2024, 9, 5)),
            new Order(3, 3, 10000, new DateTime(2023, 12, 1)),
            new Order(4, 3, 1234, new DateTime(2020, 5, 2))
        };
        List<City> cities = new List<City>() 
        {
            new City(1, "Balahna", 606403),
            new City(2, "Los-Angeles", 555555)
        };

        Requests requests = new Requests(customers, orders, cities);
        requests.Run();
    }
}