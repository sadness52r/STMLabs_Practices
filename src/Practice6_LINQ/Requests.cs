using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        }

        private IEnumerable<string?> GetCustomersFromLA() =>
            customers.Where(customer => customer.CityId == cities.Where(city => city.Name == "Los-Angeles").First().Id).Select(customer => customer.Name);
        private int GetCustomersNumberWithoutOrders()
        {
            var customersWithOrders = orders.Select(order => order.CustomerId);
            var allCustomersId = customers.Select(customer => customer.Id);
            return allCustomersId.Count() - customersWithOrders.Count();
        }
        private void GetCustomersInfo()
        {

        }
        //private IEnumerable<string?> GetCustomersWithMoreThan2OrdersOrdered()
        //{

        //}
    }
}
