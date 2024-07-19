using System;

namespace Practice3_DelegatesEventsExceptions
{
    internal class SourceTask4
    {
        private readonly string name;
        public event Action<string> Notify;

        public SourceTask4() : this("Unknown") { }
        public SourceTask4(string name)
        {
            this.name = name;
        }

        public void GenerateEvent()
        {
            Notify?.Invoke(name);
        }
    }
}
