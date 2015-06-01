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
    public partial class EmployerFilterForm : Form
    {
        string connectionString = Helper.connectionString;
        DataBaseForm form;
        public EmployerFilterForm(DataBaseForm dbForm)
        {
            InitializeComponent();
            form = dbForm;
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            string sqlString;
            int from, to;
            string forAnd = "";
            if (hasVacanciesCheckBox.Checked)
            {
                sqlString = "SELECT DISTINCT [Employer].* FROM [Employer], [Vacancy] WHERE [Employer].[Employer's ID] = [Vacancy].[Employer's ID] ";
                forAnd = " AND";
            }
            else
            {
                sqlString = "SELECT * FROM [Employer] WHERE ";
            }
            if (int.TryParse(FromEmployerIdTextBox.Text, out from) && int.TryParse(ToEmployerIdTextBox.Text, out to))
                sqlString += String.Format(" {0} [Employer].[Employer's ID] BETWEEN {1} AND {2}", forAnd, from, to);

            using (SqlConnection sql = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(sqlString, sql);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                form.filterDataTable = dt.Clone();
            }            
            DialogResult = DialogResult.OK;
        }
    }
}
