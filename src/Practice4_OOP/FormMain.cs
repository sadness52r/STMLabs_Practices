using Microsoft.Extensions.Logging;

namespace Practice4_OOP
{
    public partial class FormMain : Form
    {
        private readonly string jobTitle;
        private readonly Worker? worker;
        private readonly ILogger logger;

        public FormMain(string jobTitle)
        {
            this.jobTitle = jobTitle;
            switch (jobTitle)
            {
                case "Consultant":
                    worker = new Consultant();
                    break;
                default:
                    break;
            }
            logger = LoggerFactory.Create(builder =>
            {
                builder.AddConsole();
                builder.SetMinimumLevel(LogLevel.Error);
            }).CreateLogger<FormMain>();
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            pictureBoxJobTitle.Image = worker.Image;
            this.Text = jobTitle;
            this.labelJobTitle.Text = jobTitle;
            ClientsLoader clientLoader = new ClientsLoader("clients.txt");
            try
            {
                worker.Clients = clientLoader.Load();
                comboBoxClients.Items.AddRange(worker.Clients.Keys.ToArray());
            }
            catch (FileNotFoundException ex)
            {
                logger.LogError(ex, ex.Message);
                MessageBox.Show(ex.Message);
            }
        }
        private void comboBoxClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            worker.CurClient = worker.Clients[comboBoxClients.SelectedItem.ToString()];
            labelClientSurname.Text = worker.CurClient.Surname;
            labelClientName.Text = worker.CurClient.Name;
            labelClientPatronymic.Text = worker.CurClient.Patronymic;
            labelClientPhone.Text = worker.CurClient.PhoneNumber;
            labelClientPassport.Text = worker.GetPassportData();
            buttonChangePhone.Enabled = true;
        }
        private void buttonChangePhone_Click(object sender, EventArgs e)
        {
            FormChangePhone formChangePhone = new FormChangePhone(worker, worker.CurClient);
            formChangePhone.ShowDialog();
            if (formChangePhone.IsChangedNumber)
            {
                labelClientPhone.Text = worker.CurClient.PhoneNumber;
                comboBoxClients.Items.Remove(formChangePhone.OldPhoneNumber);
                comboBoxClients.Items.Add(worker.CurClient.PhoneNumber);
            }
        }
    }
}
