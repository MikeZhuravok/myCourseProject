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
    public partial class EmployeeFilterForm : Form
    {
        DataBaseForm dbform;
        string connectionString = Helper.connectionString;
        public EmployeeFilterForm(DataBaseForm form)
        {
            InitializeComponent();
            dbform = form;
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            string sqlString = "";
            int from, to;
            if (int.TryParse(FromEmployeeIdTextBox.Text, out from) && int.TryParse(ToEmployeeIdTextBox.Text, out to))
            {
                sqlString = String.Format("SELECT * FROM [Employee] WHERE [Employee].[Employee's ID] BETWEEN {0} AND {1}", from, to);
            }
            if (needsCheckBox.Checked)
            {
                if (sqlString != "")
                {
                    sqlString += "AND Needs IS NOT NULL";
                }
                else {
                    sqlString = "SELECT * FROM [Employee] WHERE Needs IS NOT NULL";
                }
            }
            using (SqlConnection sql = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(sqlString, sql);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dbform.filterDataTable = dt;
            }    
            DialogResult = DialogResult.OK;


        }
    }
}
