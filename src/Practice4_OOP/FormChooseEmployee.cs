namespace Practice4_OOP
{
    public partial class FormChooseEmployee : Form
    {
        private FormMain? formMain;

        public FormChooseEmployee()
        {
            InitializeComponent();
        }

        private void FormChooseEmployee_Load(object sender, EventArgs e)
        {

        }

        private void buttonOpenMain_Click(object sender, EventArgs e)
        {
            if (comboBoxChooseEmployee.Text == string.Empty)
            {
                //ошибка
            }
            formMain = new FormMain(comboBoxChooseEmployee.Text);
            this.Hide();
            formMain.Closed += (s, args) => this.Close();
            formMain.Show();
        }
    }
}
