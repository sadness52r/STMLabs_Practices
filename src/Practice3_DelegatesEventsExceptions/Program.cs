using System;

namespace Practice3_DelegatesEventsExceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DaysOfWeekTask2 task = new DaysOfWeekTask2();
            while (true)
            {
                Console.WriteLine("Click ENTER to call a delegate!\nExit: enter something else");
                if (Console.ReadLine() == String.Empty)
                {
                    Console.WriteLine(task.CallDelegate()); 
                }
                else
                {
                    break;
                }
            }
        }
    }
}
