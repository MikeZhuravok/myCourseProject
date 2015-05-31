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
    public partial class AddVacancyRequest : Form
    {
        public AddVacancyRequest()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            int vacId;
            int emplId;
            DateTime submissionDate;
            DateTime interviewDate;
            if (Int32.TryParse(vacancy_IDTextBox.Text, out vacId) && Int32.TryParse(employee_s_IDTextBox.Text, out emplId) && DateTime.TryParse(submission_dateDateTimePicker.Text, out submissionDate)
                && DateTime.TryParse(interview_dateDateTimePicker.Text, out interviewDate))
            {
                vacancy_requestTableAdapter.InsertVacRequestQuery(vacId, emplId, submissionDate, interviewDate, resultTextBox.Text);
                MessageBox.Show(String.Format("Element was just added."));                    
            }
        }
    }
}
