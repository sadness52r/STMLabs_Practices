using System;

namespace Practice2_Basics
{
    internal class OutOfRangeListException : Exception
    {
        public OutOfRangeListException(string message) : base(message) { }
    }
}
