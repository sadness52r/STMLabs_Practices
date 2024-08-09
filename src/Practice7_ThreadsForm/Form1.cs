namespace Practice7_ThreadsForm
{
    public partial class Form1 : Form
    {
        private ProcessController processController;

        public Form1()
        {
            processController = new ProcessController();
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            try
            {
                processController.StartProcess(@"Practice7_ThreadsConsole.exe");
                processController.SendCommand($"{numericUpDownNThreads.Value}");
                numericUpDownNThreads.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
