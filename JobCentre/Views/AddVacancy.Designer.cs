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
            System.Windows.Forms.Label vacancy_IdLabel;
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
            this.vacancy_IdTextBox = new System.Windows.Forms.TextBox();
            this.work_locationTextBox = new System.Windows.Forms.TextBox();
            this.social_packageTextBox = new System.Windows.Forms.TextBox();
            this.scopeTextBox = new System.Windows.Forms.TextBox();
            this.beginning_of_workTextBox = new System.Windows.Forms.TextBox();
            this.end_of_workTextBox = new System.Windows.Forms.TextBox();
            this.salaryTextBox = new System.Windows.Forms.TextBox();
            this.featuresTextBox = new System.Windows.Forms.TextBox();
            this.possibility_of_working_minorsTextBox = new System.Windows.Forms.TextBox();
            this.positionTextBox = new System.Windows.Forms.TextBox();
            this.type_of_ownershipTextBox = new System.Windows.Forms.TextBox();
            this.company_nameTextBox = new System.Windows.Forms.TextBox();
            this.employer_s_IDTextBox = new System.Windows.Forms.TextBox();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.addOrEditButton = new System.Windows.Forms.Button();
            this.vacancyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.laborExchangeDataSet = new JobCentre.LaborExchangeDataSet();
            this.vacancyTableAdapter = new JobCentre.LaborExchangeDataSetTableAdapters.VacancyTableAdapter();
            this.tableAdapterManager = new JobCentre.LaborExchangeDataSetTableAdapters.TableAdapterManager();
            vacancy_IdLabel = new System.Windows.Forms.Label();
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
            // vacancy_IdLabel
            // 
            vacancy_IdLabel.AutoSize = true;
            vacancy_IdLabel.Location = new System.Drawing.Point(18, 34);
            vacancy_IdLabel.Name = "vacancy_IdLabel";
            vacancy_IdLabel.Size = new System.Drawing.Size(64, 13);
            vacancy_IdLabel.TabIndex = 1;
            vacancy_IdLabel.Text = "Vacancy Id:";
            // 
            // vacancy_IdTextBox
            // 
            this.vacancy_IdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vacancyBindingSource, "Vacancy Id", true));
            this.vacancy_IdTextBox.Location = new System.Drawing.Point(164, 31);
            this.vacancy_IdTextBox.Name = "vacancy_IdTextBox";
            this.vacancy_IdTextBox.Size = new System.Drawing.Size(100, 20);
            this.vacancy_IdTextBox.TabIndex = 2;
            // 
            // work_locationLabel
            // 
            work_locationLabel.AutoSize = true;
            work_locationLabel.Location = new System.Drawing.Point(18, 60);
            work_locationLabel.Name = "work_locationLabel";
            work_locationLabel.Size = new System.Drawing.Size(76, 13);
            work_locationLabel.TabIndex = 3;
            work_locationLabel.Text = "Work location:";
            // 
            // work_locationTextBox
            // 
            this.work_locationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vacancyBindingSource, "Work location", true));
            this.work_locationTextBox.Location = new System.Drawing.Point(164, 57);
            this.work_locationTextBox.Name = "work_locationTextBox";
            this.work_locationTextBox.Size = new System.Drawing.Size(100, 20);
            this.work_locationTextBox.TabIndex = 4;
            // 
            // social_packageLabel
            // 
            social_packageLabel.AutoSize = true;
            social_packageLabel.Location = new System.Drawing.Point(18, 86);
            social_packageLabel.Name = "social_packageLabel";
            social_packageLabel.Size = new System.Drawing.Size(84, 13);
            social_packageLabel.TabIndex = 5;
            social_packageLabel.Text = "Social package:";
            // 
            // social_packageTextBox
            // 
            this.social_packageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vacancyBindingSource, "Social package", true));
            this.social_packageTextBox.Location = new System.Drawing.Point(164, 83);
            this.social_packageTextBox.Name = "social_packageTextBox";
            this.social_packageTextBox.Size = new System.Drawing.Size(100, 20);
            this.social_packageTextBox.TabIndex = 6;
            // 
            // scopeLabel
            // 
            scopeLabel.AutoSize = true;
            scopeLabel.Location = new System.Drawing.Point(18, 112);
            scopeLabel.Name = "scopeLabel";
            scopeLabel.Size = new System.Drawing.Size(41, 13);
            scopeLabel.TabIndex = 7;
            scopeLabel.Text = "Scope:";
            // 
            // scopeTextBox
            // 
            this.scopeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vacancyBindingSource, "Scope", true));
            this.scopeTextBox.Location = new System.Drawing.Point(164, 109);
            this.scopeTextBox.Name = "scopeTextBox";
            this.scopeTextBox.Size = new System.Drawing.Size(100, 20);
            this.scopeTextBox.TabIndex = 8;
            // 
            // beginning_of_workLabel
            // 
            beginning_of_workLabel.AutoSize = true;
            beginning_of_workLabel.Location = new System.Drawing.Point(18, 138);
            beginning_of_workLabel.Name = "beginning_of_workLabel";
            beginning_of_workLabel.Size = new System.Drawing.Size(95, 13);
            beginning_of_workLabel.TabIndex = 9;
            beginning_of_workLabel.Text = "Beginning of work:";
            // 
            // beginning_of_workTextBox
            // 
            this.beginning_of_workTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vacancyBindingSource, "Beginning of work", true));
            this.beginning_of_workTextBox.Location = new System.Drawing.Point(164, 135);
            this.beginning_of_workTextBox.Name = "beginning_of_workTextBox";
            this.beginning_of_workTextBox.Size = new System.Drawing.Size(100, 20);
            this.beginning_of_workTextBox.TabIndex = 10;
            // 
            // end_of_workLabel
            // 
            end_of_workLabel.AutoSize = true;
            end_of_workLabel.Location = new System.Drawing.Point(18, 164);
            end_of_workLabel.Name = "end_of_workLabel";
            end_of_workLabel.Size = new System.Drawing.Size(67, 13);
            end_of_workLabel.TabIndex = 11;
            end_of_workLabel.Text = "End of work:";
            // 
            // end_of_workTextBox
            // 
            this.end_of_workTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vacancyBindingSource, "End of work", true));
            this.end_of_workTextBox.Location = new System.Drawing.Point(164, 161);
            this.end_of_workTextBox.Name = "end_of_workTextBox";
            this.end_of_workTextBox.Size = new System.Drawing.Size(100, 20);
            this.end_of_workTextBox.TabIndex = 12;
            // 
            // salaryLabel
            // 
            salaryLabel.AutoSize = true;
            salaryLabel.Location = new System.Drawing.Point(18, 190);
            salaryLabel.Name = "salaryLabel";
            salaryLabel.Size = new System.Drawing.Size(39, 13);
            salaryLabel.TabIndex = 13;
            salaryLabel.Text = "Salary:";
            // 
            // salaryTextBox
            // 
            this.salaryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vacancyBindingSource, "Salary", true));
            this.salaryTextBox.Location = new System.Drawing.Point(164, 187);
            this.salaryTextBox.Name = "salaryTextBox";
            this.salaryTextBox.Size = new System.Drawing.Size(100, 20);
            this.salaryTextBox.TabIndex = 14;
            // 
            // featuresLabel
            // 
            featuresLabel.AutoSize = true;
            featuresLabel.Location = new System.Drawing.Point(18, 216);
            featuresLabel.Name = "featuresLabel";
            featuresLabel.Size = new System.Drawing.Size(51, 13);
            featuresLabel.TabIndex = 15;
            featuresLabel.Text = "Features:";
            // 
            // featuresTextBox
            // 
            this.featuresTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vacancyBindingSource, "Features", true));
            this.featuresTextBox.Location = new System.Drawing.Point(164, 213);
            this.featuresTextBox.Name = "featuresTextBox";
            this.featuresTextBox.Size = new System.Drawing.Size(100, 20);
            this.featuresTextBox.TabIndex = 16;
            // 
            // possibility_of_working_minorsLabel
            // 
            possibility_of_working_minorsLabel.AutoSize = true;
            possibility_of_working_minorsLabel.Location = new System.Drawing.Point(18, 242);
            possibility_of_working_minorsLabel.Name = "possibility_of_working_minorsLabel";
            possibility_of_working_minorsLabel.Size = new System.Drawing.Size(140, 13);
            possibility_of_working_minorsLabel.TabIndex = 17;
            possibility_of_working_minorsLabel.Text = "Possibility of working minors:";
            // 
            // possibility_of_working_minorsTextBox
            // 
            this.possibility_of_working_minorsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vacancyBindingSource, "Possibility of working minors", true));
            this.possibility_of_working_minorsTextBox.Location = new System.Drawing.Point(164, 239);
            this.possibility_of_working_minorsTextBox.Name = "possibility_of_working_minorsTextBox";
            this.possibility_of_working_minorsTextBox.Size = new System.Drawing.Size(100, 20);
            this.possibility_of_working_minorsTextBox.TabIndex = 18;
            // 
            // positionLabel
            // 
            positionLabel.AutoSize = true;
            positionLabel.Location = new System.Drawing.Point(18, 268);
            positionLabel.Name = "positionLabel";
            positionLabel.Size = new System.Drawing.Size(47, 13);
            positionLabel.TabIndex = 19;
            positionLabel.Text = "Position:";
            // 
            // positionTextBox
            // 
            this.positionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vacancyBindingSource, "Position", true));
            this.positionTextBox.Location = new System.Drawing.Point(164, 265);
            this.positionTextBox.Name = "positionTextBox";
            this.positionTextBox.Size = new System.Drawing.Size(100, 20);
            this.positionTextBox.TabIndex = 20;
            // 
            // type_of_ownershipLabel
            // 
            type_of_ownershipLabel.AutoSize = true;
            type_of_ownershipLabel.Location = new System.Drawing.Point(18, 294);
            type_of_ownershipLabel.Name = "type_of_ownershipLabel";
            type_of_ownershipLabel.Size = new System.Drawing.Size(97, 13);
            type_of_ownershipLabel.TabIndex = 21;
            type_of_ownershipLabel.Text = "Type of ownership:";
            // 
            // type_of_ownershipTextBox
            // 
            this.type_of_ownershipTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vacancyBindingSource, "Type of ownership", true));
            this.type_of_ownershipTextBox.Location = new System.Drawing.Point(164, 291);
            this.type_of_ownershipTextBox.Name = "type_of_ownershipTextBox";
            this.type_of_ownershipTextBox.Size = new System.Drawing.Size(100, 20);
            this.type_of_ownershipTextBox.TabIndex = 22;
            // 
            // company_nameLabel
            // 
            company_nameLabel.AutoSize = true;
            company_nameLabel.Location = new System.Drawing.Point(18, 320);
            company_nameLabel.Name = "company_nameLabel";
            company_nameLabel.Size = new System.Drawing.Size(83, 13);
            company_nameLabel.TabIndex = 23;
            company_nameLabel.Text = "Company name:";
            // 
            // company_nameTextBox
            // 
            this.company_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vacancyBindingSource, "Company name", true));
            this.company_nameTextBox.Location = new System.Drawing.Point(164, 317);
            this.company_nameTextBox.Name = "company_nameTextBox";
            this.company_nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.company_nameTextBox.TabIndex = 24;
            // 
            // employer_s_IDLabel
            // 
            employer_s_IDLabel.AutoSize = true;
            employer_s_IDLabel.Location = new System.Drawing.Point(18, 346);
            employer_s_IDLabel.Name = "employer_s_IDLabel";
            employer_s_IDLabel.Size = new System.Drawing.Size(74, 13);
            employer_s_IDLabel.TabIndex = 25;
            employer_s_IDLabel.Text = "Employer\'s ID:";
            // 
            // employer_s_IDTextBox
            // 
            this.employer_s_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vacancyBindingSource, "Employer\'s ID", true));
            this.employer_s_IDTextBox.Location = new System.Drawing.Point(164, 343);
            this.employer_s_IDTextBox.Name = "employer_s_IDTextBox";
            this.employer_s_IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.employer_s_IDTextBox.TabIndex = 26;
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Location = new System.Drawing.Point(106, 9);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(74, 13);
            this.HeaderLabel.TabIndex = 28;
            this.HeaderLabel.Text = "Add: Vacancy";
            // 
            // addOrEditButton
            // 
            this.addOrEditButton.Location = new System.Drawing.Point(92, 369);
            this.addOrEditButton.Name = "addOrEditButton";
            this.addOrEditButton.Size = new System.Drawing.Size(75, 23);
            this.addOrEditButton.TabIndex = 29;
            this.addOrEditButton.Text = "Add";
            this.addOrEditButton.UseVisualStyleBackColor = true;
            this.addOrEditButton.Click += new System.EventHandler(this.addOrEditButton_Click);
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
            // AddVacancy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 407);
            this.Controls.Add(this.addOrEditButton);
            this.Controls.Add(this.HeaderLabel);
            this.Controls.Add(vacancy_IdLabel);
            this.Controls.Add(this.vacancy_IdTextBox);
            this.Controls.Add(work_locationLabel);
            this.Controls.Add(this.work_locationTextBox);
            this.Controls.Add(social_packageLabel);
            this.Controls.Add(this.social_packageTextBox);
            this.Controls.Add(scopeLabel);
            this.Controls.Add(this.scopeTextBox);
            this.Controls.Add(beginning_of_workLabel);
            this.Controls.Add(this.beginning_of_workTextBox);
            this.Controls.Add(end_of_workLabel);
            this.Controls.Add(this.end_of_workTextBox);
            this.Controls.Add(salaryLabel);
            this.Controls.Add(this.salaryTextBox);
            this.Controls.Add(featuresLabel);
            this.Controls.Add(this.featuresTextBox);
            this.Controls.Add(possibility_of_working_minorsLabel);
            this.Controls.Add(this.possibility_of_working_minorsTextBox);
            this.Controls.Add(positionLabel);
            this.Controls.Add(this.positionTextBox);
            this.Controls.Add(type_of_ownershipLabel);
            this.Controls.Add(this.type_of_ownershipTextBox);
            this.Controls.Add(company_nameLabel);
            this.Controls.Add(this.company_nameTextBox);
            this.Controls.Add(employer_s_IDLabel);
            this.Controls.Add(this.employer_s_IDTextBox);
            this.Name = "AddVacancy";
            this.Text = "AddVacancy";
            this.Load += new System.EventHandler(this.AddVacancy_Load);
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
        private System.Windows.Forms.TextBox vacancy_IdTextBox;
        private System.Windows.Forms.TextBox work_locationTextBox;
        private System.Windows.Forms.TextBox social_packageTextBox;
        private System.Windows.Forms.TextBox scopeTextBox;
        private System.Windows.Forms.TextBox beginning_of_workTextBox;
        private System.Windows.Forms.TextBox end_of_workTextBox;
        private System.Windows.Forms.TextBox salaryTextBox;
        private System.Windows.Forms.TextBox featuresTextBox;
        private System.Windows.Forms.TextBox possibility_of_working_minorsTextBox;
        private System.Windows.Forms.TextBox positionTextBox;
        private System.Windows.Forms.TextBox type_of_ownershipTextBox;
        private System.Windows.Forms.TextBox company_nameTextBox;
        private System.Windows.Forms.TextBox employer_s_IDTextBox;
        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Button addOrEditButton;

    }
}