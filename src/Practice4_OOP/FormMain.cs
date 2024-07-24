using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice4_OOP
{
    public partial class FormMain : Form
    {
        private string jobTitle;
        private Consultant? consultant;

        public FormMain(string jobTitle)
        {
            this.jobTitle = jobTitle;
            switch (jobTitle)
            {
                case "Consultant":
                    consultant = new Consultant();
                    break;
                default:
                    break;
            }
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.Text = jobTitle;
            this.labelJobTitle.Text = jobTitle;
            ClientsLoader clientLoader = new ClientsLoader("clients.txt");
            if (consultant != null)
            {
                consultant.Clients = clientLoader.Load();
                comboBoxClients.Items.AddRange(consultant.Clients.Keys.ToArray());
            }
        }

        private void comboBoxClients_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
