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
    public partial class EmployerFilterForm : Form
    {
        DataBaseForm dbform;
        public EmployerFilterForm(DataBaseForm form)
        {
            InitializeComponent();
            dbform = form;
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            int from, to;
            string forAnd = "";
            if (hasVacanciesCheckBox.Checked)
            {
                dbform.sqlString = "SELECT DISTINCT [Employer].* FROM [Employer], [Vacancy] WHERE [Employer].[Employer's ID] = [Vacancy].[Employer's ID] ";
                forAnd = " AND";
            }
            else
                dbform.sqlString = "SELECT * FROM [Employer] WHERE ";
            if (int.TryParse(FromEmployerIdTextBox.Text, out from) && int.TryParse(ToEmployerIdTextBox.Text, out to))
                dbform.sqlString += String.Format(" {0} [Employer].[Employer's ID] BETWEEN {1} AND {2}", forAnd, from, to);

            DialogResult = DialogResult.OK;
        }
    }
}
