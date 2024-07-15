using System;
using Microsoft.Extensions.Logging;

namespace Practice3_DelegatesEventsExceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ILogger loggerTask3 = LoggerFactory.Create(builder =>
            {
                builder.AddConsole();
                builder.SetMinimumLevel(LogLevel.Error);
            }).CreateLogger<Program>();

            while (true)
            {
                Console.WriteLine("Enter a, b, c coefs. Click ENTER to exit:");
                string[] input = Console.ReadLine().Split(' ');
                if (input.Length == 1 && input[0] == "")
                {
                    break;
                }
                try
                {
                    if (input.Length != 3)
                    {
                        throw new InappropriateParamsNumberException("Params number needs to be 3!");
                    }
                    double a = double.Parse(input[0]);
                    double b = double.Parse(input[1]);
                    double c = double.Parse(input[2]);
                    QuadraticTrinomial quadraticTrinomial = Task3.CalcExpression(a, b, c);

                    Console.WriteLine("Enter the x parameter:");
                    double x = double.Parse(Console.ReadLine());

                    Console.WriteLine($"The expression {a}x^2 + {b}x + {c}, x = {x} equal to {quadraticTrinomial(x)}");
                }
                catch (InappropriateParamsNumberException e)
                {
                    loggerTask3.LogError(e, e.Message);
                    continue;
                }
                catch (FormatException e)
                {
                    loggerTask3.LogError(e, e.Message);
                    continue;
                }
            }
        }
    }
}
