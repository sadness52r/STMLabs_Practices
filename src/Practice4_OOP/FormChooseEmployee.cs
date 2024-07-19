namespace Practice4_OOP
{
    public partial class FormChooseEmployee : Form
    {
        public FormChooseEmployee()
        {
            InitializeComponent();
        }

        private void FormChooseEmployee_Load(object sender, EventArgs e)
        {

        }

        private void buttonOpenMain_Click(object sender, EventArgs e)
        {
            if (comboBoxChooseEmployee.SelectedText == string.Empty)
            {
                //ошибка
            }
        }
    }
}
