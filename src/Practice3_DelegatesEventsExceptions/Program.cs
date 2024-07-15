namespace Practice3_DelegatesEventsExceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SourceTask4 sourceTask4_1 = new SourceTask4("Source1");
            SourceTask4 sourceTask4_2 = new SourceTask4("Source2");
            HandlerTask4 handlerTask4 = new HandlerTask4();
            sourceTask4_1.NotifyCompleted += handlerTask4.GetArgValue;
            sourceTask4_2.NotifyCompleted += handlerTask4.GetArgValue;
            sourceTask4_1.GenerateEvent(); sourceTask4_2.GenerateEvent();
        }
    }
}
