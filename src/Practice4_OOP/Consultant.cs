namespace Practice4_OOP
{
    internal class Consultant : Worker
    {
        public Consultant()
        {
            clients = new Dictionary<string, Client>();
            image = Image.FromFile(Worker.CONSULTANT_PIC);
        }

        public override string GetPassportData()
        {
            if (curClient is null)
            {
                throw new NullReferenceException("Current client has not chosen!");
            }
            return (curClient.PassportSeries == string.Empty && curClient.PassportNumber == string.Empty ?
                string.Empty : new string('*', curClient.PassportSeries.Length) + " "
                + new string('*', curClient.PassportNumber.Length));
        }
    }
}
