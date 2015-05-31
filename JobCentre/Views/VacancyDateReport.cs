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
    public partial class VacancyDateReport : Form
    {
        string connectionString = Helper.connectionString;

        DateTime begin, end;
        public VacancyDateReport(DateTime DateBeginning, DateTime DateEnding)
        {
            InitializeComponent();
            begin = DateBeginning;
            end = DateEnding;
            using (SqlConnection sql = new SqlConnection(connectionString))
            {

                string sqlString = String.Format("SELECT * FROM [dbo].[Vacancy request] WHERE [Interview Date] BETWEEN '{0}' AND '{1}';"
                    , DateBeginning, DateEnding);
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable dt = new DataTable();
                adapter = new SqlDataAdapter(sqlString, sql);
                dt = new DataTable();
                adapter.Fill(dt);

                reportDataGridView.DataSource = dt;
            }
        }


    }
}
