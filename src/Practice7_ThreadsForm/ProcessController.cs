using System.Diagnostics;

namespace Practice7_ThreadsForm
{
    internal class ProcessController
    {
        public Process processConsole;
        private Form1 form;

        public void StartProcess(string filePath, Form1 form)
        {
            this.form = form;
            processConsole = new Process();
            processConsole.StartInfo.FileName = filePath;
            processConsole.StartInfo.UseShellExecute = false;
            processConsole.StartInfo.RedirectStandardInput = true;
            processConsole.EnableRaisingEvents = true;
            processConsole.Exited += Process_Exited;
            processConsole.Start();
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
                SendCommand("Exit");
                processConsole.WaitForExit();
            }
        }

        private void Process_Exited(object sender, EventArgs e)
        {
            form.Invoke(new Action(form.CloseConsole));
            MessageBox.Show("Console application closed!");
        }
    }
}
