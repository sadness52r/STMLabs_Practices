using System;

namespace Practice2_Basics
{
    internal class LoopsTask2
    {
        private const double FIRSTDAYNORM = 10;
        private const double RATE = 0.1;
        private const int DAYS = 7;
        private double normIntoDay;
        private double generalNorm;

        public LoopsTask2()
        {
            generalNorm = FIRSTDAYNORM;
            normIntoDay = FIRSTDAYNORM;
        }

        public void Run()
        {
            for (int i = 1; i < DAYS; i++)
            {
                normIntoDay *= (1 + RATE);
                generalNorm += normIntoDay;
            }
            Console.WriteLine($"In {DAYS} days the sportsman walked {generalNorm} km");
        }
    }
}
