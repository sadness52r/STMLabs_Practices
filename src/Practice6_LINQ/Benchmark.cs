using System.Diagnostics;

namespace Practice6_LINQ
{
    delegate double MethodOfPICalculating();

    internal class Benchmark
    {
        private const int MAX_POINTS = 1000000;
        private const int RUNS = 100;
        private readonly Random random;

        public Benchmark()
        {
            random = new Random();
        }

        public void Run()
        {
            List<double> listOfPI = new List<double>();
            List<double> times = new List<double>();
            Console.WriteLine("Processing...");
            RunCalculatingPI(listOfPI, times, SequentialPI);
            double averageSequentialPI = listOfPI.Average();
            double averageSequentialTime = times.Average();
            Console.WriteLine($"[Sequential] Average value of PI for {RUNS} runs: {averageSequentialPI}");
            Console.WriteLine($"[Sequential] Average value of time (ms) for {RUNS} runs: {averageSequentialTime}");
            listOfPI.Clear(); times.Clear();
            RunCalculatingPI(listOfPI, times, ParallelPI);
            averageSequentialPI = listOfPI.Average();
            averageSequentialTime = times.Average();
            Console.WriteLine($"[Parallel] Average value of PI for {RUNS} runs: {averageSequentialPI}");
            Console.WriteLine($"[Parallel] Average value of time (ms) for {RUNS} runs: {averageSequentialTime}");
        }

        private void RunCalculatingPI(List<double> listOfPI, List<double> times, MethodOfPICalculating methodOfPICalculating)
        {
            Stopwatch stopwatch = new Stopwatch();
            for (int i = 0; i < RUNS; i++)
            {
                stopwatch.Start();
                listOfPI.Add(methodOfPICalculating());
                stopwatch.Stop();
                times.Add(stopwatch.ElapsedMilliseconds);
            }
        }
        private bool CheckInCircle(double x, double y) => x * x + y * y <= 1;
        private double CalculatePI(int pointsInCircle, int allPoints) => 4 * (double)pointsInCircle / allPoints;
        private double SequentialPI() =>
            CalculatePI(Enumerable.Range(0, MAX_POINTS).Select(i => new
            {
                x = random.NextDouble(),
                y = random.NextDouble()
            }).Count(point => CheckInCircle(point.x, point.y)), MAX_POINTS);

        private double ParallelPI() =>
            CalculatePI(Enumerable.Range(0, MAX_POINTS).Select(i => new
            {
                x = random.NextDouble(),
                y = random.NextDouble()
            }).AsParallel().Count(point => CheckInCircle(point.x, point.y)), MAX_POINTS);
    }
}
