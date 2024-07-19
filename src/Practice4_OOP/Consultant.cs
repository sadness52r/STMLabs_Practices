using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice4_OOP
{
    internal class Consultant
    {
        protected readonly List<Client> clients;
        protected Client? curClient = null;

        public Consultant()
        {
            clients = new List<Client>();
        }

        public void AddClient(Client client)
        {
            clients.Add(client);
        }
        //public void RemoveClient(Client client)
        //{
        //    clients.Remove(client);
        //}
        public string GetPassportData()
        {
            if (curClient == null)
            {
                throw new NullReferenceException("Current client has not choosen!");
            }
            return (curClient.PassportSeries == string.Empty && curClient.PassportNumber == string.Empty ?
                string.Empty : new string('*', curClient.PassportSeries.Length) + " " 
                + new string('*', curClient.PassportNumber.Length));
        }
    }
}
