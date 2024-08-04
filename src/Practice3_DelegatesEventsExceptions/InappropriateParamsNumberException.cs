using System;

namespace Practice3_DelegatesEventsExceptions
{
    internal class InappropriateParamsNumberException : Exception
    {
        public InappropriateParamsNumberException(string message) : base(message) { }
    }
}
