using System;

namespace Practice3_DelegatesEventsExceptions
{
    internal class DataNotLoadedException : Exception
    {
        public DataNotLoadedException() : base("Data can not be load! Load your file before!") { }
    }
}
