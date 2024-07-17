using System;

namespace Practice3_DelegatesEventsExceptions
{
    internal class TooManyProhibitedLinesException : Exception
    {
        public TooManyProhibitedLinesException(string message) : base(message) { }
    }
}
