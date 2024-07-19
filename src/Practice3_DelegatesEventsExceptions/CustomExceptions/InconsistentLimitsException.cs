using System;

namespace Practice3_DelegatesEventsExceptions
{
    internal class InconsistentLimitsException : ArgumentException
    {
        private readonly string errorSymbols;

        public InconsistentLimitsException(string errorSymbols) : base($"Intersection in symbols: {errorSymbols}") 
        {
            this.errorSymbols = errorSymbols;
        }
    }
}
