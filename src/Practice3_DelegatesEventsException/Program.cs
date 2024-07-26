using Microsoft.Extensions.Logging;
using Practice3_DelegatesEventsException;

internal class Program
{
    private static void Main(string[] args)
    {
        ILogger loggerError = LoggerFactory.Create(builder =>
        {
            builder.AddConsole();
            builder.SetMinimumLevel(LogLevel.Error);
        }).CreateLogger<Program>();
        Calculator<double> calculator = new Calculator<double>();
        while (true)
        {
            Console.WriteLine("Please, enter correct expression in format: {number1} {+|-|*|/} {number2}\nTo exit click ENTER");
            string? expression = Console.ReadLine();
            if (expression == String.Empty)
            {
                break;
            }
            Console.WriteLine("Your result:");
            try
            {
                Console.WriteLine(calculator.Calculate(expression));
            }
            catch (InvalidInputException e)
            {
                loggerError.LogError(e, e.Message);
            }
            catch (InvalidCastException e)
            {
                loggerError.LogError(e, e.Message);
            }
            catch (DivideByZeroException e)
            {
                loggerError.LogError(e, e.Message);
            }
            catch (InvalidOperationException e)
            {
                loggerError.LogError(e, e.Message);
            }
        }
    }
}