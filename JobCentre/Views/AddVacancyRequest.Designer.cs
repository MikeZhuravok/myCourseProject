namespace JobCentre.Views
{
    partial class AddVacancyRequest
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
            System.Windows.Forms.Label vacancy_IDLabel;
            System.Windows.Forms.Label employee_s_IDLabel;
            System.Windows.Forms.Label submission_dateLabel;
            System.Windows.Forms.Label interview_dateLabel;
            System.Windows.Forms.Label resultLabel;
            this.vacancy_requestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.laborExchangeDataSet = new JobCentre.LaborExchangeDataSet();
            this.submission_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.interview_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AddButton = new System.Windows.Forms.Button();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.vacancyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vacancyTableAdapter = new JobCentre.LaborExchangeDataSetTableAdapters.VacancyTableAdapter();
            this.tableAdapterManager = new JobCentre.LaborExchangeDataSetTableAdapters.TableAdapterManager();
            this.vacancy_requestTableAdapter = new JobCentre.LaborExchangeDataSetTableAdapters.Vacancy_requestTableAdapter();
            this.resultComboBox = new System.Windows.Forms.ComboBox();
            this.employeeIdComboBox = new System.Windows.Forms.ComboBox();
            this.vacancyIdComboBox = new System.Windows.Forms.ComboBox();
            vacancy_IDLabel = new System.Windows.Forms.Label();
            employee_s_IDLabel = new System.Windows.Forms.Label();
            submission_dateLabel = new System.Windows.Forms.Label();
            interview_dateLabel = new System.Windows.Forms.Label();
            resultLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vacancy_requestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laborExchangeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacancyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // vacancy_IDLabel
            // 
            vacancy_IDLabel.AutoSize = true;
            vacancy_IDLabel.Location = new System.Drawing.Point(12, 64);
            vacancy_IDLabel.Name = "vacancy_IDLabel";
            vacancy_IDLabel.Size = new System.Drawing.Size(66, 13);
            vacancy_IDLabel.TabIndex = 0;
            vacancy_IDLabel.Text = "Vacancy ID:";
            // 
            // employee_s_IDLabel
            // 
            employee_s_IDLabel.AutoSize = true;
            employee_s_IDLabel.Location = new System.Drawing.Point(11, 38);
            employee_s_IDLabel.Name = "employee_s_IDLabel";
            employee_s_IDLabel.Size = new System.Drawing.Size(77, 13);
            employee_s_IDLabel.TabIndex = 2;
            employee_s_IDLabel.Text = "Employee\'s ID:";
            // 
            // submission_dateLabel
            // 
            submission_dateLabel.AutoSize = true;
            submission_dateLabel.Location = new System.Drawing.Point(11, 90);
            submission_dateLabel.Name = "submission_dateLabel";
            submission_dateLabel.Size = new System.Drawing.Size(87, 13);
            submission_dateLabel.TabIndex = 4;
            submission_dateLabel.Text = "Submission date:";
            // 
            // interview_dateLabel
            // 
            interview_dateLabel.AutoSize = true;
            interview_dateLabel.Location = new System.Drawing.Point(11, 116);
            interview_dateLabel.Name = "interview_dateLabel";
            interview_dateLabel.Size = new System.Drawing.Size(77, 13);
            interview_dateLabel.TabIndex = 6;
            interview_dateLabel.Text = "Interview date:";
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Location = new System.Drawing.Point(11, 141);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new System.Drawing.Size(40, 13);
            resultLabel.TabIndex = 8;
            resultLabel.Text = "Result:";
            // 
            // vacancy_requestBindingSource
            // 
            this.vacancy_requestBindingSource.DataMember = "Vacancy request";
            this.vacancy_requestBindingSource.DataSource = this.laborExchangeDataSet;
            // 
            // laborExchangeDataSet
            // 
            this.laborExchangeDataSet.DataSetName = "LaborExchangeDataSet";
            this.laborExchangeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // submission_dateDateTimePicker
            // 
            this.submission_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.vacancy_requestBindingSource, "Submission date", true));
            this.submission_dateDateTimePicker.Location = new System.Drawing.Point(104, 83);
            this.submission_dateDateTimePicker.Name = "submission_dateDateTimePicker";
            this.submission_dateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.submission_dateDateTimePicker.TabIndex = 5;
            // 
            // interview_dateDateTimePicker
            // 
            this.interview_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.vacancy_requestBindingSource, "Interview date", true));
            this.interview_dateDateTimePicker.Location = new System.Drawing.Point(104, 109);
            this.interview_dateDateTimePicker.Name = "interview_dateDateTimePicker";
            this.interview_dateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.interview_dateDateTimePicker.TabIndex = 7;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(120, 160);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 10;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Location = new System.Drawing.Point(89, 9);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(117, 13);
            this.HeaderLabel.TabIndex = 11;
            this.HeaderLabel.Text = "Add: Vacancy Request";
            // 
            // vacancyBindingSource
            // 
            this.vacancyBindingSource.DataMember = "Vacancy";
            this.vacancyBindingSource.DataSource = this.laborExchangeDataSet;
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
            this.tableAdapterManager.Vacancy_requestTableAdapter = this.vacancy_requestTableAdapter;
            this.tableAdapterManager.VacancyTableAdapter = this.vacancyTableAdapter;
            // 
            // vacancy_requestTableAdapter
            // 
            this.vacancy_requestTableAdapter.ClearBeforeFill = true;
            // 
            // resultComboBox
            // 
            this.resultComboBox.FormattingEnabled = true;
            this.resultComboBox.Items.AddRange(new object[] {
            "Positive",
            "Negative"});
            this.resultComboBox.Location = new System.Drawing.Point(104, 133);
            this.resultComboBox.Name = "resultComboBox";
            this.resultComboBox.Size = new System.Drawing.Size(200, 21);
            this.resultComboBox.TabIndex = 12;
            // 
            // employeeIdComboBox
            // 
            this.employeeIdComboBox.FormattingEnabled = true;
            this.employeeIdComboBox.Location = new System.Drawing.Point(104, 30);
            this.employeeIdComboBox.Name = "employeeIdComboBox";
            this.employeeIdComboBox.Size = new System.Drawing.Size(200, 21);
            this.employeeIdComboBox.TabIndex = 13;
            // 
            // vacancyIdComboBox
            // 
            this.vacancyIdComboBox.FormattingEnabled = true;
            this.vacancyIdComboBox.Location = new System.Drawing.Point(104, 56);
            this.vacancyIdComboBox.Name = "vacancyIdComboBox";
            this.vacancyIdComboBox.Size = new System.Drawing.Size(200, 21);
            this.vacancyIdComboBox.TabIndex = 14;
            // 
            // AddVacancyRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 192);
            this.Controls.Add(this.vacancyIdComboBox);
            this.Controls.Add(this.employeeIdComboBox);
            this.Controls.Add(this.resultComboBox);
            this.Controls.Add(this.HeaderLabel);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(vacancy_IDLabel);
            this.Controls.Add(employee_s_IDLabel);
            this.Controls.Add(submission_dateLabel);
            this.Controls.Add(this.submission_dateDateTimePicker);
            this.Controls.Add(interview_dateLabel);
            this.Controls.Add(this.interview_dateDateTimePicker);
            this.Controls.Add(resultLabel);
            this.Name = "AddVacancyRequest";
            this.Text = "AddVacancyRequest";
            ((System.ComponentModel.ISupportInitialize)(this.vacancy_requestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laborExchangeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacancyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LaborExchangeDataSet laborExchangeDataSet;
        private System.Windows.Forms.BindingSource vacancyBindingSource;
        private LaborExchangeDataSetTableAdapters.VacancyTableAdapter vacancyTableAdapter;
        private LaborExchangeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private LaborExchangeDataSetTableAdapters.Vacancy_requestTableAdapter vacancy_requestTableAdapter;
        private System.Windows.Forms.BindingSource vacancy_requestBindingSource;
        private System.Windows.Forms.DateTimePicker submission_dateDateTimePicker;
        private System.Windows.Forms.DateTimePicker interview_dateDateTimePicker;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.ComboBox resultComboBox;
        private System.Windows.Forms.ComboBox employeeIdComboBox;
        private System.Windows.Forms.ComboBox vacancyIdComboBox;
    }
}