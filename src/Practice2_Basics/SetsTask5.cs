using System;
using System.Collections.Generic;

namespace Practice2_Basics
{
    internal class SetsTask5
    {
        private HashSet<int> nums;
        private HashSet<int> primes;
        private HashSet<int> composites;

        public SetsTask5()
        {
            primes = new HashSet<int>();
            composites = new HashSet<int>();
            Console.WriteLine($"Random generation...");
            RandomGeneration();
        }
        public SetsTask5(int n)
        {
            primes = new HashSet<int>();
            composites = new HashSet<int>();
            if (n < 0)
            {
                Console.WriteLine("Incorrect data. Random generation...");
                RandomGeneration();
            }
            else
            {
                Console.WriteLine("Handle generation...");
                HandleGeneration(n);
            }
        }
        public SetsTask5(int start, int end, int n)
        {
            primes = new HashSet<int>();
            composites = new HashSet<int>();
            if (start > end || n < 0)
            {
                Console.WriteLine($"Incorrect data. Random generation...");
                RandomGeneration();
            }
            else
            {
                Console.WriteLine("Range generation...");
                RangeGeneration(start, end, n);
            }
        }

        private void RandomGeneration()
        {
            nums = new HashSet<int>();
            Random rnd = new Random();
            int n = rnd.Next();
            for (int i = 0; i < n; i++)
            {
                int num = rnd.Next();
                nums.Add(num);
                Console.WriteLine($"New number: {num} added!");
            }
            Console.WriteLine("Your set:");
            PrintSet(nums);
        }
        private void RangeGeneration(int start, int end, int n)
        {
            nums = new HashSet<int>();
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                int num = rnd.Next(start, end + 1);
                nums.Add(num);
                Console.WriteLine($"New number: {num} added!");
            }
            Console.WriteLine("Your set:");
            PrintSet(nums);
        }
        private void HandleGeneration(int n)
        {
            nums = new HashSet<int>();
            Random rnd = new Random();
            Console.WriteLine("Please, enter elements of your set:");
            for (int i = 0; i < n; i++)
            {
                if (int.TryParse(Console.ReadLine(), out int num))
                {
                    nums.Add(num);
                    Console.WriteLine($"New number: {num} added!");
                    continue;
                }
                Console.WriteLine("Your data is not integer! Random replacing...");
                num = rnd.Next();
                nums.Add(num);
                Console.WriteLine($"New number: {num} added!");
            }
            Console.WriteLine("Your set:");
            PrintSet(nums);
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
            Console.WriteLine("Primes set:");
            PrintSet(primes);
            Console.WriteLine("\nComposites set:");
            PrintSet(composites);
        }
    }
}
