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
        public EditVacancyRequest(int vacancy, int employer, string subTime)
        {
            employerId = employer;
            vacancyId = vacancy;
            submissionTime = DateTime.Parse(subTime);
            InitializeComponent();
        }

        private void EditVacancyRequest_Load(object sender, EventArgs e)
        {
            this.vacancy_requestTableAdapter.FillBy(this.laborExchangeDataSet.Vacancy_request, vacancyId, employerId, submissionTime);
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            DateTime interviewDate;
            bool result;
            if (DateTime.TryParse(interview_dateDateTimePicker.Text, out interviewDate) && Boolean.TryParse(resultTextBox.Text, out result))
            {
                this.vacancy_requestTableAdapter.UpdateVacRequestQuery(interviewDate, result.ToString(), vacancyId, employerId, submissionTime);
            }
            else { }
        }
    }
}
