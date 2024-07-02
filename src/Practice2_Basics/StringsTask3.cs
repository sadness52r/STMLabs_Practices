using System;
using System.Linq;

namespace Practice2_Basics
{
    internal class StringsTask3
    {
        private void PrintCountInfo(string str, char symb)
        {
            Console.WriteLine($"Letter {symb} appears {str.Count(x => x == symb)} times");
        }
        public void Run()
        {
            Console.WriteLine("Please, enter any string:");
            string str = Console.ReadLine();
            PrintCountInfo(str, 'r');
            PrintCountInfo(str, 'k');
            PrintCountInfo(str, 't');
        }
    }
}
