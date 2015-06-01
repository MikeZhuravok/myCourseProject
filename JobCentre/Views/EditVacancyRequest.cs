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
    public partial class EditVacancyRequest : Form
    {
        int employerId;
        int vacancyId;
        DateTime submissionTime;
        public EditVacancyRequest(int vacancy, int employer, DateTime subTime)
        {
            employerId = employer;
            vacancyId = vacancy;
            submissionTime = subTime;
            InitializeComponent();
        }

        private void EditVacancyRequest_Load(object sender, EventArgs e)
        {
            this.vacancy_requestTableAdapter.FillBy(this.laborExchangeDataSet.Vacancy_request, vacancyId, employerId, submissionTime);
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            DateTime interviewDate;
            if (DateTime.TryParse(interview_dateDateTimePicker.Text, out interviewDate))
            {
                this.vacancy_requestTableAdapter.UpdateVacRequestQuery(interviewDate, resultComboBox.Text, vacancyId, employerId, submissionTime);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show(String.Format("Your data is incorrect"));

            }
        }
    }
}
