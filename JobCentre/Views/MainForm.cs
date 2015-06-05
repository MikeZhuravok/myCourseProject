using JobCentre.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobCentre.Views
{
    public partial class MainForm : Form
    {
        string connectionString = Helper.connectionString;
        DataBaseForm dbForm;
        public MainForm()
        {
            InitializeComponent();
        }

        private void dataBasesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DataBaseForm form = new DataBaseForm();
            dbForm = form;
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e) // если убрать дублирование, исчезнет обновление дата тейбла
        {
            using (SqlConnection sql = new SqlConnection(connectionString))
            {
                string sqlString = "SELECT Distinct [Company name] FROM [dbo].[Vacancy];";
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable dt = new DataTable();
                //MakeSql(adapter, dt, sqlString, sql);             
                adapter = new SqlDataAdapter(sqlString, sql);
                dt = new DataTable();
                adapter.Fill(dt);
                List<string> companies = new List<string>();
                string temp = ""; // for vary of selects
                foreach (DataRow row in dt.Rows)
                {
                    foreach (DataColumn column in dt.Columns)
                    {
                        companies.Add(row[column].ToString());
                    }
                }
                foreach (string i in companies)
                    temp += String.Format(", (SELECT COUNT(Scope) FROM Vacancy v WHERE [Company name] = '{0}' AND vac.Scope = v.Scope) as {0} ", i);                //MakeSql(adapter, dt, sqlString, sql);
                sqlString = "SELECT DISTINCT Scope " + temp + " FROM Vacancy vac;";

                adapter = new SqlDataAdapter(sqlString, sql);
                dt = new DataTable();
                adapter.Fill(dt);


                AvgSlryDataGridView.DataSource = dt;

            }
        }

        private void MakeSql(SqlDataAdapter adapter, DataTable dt, string sqlString, SqlConnection sql)
        {
            adapter = new SqlDataAdapter(sqlString, sql);
            dt = new DataTable();
            adapter.Fill(dt);
        }

        private void vacancyDatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VacancyDateDetails vdd = new VacancyDateDetails();
            vdd.ShowDialog();
        }

        private void sqlQueryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sql_query_editor sqe = new Sql_query_editor();
            sqe.Show();
        }

        private void freeVacancysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VacanciesView vv = new VacanciesView();
            vv.Show();
        }

        private void vacancyInterviewsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Interviews_report ir = new Interviews_report();
            //ir.Show();

            string template = "\tReport about interviews\n\n\tInterviews without result:\n\n{0}\n\n\tPositive interviews:\n\n{1}\n\n\tNegative interviews:\n\n{2}\n\nSign _____________\n\nCertified by: ";
            interviewsReportSaveFileDialog.ShowDialog();
            string filepath = interviewsReportSaveFileDialog.FileName + ".doc";
            if (filepath == ".doc")
                return;
            string interviewsWithout = "", positive = "", negative = "";
            using (StreamWriter writer = new StreamWriter(filepath))
            {
                using (SqlConnection sql = new SqlConnection(connectionString))
                {
                    string sqlString = "SELECT * FROM [dbo].[Vacancy request] WHERE Result IS NULL"; // собеседования without result
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    DataTable dt = new DataTable();
                    adapter = new SqlDataAdapter(sqlString, sql);
                    adapter.Fill(dt);
                    foreach (DataRow row in dt.Rows)
                    {
                        interviewsWithout += "Vacancy ID: " + row[0];
                        interviewsWithout += " Interview date: " + row[3] + "; \n";
                    }

                    sqlString = "SELECT * FROM [dbo].[Vacancy request] WHERE Result = 'true'";
                    dt = new DataTable();
                    adapter = new SqlDataAdapter(sqlString, sql);
                    adapter.Fill(dt);
                    foreach (DataRow row in dt.Rows)
                    {
                        positive += "Vacancy ID: " + row[0];
                        positive += " Interview date: " + row[3] + "; \n";
                    }

                    sqlString = "SELECT * FROM [dbo].[Vacancy request] WHERE Result <> 'true'";
                    dt = new DataTable();
                    adapter = new SqlDataAdapter(sqlString, sql);
                    adapter.Fill(dt);
                    foreach (DataRow row in dt.Rows)
                    {
                        negative += "Vacancy ID: " + row[0];
                        negative += " Interview date: " + row[3] + "; \n";
                    }
                }
                negative = negative == "" ? "None" : negative.Substring(0, negative.Length - 2);
                positive = positive == "" ? "None" : positive.Substring(0, positive.Length - 2);
                interviewsWithout = interviewsWithout == "" ? "None" : interviewsWithout.Substring(0, interviewsWithout.Length - 2);
                writer.Write(String.Format(template, interviewsWithout, positive, negative));
            }
            Process.Start(filepath);
        }

        private void employerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEmployer ae = new AddEmployer();
            ae.ShowDialog();
            updateIfNotNull();
        }

        private void vacancyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddVacancy av = new AddVacancy();
            av.ShowDialog();
            updateIfNotNull();
        }

        private void vacancyRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddVacancyRequest avr = new AddVacancyRequest();
            avr.ShowDialog();
            updateIfNotNull();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEmployee ae = new AddEmployee();
            ae.ShowDialog();
            updateIfNotNull();
        }

        private void updateIfNotNull()
        {
            if (dbForm != null)
                dbForm.tabControl_SelectedIndexChanged(null, null);

        }

        private void averageSalaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProfessionsStatisticsView asv = new ProfessionsStatisticsView();
            asv.Show();
        }

        private void companiesStatisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompanyStatisticsView csv = new CompanyStatisticsView();
            csv.Show();
        }

        private void employersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployersStatisticView esv = new EmployersStatisticView();
            esv.Show();
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //interviewsReportSaveFileDialog.ShowDialog();
            //string filepath = interviewsReportSaveFileDialog.FileName + ".csv";
            //if (filepath == "")
            //    return;
            string sqlString = String.Format("SELECT [Full name], Profession, [Special skills], Education FROM Employee");

            using (SqlConnection sql = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(sqlString, sql);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                DataGridView dgv = new DataGridView();
                dgv.DataSource = dt;
                Exporter.ToExcel(dgv, System.Drawing.Color.FromArgb(230, 84, 0),
                    System.Drawing.Color.White, 14, 13, null);
            }
        }

        private void employerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string sqlString = String.Format("SELECT Employer.[Employer's ID], [Full name], [Company name], COUNT(*) AS 'Vacancy count', SUM(Salary) * 0.15 AS 'Potential tax'  FROM Employer, " +
            "Vacancy WHERE Employer.[Employer's ID] = Vacancy.[Employer's ID] GROUP BY Employer.[Employer's ID],[Full name], [Company name]");

            using (SqlConnection sql = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(sqlString, sql);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                DataGridView dgv = new DataGridView();
                dgv.DataSource = dt;
                Exporter.ToExcel(dgv, System.Drawing.Color.FromArgb(230, 84, 0),
                    System.Drawing.Color.White, 14, 13, null);
            }
        }
    }
}
