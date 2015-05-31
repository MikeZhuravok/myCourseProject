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
    public partial class EmployeeFilterForm : Form
    {
        DataBaseForm dbform;
        public EmployeeFilterForm(DataBaseForm form)
        {
            InitializeComponent();
            dbform = form;
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            int from, to;
            //if (hasVacanciesCheckBox.Checked)
            //{
            //    dbform.sqlString = "SELECT * FROM [Employee], [Vacancy] WHERE [Employee].[Employee's ID] = [Vacancy].[Employee's ID] ";
            //}
            if (needsCheckBox.Checked)
            {
                dbform.sqlString = "SELECT * FROM [Employee] WHERE Needs IS NOT NULL";
            }
            if (int.TryParse(FromEmployeeIdTextBox.Text, out from) && int.TryParse(ToEmployeeIdTextBox.Text, out to))
            {
                dbform.sqlString += String.Format(" AND [Employee].[Employee's ID] BETWEEN {0} AND {1}", from, to);
            }
            DialogResult = DialogResult.OK;


        }
    }
}
