namespace JobCentre.Views
{
    partial class VacancyFilterForm
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
            System.Windows.Forms.Label scopeLabel;
            System.Windows.Forms.Label beginning_of_workLabel;
            System.Windows.Forms.Label end_of_workLabel;
            System.Windows.Forms.Label salaryLabel;
            this.salaryTextBox = new System.Windows.Forms.TextBox();
            this.minorsCheckBox = new System.Windows.Forms.CheckBox();
            this.beginningOfWorkDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endOfWorkDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.FilterButton = new System.Windows.Forms.Button();
            this.scopeComboBox = new System.Windows.Forms.ComboBox();
            this.vacancyTableAdapter = new JobCentre.LaborExchangeDataSetTableAdapters.VacancyTableAdapter();
            this.laborExchangeDataSet = new JobCentre.LaborExchangeDataSet();
            scopeLabel = new System.Windows.Forms.Label();
            beginning_of_workLabel = new System.Windows.Forms.Label();
            end_of_workLabel = new System.Windows.Forms.Label();
            salaryLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.laborExchangeDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // scopeLabel
            // 
            scopeLabel.AutoSize = true;
            scopeLabel.Location = new System.Drawing.Point(17, 45);
            scopeLabel.Name = "scopeLabel";
            scopeLabel.Size = new System.Drawing.Size(41, 13);
            scopeLabel.TabIndex = 7;
            scopeLabel.Text = "Scope:";
            // 
            // beginning_of_workLabel
            // 
            beginning_of_workLabel.AutoSize = true;
            beginning_of_workLabel.Location = new System.Drawing.Point(17, 71);
            beginning_of_workLabel.Name = "beginning_of_workLabel";
            beginning_of_workLabel.Size = new System.Drawing.Size(95, 13);
            beginning_of_workLabel.TabIndex = 9;
            beginning_of_workLabel.Text = "Beginning of work:";
            // 
            // end_of_workLabel
            // 
            end_of_workLabel.AutoSize = true;
            end_of_workLabel.Location = new System.Drawing.Point(17, 97);
            end_of_workLabel.Name = "end_of_workLabel";
            end_of_workLabel.Size = new System.Drawing.Size(67, 13);
            end_of_workLabel.TabIndex = 11;
            end_of_workLabel.Text = "End of work:";
            // 
            // salaryLabel
            // 
            salaryLabel.AutoSize = true;
            salaryLabel.Location = new System.Drawing.Point(17, 123);
            salaryLabel.Name = "salaryLabel";
            salaryLabel.Size = new System.Drawing.Size(75, 13);
            salaryLabel.TabIndex = 13;
            salaryLabel.Text = "Minimal salary:";
            // 
            // salaryTextBox
            // 
            this.salaryTextBox.Location = new System.Drawing.Point(163, 116);
            this.salaryTextBox.Name = "salaryTextBox";
            this.salaryTextBox.Size = new System.Drawing.Size(200, 20);
            this.salaryTextBox.TabIndex = 14;
            // 
            // minorsCheckBox
            // 
            this.minorsCheckBox.AutoSize = true;
            this.minorsCheckBox.Location = new System.Drawing.Point(20, 142);
            this.minorsCheckBox.Name = "minorsCheckBox";
            this.minorsCheckBox.Size = new System.Drawing.Size(156, 17);
            this.minorsCheckBox.TabIndex = 27;
            this.minorsCheckBox.Text = "Possibility of working minors";
            this.minorsCheckBox.UseVisualStyleBackColor = true;
            // 
            // beginningOfWorkDateTimePicker
            // 
            this.beginningOfWorkDateTimePicker.CustomFormat = "HH: mm";
            this.beginningOfWorkDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.beginningOfWorkDateTimePicker.Location = new System.Drawing.Point(163, 68);
            this.beginningOfWorkDateTimePicker.Name = "beginningOfWorkDateTimePicker";
            this.beginningOfWorkDateTimePicker.ShowUpDown = true;
            this.beginningOfWorkDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.beginningOfWorkDateTimePicker.TabIndex = 28;
            // 
            // endOfWorkDateTimePicker
            // 
            this.endOfWorkDateTimePicker.CustomFormat = "HH: mm";
            this.endOfWorkDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endOfWorkDateTimePicker.Location = new System.Drawing.Point(163, 91);
            this.endOfWorkDateTimePicker.Name = "endOfWorkDateTimePicker";
            this.endOfWorkDateTimePicker.ShowUpDown = true;
            this.endOfWorkDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.endOfWorkDateTimePicker.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Filter : Vacancy";
            // 
            // FilterButton
            // 
            this.FilterButton.Location = new System.Drawing.Point(143, 164);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(75, 23);
            this.FilterButton.TabIndex = 32;
            this.FilterButton.Text = "Filter";
            this.FilterButton.UseVisualStyleBackColor = true;
            this.FilterButton.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // scopeComboBox
            // 
            this.scopeComboBox.FormattingEnabled = true;
            this.scopeComboBox.Location = new System.Drawing.Point(163, 37);
            this.scopeComboBox.Name = "scopeComboBox";
            this.scopeComboBox.Size = new System.Drawing.Size(200, 21);
            this.scopeComboBox.TabIndex = 33;
            // 
            // vacancyTableAdapter
            // 
            this.vacancyTableAdapter.ClearBeforeFill = true;
            // 
            // laborExchangeDataSet
            // 
            this.laborExchangeDataSet.DataSetName = "LaborExchangeDataSet";
            this.laborExchangeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // VacancyFilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 199);
            this.Controls.Add(this.scopeComboBox);
            this.Controls.Add(this.FilterButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.endOfWorkDateTimePicker);
            this.Controls.Add(this.beginningOfWorkDateTimePicker);
            this.Controls.Add(this.minorsCheckBox);
            this.Controls.Add(scopeLabel);
            this.Controls.Add(beginning_of_workLabel);
            this.Controls.Add(end_of_workLabel);
            this.Controls.Add(salaryLabel);
            this.Controls.Add(this.salaryTextBox);
            this.Name = "VacancyFilterForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.laborExchangeDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox salaryTextBox;
        private System.Windows.Forms.CheckBox minorsCheckBox;
        private System.Windows.Forms.DateTimePicker beginningOfWorkDateTimePicker;
        private System.Windows.Forms.DateTimePicker endOfWorkDateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button FilterButton;
        private System.Windows.Forms.ComboBox scopeComboBox;
        private LaborExchangeDataSetTableAdapters.VacancyTableAdapter vacancyTableAdapter;
        private LaborExchangeDataSet laborExchangeDataSet;

    }
}