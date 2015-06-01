namespace JobCentre.Views
{
    partial class EditVacancyRequest
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
            System.Windows.Forms.Label interview_dateLabel;
            System.Windows.Forms.Label resultLabel;
            this.laborExchangeDataSet = new JobCentre.LaborExchangeDataSet();
            this.vacancy_requestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vacancy_requestTableAdapter = new JobCentre.LaborExchangeDataSetTableAdapters.Vacancy_requestTableAdapter();
            this.tableAdapterManager = new JobCentre.LaborExchangeDataSetTableAdapters.TableAdapterManager();
            this.interview_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.editButton = new System.Windows.Forms.Button();
            this.resultComboBox = new System.Windows.Forms.ComboBox();
            interview_dateLabel = new System.Windows.Forms.Label();
            resultLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.laborExchangeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacancy_requestBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // interview_dateLabel
            // 
            interview_dateLabel.AutoSize = true;
            interview_dateLabel.Location = new System.Drawing.Point(12, 37);
            interview_dateLabel.Name = "interview_dateLabel";
            interview_dateLabel.Size = new System.Drawing.Size(77, 13);
            interview_dateLabel.TabIndex = 7;
            interview_dateLabel.Text = "Interview date:";
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Location = new System.Drawing.Point(12, 60);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new System.Drawing.Size(40, 13);
            resultLabel.TabIndex = 9;
            resultLabel.Text = "Result:";
            // 
            // laborExchangeDataSet
            // 
            this.laborExchangeDataSet.DataSetName = "LaborExchangeDataSet";
            this.laborExchangeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vacancy_requestBindingSource
            // 
            this.vacancy_requestBindingSource.DataMember = "Vacancy request";
            this.vacancy_requestBindingSource.DataSource = this.laborExchangeDataSet;
            // 
            // vacancy_requestTableAdapter
            // 
            this.vacancy_requestTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.EmployerTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = JobCentre.LaborExchangeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Vacancy_requestTableAdapter = this.vacancy_requestTableAdapter;
            this.tableAdapterManager.VacancyTableAdapter = null;
            // 
            // interview_dateDateTimePicker
            // 
            this.interview_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.vacancy_requestBindingSource, "Interview date", true));
            this.interview_dateDateTimePicker.Location = new System.Drawing.Point(105, 31);
            this.interview_dateDateTimePicker.Name = "interview_dateDateTimePicker";
            this.interview_dateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.interview_dateDateTimePicker.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Edit: Vacancy Request";
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(127, 92);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 12;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // resultComboBox
            // 
            this.resultComboBox.FormattingEnabled = true;
            this.resultComboBox.Items.AddRange(new object[] {
            "Postive",
            "Negative"});
            this.resultComboBox.Location = new System.Drawing.Point(105, 57);
            this.resultComboBox.Name = "resultComboBox";
            this.resultComboBox.Size = new System.Drawing.Size(200, 21);
            this.resultComboBox.TabIndex = 13;
            // 
            // EditVacancyRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 127);
            this.Controls.Add(this.resultComboBox);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(interview_dateLabel);
            this.Controls.Add(this.interview_dateDateTimePicker);
            this.Controls.Add(resultLabel);
            this.Name = "EditVacancyRequest";
            this.Text = "EditVacancyRequest";
            this.Load += new System.EventHandler(this.EditVacancyRequest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.laborExchangeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacancy_requestBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LaborExchangeDataSet laborExchangeDataSet;
        private System.Windows.Forms.BindingSource vacancy_requestBindingSource;
        private LaborExchangeDataSetTableAdapters.Vacancy_requestTableAdapter vacancy_requestTableAdapter;
        private LaborExchangeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DateTimePicker interview_dateDateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.ComboBox resultComboBox;
    }
}