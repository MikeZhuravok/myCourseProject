namespace JobCentre.Views
{
    partial class AddVacancy
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
            System.Windows.Forms.Label work_locationLabel;
            System.Windows.Forms.Label social_packageLabel;
            System.Windows.Forms.Label scopeLabel;
            System.Windows.Forms.Label beginning_of_workLabel;
            System.Windows.Forms.Label end_of_workLabel;
            System.Windows.Forms.Label salaryLabel;
            System.Windows.Forms.Label featuresLabel;
            System.Windows.Forms.Label possibility_of_working_minorsLabel;
            System.Windows.Forms.Label positionLabel;
            System.Windows.Forms.Label type_of_ownershipLabel;
            System.Windows.Forms.Label company_nameLabel;
            System.Windows.Forms.Label employer_s_IDLabel;
            this.vacancyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.laborExchangeDataSet = new JobCentre.LaborExchangeDataSet();
            this.work_locationTextBox = new System.Windows.Forms.TextBox();
            this.social_packageTextBox = new System.Windows.Forms.TextBox();
            this.salaryTextBox = new System.Windows.Forms.TextBox();
            this.featuresTextBox = new System.Windows.Forms.TextBox();
            this.positionTextBox = new System.Windows.Forms.TextBox();
            this.company_nameTextBox = new System.Windows.Forms.TextBox();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.addOrEditButton = new System.Windows.Forms.Button();
            this.vacancyTableAdapter = new JobCentre.LaborExchangeDataSetTableAdapters.VacancyTableAdapter();
            this.tableAdapterManager = new JobCentre.LaborExchangeDataSetTableAdapters.TableAdapterManager();
            this.employerIdComboBox = new System.Windows.Forms.ComboBox();
            this.typeOfOwnershipComboBox = new System.Windows.Forms.ComboBox();
            this.scopeComboBox = new System.Windows.Forms.ComboBox();
            this.possibOfWorkingMinorsComboBox = new System.Windows.Forms.ComboBox();
            this.beginningOfWorkDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endOfWorkDateTimePicker = new System.Windows.Forms.DateTimePicker();
            work_locationLabel = new System.Windows.Forms.Label();
            social_packageLabel = new System.Windows.Forms.Label();
            scopeLabel = new System.Windows.Forms.Label();
            beginning_of_workLabel = new System.Windows.Forms.Label();
            end_of_workLabel = new System.Windows.Forms.Label();
            salaryLabel = new System.Windows.Forms.Label();
            featuresLabel = new System.Windows.Forms.Label();
            possibility_of_working_minorsLabel = new System.Windows.Forms.Label();
            positionLabel = new System.Windows.Forms.Label();
            type_of_ownershipLabel = new System.Windows.Forms.Label();
            company_nameLabel = new System.Windows.Forms.Label();
            employer_s_IDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vacancyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laborExchangeDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // work_locationLabel
            // 
            work_locationLabel.AutoSize = true;
            work_locationLabel.Location = new System.Drawing.Point(11, 35);
            work_locationLabel.Name = "work_locationLabel";
            work_locationLabel.Size = new System.Drawing.Size(76, 13);
            work_locationLabel.TabIndex = 3;
            work_locationLabel.Text = "Work location:";
            // 
            // social_packageLabel
            // 
            social_packageLabel.AutoSize = true;
            social_packageLabel.Location = new System.Drawing.Point(11, 61);
            social_packageLabel.Name = "social_packageLabel";
            social_packageLabel.Size = new System.Drawing.Size(84, 13);
            social_packageLabel.TabIndex = 5;
            social_packageLabel.Text = "Social package:";
            // 
            // scopeLabel
            // 
            scopeLabel.AutoSize = true;
            scopeLabel.Location = new System.Drawing.Point(11, 87);
            scopeLabel.Name = "scopeLabel";
            scopeLabel.Size = new System.Drawing.Size(41, 13);
            scopeLabel.TabIndex = 7;
            scopeLabel.Text = "Scope:";
            // 
            // beginning_of_workLabel
            // 
            beginning_of_workLabel.AutoSize = true;
            beginning_of_workLabel.Location = new System.Drawing.Point(11, 113);
            beginning_of_workLabel.Name = "beginning_of_workLabel";
            beginning_of_workLabel.Size = new System.Drawing.Size(95, 13);
            beginning_of_workLabel.TabIndex = 9;
            beginning_of_workLabel.Text = "Beginning of work:";
            // 
            // end_of_workLabel
            // 
            end_of_workLabel.AutoSize = true;
            end_of_workLabel.Location = new System.Drawing.Point(11, 139);
            end_of_workLabel.Name = "end_of_workLabel";
            end_of_workLabel.Size = new System.Drawing.Size(67, 13);
            end_of_workLabel.TabIndex = 11;
            end_of_workLabel.Text = "End of work:";
            // 
            // salaryLabel
            // 
            salaryLabel.AutoSize = true;
            salaryLabel.Location = new System.Drawing.Point(11, 165);
            salaryLabel.Name = "salaryLabel";
            salaryLabel.Size = new System.Drawing.Size(39, 13);
            salaryLabel.TabIndex = 13;
            salaryLabel.Text = "Salary:";
            // 
            // featuresLabel
            // 
            featuresLabel.AutoSize = true;
            featuresLabel.Location = new System.Drawing.Point(11, 191);
            featuresLabel.Name = "featuresLabel";
            featuresLabel.Size = new System.Drawing.Size(51, 13);
            featuresLabel.TabIndex = 15;
            featuresLabel.Text = "Features:";
            // 
            // possibility_of_working_minorsLabel
            // 
            possibility_of_working_minorsLabel.AutoSize = true;
            possibility_of_working_minorsLabel.Location = new System.Drawing.Point(11, 217);
            possibility_of_working_minorsLabel.Name = "possibility_of_working_minorsLabel";
            possibility_of_working_minorsLabel.Size = new System.Drawing.Size(140, 13);
            possibility_of_working_minorsLabel.TabIndex = 17;
            possibility_of_working_minorsLabel.Text = "Possibility of working minors:";
            // 
            // positionLabel
            // 
            positionLabel.AutoSize = true;
            positionLabel.Location = new System.Drawing.Point(11, 243);
            positionLabel.Name = "positionLabel";
            positionLabel.Size = new System.Drawing.Size(47, 13);
            positionLabel.TabIndex = 19;
            positionLabel.Text = "Position:";
            // 
            // type_of_ownershipLabel
            // 
            type_of_ownershipLabel.AutoSize = true;
            type_of_ownershipLabel.Location = new System.Drawing.Point(11, 269);
            type_of_ownershipLabel.Name = "type_of_ownershipLabel";
            type_of_ownershipLabel.Size = new System.Drawing.Size(97, 13);
            type_of_ownershipLabel.TabIndex = 21;
            type_of_ownershipLabel.Text = "Type of ownership:";
            // 
            // company_nameLabel
            // 
            company_nameLabel.AutoSize = true;
            company_nameLabel.Location = new System.Drawing.Point(11, 295);
            company_nameLabel.Name = "company_nameLabel";
            company_nameLabel.Size = new System.Drawing.Size(83, 13);
            company_nameLabel.TabIndex = 23;
            company_nameLabel.Text = "Company name:";
            // 
            // employer_s_IDLabel
            // 
            employer_s_IDLabel.AutoSize = true;
            employer_s_IDLabel.Location = new System.Drawing.Point(11, 321);
            employer_s_IDLabel.Name = "employer_s_IDLabel";
            employer_s_IDLabel.Size = new System.Drawing.Size(74, 13);
            employer_s_IDLabel.TabIndex = 25;
            employer_s_IDLabel.Text = "Employer\'s ID:";
            // 
            // vacancyBindingSource
            // 
            this.vacancyBindingSource.DataMember = "Vacancy";
            this.vacancyBindingSource.DataSource = this.laborExchangeDataSet;
            // 
            // laborExchangeDataSet
            // 
            this.laborExchangeDataSet.DataSetName = "LaborExchangeDataSet";
            this.laborExchangeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // work_locationTextBox
            // 
            this.work_locationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vacancyBindingSource, "Work location", true));
            this.work_locationTextBox.Location = new System.Drawing.Point(157, 32);
            this.work_locationTextBox.Name = "work_locationTextBox";
            this.work_locationTextBox.Size = new System.Drawing.Size(200, 20);
            this.work_locationTextBox.TabIndex = 4;
            // 
            // social_packageTextBox
            // 
            this.social_packageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vacancyBindingSource, "Social package", true));
            this.social_packageTextBox.Location = new System.Drawing.Point(157, 58);
            this.social_packageTextBox.Name = "social_packageTextBox";
            this.social_packageTextBox.Size = new System.Drawing.Size(200, 20);
            this.social_packageTextBox.TabIndex = 6;
            // 
            // salaryTextBox
            // 
            this.salaryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vacancyBindingSource, "Salary", true));
            this.salaryTextBox.Location = new System.Drawing.Point(157, 162);
            this.salaryTextBox.Name = "salaryTextBox";
            this.salaryTextBox.Size = new System.Drawing.Size(202, 20);
            this.salaryTextBox.TabIndex = 14;
            // 
            // featuresTextBox
            // 
            this.featuresTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vacancyBindingSource, "Features", true));
            this.featuresTextBox.Location = new System.Drawing.Point(157, 188);
            this.featuresTextBox.Name = "featuresTextBox";
            this.featuresTextBox.Size = new System.Drawing.Size(202, 20);
            this.featuresTextBox.TabIndex = 16;
            // 
            // positionTextBox
            // 
            this.positionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vacancyBindingSource, "Position", true));
            this.positionTextBox.Location = new System.Drawing.Point(157, 240);
            this.positionTextBox.Name = "positionTextBox";
            this.positionTextBox.Size = new System.Drawing.Size(202, 20);
            this.positionTextBox.TabIndex = 20;
            // 
            // company_nameTextBox
            // 
            this.company_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vacancyBindingSource, "Company name", true));
            this.company_nameTextBox.Location = new System.Drawing.Point(157, 292);
            this.company_nameTextBox.Name = "company_nameTextBox";
            this.company_nameTextBox.Size = new System.Drawing.Size(202, 20);
            this.company_nameTextBox.TabIndex = 24;
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Location = new System.Drawing.Point(121, 9);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(74, 13);
            this.HeaderLabel.TabIndex = 28;
            this.HeaderLabel.Text = "Add: Vacancy";
            // 
            // addOrEditButton
            // 
            this.addOrEditButton.Location = new System.Drawing.Point(120, 344);
            this.addOrEditButton.Name = "addOrEditButton";
            this.addOrEditButton.Size = new System.Drawing.Size(75, 23);
            this.addOrEditButton.TabIndex = 29;
            this.addOrEditButton.Text = "Add";
            this.addOrEditButton.UseVisualStyleBackColor = true;
            this.addOrEditButton.Click += new System.EventHandler(this.addOrEditButton_Click);
            // 
            // vacancyTableAdapter
            // 
            this.vacancyTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.EmployerTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = JobCentre.LaborExchangeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Vacancy_requestTableAdapter = null;
            this.tableAdapterManager.VacancyTableAdapter = this.vacancyTableAdapter;
            // 
            // employerIdComboBox
            // 
            this.employerIdComboBox.FormattingEnabled = true;
            this.employerIdComboBox.Location = new System.Drawing.Point(157, 321);
            this.employerIdComboBox.Name = "employerIdComboBox";
            this.employerIdComboBox.Size = new System.Drawing.Size(200, 21);
            this.employerIdComboBox.TabIndex = 30;
            // 
            // typeOfOwnershipComboBox
            // 
            this.typeOfOwnershipComboBox.FormattingEnabled = true;
            this.typeOfOwnershipComboBox.Items.AddRange(new object[] {
            "Physical",
            "Legal"});
            this.typeOfOwnershipComboBox.Location = new System.Drawing.Point(157, 265);
            this.typeOfOwnershipComboBox.Name = "typeOfOwnershipComboBox";
            this.typeOfOwnershipComboBox.Size = new System.Drawing.Size(200, 21);
            this.typeOfOwnershipComboBox.TabIndex = 31;
            // 
            // scopeComboBox
            // 
            this.scopeComboBox.FormattingEnabled = true;
            this.scopeComboBox.Location = new System.Drawing.Point(157, 83);
            this.scopeComboBox.Name = "scopeComboBox";
            this.scopeComboBox.Size = new System.Drawing.Size(200, 21);
            this.scopeComboBox.TabIndex = 32;
            // 
            // possibOfWorkingMinorsComboBox
            // 
            this.possibOfWorkingMinorsComboBox.FormattingEnabled = true;
            this.possibOfWorkingMinorsComboBox.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.possibOfWorkingMinorsComboBox.Location = new System.Drawing.Point(157, 213);
            this.possibOfWorkingMinorsComboBox.Name = "possibOfWorkingMinorsComboBox";
            this.possibOfWorkingMinorsComboBox.Size = new System.Drawing.Size(200, 21);
            this.possibOfWorkingMinorsComboBox.TabIndex = 33;
            // 
            // beginningOfWorkDateTimePicker
            // 
            this.beginningOfWorkDateTimePicker.CustomFormat = "HH:mm";
            this.beginningOfWorkDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.beginningOfWorkDateTimePicker.Location = new System.Drawing.Point(157, 110);
            this.beginningOfWorkDateTimePicker.Name = "beginningOfWorkDateTimePicker";
            this.beginningOfWorkDateTimePicker.ShowUpDown = true;
            this.beginningOfWorkDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.beginningOfWorkDateTimePicker.TabIndex = 34;
            // 
            // endOfWorkDateTimePicker
            // 
            this.endOfWorkDateTimePicker.CustomFormat = "HH:mm";
            this.endOfWorkDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endOfWorkDateTimePicker.Location = new System.Drawing.Point(157, 136);
            this.endOfWorkDateTimePicker.Name = "endOfWorkDateTimePicker";
            this.endOfWorkDateTimePicker.ShowUpDown = true;
            this.endOfWorkDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.endOfWorkDateTimePicker.TabIndex = 35;
            // 
            // AddVacancy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 379);
            this.Controls.Add(this.endOfWorkDateTimePicker);
            this.Controls.Add(this.beginningOfWorkDateTimePicker);
            this.Controls.Add(this.possibOfWorkingMinorsComboBox);
            this.Controls.Add(this.scopeComboBox);
            this.Controls.Add(this.typeOfOwnershipComboBox);
            this.Controls.Add(this.employerIdComboBox);
            this.Controls.Add(this.addOrEditButton);
            this.Controls.Add(this.HeaderLabel);
            this.Controls.Add(work_locationLabel);
            this.Controls.Add(this.work_locationTextBox);
            this.Controls.Add(social_packageLabel);
            this.Controls.Add(this.social_packageTextBox);
            this.Controls.Add(scopeLabel);
            this.Controls.Add(beginning_of_workLabel);
            this.Controls.Add(end_of_workLabel);
            this.Controls.Add(salaryLabel);
            this.Controls.Add(this.salaryTextBox);
            this.Controls.Add(featuresLabel);
            this.Controls.Add(this.featuresTextBox);
            this.Controls.Add(possibility_of_working_minorsLabel);
            this.Controls.Add(positionLabel);
            this.Controls.Add(this.positionTextBox);
            this.Controls.Add(type_of_ownershipLabel);
            this.Controls.Add(company_nameLabel);
            this.Controls.Add(this.company_nameTextBox);
            this.Controls.Add(employer_s_IDLabel);
            this.Name = "AddVacancy";
            this.Text = "AddVacancy";
            ((System.ComponentModel.ISupportInitialize)(this.vacancyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laborExchangeDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LaborExchangeDataSet laborExchangeDataSet;
        private System.Windows.Forms.BindingSource vacancyBindingSource;
        private LaborExchangeDataSetTableAdapters.VacancyTableAdapter vacancyTableAdapter;
        private LaborExchangeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox work_locationTextBox;
        private System.Windows.Forms.TextBox social_packageTextBox;
        private System.Windows.Forms.TextBox salaryTextBox;
        private System.Windows.Forms.TextBox featuresTextBox;
        private System.Windows.Forms.TextBox positionTextBox;
        private System.Windows.Forms.TextBox company_nameTextBox;
        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Button addOrEditButton;
        private System.Windows.Forms.ComboBox employerIdComboBox;
        private System.Windows.Forms.ComboBox typeOfOwnershipComboBox;
        private System.Windows.Forms.ComboBox scopeComboBox;
        private System.Windows.Forms.ComboBox possibOfWorkingMinorsComboBox;
        private System.Windows.Forms.DateTimePicker beginningOfWorkDateTimePicker;
        private System.Windows.Forms.DateTimePicker endOfWorkDateTimePicker;

    }
}