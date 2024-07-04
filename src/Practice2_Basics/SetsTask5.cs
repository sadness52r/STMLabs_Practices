using System;
using System.Collections.Generic;

namespace Practice2_Basics
{
    internal class SetsTask5
    {
        private HashSet<int> nums;
        private HashSet<int> primes;
        private HashSet<int> composites;

        public SetsTask5() : this(n:int.MaxValue) { }
        public SetsTask5(int n) : this(start: 0, end: int.MaxValue, n) { }
        public SetsTask5(int start, int end, int n)
        {
            primes = new HashSet<int>();
            composites = new HashSet<int>();
            RangeGeneration(start > end ? 0 : start, end, n < 0 ? 1 : n);
        }

        private void RangeGeneration(int start, int end, int n)
        {
            nums = new HashSet<int>();
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                int num = rnd.Next(start, end);
                nums.Add(num);
            }
        }
        private void PrintSet(HashSet<int> set)
        {
            foreach (int i in set)
            {
                Console.Write($"{i} ");
            }
        }

        public void Run()
        {
            Console.WriteLine("Initial set:");
            PrintSet(nums);
            FermatTest fermatTest = new FermatTest();
            foreach (int num in nums)
            {
                if (fermatTest.Run(num))
                {
                    primes.Add(num);
                    continue;
                }
                composites.Add(num);
            }
            Console.WriteLine("\nPrimes set:");
            PrintSet(primes);
            Console.WriteLine("\nComposites set:");
            PrintSet(composites);
        }
    }
}
