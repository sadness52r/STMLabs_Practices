using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using System.IO.Pipes;
using Newtonsoft.Json;

namespace Practice7_ThreadsConsole
{
    internal class Program
    {
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
                TaskController taskController = new TaskController(pipeServer, config.Delay, config.ItemsToLoad);
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
                            taskController.CreateTask();
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
                pipeServer.Close();
            }
            catch (FileNotFoundException ex)
            {
                logger.LogError(ex.Message, ex);
            }
        }
        private static Config? LoadConfig() => JsonConvert.DeserializeObject<Config>(File.ReadAllText("config.json"));
    }
}