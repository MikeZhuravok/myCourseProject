using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobCentre.Views
{
    public partial class AddVacancy : Form
    {
        int selectedIndex;
        public AddVacancy(int SelIndex = -1)
        {
            selectedIndex = SelIndex;
            InitializeComponent();
        }

        private void AddVacancy_Load(object sender, EventArgs e)
        {
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
            if (work_locationTextBox.Text != "" && social_packageTextBox.Text != "" && scopeTextBox.Text != "" && beginning_of_workTextBox.Text != "" &&
                end_of_workTextBox.Text != "" && Decimal.TryParse(salaryTextBox.Text, out salary) && featuresTextBox.Text != "" &&
                possibility_of_working_minorsTextBox.Text != "" && positionTextBox.Text != "" && type_of_ownershipTextBox.Text != "" &&
                company_nameTextBox.Text != "" && Int32.TryParse(employer_s_IDTextBox.Text, out employersID))
            {
                if (selectedIndex == -1)
                {
                    this.vacancyTableAdapter.InsertVacancyQuery(work_locationTextBox.Text, social_packageTextBox.Text, scopeTextBox.Text, beginning_of_workTextBox.Text, end_of_workTextBox.Text, salary, featuresTextBox.Text,
                        possibility_of_working_minorsTextBox.Text, positionTextBox.Text, type_of_ownershipTextBox.Text, company_nameTextBox.Text, employersID);
                }
                else
                {
                    this.vacancyTableAdapter.UpdateVacancyQuery(work_locationTextBox.Text, social_packageTextBox.Text, scopeTextBox.Text, beginning_of_workTextBox.Text, end_of_workTextBox.Text, salary, featuresTextBox.Text,
                        possibility_of_working_minorsTextBox.Text, positionTextBox.Text, type_of_ownershipTextBox.Text, company_nameTextBox.Text, employersID, selectedIndex);
                }
                DialogResult = DialogResult.OK;
                this.vacancyTableAdapter.Update(this.laborExchangeDataSet);
            }
            else
            {
                MessageBox.Show(String.Format("Your data is incorrect"));
            }
        }
    }
}
