using System;

namespace Practice3_DelegatesEventsExceptions
{
    internal class SourceTask4
    {
        private event Action<string> notify;
        private readonly string name;

        public event Action<string> NotifyCompleted
        {
            add { notify += value; }
            remove { notify -= value; }
        }

        public SourceTask4() : this("Unknown") { }
        public SourceTask4(string name)
        {
            this.name = name;
        }

        public void GenerateEvent()
        {
            notify?.Invoke(name);
        }
    }
}
