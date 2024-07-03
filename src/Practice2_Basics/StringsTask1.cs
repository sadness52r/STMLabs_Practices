using System;

namespace Practice2_Basics
{
    internal class StringsTask1
    {
        private const string LETTERS_TEMPLATE_ENG = "ABCEHKMOPTXY";
        private const string LETTERS_TEMPLATE_RU = "АВСЕНКМОРТХУ";

        private bool CheckValidation(string number, out string errorMessage)
        {
            errorMessage = null;
            if (number.Length != 6)
            {
                errorMessage = $"Your number length: {number.Length}. Need: 6";
                return false;
            }
            if (!char.IsLetter(number[0]) || !char.IsLetter(number[4]) || !char.IsLetter(number[5]))
            {
                errorMessage = $"{number[0]}, {number[4]} or {number[5]} is not a letter!";
                return false;
            }
            if (!char.IsDigit(number[1]) || !char.IsDigit(number[2]) || !char.IsDigit(number[3]))
            {
                errorMessage = $"{number[1]}, {number[2]} or {number[3]} is not a digit!";
                return false;
            }
            if (LETTERS_TEMPLATE_ENG.IndexOf(number[0]) == -1 && LETTERS_TEMPLATE_RU.IndexOf(number[0]) == -1
                || LETTERS_TEMPLATE_ENG.IndexOf(number[4]) == -1 && LETTERS_TEMPLATE_RU.IndexOf(number[4]) == -1
                || LETTERS_TEMPLATE_ENG.IndexOf(number[5]) == -1 && LETTERS_TEMPLATE_RU.IndexOf(number[5]) == -1)
            {
                errorMessage = $"{number[0]}, {number[4]} or {number[5]} is incorrect letter!";
                return false;
            }
            if (LETTERS_TEMPLATE_ENG.IndexOf(number[0]) == -1 && LETTERS_TEMPLATE_RU.IndexOf(number[0]) != -1
                || LETTERS_TEMPLATE_ENG.IndexOf(number[4]) == -1 && LETTERS_TEMPLATE_RU.IndexOf(number[4]) != -1
                || LETTERS_TEMPLATE_ENG.IndexOf(number[5]) == -1 && LETTERS_TEMPLATE_RU.IndexOf(number[5]) != -1)
            {
                errorMessage = $"{number[0]}, {number[4]} or {number[5]} is incorrect Russian letter! Try to replace it to the same Eng!";
                return false;
            }
            return true;
        }
        private string GetLogValidation(string number) =>
            CheckValidation(number, out string errorMessage) ? $"{number} is valid!" : $"{number} is invalid!\n{errorMessage}";
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
