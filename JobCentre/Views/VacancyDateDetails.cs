using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobCentre.Views
{
    public partial class VacancyDateDetails : Form
    {
        public VacancyDateDetails()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime From, To;
            if (DateTime.TryParse(dateFromTextBox.Text, out From) && DateTime.TryParse(DateToTextBox.Text, out To))
            {
                VacancyDateReport report = new VacancyDateReport(From, To);
                report.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Your data is incorrect");
            }

        }
    }
}
