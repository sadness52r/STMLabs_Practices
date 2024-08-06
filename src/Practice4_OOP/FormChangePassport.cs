namespace Practice4_OOP
{
    internal partial class FormChangePassport : Form
    {
        private Worker worker;
        private Client client;

        public FormChangePassport(Worker worker, Client client)
        {
            this.worker = worker;
            this.client = client;
            InitializeComponent();
        }

        private void buttonAcceptPassport_Click(object sender, EventArgs e)
        {
            client.PassportSeries = maskedTextBoxNewPassportSeries.Text;
            client.PassportNumber = maskedTextBoxNewPassportNumber.Text;
            MessageBox.Show("Passport successfully changed!");
        }
        private void timerCheckUpdateButton_Tick(object sender, EventArgs e)
        {
            if (maskedTextBoxNewPassportSeries.Text.Length == maskedTextBoxNewPassportSeries.Mask.Length
                && maskedTextBoxNewPassportNumber.Text.Length == maskedTextBoxNewPassportNumber.Mask.Length)
            {
                buttonAcceptPassport.Enabled = true;
            }
            else
            {
                buttonAcceptPassport.Enabled = false;
            }
        }
    }
}
