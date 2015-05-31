namespace JobCentre.Views
{
    partial class EmployerFilterForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FromEmployerIdTextBox = new System.Windows.Forms.TextBox();
            this.ToEmployerIdTextBox = new System.Windows.Forms.TextBox();
            this.FilterButton = new System.Windows.Forms.Button();
            this.hasVacanciesCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose fields for filtering";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employer\'s ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "From";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(153, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "To";
            // 
            // FromEmployerIdTextBox
            // 
            this.FromEmployerIdTextBox.Location = new System.Drawing.Point(15, 93);
            this.FromEmployerIdTextBox.Name = "FromEmployerIdTextBox";
            this.FromEmployerIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.FromEmployerIdTextBox.TabIndex = 4;
            // 
            // ToEmployerIdTextBox
            // 
            this.ToEmployerIdTextBox.Location = new System.Drawing.Point(156, 93);
            this.ToEmployerIdTextBox.Name = "ToEmployerIdTextBox";
            this.ToEmployerIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.ToEmployerIdTextBox.TabIndex = 5;
            // 
            // FilterButton
            // 
            this.FilterButton.Location = new System.Drawing.Point(98, 166);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(75, 23);
            this.FilterButton.TabIndex = 6;
            this.FilterButton.Text = "Filter";
            this.FilterButton.UseVisualStyleBackColor = true;
            this.FilterButton.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // hasVacanciesCheckBox
            // 
            this.hasVacanciesCheckBox.AutoSize = true;
            this.hasVacanciesCheckBox.Location = new System.Drawing.Point(15, 128);
            this.hasVacanciesCheckBox.Name = "hasVacanciesCheckBox";
            this.hasVacanciesCheckBox.Size = new System.Drawing.Size(116, 17);
            this.hasVacanciesCheckBox.TabIndex = 14;
            this.hasVacanciesCheckBox.Text = "has free vacancies";
            this.hasVacanciesCheckBox.UseVisualStyleBackColor = true;
            // 
            // EmployerFilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 215);
            this.Controls.Add(this.hasVacanciesCheckBox);
            this.Controls.Add(this.FilterButton);
            this.Controls.Add(this.ToEmployerIdTextBox);
            this.Controls.Add(this.FromEmployerIdTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EmployerFilterForm";
            this.Text = "EmployerFilterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox FromEmployerIdTextBox;
        private System.Windows.Forms.TextBox ToEmployerIdTextBox;
        private System.Windows.Forms.Button FilterButton;
        private System.Windows.Forms.CheckBox hasVacanciesCheckBox;
    }
}