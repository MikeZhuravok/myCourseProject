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
    public partial class Sql_query_editor : Form
    {
        string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\App_Data\LaborExchange.mdf;Integrated Security=True;Connect Timeout=30";
        public Sql_query_editor()
        {
            InitializeComponent();
        }

        private void doSQLButton_Click(object sender, EventArgs e)
        {
            //if (sqlRichTextBox.Text == "")
            //    return;
            using (SqlConnection sql = new SqlConnection(connectionString))
            {

                string sqlString = sqlRichTextBox.Text;
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable dt = new DataTable();
                adapter = new SqlDataAdapter(sqlString, sql);
                adapter.Fill(dt);
                sqlQueryDataGridView.DataSource = dt;
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            sqlRichTextBox.Text = "";
            sqlQueryDataGridView.DataSource = null;
        }
    }
}

