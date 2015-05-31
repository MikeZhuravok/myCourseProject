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
    public partial class AddEmployer : Form
    {
        int selectedIndex;
        public AddEmployer(int selIndex = -1)
        {
            InitializeComponent();
            selectedIndex = selIndex;
        }

        private void AddEmployer_Load(object sender, EventArgs e)
        {
            if (selectedIndex == -1)
                return;
            this.employerTableAdapter.Fill(this.laborExchangeDataSet.Employer);
            HeaderLabel.Text = "Edit: Employee";
            addOrEditButton.Text = "Edit";

            this.employerTableAdapter.FillBy(this.laborExchangeDataSet.Employer, selectedIndex);
        }

        private void addOrEditButton_Click(object sender, EventArgs e)
        {
            decimal indTaxNumber;
            if (full_nameTextBox.Text != "" && pasport_numberTextBox.Text != "" && phone_numberTextBox.Text != "" && bank_detailsTextBox.Text != ""
                && decimal.TryParse(individual_tax_numberTextBox.Text, out indTaxNumber) && main_property_typeTextBox.Text != "" && economical_activityTextBox.Text != "")
            {
                if (selectedIndex == -1)
                {
                    employerTableAdapter.InsertEmployerQuery(full_nameTextBox.Text, pasport_numberTextBox.Text, phone_numberTextBox.Text, bank_detailsTextBox.Text,
                        indTaxNumber, main_property_typeTextBox.Text, economical_activityTextBox.Text);
                }
                else
                {
                    employerTableAdapter.UpdateEmployerQuery(full_nameTextBox.Text, pasport_numberTextBox.Text, phone_numberTextBox.Text, bank_detailsTextBox.Text,
                                           indTaxNumber, main_property_typeTextBox.Text, economical_activityTextBox.Text, selectedIndex);
                }
            }
        }
    }
}
