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
            this.vacancy_IDTextBox = new System.Windows.Forms.TextBox();
            this.employee_s_IDTextBox = new System.Windows.Forms.TextBox();
            this.submission_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.interview_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.vacancy_requestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.laborExchangeDataSet = new JobCentre.LaborExchangeDataSet();
            this.vacancyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vacancyTableAdapter = new JobCentre.LaborExchangeDataSetTableAdapters.VacancyTableAdapter();
            this.tableAdapterManager = new JobCentre.LaborExchangeDataSetTableAdapters.TableAdapterManager();
            this.vacancy_requestTableAdapter = new JobCentre.LaborExchangeDataSetTableAdapters.Vacancy_requestTableAdapter();
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
            vacancy_IDLabel.Location = new System.Drawing.Point(11, 37);
            vacancy_IDLabel.Name = "vacancy_IDLabel";
            vacancy_IDLabel.Size = new System.Drawing.Size(66, 13);
            vacancy_IDLabel.TabIndex = 0;
            vacancy_IDLabel.Text = "Vacancy ID:";
            // 
            // vacancy_IDTextBox
            // 
            this.vacancy_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vacancy_requestBindingSource, "Vacancy ID", true));
            this.vacancy_IDTextBox.Location = new System.Drawing.Point(104, 34);
            this.vacancy_IDTextBox.Name = "vacancy_IDTextBox";
            this.vacancy_IDTextBox.Size = new System.Drawing.Size(200, 20);
            this.vacancy_IDTextBox.TabIndex = 1;
            // 
            // employee_s_IDLabel
            // 
            employee_s_IDLabel.AutoSize = true;
            employee_s_IDLabel.Location = new System.Drawing.Point(11, 63);
            employee_s_IDLabel.Name = "employee_s_IDLabel";
            employee_s_IDLabel.Size = new System.Drawing.Size(77, 13);
            employee_s_IDLabel.TabIndex = 2;
            employee_s_IDLabel.Text = "Employee\'s ID:";
            // 
            // employee_s_IDTextBox
            // 
            this.employee_s_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vacancy_requestBindingSource, "Employee\'s ID", true));
            this.employee_s_IDTextBox.Location = new System.Drawing.Point(104, 60);
            this.employee_s_IDTextBox.Name = "employee_s_IDTextBox";
            this.employee_s_IDTextBox.Size = new System.Drawing.Size(200, 20);
            this.employee_s_IDTextBox.TabIndex = 3;
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
            // submission_dateDateTimePicker
            // 
            this.submission_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.vacancy_requestBindingSource, "Submission date", true));
            this.submission_dateDateTimePicker.Location = new System.Drawing.Point(104, 86);
            this.submission_dateDateTimePicker.Name = "submission_dateDateTimePicker";
            this.submission_dateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.submission_dateDateTimePicker.TabIndex = 5;
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
            // interview_dateDateTimePicker
            // 
            this.interview_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.vacancy_requestBindingSource, "Interview date", true));
            this.interview_dateDateTimePicker.Location = new System.Drawing.Point(104, 112);
            this.interview_dateDateTimePicker.Name = "interview_dateDateTimePicker";
            this.interview_dateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.interview_dateDateTimePicker.TabIndex = 7;
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
            // resultTextBox
            // 
            this.resultTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vacancy_requestBindingSource, "Result", true));
            this.resultTextBox.Location = new System.Drawing.Point(104, 138);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(200, 20);
            this.resultTextBox.TabIndex = 9;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(115, 164);
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
            // AddVacancyRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 201);
            this.Controls.Add(this.HeaderLabel);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(vacancy_IDLabel);
            this.Controls.Add(this.vacancy_IDTextBox);
            this.Controls.Add(employee_s_IDLabel);
            this.Controls.Add(this.employee_s_IDTextBox);
            this.Controls.Add(submission_dateLabel);
            this.Controls.Add(this.submission_dateDateTimePicker);
            this.Controls.Add(interview_dateLabel);
            this.Controls.Add(this.interview_dateDateTimePicker);
            this.Controls.Add(resultLabel);
            this.Controls.Add(this.resultTextBox);
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
        private System.Windows.Forms.TextBox vacancy_IDTextBox;
        private System.Windows.Forms.TextBox employee_s_IDTextBox;
        private System.Windows.Forms.DateTimePicker submission_dateDateTimePicker;
        private System.Windows.Forms.DateTimePicker interview_dateDateTimePicker;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label HeaderLabel;
    }
}