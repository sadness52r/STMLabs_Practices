using System;
using System.Collections.Generic;

namespace Practice2_Basics
{
    internal class StringsTask3
    {
        private Dictionary<char, int> frequencies;

        public StringsTask3()
        {
            frequencies = new Dictionary<char, int>();
        }

        private void CountFrequencies(string str)
        {
            foreach (char item in str)
            {
                if (item == 'r' || item == 'k' || item == 't')
                {
                    if (!frequencies.ContainsKey(item))
                    {
                        frequencies[item] = 1;
                        continue;
                    }
                    frequencies[item]++;
                }
            }
        }
        public void Run()
        {
            Console.WriteLine("Please, enter any string:");
            string str = Console.ReadLine();
            CountFrequencies(str);
            Console.WriteLine($"Letter r appears {(frequencies.ContainsKey('r') ? frequencies['r'] : 0)} times");
            Console.WriteLine($"Letter k appears {(frequencies.ContainsKey('k') ? frequencies['k'] : 0)} times");
            Console.WriteLine($"Letter t appears {(frequencies.ContainsKey('t') ? frequencies['t'] : 0)} times");
        }
    }
}
