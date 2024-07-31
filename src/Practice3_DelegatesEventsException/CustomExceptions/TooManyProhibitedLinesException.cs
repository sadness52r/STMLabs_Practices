using System;

namespace Practice3_DelegatesEventsExceptions
{
    internal class TooManyProhibitedLinesException : Exception
    {
        public TooManyProhibitedLinesException() : base("Too many skipped lines!") { }
    }
}
