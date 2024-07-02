using System;
using System.Text.RegularExpressions;

namespace Practice2_Basics
{
    internal class StringsTask1
    {
        private const string LETTERS_TEMPLATE = "ABCEHKMOPTXY";

        private bool CheckNumber(string number)
        {
            return new Regex($"[{LETTERS_TEMPLATE}]{{1}}[0-9]{{3}}[{LETTERS_TEMPLATE}]{{2}}").IsMatch(number);
        }
        public void Run()
        {
            Console.WriteLine("Please, enter bus numbers (For exit, press ENTER):");
            while (true)
            {
                string number = Console.ReadLine();
                if (number.Length == 0)
                {
                    return;
                }

                if (CheckNumber(number))
                {
                    Console.WriteLine($"{number} - is valid!");
                }
                else
                {
                    Console.WriteLine($"{number} - is not valid!");
                }
            }
        }
    }
}
