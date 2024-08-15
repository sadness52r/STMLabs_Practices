using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice7_ThreadsForm
{
    internal class ConnectionController
    {
        //private CancellationTokenSource cts;
        private Task task;
        private NamedPipeClientStream pipeClient;
        private StreamReader? reader;
        private Form1 form;

        public ConnectionController(Form1 form)
        {
            this.form = form;
            //cts = new CancellationTokenSource();
        }

        public void StartPipeClient()
        {
            pipeClient = new NamedPipeClientStream(".", "DataPipe", PipeDirection.In);
            pipeClient.Connect();
            reader = new StreamReader(pipeClient);

            task = Task.Run(() =>
            {
                form.Invoke((Action)(() =>
                {
                    form.listBox1.Items.Add("Task added!");
                }));
                while (true)
                {
                    string line = reader.ReadLine();
                    if (line == null) break;

                    form.Invoke((Action)(() =>
                    {
                        form.listBoxFileText.Items.Add(line);
                    }));
                }
                form.Invoke((Action)(() =>
                {
                    form.listBox1.Items.Add("Task stopped!");
                }));
            });
        }
        public void ClosePipeClient()
        {
            //cts.Cancel();
            pipeClient?.Close();
        }
    }
}
