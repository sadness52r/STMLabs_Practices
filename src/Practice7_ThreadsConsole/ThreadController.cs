namespace Practice7_ThreadsConsole
{
    public class ThreadController
    {
        public void CreateThread()
        {
            Thread thread = new Thread(() =>
            {
                Console.WriteLine("Created a new thread: " + Thread.CurrentThread.ManagedThreadId);
            });
            thread.Start();
        }
    }
}
