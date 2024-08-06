namespace Practice4_OOP
{
    internal abstract class Worker
    {
        public const string CONSULTANT_PIC = "Materials/consultant.jpg";
        public const string MANAGER_PIC = "Materials/manager.jpg";

        protected Dictionary<string, Client>? clients;
        protected Client? curClient = null;
        protected Image? image;

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
        public Image? Image => image;
    }
}
