using Practice6_LINQ;

internal class Program
{
    private static void Main(string[] args)
    {
        List<City> cities = new List<City>()
        {
            new City(1, "Balahna", 606403),
            new City(2, "Los-Angeles", 555555)
        };
        List<Customer> customers = new List<Customer>() 
        {
            new Customer(1, "Kirill", cities[1]),
            new Customer(2, "Darya", cities[1]),
            new Customer(3, "Meow", cities[0]),
            new Customer(4, "Vlad", cities[0]),
        };
        List<Order> orders = new List<Order>() 
        {
            new Order(1, customers[0], 2500, new DateTime(2002, 3, 23)),
            new Order(2, customers[2], 5678, new DateTime(2024, 9, 5)),
            new Order(3, customers[2], 10000, new DateTime(2023, 12, 1)),
            new Order(4, customers[2], 1234, new DateTime(2020, 5, 2))
        };

        Requests requests = new Requests(customers, orders, cities);
        requests.Run();
    }
}