namespace Practice7_ThreadsConsole
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ThreadController threadController = new ThreadController();
            Console.WriteLine("Console has been run!");
            while (true)
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out int threadCount))
                {
                    for (int i = 0; i < threadCount; i++)
                    {
                        threadController.CreateThread();
                    }
                }
            }
        }
    }
}