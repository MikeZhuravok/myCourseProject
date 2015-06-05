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
    public partial class VacancyFilterForm : Form
    {
        string connectionString = Helper.connectionString;
        DataBaseForm dbForm;
        public VacancyFilterForm(DataBaseForm form)
        {
            InitializeComponent();
            dbForm = form;
            string sqlString;
            using (SqlConnection sql = new SqlConnection(connectionString))
            {
                sqlString = "SELECT DISTINCT Scope FROM [dbo].[Vacancy]";
                SqlDataAdapter adapter = new SqlDataAdapter(sqlString, sql);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt != null)
                {
                    scopeComboBox.DataSource = Helper.DataTableToStringList(dt);
                }
            }
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            string sqlString;
            DateTime from = beginningOfWorkDateTimePicker.Value, to = endOfWorkDateTimePicker.Value;
            decimal minSalary = -1;
            string forSalary = "";
            if (Decimal.TryParse(salaryTextBox.Text, out minSalary))
                forSalary = "AND Salary > " + minSalary;
            bool possibilyOfWorkingMinors = minorsCheckBox.Checked;
            string forMinors = "";
            if (possibilyOfWorkingMinors)
                forMinors = "AND [Possibility of working minors] = 'Yes'";

            string fromTime = String.Format("{0}:{1}", from.Hour, from.Minute);
            string toTime = String.Format("{0}:{1}", to.Hour, to.Minute);

            sqlString = String.Format("SELECT * FROM [Vacancy] WHERE [Beginning of work] > '{0}' AND [End of work] < '{1}' {2} {3};", fromTime, toTime, forSalary, forMinors);

            using (SqlConnection sql = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(sqlString, sql);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dbForm.filterDataTable = dt;
            }
            DialogResult = DialogResult.OK;
        }
    }
}
