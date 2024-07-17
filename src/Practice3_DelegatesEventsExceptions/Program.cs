using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace Practice3_DelegatesEventsExceptions
{
    internal class Program
    {
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
            LimitedStringLoader limitedStringLoader = new LimitedStringLoader(prohibited, erroneous, proLimit);

        }
    }
}
