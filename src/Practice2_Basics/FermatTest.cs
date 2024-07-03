using System;

namespace Practice2_Basics
{
    internal class FermatTest
    {
        private const int INTERATIONS = 10;
        public bool Run(int num)
        {
            if (num == 1)
            {
                return false;
            }
            Random rnd = new Random();
            for (int i = 0; i < INTERATIONS; i++)
            {
                long a = rnd.Next(1, num);
                if (GCD(a, num) != 1 || FastPower(a, num - 1, num) != 1)
                {
                    return false;
                }
            }
            return true;
        }
        private long GCD(long a, long b)
        {
            if (b == 0)
                return a;
            return GCD(b, a % b);
        }
        //x^y (mod n)
        private long FastPower(long x, long y, long n)
        {
            if (y == 0)
                return 1;

            if (y % 2 == 0)
            {
                long z = FastPower(x, y / 2, n);
                return (z * z) % n;
            }
            else
            {
                long z = FastPower(x, (y - 1) / 2, n);
                return (x * z * z) % n;
            }
        }
    }
}
