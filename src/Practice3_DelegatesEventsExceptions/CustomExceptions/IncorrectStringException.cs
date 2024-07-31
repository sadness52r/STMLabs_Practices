using System;

namespace Practice3_DelegatesEventsExceptions
{
    internal class IncorrectStringException : Exception
    {
        protected readonly int lineNumber;

        public IncorrectStringException(int lineNumber) : base($"Incorrect string number: {lineNumber}") { }
        public IncorrectStringException(int lineNumber, char symbol) : 
            base($"Wrong starting symbol {symbol} in line {lineNumber}")
        {
            this.lineNumber = lineNumber;
        }
    }
}
