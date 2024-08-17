namespace Practice7_ThreadsForm
{
    public partial class Form1 : Form
    {
        private const string FILE_POSITIONS = "file_positions.json";
        private ProcessController processController;
        private ConnectionController connectionController;

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
                    processController.StartProcess(@"Practice7_ThreadsConsole.exe", this);
                    comboBoxTasks.Items.Add("All threads");
                    comboBoxTasks.Items.Add("Main thread");
                    connectionController.StartPipeClient();
                    numericUpDownNThreads.Enabled = true;
                    buttonStop.Enabled = true;
                }
                if (numericUpDownNThreads.Value != 0)
                {
                    processController.SendCommand($"Start {numericUpDownNThreads.Value}");
                    for (int i = 0; i < numericUpDownNThreads.Value; i++)
                    {
                        comboBoxTasks.Items.Add($"Thread {i + 1}");
                    }
                    numericUpDownNThreads.Enabled = false;
                }
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
                CloseConsole();
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (File.Exists(FILE_POSITIONS))
            {
                File.Delete(FILE_POSITIONS);
            }
            processController.StopProcess();
        }

        public void CloseConsole()
        {
            this.Enabled = false;
            processController.StopProcess();
            connectionController.ClosePipeClient();
            comboBoxTasks.Items.Clear();
            numericUpDownNThreads.Enabled = false;
            buttonStop.Enabled = false;
            this.Enabled = true;
        } 
    }
}
