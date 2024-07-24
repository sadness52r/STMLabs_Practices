using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice4_OOP
{
    internal class Consultant : IWorker
    {
        protected Dictionary<string, Client> clients;
        protected Client? curClient = null;

        public Dictionary<string, Client> Clients 
        {
            get { return clients; }
            set { clients = value; }
        }

        public Consultant()
        {
            clients = new Dictionary<string, Client>();
        }

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
