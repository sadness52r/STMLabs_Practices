namespace Practice4_OOP
{
    internal class Client
    {
        private readonly string surname, name, patronymic, passportSeries, passportNumber;
        private string phoneNumber;

        public string Surname => surname;
        public string Name => name;
        public string Patronymic => patronymic;
        public string PassportSeries => passportSeries;
        public string PassportNumber => passportNumber;
        public string PhoneNumber
        {
            get => phoneNumber;
            set => phoneNumber = value;
        }

        public Client(string surname, string name, string passportSeries, string passportNumber) :
            this(surname, name, "", "", passportSeries, passportNumber)
        { }
        public Client(string surname, string name, string patronymic, string passportSeries, string passportNumber) :
            this(surname, name, patronymic, "", passportSeries, passportNumber)
        { }
        public Client(string surname, string name, string patronymic, string phoneNumber,
            string passportSeries, string passportNumber)
        {
            this.surname = surname;
            this.name = name;
            this.patronymic = patronymic;
            this.phoneNumber = phoneNumber;
            this.passportSeries = passportSeries;
            this.passportNumber = passportNumber;
        }
    }
}
