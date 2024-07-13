using Microsoft.Extensions.Logging;
using Practice3_DelegatesEventsException;

internal class Program
{
    private static void Main(string[] args)
    {
        ILogger logger = LoggerFactory.Create(builder =>
        {
            builder.AddConsole();
            builder.SetMinimumLevel(LogLevel.Error);
        }).CreateLogger<Calculator<double>>();
        Calculator<double> calculator = new Calculator<double>(logger);
        while (true)
        {
            Console.WriteLine("Please, enter correct expression in format: {number1} {+|-|*|/} {number2}\nTo exit click ENTER");
            string expression = Console.ReadLine();
            if (expression == String.Empty)
            {
                break;
            }
            Console.WriteLine("Your result:");
            double ans = calculator.Calculate(expression);
            Console.WriteLine(double.IsNaN(ans) ? " " : ans);
        }
    }
}