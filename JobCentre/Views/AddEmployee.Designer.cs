namespace JobCentre.Views
{
    partial class AddEmployee
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
            System.Windows.Forms.Label full_nameLabel;
            System.Windows.Forms.Label professionLabel;
            System.Windows.Forms.Label record_of_serviceLabel;
            System.Windows.Forms.Label pasport_numberLabel;
            System.Windows.Forms.Label special_skillsLabel;
            System.Windows.Forms.Label locationLabel;
            System.Windows.Forms.Label identification_codeLabel;
            System.Windows.Forms.Label educationLabel;
            System.Windows.Forms.Label needsLabel;
            System.Windows.Forms.Label work_modeLabel;
            System.Windows.Forms.Label work_natureLabel;
            System.Windows.Forms.Label phone_numberLabel;
            this.full_nameTextBox = new System.Windows.Forms.TextBox();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.laborExchangeDataSet = new JobCentre.LaborExchangeDataSet();
            this.record_of_serviceTextBox = new System.Windows.Forms.TextBox();
            this.pasport_numberTextBox = new System.Windows.Forms.TextBox();
            this.special_skillsTextBox = new System.Windows.Forms.TextBox();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.identification_codeTextBox = new System.Windows.Forms.TextBox();
            this.educationTextBox = new System.Windows.Forms.TextBox();
            this.needsTextBox = new System.Windows.Forms.TextBox();
            this.phone_numberTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.employeeTableAdapter = new JobCentre.LaborExchangeDataSetTableAdapters.EmployeeTableAdapter();
            this.tableAdapterManager = new JobCentre.LaborExchangeDataSetTableAdapters.TableAdapterManager();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.professionsComboBox = new System.Windows.Forms.ComboBox();
            this.workModeComboBox = new System.Windows.Forms.ComboBox();
            this.workNatureComboBox = new System.Windows.Forms.ComboBox();
            full_nameLabel = new System.Windows.Forms.Label();
            professionLabel = new System.Windows.Forms.Label();
            record_of_serviceLabel = new System.Windows.Forms.Label();
            pasport_numberLabel = new System.Windows.Forms.Label();
            special_skillsLabel = new System.Windows.Forms.Label();
            locationLabel = new System.Windows.Forms.Label();
            identification_codeLabel = new System.Windows.Forms.Label();
            educationLabel = new System.Windows.Forms.Label();
            needsLabel = new System.Windows.Forms.Label();
            work_modeLabel = new System.Windows.Forms.Label();
            work_natureLabel = new System.Windows.Forms.Label();
            phone_numberLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laborExchangeDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // full_nameLabel
            // 
            full_nameLabel.AutoSize = true;
            full_nameLabel.Location = new System.Drawing.Point(16, 38);
            full_nameLabel.Name = "full_nameLabel";
            full_nameLabel.Size = new System.Drawing.Size(55, 13);
            full_nameLabel.TabIndex = 3;
            full_nameLabel.Text = "Full name:";
            // 
            // professionLabel
            // 
            professionLabel.AutoSize = true;
            professionLabel.Location = new System.Drawing.Point(16, 64);
            professionLabel.Name = "professionLabel";
            professionLabel.Size = new System.Drawing.Size(59, 13);
            professionLabel.TabIndex = 5;
            professionLabel.Text = "Profession:";
            // 
            // record_of_serviceLabel
            // 
            record_of_serviceLabel.AutoSize = true;
            record_of_serviceLabel.Location = new System.Drawing.Point(16, 90);
            record_of_serviceLabel.Name = "record_of_serviceLabel";
            record_of_serviceLabel.Size = new System.Drawing.Size(94, 13);
            record_of_serviceLabel.TabIndex = 7;
            record_of_serviceLabel.Text = "Record of service:";
            // 
            // pasport_numberLabel
            // 
            pasport_numberLabel.AutoSize = true;
            pasport_numberLabel.Location = new System.Drawing.Point(16, 116);
            pasport_numberLabel.Name = "pasport_numberLabel";
            pasport_numberLabel.Size = new System.Drawing.Size(84, 13);
            pasport_numberLabel.TabIndex = 9;
            pasport_numberLabel.Text = "Pasport number:";
            // 
            // special_skillsLabel
            // 
            special_skillsLabel.AutoSize = true;
            special_skillsLabel.Location = new System.Drawing.Point(16, 142);
            special_skillsLabel.Name = "special_skillsLabel";
            special_skillsLabel.Size = new System.Drawing.Size(70, 13);
            special_skillsLabel.TabIndex = 11;
            special_skillsLabel.Text = "Special skills:";
            // 
            // locationLabel
            // 
            locationLabel.AutoSize = true;
            locationLabel.Location = new System.Drawing.Point(16, 168);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new System.Drawing.Size(51, 13);
            locationLabel.TabIndex = 13;
            locationLabel.Text = "Location:";
            // 
            // identification_codeLabel
            // 
            identification_codeLabel.AutoSize = true;
            identification_codeLabel.Location = new System.Drawing.Point(16, 194);
            identification_codeLabel.Name = "identification_codeLabel";
            identification_codeLabel.Size = new System.Drawing.Size(97, 13);
            identification_codeLabel.TabIndex = 15;
            identification_codeLabel.Text = "Identification code:";
            // 
            // educationLabel
            // 
            educationLabel.AutoSize = true;
            educationLabel.Location = new System.Drawing.Point(16, 220);
            educationLabel.Name = "educationLabel";
            educationLabel.Size = new System.Drawing.Size(58, 13);
            educationLabel.TabIndex = 17;
            educationLabel.Text = "Education:";
            // 
            // needsLabel
            // 
            needsLabel.AutoSize = true;
            needsLabel.Location = new System.Drawing.Point(16, 246);
            needsLabel.Name = "needsLabel";
            needsLabel.Size = new System.Drawing.Size(41, 13);
            needsLabel.TabIndex = 19;
            needsLabel.Text = "Needs:";
            // 
            // work_modeLabel
            // 
            work_modeLabel.AutoSize = true;
            work_modeLabel.Location = new System.Drawing.Point(16, 272);
            work_modeLabel.Name = "work_modeLabel";
            work_modeLabel.Size = new System.Drawing.Size(65, 13);
            work_modeLabel.TabIndex = 21;
            work_modeLabel.Text = "Work mode:";
            // 
            // work_natureLabel
            // 
            work_natureLabel.AutoSize = true;
            work_natureLabel.Location = new System.Drawing.Point(16, 298);
            work_natureLabel.Name = "work_natureLabel";
            work_natureLabel.Size = new System.Drawing.Size(69, 13);
            work_natureLabel.TabIndex = 23;
            work_natureLabel.Text = "Work nature:";
            // 
            // phone_numberLabel
            // 
            phone_numberLabel.AutoSize = true;
            phone_numberLabel.Location = new System.Drawing.Point(16, 324);
            phone_numberLabel.Name = "phone_numberLabel";
            phone_numberLabel.Size = new System.Drawing.Size(79, 13);
            phone_numberLabel.TabIndex = 25;
            phone_numberLabel.Text = "Phone number:";
            // 
            // full_nameTextBox
            // 
            this.full_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Full name", true));
            this.full_nameTextBox.Location = new System.Drawing.Point(119, 35);
            this.full_nameTextBox.Name = "full_nameTextBox";
            this.full_nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.full_nameTextBox.TabIndex = 4;
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
            // record_of_serviceTextBox
            // 
            this.record_of_serviceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Record of service", true));
            this.record_of_serviceTextBox.Location = new System.Drawing.Point(119, 87);
            this.record_of_serviceTextBox.Name = "record_of_serviceTextBox";
            this.record_of_serviceTextBox.Size = new System.Drawing.Size(100, 20);
            this.record_of_serviceTextBox.TabIndex = 8;
            // 
            // pasport_numberTextBox
            // 
            this.pasport_numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Pasport number", true));
            this.pasport_numberTextBox.Location = new System.Drawing.Point(119, 113);
            this.pasport_numberTextBox.Name = "pasport_numberTextBox";
            this.pasport_numberTextBox.Size = new System.Drawing.Size(100, 20);
            this.pasport_numberTextBox.TabIndex = 10;
            // 
            // special_skillsTextBox
            // 
            this.special_skillsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Special skills", true));
            this.special_skillsTextBox.Location = new System.Drawing.Point(119, 139);
            this.special_skillsTextBox.Name = "special_skillsTextBox";
            this.special_skillsTextBox.Size = new System.Drawing.Size(100, 20);
            this.special_skillsTextBox.TabIndex = 12;
            // 
            // locationTextBox
            // 
            this.locationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Location", true));
            this.locationTextBox.Location = new System.Drawing.Point(119, 165);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(100, 20);
            this.locationTextBox.TabIndex = 14;
            // 
            // identification_codeTextBox
            // 
            this.identification_codeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Identification code", true));
            this.identification_codeTextBox.Location = new System.Drawing.Point(119, 191);
            this.identification_codeTextBox.Name = "identification_codeTextBox";
            this.identification_codeTextBox.Size = new System.Drawing.Size(100, 20);
            this.identification_codeTextBox.TabIndex = 16;
            // 
            // educationTextBox
            // 
            this.educationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Education", true));
            this.educationTextBox.Location = new System.Drawing.Point(119, 217);
            this.educationTextBox.Name = "educationTextBox";
            this.educationTextBox.Size = new System.Drawing.Size(100, 20);
            this.educationTextBox.TabIndex = 18;
            // 
            // needsTextBox
            // 
            this.needsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Needs", true));
            this.needsTextBox.Location = new System.Drawing.Point(119, 243);
            this.needsTextBox.Name = "needsTextBox";
            this.needsTextBox.Size = new System.Drawing.Size(100, 20);
            this.needsTextBox.TabIndex = 20;
            // 
            // phone_numberTextBox
            // 
            this.phone_numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Phone number", true));
            this.phone_numberTextBox.Location = new System.Drawing.Point(119, 321);
            this.phone_numberTextBox.Name = "phone_numberTextBox";
            this.phone_numberTextBox.Size = new System.Drawing.Size(100, 20);
            this.phone_numberTextBox.TabIndex = 26;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(95, 354);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 28;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EmployeeTableAdapter = this.employeeTableAdapter;
            this.tableAdapterManager.EmployerTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = JobCentre.LaborExchangeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Vacancy_requestTableAdapter = null;
            this.tableAdapterManager.VacancyTableAdapter = null;
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Location = new System.Drawing.Point(95, 9);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(78, 13);
            this.HeaderLabel.TabIndex = 27;
            this.HeaderLabel.Text = "Add: Employee";
            // 
            // professionsComboBox
            // 
            this.professionsComboBox.FormattingEnabled = true;
            this.professionsComboBox.Location = new System.Drawing.Point(119, 60);
            this.professionsComboBox.Name = "professionsComboBox";
            this.professionsComboBox.Size = new System.Drawing.Size(100, 21);
            this.professionsComboBox.TabIndex = 29;
            // 
            // workModeComboBox
            // 
            this.workModeComboBox.FormattingEnabled = true;
            this.workModeComboBox.Location = new System.Drawing.Point(119, 268);
            this.workModeComboBox.Name = "workModeComboBox";
            this.workModeComboBox.Size = new System.Drawing.Size(100, 21);
            this.workModeComboBox.TabIndex = 30;
            // 
            // workNatureComboBox
            // 
            this.workNatureComboBox.FormattingEnabled = true;
            this.workNatureComboBox.Location = new System.Drawing.Point(119, 294);
            this.workNatureComboBox.Name = "workNatureComboBox";
            this.workNatureComboBox.Size = new System.Drawing.Size(100, 21);
            this.workNatureComboBox.TabIndex = 31;
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 387);
            this.Controls.Add(this.workNatureComboBox);
            this.Controls.Add(this.workModeComboBox);
            this.Controls.Add(this.professionsComboBox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.HeaderLabel);
            this.Controls.Add(full_nameLabel);
            this.Controls.Add(this.full_nameTextBox);
            this.Controls.Add(professionLabel);
            this.Controls.Add(record_of_serviceLabel);
            this.Controls.Add(this.record_of_serviceTextBox);
            this.Controls.Add(pasport_numberLabel);
            this.Controls.Add(this.pasport_numberTextBox);
            this.Controls.Add(special_skillsLabel);
            this.Controls.Add(this.special_skillsTextBox);
            this.Controls.Add(locationLabel);
            this.Controls.Add(this.locationTextBox);
            this.Controls.Add(identification_codeLabel);
            this.Controls.Add(this.identification_codeTextBox);
            this.Controls.Add(educationLabel);
            this.Controls.Add(this.educationTextBox);
            this.Controls.Add(needsLabel);
            this.Controls.Add(this.needsTextBox);
            this.Controls.Add(work_modeLabel);
            this.Controls.Add(work_natureLabel);
            this.Controls.Add(phone_numberLabel);
            this.Controls.Add(this.phone_numberTextBox);
            this.Name = "AddEmployee";
            this.Text = "AddEmployee";
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laborExchangeDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LaborExchangeDataSet laborExchangeDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private LaborExchangeDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private LaborExchangeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox full_nameTextBox;
        private System.Windows.Forms.TextBox record_of_serviceTextBox;
        private System.Windows.Forms.TextBox pasport_numberTextBox;
        private System.Windows.Forms.TextBox special_skillsTextBox;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.TextBox identification_codeTextBox;
        private System.Windows.Forms.TextBox educationTextBox;
        private System.Windows.Forms.TextBox needsTextBox;
        private System.Windows.Forms.TextBox phone_numberTextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.ComboBox professionsComboBox;
        private System.Windows.Forms.ComboBox workModeComboBox;
        private System.Windows.Forms.ComboBox workNatureComboBox;

    }
}