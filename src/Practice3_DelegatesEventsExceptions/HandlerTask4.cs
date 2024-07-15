using Microsoft.Extensions.Logging;
using System;

namespace Practice3_DelegatesEventsExceptions
{
    internal class HandlerTask4
    {
        private readonly ILogger logger;

        public HandlerTask4() : this(LoggerFactory.Create(builder =>
        {
            builder.AddConsole();
            builder.SetMinimumLevel(LogLevel.Error);
        }).CreateLogger<HandlerTask4>())
        { }
        public HandlerTask4(ILogger logger)
        {
            this.logger = logger;
        }

        public void GetArgValue(string arg)
        {
            try
            {
                if (arg == null)
                {
                    throw new NullReferenceException("Argument is null!");
                }
                Console.WriteLine(arg);
            }
            catch (NullReferenceException e)
            {
                logger.LogError(e, e.Message);
            }
        }
    }
}
