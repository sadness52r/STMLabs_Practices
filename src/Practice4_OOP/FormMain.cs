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
        private JobTitle jobTitle;

        public FormMain(JobTitle jobTitle)
        {
            this.jobTitle = jobTitle;
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            switch (jobTitle)
            {
                case JobTitle.Consultant:
                    break;
                default:
                    break;
            }
        }
    }
}
