using System;
using System.Collections.Generic;
using System.Text;

namespace Practice2_Basics
{
    internal class SetsTask5
    {
        private HashSet<int> nums;
        private HashSet<int> primes;
        private HashSet<int> composites;
        private StringBuilder sb;

        public SetsTask5() : this(n:int.MaxValue) { }
        public SetsTask5(int n) : this(start: 0, end: int.MaxValue, n) { }
        public SetsTask5(int start, int end, int n)
        {
            primes = new HashSet<int>();
            composites = new HashSet<int>();
            sb = new StringBuilder();
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

        public override string ToString()
        {
            sb.Append("Initial set: ");
            sb.Append(string.Join(" ", nums));
            sb.Append("\nPrimes set: ");
            sb.Append(string.Join(" ", primes));
            sb.Append("\nComposites set: ");
            sb.Append(string.Join(" ", composites));
            string representation = sb.ToString();
            sb.Clear();
            return representation;
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
        }
    }
}
