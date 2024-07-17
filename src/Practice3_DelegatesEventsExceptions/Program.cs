using Microsoft.Extensions.Logging;
using System;
using System.IO;

namespace Practice3_DelegatesEventsExceptions
{
    internal class Program
    {
        private const string FILENAME = "data.txt";

        static void Main(string[] args)
        {
            ILogger loggerError = LoggerFactory.Create(builder =>
            {
                builder.AddConsole();
                builder.SetMinimumLevel(LogLevel.Error);
            }).CreateLogger<Program>();

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
}
