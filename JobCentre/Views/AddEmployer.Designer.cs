namespace JobCentre.Views
{
    partial class AddEmployer
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
            System.Windows.Forms.Label pasport_numberLabel;
            System.Windows.Forms.Label phone_numberLabel;
            System.Windows.Forms.Label bank_detailsLabel;
            System.Windows.Forms.Label individual_tax_numberLabel;
            System.Windows.Forms.Label main_property_typeLabel;
            System.Windows.Forms.Label economical_activityLabel;
            this.laborExchangeDataSet = new JobCentre.LaborExchangeDataSet();
            this.employerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employerTableAdapter = new JobCentre.LaborExchangeDataSetTableAdapters.EmployerTableAdapter();
            this.tableAdapterManager = new JobCentre.LaborExchangeDataSetTableAdapters.TableAdapterManager();
            this.full_nameTextBox = new System.Windows.Forms.TextBox();
            this.pasport_numberTextBox = new System.Windows.Forms.TextBox();
            this.phone_numberTextBox = new System.Windows.Forms.TextBox();
            this.bank_detailsTextBox = new System.Windows.Forms.TextBox();
            this.individual_tax_numberTextBox = new System.Windows.Forms.TextBox();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.addOrEditButton = new System.Windows.Forms.Button();
            this.mainPropertyTypeComboBox = new System.Windows.Forms.ComboBox();
            this.economicalActivityComboBox = new System.Windows.Forms.ComboBox();
            full_nameLabel = new System.Windows.Forms.Label();
            pasport_numberLabel = new System.Windows.Forms.Label();
            phone_numberLabel = new System.Windows.Forms.Label();
            bank_detailsLabel = new System.Windows.Forms.Label();
            individual_tax_numberLabel = new System.Windows.Forms.Label();
            main_property_typeLabel = new System.Windows.Forms.Label();
            economical_activityLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.laborExchangeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // full_nameLabel
            // 
            full_nameLabel.AutoSize = true;
            full_nameLabel.Location = new System.Drawing.Point(15, 35);
            full_nameLabel.Name = "full_nameLabel";
            full_nameLabel.Size = new System.Drawing.Size(55, 13);
            full_nameLabel.TabIndex = 3;
            full_nameLabel.Text = "Full name:";
            // 
            // pasport_numberLabel
            // 
            pasport_numberLabel.AutoSize = true;
            pasport_numberLabel.Location = new System.Drawing.Point(15, 61);
            pasport_numberLabel.Name = "pasport_numberLabel";
            pasport_numberLabel.Size = new System.Drawing.Size(84, 13);
            pasport_numberLabel.TabIndex = 5;
            pasport_numberLabel.Text = "Pasport number:";
            // 
            // phone_numberLabel
            // 
            phone_numberLabel.AutoSize = true;
            phone_numberLabel.Location = new System.Drawing.Point(15, 87);
            phone_numberLabel.Name = "phone_numberLabel";
            phone_numberLabel.Size = new System.Drawing.Size(79, 13);
            phone_numberLabel.TabIndex = 7;
            phone_numberLabel.Text = "Phone number:";
            // 
            // bank_detailsLabel
            // 
            bank_detailsLabel.AutoSize = true;
            bank_detailsLabel.Location = new System.Drawing.Point(15, 113);
            bank_detailsLabel.Name = "bank_detailsLabel";
            bank_detailsLabel.Size = new System.Drawing.Size(68, 13);
            bank_detailsLabel.TabIndex = 9;
            bank_detailsLabel.Text = "Bank details:";
            // 
            // individual_tax_numberLabel
            // 
            individual_tax_numberLabel.AutoSize = true;
            individual_tax_numberLabel.Location = new System.Drawing.Point(15, 139);
            individual_tax_numberLabel.Name = "individual_tax_numberLabel";
            individual_tax_numberLabel.Size = new System.Drawing.Size(110, 13);
            individual_tax_numberLabel.TabIndex = 11;
            individual_tax_numberLabel.Text = "Individual tax number:";
            // 
            // main_property_typeLabel
            // 
            main_property_typeLabel.AutoSize = true;
            main_property_typeLabel.Location = new System.Drawing.Point(15, 165);
            main_property_typeLabel.Name = "main_property_typeLabel";
            main_property_typeLabel.Size = new System.Drawing.Size(97, 13);
            main_property_typeLabel.TabIndex = 13;
            main_property_typeLabel.Text = "Main property type:";
            // 
            // economical_activityLabel
            // 
            economical_activityLabel.AutoSize = true;
            economical_activityLabel.Location = new System.Drawing.Point(15, 191);
            economical_activityLabel.Name = "economical_activityLabel";
            economical_activityLabel.Size = new System.Drawing.Size(101, 13);
            economical_activityLabel.TabIndex = 15;
            economical_activityLabel.Text = "Economical activity:";
            // 
            // laborExchangeDataSet
            // 
            this.laborExchangeDataSet.DataSetName = "LaborExchangeDataSet";
            this.laborExchangeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employerBindingSource
            // 
            this.employerBindingSource.DataMember = "Employer";
            this.employerBindingSource.DataSource = this.laborExchangeDataSet;
            // 
            // employerTableAdapter
            // 
            this.employerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EmployeeTableAdapter = null;
            this.tableAdapterManager.EmployerTableAdapter = this.employerTableAdapter;
            this.tableAdapterManager.UpdateOrder = JobCentre.LaborExchangeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Vacancy_requestTableAdapter = null;
            this.tableAdapterManager.VacancyTableAdapter = null;
            // 
            // full_nameTextBox
            // 
            this.full_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employerBindingSource, "Full name", true));
            this.full_nameTextBox.Location = new System.Drawing.Point(131, 32);
            this.full_nameTextBox.Name = "full_nameTextBox";
            this.full_nameTextBox.Size = new System.Drawing.Size(125, 20);
            this.full_nameTextBox.TabIndex = 4;
            // 
            // pasport_numberTextBox
            // 
            this.pasport_numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employerBindingSource, "Pasport number", true));
            this.pasport_numberTextBox.Location = new System.Drawing.Point(131, 58);
            this.pasport_numberTextBox.Name = "pasport_numberTextBox";
            this.pasport_numberTextBox.Size = new System.Drawing.Size(125, 20);
            this.pasport_numberTextBox.TabIndex = 6;
            // 
            // phone_numberTextBox
            // 
            this.phone_numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employerBindingSource, "Phone number", true));
            this.phone_numberTextBox.Location = new System.Drawing.Point(131, 84);
            this.phone_numberTextBox.Name = "phone_numberTextBox";
            this.phone_numberTextBox.Size = new System.Drawing.Size(125, 20);
            this.phone_numberTextBox.TabIndex = 8;
            // 
            // bank_detailsTextBox
            // 
            this.bank_detailsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employerBindingSource, "Bank details", true));
            this.bank_detailsTextBox.Location = new System.Drawing.Point(131, 110);
            this.bank_detailsTextBox.Name = "bank_detailsTextBox";
            this.bank_detailsTextBox.Size = new System.Drawing.Size(125, 20);
            this.bank_detailsTextBox.TabIndex = 10;
            // 
            // individual_tax_numberTextBox
            // 
            this.individual_tax_numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employerBindingSource, "Individual tax number", true));
            this.individual_tax_numberTextBox.Location = new System.Drawing.Point(131, 136);
            this.individual_tax_numberTextBox.Name = "individual_tax_numberTextBox";
            this.individual_tax_numberTextBox.Size = new System.Drawing.Size(125, 20);
            this.individual_tax_numberTextBox.TabIndex = 12;
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Location = new System.Drawing.Point(100, 9);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(75, 13);
            this.HeaderLabel.TabIndex = 17;
            this.HeaderLabel.Text = "Add: Employer";
            // 
            // addOrEditButton
            // 
            this.addOrEditButton.Location = new System.Drawing.Point(103, 214);
            this.addOrEditButton.Name = "addOrEditButton";
            this.addOrEditButton.Size = new System.Drawing.Size(79, 26);
            this.addOrEditButton.TabIndex = 18;
            this.addOrEditButton.Text = "Add";
            this.addOrEditButton.UseVisualStyleBackColor = true;
            this.addOrEditButton.Click += new System.EventHandler(this.addOrEditButton_Click);
            // 
            // mainPropertyTypeComboBox
            // 
            this.mainPropertyTypeComboBox.FormattingEnabled = true;
            this.mainPropertyTypeComboBox.Items.AddRange(new object[] {
            "Physical",
            "Legal"});
            this.mainPropertyTypeComboBox.Location = new System.Drawing.Point(131, 162);
            this.mainPropertyTypeComboBox.Name = "mainPropertyTypeComboBox";
            this.mainPropertyTypeComboBox.Size = new System.Drawing.Size(125, 21);
            this.mainPropertyTypeComboBox.TabIndex = 19;
            // 
            // economicalActivityComboBox
            // 
            this.economicalActivityComboBox.FormattingEnabled = true;
            this.economicalActivityComboBox.Items.AddRange(new object[] {
            "A: Forestry",
            "B: Fishing",
            "C: Mining",
            "D: Recycling",
            "E: Power Generation",
            "F: Building",
            "G: Trade",
            "H: Hote Activity",
            "I: Communication",
            "J: Finances",
            "K: Real Eastate",
            "L: Government",
            "M: Education",
            "N: Health Care",
            "O: Service Providing",
            "P: Housekeeping",
            "Q: Extra-territorial"});
            this.economicalActivityComboBox.Location = new System.Drawing.Point(131, 187);
            this.economicalActivityComboBox.Name = "economicalActivityComboBox";
            this.economicalActivityComboBox.Size = new System.Drawing.Size(125, 21);
            this.economicalActivityComboBox.TabIndex = 20;
            // 
            // AddEmployer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 247);
            this.Controls.Add(this.economicalActivityComboBox);
            this.Controls.Add(this.mainPropertyTypeComboBox);
            this.Controls.Add(this.addOrEditButton);
            this.Controls.Add(this.HeaderLabel);
            this.Controls.Add(full_nameLabel);
            this.Controls.Add(this.full_nameTextBox);
            this.Controls.Add(pasport_numberLabel);
            this.Controls.Add(this.pasport_numberTextBox);
            this.Controls.Add(phone_numberLabel);
            this.Controls.Add(this.phone_numberTextBox);
            this.Controls.Add(bank_detailsLabel);
            this.Controls.Add(this.bank_detailsTextBox);
            this.Controls.Add(individual_tax_numberLabel);
            this.Controls.Add(this.individual_tax_numberTextBox);
            this.Controls.Add(main_property_typeLabel);
            this.Controls.Add(economical_activityLabel);
            this.Name = "AddEmployer";
            this.Text = "AddEmployer";
            this.Load += new System.EventHandler(this.AddEmployer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.laborExchangeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LaborExchangeDataSet laborExchangeDataSet;
        private System.Windows.Forms.BindingSource employerBindingSource;
        private LaborExchangeDataSetTableAdapters.EmployerTableAdapter employerTableAdapter;
        private LaborExchangeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox full_nameTextBox;
        private System.Windows.Forms.TextBox pasport_numberTextBox;
        private System.Windows.Forms.TextBox phone_numberTextBox;
        private System.Windows.Forms.TextBox bank_detailsTextBox;
        private System.Windows.Forms.TextBox individual_tax_numberTextBox;
        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Button addOrEditButton;
        private System.Windows.Forms.ComboBox mainPropertyTypeComboBox;
        private System.Windows.Forms.ComboBox economicalActivityComboBox;
    }
}