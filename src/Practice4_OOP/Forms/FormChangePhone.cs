namespace Practice4_OOP
{
    internal partial class FormChangePhone : Form
    {
        private Worker worker;
        private Client client;
        private string? oldPhoneNumber;
        public bool IsChangedNumber = false;

        public string OldPhoneNumber => oldPhoneNumber;

        public FormChangePhone(Worker worker, Client client)
        {
            this.worker = worker;
            this.client = client;
            InitializeComponent();
        }

        private void buttonAcceptPhone_Click(object sender, EventArgs e)
        {
            if (worker.Clients.ContainsKey(maskedTextBoxNewPhone.Text))
            {
                MessageBox.Show("This number is already exists!");
            }
            else
            {
                oldPhoneNumber = client.PhoneNumber;
                worker.Clients.Remove(oldPhoneNumber);
                worker.Clients.Add(maskedTextBoxNewPhone.Text, client);
                client.PhoneNumber = maskedTextBoxNewPhone.Text;
                MessageBox.Show("Phone successfully changed!");
                IsChangedNumber = true;
            }
        }
        private void maskedTextBoxNewPhone_TextChanged(object sender, EventArgs e)
        {
            if (maskedTextBoxNewPhone.Text.Length != 0)
            {
                buttonAcceptPhone.Enabled = true;
            }
            else
            {
                buttonAcceptPhone.Enabled = false;
            }
        }
    }
}
