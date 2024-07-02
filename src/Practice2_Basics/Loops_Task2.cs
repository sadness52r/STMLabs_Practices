using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2_Basics
{
    internal class Loops_Task2
    {
        private const double FIRSTDAYNORM = 10;
        private const double RATE = 0.1;
        private const int DAYS = 7;
        private double generalNorm;

        public Loops_Task2() 
        {
            generalNorm = FIRSTDAYNORM;
        }

        public void Run()
        {
            for (int i = 1; i < DAYS; i++)
            {
                generalNorm *= (1 + RATE);
            }
            Console.WriteLine($"In {DAYS} days the sportsman walked {generalNorm} km");
        }
    }
}
