using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Practice7_ThreadsConsole
{
    public class ThreadController
    {
        Thread thread = null;

        private void Run()
        {
            Console.WriteLine($"Thread {thread?.Name} is running...");
            Thread.Sleep(2000);
            Console.WriteLine($"Thread {thread?.Name} was stopped!");
        }

        public void CreateThread(string name)
        {
            thread = new Thread(this.Run);
            thread.Name = name;
            thread.Start();
        }
    }
}
