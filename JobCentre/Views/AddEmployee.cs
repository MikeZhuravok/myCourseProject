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
    public partial class AddEmployee : Form
    {
        string connectionString = Helper.connectionString;

        int selectedIndex;
        public AddEmployee(int selIndex = -1)
        {
            InitializeComponent();
            selectedIndex = selIndex;

            // ComboBox filling
            string sqlString;
            using (SqlConnection sql = new SqlConnection(connectionString))
            {
                sqlString = "SELECT DISTINCT Profession FROM [dbo].[Employee]";
                SqlDataAdapter adapter = new SqlDataAdapter(sqlString, sql);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt != null)
                {
                    professionsComboBox.DataSource = Helper.DataTableToStringList(dt);
                }
                sqlString = "SELECT DISTINCT [Work mode] FROM [dbo].[Employee]";
                adapter = new SqlDataAdapter(sqlString, sql);
                dt = new DataTable();
                adapter.Fill(dt);
                if (dt != null)
                {
                    workModeComboBox.DataSource = Helper.DataTableToStringList(dt);
                } 
                sqlString = "SELECT DISTINCT [Work nature] FROM [dbo].[Employee]";
                adapter = new SqlDataAdapter(sqlString, sql);
                dt = new DataTable();
                adapter.Fill(dt);
                if (dt != null)
                {
                    workNatureComboBox.DataSource = Helper.DataTableToStringList(dt);
                }
            }



            if (selectedIndex == -1)
                return;
            this.employeeTableAdapter.Fill(this.laborExchangeDataSet.Employee);
            HeaderLabel.Text = "Edit: Employee";
            AddButton.Text = "Edit";

            this.employeeTableAdapter.FillBy(this.laborExchangeDataSet.Employee, selectedIndex);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            decimal ros;
            decimal idenCode;
            if (full_nameTextBox.Text != "" && professionsComboBox.Text != "" && decimal.TryParse(record_of_serviceTextBox.Text, out ros)
                    && decimal.TryParse(identification_codeTextBox.Text, out idenCode) && educationTextBox.Text != "" && pasport_numberTextBox.Text != ""
                    && special_skillsTextBox.Text != "" && locationTextBox.Text != "" && needsTextBox.Text != "" && workModeComboBox.Text != ""
                    && workNatureComboBox.Text != "" && phone_numberTextBox.Text != "")
            {
                if (selectedIndex == -1)
                {
                    employeeTableAdapter.InsertEmployeeQuery(full_nameTextBox.Text, professionsComboBox.Text, ros,
                    pasport_numberTextBox.Text, special_skillsTextBox.Text, locationTextBox.Text, idenCode, educationTextBox.Text,
                    needsTextBox.Text, workModeComboBox.Text, workNatureComboBox.Text, phone_numberTextBox.Text);
                    MessageBox.Show(String.Format("Element was just added."));
                }
                else
                {
                    employeeTableAdapter.UpdateEmployeeQuery(full_nameTextBox.Text, professionsComboBox.Text, ros,
                    pasport_numberTextBox.Text, special_skillsTextBox.Text, locationTextBox.Text, idenCode, educationTextBox.Text,
                    needsTextBox.Text, workModeComboBox.Text, workNatureComboBox.Text, phone_numberTextBox.Text, selectedIndex);
                    MessageBox.Show(String.Format("Element #{0} was just updated.", selectedIndex));
                }
                employeeTableAdapter.Update(this.laborExchangeDataSet);
                DialogResult = DialogResult.OK;

            }
            else
            {
                MessageBox.Show(String.Format("Your data is incorrect"));
            }
        }
    }
}
