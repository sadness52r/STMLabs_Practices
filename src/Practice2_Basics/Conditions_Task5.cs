using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2_Basics
{
    internal class Conditions_Task5
    {
        private const double EPS = 1e-8;
        private double num1;
        private double num2;

        private bool CheckValidParsing()
        {
            return !double.TryParse(Console.ReadLine(), out num1) ||
                !double.TryParse(Console.ReadLine(), out num2);
        }
        private Tuple<double, double> CalculateNumbers(double number1, double number2)
        {
            if (number1 - number2 < 0)
            {
                return new Tuple<double, double>((number1 + number2) / 2, 2 * number1 * number2);
            }
            return new Tuple<double, double>(2 * number1 * number2, (number1 + number2) / 2);
        }

        public void Run()
        {
            Console.WriteLine("Please, enter 2 different numbers:");
            while (true)
            {
                if (CheckValidParsing())
                {
                    Console.WriteLine("Please, enter correct number!");
                    continue;
                }
                
                if (Math.Abs(num1 - num2) <= EPS)
                {
                    Console.WriteLine("Please, enter different numbers!");
                    continue;
                }
                Console.WriteLine($"Your new numbers:\n{CalculateNumbers(num1, num2)}");
                return;
            }
        }
    }
}
