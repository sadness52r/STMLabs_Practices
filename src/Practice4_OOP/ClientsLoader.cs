namespace Practice4_OOP
{
    internal class ClientsLoader
    {
        private string filename;

        public ClientsLoader(string filename)
        {
            this.filename = filename;
        }

        public Dictionary<string, Client> Load()
        {
            Dictionary<string, Client> clients = new Dictionary<string, Client>();
            using (StreamReader sr = new StreamReader(filename))
            {
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split();
                    int ind = 0;
                    string surname = line[ind], name = line[++ind], phoneNumber = string.Empty, patronymic = string.Empty,
                        passportSeries = string.Empty, passportNumber = string.Empty;
                    if (!line[++ind].StartsWith("Phone:"))
                    {
                        patronymic = line[ind++];
                    }
                    phoneNumber = line[ind++].Split(':')[1];
                    if (line.Length == 5 || line.Length == 6)
                    {
                        passportSeries = line[ind++];
                        passportNumber = line[ind++];
                    }
                    clients.Add(phoneNumber, new Client(surname, name, patronymic, phoneNumber, passportSeries, passportNumber));
                }
            }
            return clients;
        }
    }
}
