using System;

namespace Practice2_Basics
{
    enum MONTHS
    {
        JANUARY = 1,
        FEBRUARY,
        MARCH,
        APRIL,
        MAY,
        JUNE,
        JULY,
        AUGUST,
        SEPTEMBER,
        OCTOBER,
        NOVEMBER,
        DECEMBER,
    }
    
    internal class DataTask1
    {
        private const int DATA_PARTS = 3;
        private const int DATA_SYMBOLS = 10;
        private const int FIRST_DAY_MONTH_YEAR = 1;
        private const int LAST_DAY = 31;
        private const int LAST_MONTH = 12;
        private const int LAST_FEBRUARY_DAY = 28;
        private const int LAST_FEBRUARY_LEAP_DAY = 29;

        private bool CheckValidation(string data, out string errorMessage)
        {
            errorMessage = null;
            if (data.Length != DATA_SYMBOLS)
            {
                errorMessage = $"Data has a length = 10. Your length: {data.Length}";
                return false;
            }
            string[] parts = data.Split('.');
            if (parts.Length != DATA_PARTS)
            {
                errorMessage = $"Your data has more than 3 parts! Notice: there is only 3 parts - DD.MM.YYYY";
                return false;
            }
            if (!int.TryParse(parts[0], out int day) ||
                !int.TryParse(parts[1], out int month) || !int.TryParse(parts[2], out int year))
            {
                errorMessage = $"Incorrect format of day, month or year!";
                return false;
            }
            if (day < FIRST_DAY_MONTH_YEAR || day > LAST_DAY || month < FIRST_DAY_MONTH_YEAR ||
                month > LAST_MONTH || year < FIRST_DAY_MONTH_YEAR)
            {
                errorMessage = $"Incorrect value of day, month or year!";
                return false;
            }
            if (month == (int)MONTHS.FEBRUARY)
            {
                int maxDays = DateTime.IsLeapYear(year) ? LAST_FEBRUARY_LEAP_DAY : LAST_FEBRUARY_DAY;
                if (day > maxDays)
                {
                    errorMessage = $"February in {year} has {maxDays} days!";
                    return false;
                }
            }
            return true;
        }
        private string GetLogValidation(string data) =>
            CheckValidation(data, out string errorMessage) ? $"{data} is valid!" : $"{data} is invalid!\n{errorMessage}";
        public void Run()
        {
            Console.WriteLine("Please, enter data in format DD.MM.YYYY:");
            string data = Console.ReadLine();
            Console.WriteLine(GetLogValidation(data));
        }
    }
}
