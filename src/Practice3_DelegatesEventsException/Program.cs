using Microsoft.Extensions.Logging;
using Practice3_DelegatesEventsException;
using Practice3_DelegatesEventsExceptions;

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

        DaysOfWeekTask2 task = new DaysOfWeekTask2();
        while (true)
        {
            Console.WriteLine("Click ENTER to call a delegate!\nExit: enter something else");
            if (Console.ReadLine() == String.Empty)
            {
                Console.WriteLine(task.CallDelegate());
            }
            else
            {
                break;
            }
        }
    }
}