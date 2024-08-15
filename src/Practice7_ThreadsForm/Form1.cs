using System.IO.Pipes;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Practice7_ThreadsForm
{
    public partial class Form1 : Form
    {
        private ProcessController processController;
        private ConnectionController connectionController;
        private int numThreads = 0;

        public Form1()
        {
            processController = new ProcessController();
            connectionController = new ConnectionController(this);
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            try
            {
                if (processController.processConsole == null || processController.processConsole.HasExited)
                {
                    processController.StartProcess(@"Practice7_ThreadsConsole.exe");
                    comboBoxTasks.Items.Add("All threads");
                    comboBoxTasks.Items.Add("Main thread");
                    connectionController.StartPipeClient();
                    numericUpDownNThreads.Enabled = true;
                    buttonStop.Enabled = true;
                }
                processController.SendCommand($"Start {numericUpDownNThreads.Value}");
                for (int i = numThreads; i < numericUpDownNThreads.Value; i++)
                {
                    comboBoxTasks.Items.Add($"Thread {i + 1}");
                }
                numThreads = (int)numericUpDownNThreads.Value;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void buttonStop_Click(object sender, EventArgs e)
        {
            processController.SendCommand("Stop");
            if (comboBoxTasks.Items.Count > 2)
            {
                comboBoxTasks.Items.RemoveAt(comboBoxTasks.Items.Count - 1);
            }
            else
            {
                connectionController.ClosePipeClient();
                processController.StopProcess();
                comboBoxTasks.Items.Clear();
                numericUpDownNThreads.Enabled = false;
                buttonStop.Enabled = false;
            }
        }
        //private void ConsoleProcess_Exited(object sender, EventArgs e)
        //{
        //    Invoke((Action)(() =>
        //    {
                
        //    }));
        //    connectionController.ClosePipeClient();
        //}
    }
}
