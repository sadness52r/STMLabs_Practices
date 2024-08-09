namespace Practice4_OOP
{
    internal class Manager : Consultant
    {
        public Manager()
        {
            clients = new Dictionary<string, Client>();
            image = Image.FromFile(Worker.MANAGER_PIC);
        }

        public override string GetPassportData()
        {
            if (curClient is null)
            {
                throw new NullReferenceException("Current client has not chosen!");
            }
            return curClient.PassportSeries + " " + curClient.PassportNumber;
        }
        public override string ToString() => "Manager";
    }
}
