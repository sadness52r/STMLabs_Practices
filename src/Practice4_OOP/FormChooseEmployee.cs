using Microsoft.Extensions.DependencyInjection;

namespace Practice4_OOP
{
    public partial class FormChooseEmployee : Form
    {
        private FormMain? formMain;

        public FormChooseEmployee()
        {
            InitializeComponent();
        }

        private void buttonOpenMain_Click(object sender, EventArgs e)
        {
            formMain = new FormMain(comboBoxChooseEmployee.Text);
            this.Hide();
            formMain.Closed += (s, args) => this.Close();
            formMain.Show();
        }
        private void comboBoxChooseEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonOpenMain.Enabled = true;
        }
    }
}
