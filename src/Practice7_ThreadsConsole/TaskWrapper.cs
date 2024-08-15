using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice7_ThreadsConsole
{
    internal class TaskWrapper
    {
        public Task Task { get; private set; }
        public CancellationTokenSource CancellationTokenSource { get; private set; }
        //private Func<CancellationToken, Task> taskFunc;

        public TaskWrapper(Action<CancellationToken> taskFunc)
        {
            //this.taskFunc = taskFunc;
            CancellationTokenSource = new CancellationTokenSource();
            Task = Task.Run(() => taskFunc(CancellationTokenSource.Token));
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
