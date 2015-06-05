namespace JobCentre.Views
{
    partial class DataBaseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TabPage EmployeeTabPage;
            this.MainDataGridView = new System.Windows.Forms.DataGridView();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.laborExchangeDataSet = new JobCentre.LaborExchangeDataSet();
            this.Clear_button = new System.Windows.Forms.Button();
            this.FilterButton = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.EmployerTabPage = new System.Windows.Forms.TabPage();
            this.VacancyTabPage = new System.Windows.Forms.TabPage();
            this.Vacancy_requestsTabPage = new System.Windows.Forms.TabPage();
            this.employerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vacancyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vacancyRequestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new JobCentre.LaborExchangeDataSetTableAdapters.EmployeeTableAdapter();
            this.employerTableAdapter = new JobCentre.LaborExchangeDataSetTableAdapters.EmployerTableAdapter();
            this.vacancyTableAdapter = new JobCentre.LaborExchangeDataSetTableAdapters.VacancyTableAdapter();
            this.vacancy_requestTableAdapter = new JobCentre.LaborExchangeDataSetTableAdapters.Vacancy_requestTableAdapter();
            this.employeeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.currentHeaderComboBox = new System.Windows.Forms.ComboBox();
            EmployeeTabPage = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.MainDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laborExchangeDataSet)).BeginInit();
            this.tabControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacancyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacancyRequestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployeeTabPage
            // 
            EmployeeTabPage.AccessibleDescription = "Employee";
            EmployeeTabPage.Location = new System.Drawing.Point(4, 22);
            EmployeeTabPage.Name = "EmployeeTabPage";
            EmployeeTabPage.Padding = new System.Windows.Forms.Padding(3);
            EmployeeTabPage.Size = new System.Drawing.Size(278, 6);
            EmployeeTabPage.TabIndex = 0;
            EmployeeTabPage.Text = "Employees";
            EmployeeTabPage.UseVisualStyleBackColor = true;
            // 
            // MainDataGridView
            // 
            this.MainDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MainDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.MainDataGridView.Location = new System.Drawing.Point(12, 34);
            this.MainDataGridView.Name = "MainDataGridView";
            this.MainDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MainDataGridView.Size = new System.Drawing.Size(789, 472);
            this.MainDataGridView.TabIndex = 0;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.laborExchangeDataSet;
            // 
            // laborExchangeDataSet
            // 
            this.laborExchangeDataSet.DataSetName = "LaborExchangeDataSet";
            this.laborExchangeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Clear_button
            // 
            this.Clear_button.Location = new System.Drawing.Point(33, 515);
            this.Clear_button.Name = "Clear_button";
            this.Clear_button.Size = new System.Drawing.Size(75, 23);
            this.Clear_button.TabIndex = 9;
            this.Clear_button.Text = "Clear";
            this.Clear_button.UseVisualStyleBackColor = true;
            this.Clear_button.Click += new System.EventHandler(this.Clear_button_Click);
            // 
            // FilterButton
            // 
            this.FilterButton.Location = new System.Drawing.Point(708, 512);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(75, 23);
            this.FilterButton.TabIndex = 8;
            this.FilterButton.Text = "Filter";
            this.FilterButton.UseVisualStyleBackColor = true;
            this.FilterButton.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(369, 515);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(152, 20);
            this.SearchTextBox.TabIndex = 7;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Location = new System.Drawing.Point(306, 517);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(44, 13);
            this.SearchLabel.TabIndex = 6;
            this.SearchLabel.Text = "Search:";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(225, 515);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(73, 23);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(144, 515);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 23);
            this.EditButton.TabIndex = 1;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(EmployeeTabPage);
            this.tabControl.Controls.Add(this.EmployerTabPage);
            this.tabControl.Controls.Add(this.VacancyTabPage);
            this.tabControl.Controls.Add(this.Vacancy_requestsTabPage);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(286, 32);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // EmployerTabPage
            // 
            this.EmployerTabPage.AccessibleDescription = "Employer";
            this.EmployerTabPage.Location = new System.Drawing.Point(4, 22);
            this.EmployerTabPage.Name = "EmployerTabPage";
            this.EmployerTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.EmployerTabPage.Size = new System.Drawing.Size(278, 6);
            this.EmployerTabPage.TabIndex = 1;
            this.EmployerTabPage.Text = "Employers";
            this.EmployerTabPage.UseVisualStyleBackColor = true;
            // 
            // VacancyTabPage
            // 
            this.VacancyTabPage.AccessibleDescription = "Vacancy";
            this.VacancyTabPage.Location = new System.Drawing.Point(4, 22);
            this.VacancyTabPage.Name = "VacancyTabPage";
            this.VacancyTabPage.Size = new System.Drawing.Size(278, 6);
            this.VacancyTabPage.TabIndex = 2;
            this.VacancyTabPage.Text = "Vacancys";
            this.VacancyTabPage.UseVisualStyleBackColor = true;
            // 
            // Vacancy_requestsTabPage
            // 
            this.Vacancy_requestsTabPage.AccessibleDescription = "Vacancy request";
            this.Vacancy_requestsTabPage.Location = new System.Drawing.Point(4, 22);
            this.Vacancy_requestsTabPage.Name = "Vacancy_requestsTabPage";
            this.Vacancy_requestsTabPage.Size = new System.Drawing.Size(278, 6);
            this.Vacancy_requestsTabPage.TabIndex = 3;
            this.Vacancy_requestsTabPage.Text = "Vacancy requests";
            this.Vacancy_requestsTabPage.UseVisualStyleBackColor = true;
            // 
            // employerBindingSource
            // 
            this.employerBindingSource.DataMember = "Employer";
            this.employerBindingSource.DataSource = this.laborExchangeDataSet;
            // 
            // vacancyBindingSource
            // 
            this.vacancyBindingSource.DataMember = "Vacancy";
            this.vacancyBindingSource.DataSource = this.laborExchangeDataSet;
            // 
            // vacancyRequestBindingSource
            // 
            this.vacancyRequestBindingSource.DataMember = "Vacancy request";
            this.vacancyRequestBindingSource.DataSource = this.laborExchangeDataSet;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // employerTableAdapter
            // 
            this.employerTableAdapter.ClearBeforeFill = true;
            // 
            // vacancyTableAdapter
            // 
            this.vacancyTableAdapter.ClearBeforeFill = true;
            // 
            // vacancy_requestTableAdapter
            // 
            this.vacancy_requestTableAdapter.ClearBeforeFill = true;
            // 
            // employeeBindingSource1
            // 
            this.employeeBindingSource1.DataMember = "Employee";
            this.employeeBindingSource1.DataSource = this.laborExchangeDataSet;
            // 
            // currentHeaderComboBox
            // 
            this.currentHeaderComboBox.FormattingEnabled = true;
            this.currentHeaderComboBox.Location = new System.Drawing.Point(527, 514);
            this.currentHeaderComboBox.Name = "currentHeaderComboBox";
            this.currentHeaderComboBox.Size = new System.Drawing.Size(175, 21);
            this.currentHeaderComboBox.TabIndex = 10;
            this.currentHeaderComboBox.SelectedIndexChanged += new System.EventHandler(this.currentHeaderComboBox_SelectedIndexChanged);
            // 
            // DataBaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 542);
            this.Controls.Add(this.currentHeaderComboBox);
            this.Controls.Add(this.MainDataGridView);
            this.Controls.Add(this.Clear_button);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.FilterButton);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.DeleteButton);
            this.Name = "DataBaseForm";
            this.Text = "DataBaseForm";
            this.Load += new System.EventHandler(this.DataBaseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MainDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laborExchangeDataSet)).EndInit();
            this.tabControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacancyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacancyRequestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage EmployerTabPage;
        private System.Windows.Forms.DataGridView MainDataGridView;
        private System.Windows.Forms.TabPage VacancyTabPage;
        private System.Windows.Forms.TabPage Vacancy_requestsTabPage;
        private LaborExchangeDataSet laborExchangeDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private LaborExchangeDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.BindingSource employerBindingSource;
        private LaborExchangeDataSetTableAdapters.EmployerTableAdapter employerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn passportNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vacancyBindingSource;
        private LaborExchangeDataSetTableAdapters.VacancyTableAdapter vacancyTableAdapter;
        private System.Windows.Forms.BindingSource vacancyRequestBindingSource;
        private LaborExchangeDataSetTableAdapters.Vacancy_requestTableAdapter vacancy_requestTableAdapter;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.BindingSource employeeBindingSource1;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.Button FilterButton;
        private System.Windows.Forms.Button Clear_button;
        private System.Windows.Forms.ComboBox currentHeaderComboBox;

    }
}