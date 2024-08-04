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

        public Client(string surname, string name, string phoneNumber, string passportSeries, string passportNumber) :
            this(surname, name, "", phoneNumber, passportSeries, passportNumber)
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

        public static bool operator ==(Client left, Client right)
        {
            if ((object)left == (object)right)
            {
                return true;
            }
            return left.phoneNumber == right.PhoneNumber && left.passportSeries == right.PassportSeries &&
                left.passportNumber == right.PassportNumber;
        }
        public static bool operator !=(Client left, Client right)
        {
            if ((object)left != (object)right)
            {
                return true;
            }
            return left.phoneNumber != right.PhoneNumber || left.passportSeries != right.PassportSeries ||
                left.passportNumber != right.PassportNumber;
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
