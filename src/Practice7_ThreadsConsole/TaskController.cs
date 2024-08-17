using System.Collections.Concurrent;
using System.IO.Pipes;

namespace Practice7_ThreadsConsole
{
    public class TaskController
    {
        private List<TaskWrapper> tasks;
        private ConcurrentQueue<string> fileRows;
        private StreamWriter writer;
        private NamedPipeServerStream pipeServer;
        private int delay, itemsToLoad, activeTasks = 0;
        private bool isAllAborted = false;

        public TaskController(int delay, int itemsToLoad, NamedPipeServerStream pipeServer/*, List<StreamWriter> writers*/)
        {
            this.delay = delay;
            this.itemsToLoad = itemsToLoad;
            tasks = new List<TaskWrapper>();
            this.pipeServer = pipeServer;
            writer = new StreamWriter(pipeServer);
            fileRows = new ConcurrentQueue<string>();
        }

        public void CreateTask()
        {
            tasks.Add(new TaskWrapper(delay, itemsToLoad));
            tasks.Last().RunTask(TaskReadFile);
            activeTasks++;
        }
        public void RemoveTask()
        {
            if (tasks.Count > 0)
            {
                if (!tasks.Last().Task.IsCompleted && !tasks.Last().Task.IsCanceled)
                {
                    tasks[--activeTasks].CancelTask();
                }
                tasks.RemoveAt(tasks.Count - 1);
            }
            else
            {
                string? line = null;
                writer.WriteLine(line);
                writer.Flush();
                writer.Close();
                writer.Dispose();
                isAllAborted = true;
            }
        }
        public void FileToQueue(string[] lines)
        {
            foreach (var item in lines)
            {
                fileRows.Enqueue(item);
            }
        }
        public string[] QueueToArray() => fileRows.ToArray();
        public void AbortAllTasks()
        {
            while (!isAllAborted)
            {
                RemoveTask();
            }
        }

        private void TaskReadFile(TaskWrapper task)
        {
            int rowsNumber = 0;
            while (!fileRows.IsEmpty && rowsNumber < itemsToLoad)
            {
                if (task.CancellationTokenSource.IsCancellationRequested) break;

                if (fileRows.TryDequeue(out string result))
                {
                    writer.WriteLine(result);
                    writer.Flush();
                    rowsNumber++;
                    Thread.Sleep(delay);
                }
                else
                {
                    break;
                }
            }
        }
    }
}
