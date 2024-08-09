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
                case "Manager":
                    worker = new Manager();
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
            if (worker is Manager)
            {
                buttonAddClient.Enabled = true;
            }
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
            labelLastChanges.Text = worker.CurClient.LastDateOfChanges.ToString();
            labelChangedProperty.Text = worker.CurClient.ChangableProp.ToString();
            labelTypeOfChanges.Text = worker.CurClient.TypeOfChanges;
            labelChangerOfData.Text = worker.CurClient.ChangerOfData?.ToString();
            buttonChangePhone.Enabled = true;
            if (worker is Manager)
            {
                buttonChangeName.Enabled = true;
                buttonChangeSurname.Enabled = true;
                buttonChangePatronymic.Enabled = true;
                buttonChangePassport.Enabled = true;
            }
        }
        private void buttonChangePhone_Click(object sender, EventArgs e)
        {
            FormChangePhone formChangePhone = new FormChangePhone(worker, worker.CurClient);
            formChangePhone.ShowDialog();
            if (formChangePhone.IsChangedNumber)
            {
                worker.CurClient.LastDateOfChanges = DateTime.Now;
                worker.CurClient.ChangableProp = ChangableProperty.Phone;
                worker.CurClient.TypeOfChanges = $"{formChangePhone.OldPhoneNumber} -> {worker.CurClient.PhoneNumber}";
                worker.CurClient.ChangerOfData = worker;

                labelClientPhone.Text = worker.CurClient.PhoneNumber;
                labelLastChanges.Text = worker.CurClient.LastDateOfChanges.ToString();
                labelChangedProperty.Text = worker.CurClient.ChangableProp.ToString();
                labelTypeOfChanges.Text = worker.CurClient.TypeOfChanges;
                labelChangerOfData.Text = worker.CurClient.ChangerOfData?.ToString();

                comboBoxClients.Items.Remove(formChangePhone.OldPhoneNumber);
                comboBoxClients.Items.Add(worker.CurClient.PhoneNumber);
            }
        }
        private void buttonChangeSurname_Click(object sender, EventArgs e)
        {
            FormChangeConcreteName formChangeSurname = new FormChangeConcreteName(worker, worker.CurClient, FullnameType.SURNAME);
            formChangeSurname.ShowDialog();
            worker.CurClient.LastDateOfChanges = DateTime.Now;
            worker.CurClient.ChangableProp = ChangableProperty.Surname;
            worker.CurClient.TypeOfChanges = $"{formChangeSurname.OldConcreteName} -> {worker.CurClient.Surname}";
            worker.CurClient.ChangerOfData = worker;

            labelClientSurname.Text = worker.CurClient.Surname;
            labelLastChanges.Text = worker.CurClient.LastDateOfChanges.ToString();
            labelChangedProperty.Text = worker.CurClient.ChangableProp.ToString();
            labelTypeOfChanges.Text = worker.CurClient.TypeOfChanges;
            labelChangerOfData.Text = worker.CurClient.ChangerOfData?.ToString();
        }
        private void buttonChangeName_Click(object sender, EventArgs e)
        {
            FormChangeConcreteName formChangeName = new FormChangeConcreteName(worker, worker.CurClient, FullnameType.NAME);
            formChangeName.ShowDialog();
            worker.CurClient.LastDateOfChanges = DateTime.Now;
            worker.CurClient.ChangableProp = ChangableProperty.Name;
            worker.CurClient.TypeOfChanges = $"{formChangeName.OldConcreteName} -> {worker.CurClient.Name}";
            worker.CurClient.ChangerOfData = worker;

            labelClientName.Text = worker.CurClient.Name;
            labelLastChanges.Text = worker.CurClient.LastDateOfChanges.ToString();
            labelChangedProperty.Text = worker.CurClient.ChangableProp.ToString();
            labelTypeOfChanges.Text = worker.CurClient.TypeOfChanges;
            labelChangerOfData.Text = worker.CurClient.ChangerOfData?.ToString();
        }
        private void buttonChangePatronymic_Click(object sender, EventArgs e)
        {
            FormChangeConcreteName formChangePatronymic = new FormChangeConcreteName(worker, worker.CurClient, FullnameType.PATRONYMIC);
            formChangePatronymic.ShowDialog();
            worker.CurClient.LastDateOfChanges = DateTime.Now;
            worker.CurClient.ChangableProp = ChangableProperty.Patronymic;
            worker.CurClient.TypeOfChanges = $"{formChangePatronymic.OldConcreteName} -> {worker.CurClient.Patronymic}";
            worker.CurClient.ChangerOfData = worker;

            labelClientPatronymic.Text = worker.CurClient.Patronymic;
            labelLastChanges.Text = worker.CurClient.LastDateOfChanges.ToString();
            labelChangedProperty.Text = worker.CurClient.ChangableProp.ToString();
            labelTypeOfChanges.Text = worker.CurClient.TypeOfChanges;
            labelChangerOfData.Text = worker.CurClient.ChangerOfData?.ToString();
        }
        private void buttonChangePassport_Click(object sender, EventArgs e)
        {
            FormChangePassport formChangePassport = new FormChangePassport(worker, worker.CurClient);
            formChangePassport.ShowDialog();
            worker.CurClient.LastDateOfChanges = DateTime.Now;
            worker.CurClient.ChangableProp = ChangableProperty.Passport;
            worker.CurClient.TypeOfChanges = $"{formChangePassport.OldPassport} -> {worker.CurClient.PassportSeries} {worker.CurClient.PassportNumber}";
            worker.CurClient.ChangerOfData = worker;

            labelClientPassport.Text = worker.CurClient.PassportSeries + " " + worker.CurClient.PassportNumber;
            labelLastChanges.Text = worker.CurClient.LastDateOfChanges.ToString();
            labelChangedProperty.Text = worker.CurClient.ChangableProp.ToString();
            labelTypeOfChanges.Text = worker.CurClient.TypeOfChanges;
            labelChangerOfData.Text = worker.CurClient.ChangerOfData?.ToString();
        }
        private void buttonAddClient_Click(object sender, EventArgs e)
        {
            FormAddClient formAddClient = new FormAddClient(worker, comboBoxClients);
            formAddClient.ShowDialog();
        }
    }
}
