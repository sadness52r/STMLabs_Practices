using System.Text;

namespace Practice6_LINQ
{
    internal class Requests
    {
        List<Customer> customers;
        List<Order> orders;
        List<City> cities;

        public Requests(List<Customer> customers, List<Order> orders, List<City> cities)
        {
            this.customers = customers;
            this.orders = orders;
            this.cities = cities;
        }

        public void Run()
        {
            Console.WriteLine("1. Customers from Los-Angeles:");
            var query1 = GetCustomersFromLA();
            foreach (var item in query1)
            {
                Console.WriteLine($"\t{item}");
            }
            Console.WriteLine($"2. Number of customers without orders:\n\t{GetCustomersNumberWithoutOrders()}");
            Console.WriteLine($"3. Customers info:\n{GetCustomersInfo()}");
            Console.WriteLine($"4. Customers with more than 2 orders (ordered by name):");
            var query4 = GetCustomersWithMoreThan2OrdersOrdered();
            foreach (var item in query4)
            {
                Console.WriteLine($"\t{item}");
            }
            Console.WriteLine($"5. Customers with orders grouped by cities:\n{GetCustomersWithOrdersGroupByCities()}");
            Console.WriteLine($"6. Customers who has less orders than average in the city:");
            var query6 = GetCustomersWithOrdersLessThanAverageInCity();
            foreach (var item in query6)
            {
                Console.WriteLine($"\t{item.Name}");
            }
            Console.WriteLine($"7. City with the most spends:\n\t{GetCityWithTheMostSpends().Name}");
            Console.WriteLine($"8. Three customers with the cheapes orders:\n{GetThreeCustomersWithoutOrWithCheapestOrders()}");
        }

        private IEnumerable<string?> GetCustomersFromLA() =>
            customers.Where(customer => customer.City.Name == "Los-Angeles").Select(customer => customer.Name);
        private int GetCustomersNumberWithoutOrders() => customers.Except(orders.Select(order => order.Customer)).Count();
        private string? GetCustomersInfo()
        {
            var customersInfo = customers.Select(customer => new
            {
                CustomerName = customer.Name,
                CityName = customer.City.Name,
                CityCode = customer.City.CityCode,
                OrdersNumber = orders.Count(o => o.Customer.Id == customer.Id),
                LastOrderDate = orders.Where(o => o.Customer.Id == customer.Id).Select(o => o.Date).DefaultIfEmpty().Max()
            });
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var item in customersInfo)
            {
                stringBuilder.AppendLine($"\tName: {item.CustomerName}, City: {item.CityName}, City code: {item.CityCode}, " +
                    $"Orders number: {item.OrdersNumber}, Last order date: {item.LastOrderDate}");
            }
            return stringBuilder.ToString();
        }
        private IEnumerable<string?> GetCustomersWithMoreThan2OrdersOrdered() =>
            customers.Where(c => orders.Count(o => o.Customer.Id == c.Id) > 2).OrderBy(c => c.Name).Select(c => c.Name);
        private string? GetCustomersWithOrdersGroupByCities()
        {
            var customersWithOrdersGroupCity = customers.Join(orders, c => c.Id, o => o.Customer.Id, (c, o) => new
            {
                Customer = c,
                Order = o,
            }).GroupBy(customer => customer.Customer.City.Id).Join(cities, p => p.Key, city => city.Id, (p, city) => new
            {
                CityName = city.Name,
                Customers = p.Select(cust => new
                {
                    cust.Customer.Name,
                    OrdersNumber = orders.Count(o => o.Customer.Id == cust.Customer.Id)
                }).Distinct()
            });
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var item in customersWithOrdersGroupCity)
            {
                stringBuilder.AppendLine($"\t{item.CityName}:");
                foreach (var customer in item.Customers)
                {
                    stringBuilder.AppendLine($"\t\tName: {customer.Name} - Orders: {customer.OrdersNumber}");
                }
            }
            return stringBuilder.ToString();
        }
        private IEnumerable<Customer?> GetCustomersWithOrdersLessThanAverageInCity() =>
            customers.Select(c => new
            {
                Customer = c,
                AverageOrders = customers.Where(cust => cust.City.Id == c.City.Id).Average(cust => orders.Count(o => o.Customer.Id == cust.Id))
            }).Where(c => orders.Count(o => o.Customer.Id == c.Customer.Id) < c.AverageOrders).Select(c => c.Customer);
        private City GetCityWithTheMostSpends()
        {
            var cityToTotalSpend = orders.GroupBy(o => o.Customer.Id).Join(customers, o => o.Key, customer => customer.Id, (o, customer) => new
            {
                o,
                customer
            }).Join(cities, line => line.customer.City.Id, city => city.Id, (line, city) => new
            {
                City = city,
                TotalSpend = line.o.Sum(o => o.Price)
            });
            return cityToTotalSpend.Where(l => l.TotalSpend == cityToTotalSpend.Max(row => row.TotalSpend)).First().City;
        }
        private string? GetThreeCustomersWithoutOrWithCheapestOrders()
        {
            var lowestSpendingCustomers = customers.Select(c => new
            {
                CustomerName = c.Name,
                CityName = cities.FirstOrDefault(city => city.Id == c.City.Id)?.Name,
                OrdersNumber = orders.Count(o => o.Customer.Id == c.Id),
                TotalSpend = orders.Where(o => o.Customer.Id == c.Id).Sum(o => o.Price)
            }).OrderBy(x => x.TotalSpend).Take(3);
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var item in lowestSpendingCustomers)
            {
                stringBuilder.AppendLine($"\tName: {item.CustomerName}, City: {item.CityName}, Orders number: {item.OrdersNumber}, " +
                    $"Total spend: {item.TotalSpend}");
            }
            return stringBuilder.ToString();
        }
    }
}
