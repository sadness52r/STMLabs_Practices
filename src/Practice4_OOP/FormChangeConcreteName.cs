﻿namespace Practice4_OOP
{
    internal partial class FormChangeConcreteName : Form
    {
        private Worker worker;
        private Client client;
        private FullnameType concreteInitial;

        public FormChangeConcreteName(Worker worker, Client client, FullnameType concreteInitial)
        {
            this.worker = worker;
            this.client = client;
            this.concreteInitial = concreteInitial;
            InitializeComponent();
        }

        private void FormChangeFullname_Load(object sender, EventArgs e)
        {
            labelConcreteName.Text = concreteInitial.ToString().ToLower();
        }

        private void buttonAcceptConcreteName_Click(object sender, EventArgs e)
        {
            switch (concreteInitial)
            {
                case FullnameType.SURNAME:
                    client.Surname = maskedTextBoxNewConcreteName.Text;
                    MessageBox.Show("Surname successfully changed!");
                    break;
                case FullnameType.NAME:
                    client.Name = maskedTextBoxNewConcreteName.Text;
                    MessageBox.Show("Name successfully changed!");
                    break;
                case FullnameType.PATRONYMIC:
                    client.Patronymic = maskedTextBoxNewConcreteName.Text;
                    MessageBox.Show("Patronymic successfully changed!");
                    break;
                default:
                    break;
            }
        }
        private void maskedTextBoxNewConcreteName_TextChanged(object sender, EventArgs e)
        {
            if (maskedTextBoxNewConcreteName.Text.Length != 0)
            {
                buttonAcceptConcreteName.Enabled = true;
            }
            else
            {
                buttonAcceptConcreteName.Enabled = false;
            }
        }
    }
}
