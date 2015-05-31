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
    public partial class AddVacancy : Form
    {        
        string connectionString = Helper.connectionString;

        int selectedIndex;
        public AddVacancy(int SelIndex = -1)
        {
            selectedIndex = SelIndex;
            InitializeComponent();

             // ComboBox filling
            string sqlString;
            using (SqlConnection sql = new SqlConnection(connectionString))
            {
                sqlString = "SELECT [Employer's ID], [Full name] Profession FROM [dbo].[Employer]";
                SqlDataAdapter adapter = new SqlDataAdapter(sqlString, sql);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt != null)
                {
                    employerIdComboBox.DataSource = Helper.DataTableToStringList(dt, false);
                }

                sqlString = "SELECT DISTINCT Scope Profession FROM [dbo].[Vacancy]";
                adapter = new SqlDataAdapter(sqlString, sql);
                dt = new DataTable();
                adapter.Fill(dt);
                if (dt != null)
                {
                    scopeComboBox.DataSource = Helper.DataTableToStringList(dt);
                }
            }

            if (selectedIndex == -1)
                return;
            this.vacancyTableAdapter.Fill(this.laborExchangeDataSet.Vacancy);
            HeaderLabel.Text = "Edit: Vacancy";
            addOrEditButton.Text = "Edit";

            this.vacancyTableAdapter.FillBy(this.laborExchangeDataSet.Vacancy, selectedIndex);
        }


        private void addOrEditButton_Click(object sender, EventArgs e)
        {
            decimal salary;
            int employersID;
            if (work_locationTextBox.Text != "" && social_packageTextBox.Text != "" && scopeComboBox.Text != "" && beginning_of_workTextBox.Text != "" &&
                end_of_workTextBox.Text != "" && Decimal.TryParse(salaryTextBox.Text, out salary) && featuresTextBox.Text != "" &&
                possibOfWorkingMinorsComboBox.Text != "" && positionTextBox.Text != "" && typeOfOwnershipComboBox.Text != "" &&
                company_nameTextBox.Text != "" && Helper.TryParse(employerIdComboBox.Text, out employersID))
            {
                if (selectedIndex == -1)
                {
                    this.vacancyTableAdapter.InsertVacancyQuery(work_locationTextBox.Text, social_packageTextBox.Text, scopeComboBox.Text, beginning_of_workTextBox.Text, end_of_workTextBox.Text, salary, featuresTextBox.Text,
                        possibOfWorkingMinorsComboBox.Text, positionTextBox.Text, typeOfOwnershipComboBox.Text, company_nameTextBox.Text, employersID);
                }
                else
                {
                    this.vacancyTableAdapter.UpdateVacancyQuery(work_locationTextBox.Text, social_packageTextBox.Text, scopeComboBox.Text, beginning_of_workTextBox.Text, end_of_workTextBox.Text, salary, featuresTextBox.Text,
                        possibOfWorkingMinorsComboBox.Text, positionTextBox.Text, typeOfOwnershipComboBox.Text, company_nameTextBox.Text, employersID, selectedIndex);
                }
                this.vacancyTableAdapter.Update(this.laborExchangeDataSet);
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show(String.Format("Your data is incorrect"));
            }
        }
    }
}
