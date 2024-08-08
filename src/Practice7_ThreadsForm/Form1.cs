using Practice7_ThreadsConsole;

namespace Practice7_ThreadsForm
{
    public partial class Form1 : Form
    {
        private int numberClicksStartButton = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            ProcessController? processController = null;
            if (numberClicksStartButton == 0)
            {
                numberClicksStartButton++;
                processController = new ProcessController(@"Practice7_ThreadsConsole.exe");
                processController.Run();
            }
            else
            {
                //for (int i = 0; i < numericUpDownNThreads.Value; i++)
                //{
                //    processController?.processConsole.StandardInput.WriteLine($"Create thread {i}");
                //    ThreadController threadController = new ThreadContoller($"Thread {i + 1}", processController?.processConsole);
                //}
                processController?.processConsole.StandardInput.WriteLine(numericUpDownNThreads.Value.ToString());
            }
        }
    }
}
