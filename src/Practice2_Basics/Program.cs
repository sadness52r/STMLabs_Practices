using System;

namespace Practice2_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1:");
            StringsTask1 task1 = new StringsTask1();
            task1.Run();

            Console.WriteLine("\nTask3:");
            StringsTask3 stringsTask3 = new StringsTask3();
            stringsTask3.Run();
        }
    }
}
