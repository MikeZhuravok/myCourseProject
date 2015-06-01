﻿using JobCentre.LaborExchangeDataSetTableAdapters;
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
    public partial class DataBaseForm : Form
    {
        string primaryKey;
        string connectionString = Helper.connectionString;
        public string temp; // change in future

        public string sqlString = "";
        public DataTable filterDataTable;
        string tableName { get { return tabControl.SelectedTab.AccessibleDescription; } }

        public DataBaseForm()
        {
            InitializeComponent();
            tabControl_SelectedIndexChanged(null, null);
        }

        private void DataBaseForm_Load(object sender, EventArgs e)
        {
            this.vacancy_requestTableAdapter.Fill(this.laborExchangeDataSet.Vacancy_request);
            this.vacancyTableAdapter.Fill(this.laborExchangeDataSet.Vacancy);
            this.employerTableAdapter.Fill(this.laborExchangeDataSet.Employer);
            this.employeeTableAdapter.Fill(this.laborExchangeDataSet.Employee);
        }

        int selectedIndex
        {
            get
            {
                int rowIndex = MainDataGridView.CurrentRow.Index;
                return (int)MainDataGridView.Rows[rowIndex].Cells[0].Value;
            }
        } //  с индексами надо разобраться это не все

        int secondColumn
        {
            get
            {
                int rowIndex = MainDataGridView.CurrentRow.Index;
                return (int)MainDataGridView.Rows[rowIndex].Cells[1].Value;
            }
        }
        DateTime thirdColumn
        {
            get
            {
                int rowIndex = MainDataGridView.CurrentRow.Index;
                return (DateTime)MainDataGridView.Rows[rowIndex].Cells[2].Value;
            }
        }
        private void EditButton_Click(object sender, EventArgs e)
        {
            if (MainDataGridView.CurrentRow == null)
            {
                MessageBox.Show("Choose some");
                return;
            }
            switch (tableName) // селектед айди неверный
            {
                case "Employer":
                    AddEmployer ar = new AddEmployer(selectedIndex);
                    ar.ShowDialog();
                    this.employerTableAdapter.Fill(this.laborExchangeDataSet.Employer);
                    MainDataGridView.DataSource = employerTableAdapter.GetData();
                    break;
                case "Employee":
                    AddEmployee ae = new AddEmployee(selectedIndex);
                    ae.ShowDialog();
                    this.employeeTableAdapter.Fill(this.laborExchangeDataSet.Employee);
                    MainDataGridView.DataSource = employeeTableAdapter.GetData();
                    break;
                case "Vacancy request":
                    int vacancyId = selectedIndex;
                    int employerId = secondColumn;
                    DateTime dt = thirdColumn;
                    EditVacancyRequest avr = new EditVacancyRequest(vacancyId, employerId, dt);
                    avr.ShowDialog();
                    this.vacancy_requestTableAdapter.Fill(this.laborExchangeDataSet.Vacancy_request);
                    MainDataGridView.DataSource = vacancy_requestTableAdapter.GetData();
                    break;
                case "Vacancy":
                    AddVacancy av = new AddVacancy(selectedIndex);
                    av.ShowDialog();
                    this.vacancyTableAdapter.Fill(this.laborExchangeDataSet.Vacancy);
                    MainDataGridView.DataSource = vacancyTableAdapter.GetData();
                    break;
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (selectedIndex == -1)
                return;
            using (SqlConnection sql = new SqlConnection(connectionString))
            {
                string sqlCopy = (string)sqlString.Clone();
                sqlCopy = String.Format("DELETE FROM [dbo].[{0}] WHERE [{1}] = {2};", tableName, primaryKey, selectedIndex);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCopy, sql);
                DataTable dt = new DataTable();
                try
                {
                    adapter.Fill(dt);
                }
                catch
                {
                    MessageBox.Show("You can't delete element because of integrity of DB");
                }
            }
            employeeTableAdapter.Update(this.laborExchangeDataSet);
            employerTableAdapter.Update(this.laborExchangeDataSet);
            vacancy_requestTableAdapter.Update(this.laborExchangeDataSet);
            vacancyTableAdapter.Update(this.laborExchangeDataSet);
            tabControl_SelectedIndexChanged(null, null);
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (SearchTextBox.Text == "")
            {
                for (int i = 0; i < MainDataGridView.Rows.Count - 1; i++) // последняя строка пустая для добавления
                    for (int j = 0; j < MainDataGridView.Columns.Count; j++)
                    {
                        MainDataGridView.Rows[i].Cells[j].Selected = false;
                    }
                return;
            }
            string searchText = SearchTextBox.Text;
            for (int i = 0; i < MainDataGridView.Rows.Count - 1; i++)
                for (int j = 0; j < MainDataGridView.Columns.Count; j++)
                {
                    MainDataGridView.Rows[i].Cells[j].Selected = false;
                }
            for (int i = 0; i < MainDataGridView.Rows.Count - 1; i++)
                for (int j = 0; j < MainDataGridView.Columns.Count; j++)
                {
                    if (MainDataGridView.Rows[i].Cells[j].Value.ToString().ToLower().Contains(searchText.ToLower()))
                        MainDataGridView.Rows[i].Cells[j].Selected = true;
                }
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            switch (tableName)
            {
                case "Employer":
                    EmployerFilterForm form = new EmployerFilterForm(this);
                    form.ShowDialog();
                    if (form.DialogResult != DialogResult.OK)
                        return;
                    break;
                case "Employee":
                    EmployeeFilterForm eff = new EmployeeFilterForm(this);
                    eff.ShowDialog();
                    if (eff.DialogResult != DialogResult.OK)
                        return;
                    break;
                case "Vacancy request":
                    VacancyFilterForm vff = new VacancyFilterForm();
                    vff.ShowDialog();
                    if (vff.DialogResult != DialogResult.OK)
                        return;
                    break;
                case "Vacancy":
                    break;
            }
            MainDataGridView.DataSource = filterDataTable;
        }

        private void Clear_button_Click(object sender, EventArgs e)
        {
            SearchTextBox.Text = "";
            temp = "";
            sqlString = "";
            using (SqlConnection sql = new SqlConnection(connectionString))
            {
                string sqltemp = String.Format("SELECT * FROM [dbo].[{0}]", tableName);
                SqlDataAdapter adapter = new SqlDataAdapter(sqltemp, sql);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                MainDataGridView.DataSource = dt;
            }
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tableName) // селектед айди неверный
            {
                case "Employer":
                    //FindListComboBox.DataSource = new List<string> { "Employer's ID", "Full name", "Pasport number", "Phone number", "Bank details", 
                    //"Individual tax number", "Main property type", "Economical activity"};
                    primaryKey = "Employer's ID";
                    break;
                case "Employee":
                    //FindListComboBox.DataSource = new List<string> { "Employee's ID", "Full name", "Profession", 
                    //    "Record of service", "Special skills", "Location", "Identificaton code", 
                    //"Education", "Needs", "Work mode", "Work nature"};
                    primaryKey = "Employee's ID";
                    break;
                case "Vacancy request":
                    //FindListComboBox.DataSource = new List<string> { "Vacancy ID", "Employee's ID", "Submission date", "Interview date", "Result" };
                    primaryKey = "Vacancy ID";
                    break;
                case "Vacancy":
                    //FindListComboBox.DataSource = new List<string> { "Vacancy Id", "Work location", "Social package","Scope",  "Beginning of work", "End of work",
                    //"Salary", "Features", "Possibility of working minors", "Position", "Type of ownership", "Company name"};
                    primaryKey = "Vacancy Id";
                    break;
            }
            Clear_button_Click(null, null);
            filterDataTable = null;
        }
    }
}
