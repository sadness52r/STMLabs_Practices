namespace Practice4_OOP
{
    internal partial class FormAddClient : Form
    {
        private Worker worker;
        private ComboBox comboBox;

        public FormAddClient(Worker worker, ComboBox comboBox)
        {
            this.worker = worker;
            this.comboBox = comboBox;
            InitializeComponent();
        }

        private void buttonAddClient_Click(object sender, EventArgs e)
        {
            if (worker.Clients.ContainsKey(maskedTextBoxNewClientPhone.Text))
            {
                MessageBox.Show("Client with this number is already exists!");
            }
            else
            {
                worker.Clients.Add(maskedTextBoxNewClientPhone.Text, new Client(maskedTextBoxNewClientSurname.Text, maskedTextBoxNewClientName.Text,
                    maskedTextBoxNewClientPatronymic.Text, maskedTextBoxNewClientPhone.Text,
                    maskedTextBoxNewClientPassportSeries.Text, maskedTextBoxNewClientPassportNumber.Text));
                comboBox.Items.Add(maskedTextBoxNewClientPhone.Text);
                MessageBox.Show("Client was successfully added!");
            }
        }
        private void timerAcceptClientToAdd_Tick(object sender, EventArgs e)
        {
            if (maskedTextBoxNewClientName.Text.Length != 0 && maskedTextBoxNewClientSurname.Text.Length != 0 && maskedTextBoxNewClientPhone.Text.Length != 0
                && (maskedTextBoxNewClientPassportSeries.Text.Length == 0 && maskedTextBoxNewClientPassportNumber.Text.Length == 0
                || maskedTextBoxNewClientPassportSeries.Text.Length == maskedTextBoxNewClientPassportSeries.Mask.Length
                && maskedTextBoxNewClientPassportNumber.Text.Length == maskedTextBoxNewClientPassportNumber.Mask.Length))
            {
                buttonAddClient.Enabled = true;
            }
            else
            {
                buttonAddClient.Enabled = false;
            }
        }
    }
}
