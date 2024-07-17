using System;

namespace Practice3_DelegatesEventsExceptions
{
    internal class IncorrectStringException : Exception
    {
        protected readonly int lineNumber;

        public IncorrectStringException(int lineNumber) :
            this(lineNumber, $"Incorrect string number: {lineNumber}") { }
        public IncorrectStringException(int lineNumber, string message) : base(message)
        {
            this.lineNumber = lineNumber;
        }
    }
}
