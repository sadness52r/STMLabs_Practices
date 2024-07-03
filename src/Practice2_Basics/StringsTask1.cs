using System;

namespace Practice2_Basics
{
    internal class StringsTask1
    {
        private const string LETTERS_TEMPLATE_ENG = "ABCEHKMOPTXY";
        private const string LETTERS_TEMPLATE_RU = "АВСЕНКМОРТХУ";

        private string GetLogValidation(string number)
        {
            if (number.Length < 6 || number.Length > 6)
            {
                return $"{number} is invalid!\nYour number length: {number.Length}. Need: 6";
            }
            if (!char.IsLetter(number[0]) || !char.IsLetter(number[4]) || !char.IsLetter(number[5]))
            {
                return $"{number} is invalid!\n{number[0]}, {number[4]} or {number[5]} is not a letter!";
            }
            if (!char.IsDigit(number[1]) || !char.IsDigit(number[2]) || !char.IsDigit(number[3]))
            {
                return $"{number} is invalid!\n{number[1]}, {number[2]} or {number[3]} is not a digit!";
            }
            if (LETTERS_TEMPLATE_ENG.IndexOf(number[0]) == -1 && LETTERS_TEMPLATE_RU.IndexOf(number[0]) == -1
                || LETTERS_TEMPLATE_ENG.IndexOf(number[4]) == -1 && LETTERS_TEMPLATE_RU.IndexOf(number[4]) == -1
                || LETTERS_TEMPLATE_ENG.IndexOf(number[5]) == -1 && LETTERS_TEMPLATE_RU.IndexOf(number[5]) == -1)
            {
                return $"{number} is invalid!\n{number[0]}, {number[4]} or {number[5]} is incorrect letter!";
            }
            if (LETTERS_TEMPLATE_ENG.IndexOf(number[0]) == -1 && LETTERS_TEMPLATE_RU.IndexOf(number[0]) != -1
                || LETTERS_TEMPLATE_ENG.IndexOf(number[4]) == -1 && LETTERS_TEMPLATE_RU.IndexOf(number[4]) != -1
                || LETTERS_TEMPLATE_ENG.IndexOf(number[5]) == -1 && LETTERS_TEMPLATE_RU.IndexOf(number[5]) != -1)
            {
                return $"{number} is invalid!\n{number[0]}, {number[4]} or {number[5]} is incorrect Russian letter! Try to replace it to the same Eng!";
            }
            return $"{number} is valid!";
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
                Console.WriteLine(GetLogValidation(number));
            }
        }
    }
}
