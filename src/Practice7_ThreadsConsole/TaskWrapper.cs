namespace Practice7_ThreadsConsole
{
    internal class TaskWrapper
    {
        private int itemsToLoad, delay;
        public Task Task { get; private set; }
        public CancellationTokenSource CancellationTokenSource { get; private set; }

        public TaskWrapper(int delay, int itemsToload)
        {
            this.delay = delay;
            this.itemsToLoad = itemsToload;
            CancellationTokenSource = new CancellationTokenSource();
        }

        public void RunTask(Action<TaskWrapper> taskMethod)
        {
            Task = Task.Run(() => taskMethod(this));
        }
        public void CancelTask()
        {
            CancellationTokenSource.Cancel();
            try
            {
                Task.Wait();
            }
            catch (AggregateException ex)
            {
                foreach (var inner in ex.InnerExceptions)
                {
                    Console.WriteLine(inner.Message);
                }
            }
            finally
            {
                CancellationTokenSource.Dispose();
            }
        }
    }
}
