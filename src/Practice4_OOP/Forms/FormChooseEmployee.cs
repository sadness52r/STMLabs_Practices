using Microsoft.Extensions.Logging;

namespace Practice4_OOP
{
    public partial class FormChooseEmployee : Form
    {
        private readonly ILogger logger;

        public FormChooseEmployee(ILogger<FormChooseEmployee> logger)
        {
            this.logger = logger;
            InitializeComponent();
        }

        private void buttonOpenMain_Click(object sender, EventArgs e)
        {
            FormMain formMain = new FormMain(comboBoxChooseEmployee.Text);
            this.Hide();
            formMain.Closed += (s, args) => this.Close();
            formMain.Show();
        }
        private void comboBoxChooseEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonOpenMain.Enabled = true;
            try
            {
                switch (comboBoxChooseEmployee.Text)
                {
                    case "Consultant":
                        pictureBoxJobTitle.Image = Image.FromFile(Worker.CONSULTANT_PIC);
                        break;
                    case "Manager":
                        pictureBoxJobTitle.Image = Image.FromFile(Worker.MANAGER_PIC);
                        break;
                    default:
                        break;
                }
            }
            catch (FileNotFoundException ex)
            {
                logger.LogError(ex, ex.Message);
            }
        }
    }
}
