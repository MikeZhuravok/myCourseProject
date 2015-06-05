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
    public partial class VacancyRequestFilterForm : Form
    {
        string connectionString = Helper.connectionString;
        DataBaseForm form;
        public VacancyRequestFilterForm(DataBaseForm dbForm)
        {
            InitializeComponent();
            form = dbForm;
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            string sqlString;
            DateTime from = fromDateTimePicker.Value;
            bool positive = isPositiveResultCheckBox.Checked;
            string forResult = "";
            if (positive)
                forResult = " AND Result = 'Positive'";

            string fromTime = String.Format("{0}:{1}", from.Hour, from.Minute);

            sqlString = String.Format("SELECT * FROM [Vacancy Request] WHERE [Interview date] > '{0}'{1};", fromTime, forResult);

            using (SqlConnection sql = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(sqlString, sql);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                form.filterDataTable = dt;
            }
            DialogResult = DialogResult.OK;

        }
    }
}
