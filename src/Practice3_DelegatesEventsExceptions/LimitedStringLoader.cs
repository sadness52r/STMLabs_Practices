using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Practice3_DelegatesEventsExceptions
{
    internal class LimitedStringLoader
    {
        private bool isLoaded;
        private readonly string prohibited;
        private readonly string erroneous;
        private readonly int proLimit;
        private readonly List<string> parsedStrings;
        private readonly ILogger logger;

        public List<string> ParsedStrings => isLoaded ? parsedStrings 
            : throw new DataNotLoadedException("Data can not be load! Load your file before!");

        public LimitedStringLoader(string prohibited, string erroneous, int proLimit) : this(prohibited, erroneous, proLimit, LoggerFactory.Create(builder =>
        {
            builder.AddConsole();
            builder.SetMinimumLevel(LogLevel.Error);
        }).CreateLogger<LimitedStringLoader>())
        { }
        public LimitedStringLoader(string prohibited, string erroneous, int proLimit, ILogger logger)
        {
            this.logger = logger;

            CheckIntersection(prohibited, erroneous);

            this.prohibited = prohibited;
            this.erroneous = erroneous;
            this.proLimit = proLimit;
            parsedStrings = new List<string>();
            isLoaded = false;
        }

        private void CheckIntersection(string str1, string str2)
        {
            var intersectSymbols = str1.Intersect(str2);
            if (intersectSymbols.Count() > 0)
            {
                throw new InconsistentLimitsException(string.Join(" ", intersectSymbols));
            }
        }

        public void Load(string filename)
        {
            using (StreamReader sReader = new StreamReader(filename))
            {
                string fileLine;
                int lineNumber = 1, skippedLines = 0;
                while ((fileLine = sReader.ReadLine()) != null)
                {
                    if (skippedLines > proLimit)
                    {
                        throw new TooManyProhibitedLinesException("Too many skipped lines!");
                    }
                    if (fileLine.Length == 0 || (fileLine[0] < 'A' && fileLine[0] > 'Z'))
                    {
                        throw new IncorrectStringException(lineNumber);
                    }
                    if (erroneous.Contains(fileLine[0]))
                    {
                        throw new WrongStartingSymbolException(lineNumber, fileLine[0]);
                    }
                    if (prohibited.Contains(fileLine[0]))
                    {
                        skippedLines++;
                        continue;
                    }
                    parsedStrings.Add(fileLine);
                    lineNumber++;
                }
                isLoaded = true;
            }
        }
    }
}
