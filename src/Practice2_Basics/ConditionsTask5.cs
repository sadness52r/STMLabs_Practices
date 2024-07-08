using System;

namespace Practice2_Basics
{
    internal class ConditionsTask5
    {
        private const double EPS = 1e-8;
        private double num1;
        private double num2;

        private bool CheckValidParsing()
        {
            return double.TryParse(Console.ReadLine(), out num1) &&
                double.TryParse(Console.ReadLine(), out num2);
        }
        private void CalculateNumbers(ref double number1, ref double number2)
        {
            double tmpNumber = number1;
            if (number1 - number2 < 0)
            {
                number1 = (number1 + number2) / 2;
                number2 = 2 * tmpNumber * number2;
                return;
            }
            number1 = 2 * number1 * number2;
            number2 = (tmpNumber + number2) / 2;
        }

        public void Run()
        {
            Console.WriteLine("Please, enter 2 different numbers:");
            while (true)
            {
                if (!CheckValidParsing())
                {
                    Console.WriteLine("Please, enter correct numbers!");
                    continue;
                }

                if (Math.Abs(num1 - num2) <= EPS)
                {
                    Console.WriteLine("Please, enter different numbers!");
                    continue;
                }
                CalculateNumbers(ref num1, ref num2);
                Console.WriteLine($"Your new numbers:\n{num1} {num2}");
                return;
            }
        }
    }
}
