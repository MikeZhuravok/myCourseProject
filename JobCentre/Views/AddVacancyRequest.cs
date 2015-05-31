using JobCentre.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobCentre.Views
{
    public partial class AddVacancyRequest : Form
    {
        string connectionString = Helper.connectionString;
        public AddVacancyRequest()
        {
            InitializeComponent();

            string sqlString;
            using (SqlConnection sql = new SqlConnection(connectionString))
            {
                sqlString = "SELECT [Employee's ID], [Full name] FROM [dbo].[Employee]";
                SqlDataAdapter adapter = new SqlDataAdapter(sqlString, sql);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt != null)
                {
                    employeeIdComboBox.DataSource = Helper.DataTableToStringList(dt, false);
                }
                sqlString = "SELECT [Vacancy Id] FROM [dbo].[Vacancy]";
                adapter = new SqlDataAdapter(sqlString, sql);
                dt = new DataTable();
                adapter.Fill(dt);
                if (dt != null)
                {
                    vacancyIdComboBox.DataSource = Helper.DataTableToStringList(dt);
                }
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            int vacId;
            int emplId;
            DateTime submissionDate;
            DateTime interviewDate;
            if (Int32.TryParse(vacancyIdComboBox.Text, out vacId) && Helper.TryParse(employeeIdComboBox.Text, out emplId) && DateTime.TryParse(submission_dateDateTimePicker.Text, out submissionDate)
                && DateTime.TryParse(interview_dateDateTimePicker.Text, out interviewDate))
            {
                try
                {
                    vacancy_requestTableAdapter.InsertVacRequestQuery(vacId, emplId, submissionDate, interviewDate, resultComboBox.Text == null ? "" : resultComboBox.Text);
                    MessageBox.Show(String.Format("Element was just added."));
                    this.vacancyTableAdapter.Update(this.laborExchangeDataSet);
                    DialogResult = DialogResult.OK;
                    return;
                }
                catch { }
            }
            MessageBox.Show(String.Format("Your data is incorrect"));
        }
    }
}
