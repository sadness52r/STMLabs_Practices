namespace Practice3_DelegatesEventsExceptions
{
    internal class WrongStartingSymbolException : IncorrectStringException
    {
        private readonly char symbol;

        public WrongStartingSymbolException(int _lineNumber, char symbol) :
            base(_lineNumber, $"Wrong starting symbol {symbol} in line {_lineNumber}")
        {
            this.symbol = symbol;
        }
    }
}
