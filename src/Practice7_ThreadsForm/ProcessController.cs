using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice7_ThreadsForm
{
    internal class ProcessController
    {
        private readonly string _processName;
        public readonly Process processConsole;
        
        public ProcessController(string processName)
        {
            _processName = processName;
            processConsole = new Process();
            processConsole.StartInfo.FileName = _processName;
            processConsole.EnableRaisingEvents = true;
            processConsole.StartInfo.UseShellExecute = false;
            processConsole.StartInfo.RedirectStandardOutput = true;
            processConsole.OutputDataReceived += (s, args) =>
            {
                if (!string.IsNullOrEmpty(args.Data))
                {
                    Console.WriteLine(args.Data);
                }
            };
        }

        public void Run()
        {
            processConsole.Start();
            processConsole.BeginOutputReadLine();
        }
    }
}
