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
    public partial class AddEmployee : Form
    {
        int selectedIndex;
        public AddEmployee(int selIndex = -1)
        {
            InitializeComponent();
            selectedIndex = selIndex;
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {
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
            if (full_nameTextBox.Text != "" && professionTextBox.Text != "" && decimal.TryParse(record_of_serviceTextBox.Text, out ros)
                    && decimal.TryParse(identification_codeTextBox.Text, out idenCode) && educationTextBox.Text != "" && pasport_numberTextBox.Text != ""
                    && special_skillsTextBox.Text != "" && locationTextBox.Text != "" && needsTextBox.Text != "" && work_modeTextBox.Text != ""
                    && work_natureTextBox.Text != "" && phone_numberTextBox.Text != "")
            {
                if (selectedIndex == -1)
                {
                    employeeTableAdapter.InsertEmployeeQuery(full_nameTextBox.Text, professionTextBox.Text, ros,
                    pasport_numberTextBox.Text, special_skillsTextBox.Text, locationTextBox.Text, idenCode, educationTextBox.Text,
                    needsTextBox.Text, work_modeTextBox.Text, work_natureTextBox.Text, phone_numberTextBox.Text);
                    MessageBox.Show(String.Format("Element was just added."));                    
                }
                else
                {
                    employeeTableAdapter.UpdateEmployeeQuery(full_nameTextBox.Text, professionTextBox.Text, ros,
                    pasport_numberTextBox.Text, special_skillsTextBox.Text, locationTextBox.Text, idenCode, educationTextBox.Text,
                    needsTextBox.Text, work_modeTextBox.Text, work_natureTextBox.Text, phone_numberTextBox.Text, selectedIndex);
                    MessageBox.Show(String.Format("Element #{0} was just updated.", selectedIndex));
                }
                DialogResult = DialogResult.OK;
                employeeTableAdapter.Update(this.laborExchangeDataSet);
            }
            else
            {
                MessageBox.Show(String.Format("Your data is incorrect"));
            }
        }
    }
}
