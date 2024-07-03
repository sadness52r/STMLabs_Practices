using System;

namespace Practice2_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SetsTask5 setsTask5_2 = new SetsTask5(10);
            Console.WriteLine();
            SetsTask5 setsTask5_3 = new SetsTask5(1, 20, 8);
            Console.WriteLine();
            setsTask5_2.Run();
            Console.WriteLine();
            setsTask5_3.Run();
        }
    }
}
