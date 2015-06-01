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

        public VacancyFilterForm()
        {
            InitializeComponent();

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

        private void VacancyFilterForm_Load(object sender, EventArgs e)
        {

        }

        private void FilterButton_Click(object sender, EventArgs e)
        {

        }
    }
}
