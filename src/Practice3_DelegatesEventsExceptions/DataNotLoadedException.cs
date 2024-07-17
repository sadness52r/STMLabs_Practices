using System;

namespace Practice3_DelegatesEventsExceptions
{
    internal class DataNotLoadedException : Exception
    {
        public DataNotLoadedException(string message) : base(message) { }
    }
}
