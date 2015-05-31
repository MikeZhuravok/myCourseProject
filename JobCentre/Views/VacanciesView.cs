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
    public partial class VacanciesView : Form
    {
        string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\App_Data\LaborExchange.mdf;Integrated Security=True;Connect Timeout=30";
        public VacanciesView()
        {
            InitializeComponent();
            string sqlString = "SELECT Distinct Scope FROM [dbo].[Vacancy];";
            using (SqlConnection sql = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable dt = new DataTable();
                adapter = new SqlDataAdapter(sqlString, sql);
                dt = new DataTable();
                adapter.Fill(dt);
                List<string> comboTextSource = new List<string>();
                foreach (DataRow row in dt.Rows)
                {
                    foreach (DataColumn column in dt.Columns)
                    {
                        comboTextSource.Add(row[column].ToString());
                    }
                }
                scopeComboBox.DataSource = comboTextSource;
            }           
        }

        private void scopeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string scope = scopeComboBox.Text;
            string sqlString = "SELECT  [Vacancy Id], [Work location], [Social package],[Beginning of work], [End of work]," +
                    "[Salary], [Features], [Possibility of working minors], [Position], [Type of ownership], [Company name] FROM [dbo].[Vacancy] " 
                    + String.Format("WHERE Scope = '{0}';", scope);
            using (SqlConnection sql = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable dt = new DataTable();
                adapter = new SqlDataAdapter(sqlString, sql);
                dt = new DataTable();
                adapter.Fill(dt);    
                vacanciesDataGridView.DataSource = dt;
            }
        }
    }
}
