namespace Practice4_OOP
{
    internal class ClientAlreadyExistsException : Exception
    {
        public ClientAlreadyExistsException(string message) : base(message) { }
    }
}
