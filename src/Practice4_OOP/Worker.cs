namespace Practice4_OOP
{
    internal abstract class Worker
    {
        protected Dictionary<string, Client>? clients;
        protected Client? curClient = null;

        public abstract string GetPassportData();

        public Dictionary<string, Client>? Clients
        {
            get { return clients; }
            set { clients = value; }
        }
        public Client? CurClient
        {
            get { return curClient; }
            set { curClient = value; }
        }
    }
}
