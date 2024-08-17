using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.IO.Pipes;

namespace Practice7_ThreadsConsole
{
    internal class Program
    {
        private const string FILENAME = "piter1.txt";
        private const string FILE_POSITIONS = "file_positions.json";
        private static void Main(string[] args)
        {
            ILogger logger = LoggerFactory.Create(builder =>
            {
                builder.AddConsole();
                builder.SetMinimumLevel(LogLevel.Error);
            }).CreateLogger<Program>();
            try
            {
                Config? config = LoadConfig();
                NamedPipeServerStream pipeServer = new NamedPipeServerStream("DataPipe", PipeDirection.Out);
                TaskController taskController = new TaskController(config.Delay, config.ItemsToLoad, pipeServer/*, writers*/);
                AppDomain.CurrentDomain.ProcessExit += (sender, e) =>
                {
                    RequestExit(taskController, pipeServer);
                };

                string[] lines;
                if (File.Exists(FILE_POSITIONS))
                {
                    lines = JsonConvert.DeserializeObject<string[]>(File.ReadAllText(FILE_POSITIONS));
                }
                else
                {
                    lines = File.ReadAllLines(FILENAME);
                }
                taskController.FileToQueue(lines);
                pipeServer.WaitForConnection();

                Console.WriteLine("Console has been run!");
                while (true)
                {
                    string input = Console.ReadLine();
                    if (input.StartsWith("Start"))
                    {
                        int threadCount = int.Parse(input.Split(' ')[1]);
                        for (int i = 0; i < threadCount; i++)
                        {
                            taskController.CreateTask(/*lastFilePositions*/);
                        }
                        continue;
                    }
                    if (input == "Stop")
                    {
                        taskController.RemoveTask();
                        continue;
                    }
                    if (input == "Exit")
                    {
                        break;
                    }
                }
            }
            catch (FileNotFoundException ex)
            {
                logger.LogError(ex.Message, ex);
            }
        }
        private static Config? LoadConfig() => JsonConvert.DeserializeObject<Config>(File.ReadAllText("config.json"));
        private static void RequestExit(TaskController taskController, NamedPipeServerStream pipeServer)
        {
            taskController.AbortAllTasks();
            using (StreamWriter streamWriter = new StreamWriter(FILE_POSITIONS))
            {
                streamWriter.Write(JsonConvert.SerializeObject(taskController.QueueToArray()));
            }
            pipeServer.Close();
        }
    }
}