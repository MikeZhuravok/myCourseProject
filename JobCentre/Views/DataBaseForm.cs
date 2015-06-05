using JobCentre.LaborExchangeDataSetTableAdapters;
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
        string connectionString = Helper.connectionString;

        string primaryKey
        {
            get
            {
                if (tableName != "Vacancy request")
                    return MainDataGridView.Columns[0].Name;
                return "Vacancy request";
            }
        }
        public string sqlString = "";
        public DataTable filterDataTable;
        string tableName { get { return tabControl.SelectedTab.AccessibleDescription; } }
        List<string> headers;
        public DataBaseForm()
        {
            InitializeComponent();
            tabControl_SelectedIndexChanged(null, null);

            ToolTip tp = new ToolTip();
            tp.SetToolTip(EditButton, "If you choose more than 1 item, you will edit only first");
            tp.SetToolTip(DeleteButton, "If you choose more than 1 item, you will delete only first");
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
        }

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
            {
                return;
            }
            SureForm form = new SureForm();
            form.ShowDialog();
            if (form.DialogResult != DialogResult.Yes)
            {
                return;
            }

            using (SqlConnection sql = new SqlConnection(connectionString))
            {
                if (primaryKey != "Vacancy request")
                    sqlString = String.Format("DELETE FROM [dbo].[{0}] WHERE [{1}] = {2};", tableName, primaryKey, selectedIndex);
                else
                {
                    // no need any try-catch, because this table isn't linked to anyone
                    vacancy_requestTableAdapter.DeleteVacRequestQuery(selectedIndex, secondColumn, thirdColumn);
                    vacancy_requestTableAdapter.Update(this.laborExchangeDataSet);
                    tabControl_SelectedIndexChanged(null, null);
                    return;
                }
                SqlDataAdapter adapter = new SqlDataAdapter(sqlString, sql);
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
            //vacancy_requestTableAdapter.Update(this.laborExchangeDataSet);
            vacancyTableAdapter.Update(this.laborExchangeDataSet);
            tabControl_SelectedIndexChanged(null, null);
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
                    VacancyRequestFilterForm vrff = new VacancyRequestFilterForm(this);
                    vrff.ShowDialog();
                    if (vrff.DialogResult != DialogResult.OK)
                        return; 
                        break;
                case "Vacancy":
                    VacancyFilterForm vff = new VacancyFilterForm(this);
                    vff.ShowDialog();
                    if (vff.DialogResult != DialogResult.OK)
                        return;
                    break;
            }
            MainDataGridView.DataSource = filterDataTable;
        }

        private void Clear_button_Click(object sender, EventArgs e)
        {
            SearchTextBox.Text = "";
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

        public void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clear_button_Click(null, null);
            filterDataTable = null;
            headers = new List<string>();
            foreach (DataGridViewColumn i in MainDataGridView.Columns)
                headers.Add(i.Name);
            currentHeaderComboBox.DataSource = headers;

        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < MainDataGridView.Rows.Count - 1; i++)
                for (int j = 0; j < MainDataGridView.Columns.Count; j++)
                {
                    MainDataGridView.Rows[i].Cells[j].Selected = false;
                }
            if (SearchTextBox.Text == "")
            {
                return;
            }
            string searchText = SearchTextBox.Text;
            string currentHeader = currentHeaderComboBox.Text;
            int index = headers.IndexOf(currentHeader);
            for (int i = 0; i < MainDataGridView.Rows.Count - 1; i++)
            {
                if (MainDataGridView.Rows[i].Cells[index].Value.ToString().ToLower().Contains(searchText.ToLower()))
                    MainDataGridView.Rows[i].Cells[index].Selected = true;
            }
        }

        private void currentHeaderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < MainDataGridView.Rows.Count - 1; i++)
                for (int j = 0; j < MainDataGridView.Columns.Count; j++)
                {
                    MainDataGridView.Rows[i].Cells[j].Selected = false;
                }
        }

    }
}
