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
    public partial class EmployersStatisticView : Form
    {
        string connectionString = Helper.connectionString;

        public EmployersStatisticView()
        {
            InitializeComponent();
            string sqlString = String.Format("SELECT [Economical activity], [Main property type], COUNT(*) AS 'Count' FROM Employer GROUP BY [Economical activity], [Main property type];");

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
