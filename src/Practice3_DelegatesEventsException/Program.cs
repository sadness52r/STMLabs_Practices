using Microsoft.Extensions.Logging;
using Practice3_DelegatesEventsException;
using Practice3_DelegatesEventsExceptions;

internal class Program
{
    private const string FILENAME = "data.txt";

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
                loggerError.LogError(e, e.Message);
                continue;
            }
            catch (FormatException e)
            {
                loggerError.LogError(e, e.Message);
                continue;
            }
        }

        SourceTask4 sourceTask4_1 = new SourceTask4("Source1");
        SourceTask4 sourceTask4_2 = new SourceTask4("Source2");
        HandlerTask4 handlerTask4 = new HandlerTask4();
        sourceTask4_1.Notify += handlerTask4.GetArgValue;
        sourceTask4_2.Notify += handlerTask4.GetArgValue;
        sourceTask4_1.GenerateEvent(); sourceTask4_2.GenerateEvent();

        Console.WriteLine("Enter prohibited and erroneous templates");
        string prohibited = Console.ReadLine();
        string erroneous = Console.ReadLine();
        int proLimit;
        while (true)
        {
            Console.WriteLine("Enter proLimit parameter");
            try
            {
                proLimit = int.Parse(Console.ReadLine());
                break;
            }
            catch (FormatException e)
            {
                loggerError.LogError(e, e.Message);
            }
        }
        try
        {
            LimitedStringLoader limitedStringLoader = new LimitedStringLoader(prohibited, erroneous, proLimit);
            limitedStringLoader.Load(FILENAME);
            foreach (var item in limitedStringLoader.ParsedStrings)
            {
                Console.WriteLine(item);
            }
        }
        catch (InconsistentLimitsException e)
        {
            loggerError.LogError(e, e.Message);
        }
        catch (TooManyProhibitedLinesException e)
        {
            loggerError.LogError(e, e.Message);
        }
        catch (WrongStartingSymbolException e)
        {
            loggerError.LogError(e, e.Message);
        }
        catch (IncorrectStringException e)
        {
            loggerError.LogError(e, e.Message);
        }
        catch (DataNotLoadedException e)
        {
            loggerError.LogError(e, e.Message);
        }
        catch (FileNotFoundException e)
        {
            loggerError.LogError(e, e.Message);
        }
    }
}