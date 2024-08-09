using System.Diagnostics;

namespace Practice7_ThreadsForm
{
    internal class ProcessController
    {
        public Process processConsole;

        public void StartProcess(string filePath)
        {
            if (processConsole == null || processConsole.HasExited)
            {
                processConsole = new Process();
                processConsole.StartInfo.FileName = filePath;
                processConsole.StartInfo.UseShellExecute = false;
                processConsole.StartInfo.RedirectStandardInput = true;
                processConsole.Start();
            }
        }

        public void SendCommand(string command)
        {
            if (processConsole != null && !processConsole.HasExited)
            {
                processConsole.StandardInput.WriteLine(command);
            }
            else
            {
                throw new InvalidOperationException("Process has not been run or finished!");
            }
        }

        public void StopProcess()
        {
            if (processConsole != null && !processConsole.HasExited)
            {
                processConsole.Kill();
                processConsole.Dispose();
                processConsole = null;
            }
        }
    }
}
