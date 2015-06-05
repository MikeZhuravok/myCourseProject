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
    public partial class ProfessionsStatisticsView : Form
    {
        string connectionString = Helper.connectionString;

        public ProfessionsStatisticsView()
        {
            InitializeComponent();
            string sqlString = String.Format("SELECT Scope, COUNT(*)  As 'Vacancies count', AVG(Salary) As 'Average Salary', MIN([Beginning of work]) AS 'Earliest start', MAX([End of work]) As 'Latest end' FROM [Vacancy] GROUP BY Scope");

            using (SqlConnection sql = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(sqlString, sql);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                statisticsDataGridView.DataSource = dt;
            }
        }

    }
}
