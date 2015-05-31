namespace JobCentre.Views
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dataBasesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataBasesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sqlQueryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.freeVacancysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vacancyInterviewsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RefreshViewButton = new System.Windows.Forms.Button();
            this.AvgSlryDataGridView = new System.Windows.Forms.DataGridView();
            this.avgSalarylabel = new System.Windows.Forms.Label();
            this.interviewsReportSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.employerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vacancyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vacancyRequestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AvgSlryDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataBasesToolStripMenuItem,
            this.addToolStripMenuItem,
            this.statisticsToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dataBasesToolStripMenuItem
            // 
            this.dataBasesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataBasesToolStripMenuItem1,
            this.sqlQueryToolStripMenuItem});
            this.dataBasesToolStripMenuItem.Name = "dataBasesToolStripMenuItem";
            this.dataBasesToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.dataBasesToolStripMenuItem.Text = "Data";
            // 
            // dataBasesToolStripMenuItem1
            // 
            this.dataBasesToolStripMenuItem1.Name = "dataBasesToolStripMenuItem1";
            this.dataBasesToolStripMenuItem1.Size = new System.Drawing.Size(136, 22);
            this.dataBasesToolStripMenuItem1.Text = "DataBases...";
            this.dataBasesToolStripMenuItem1.Click += new System.EventHandler(this.dataBasesToolStripMenuItem1_Click);
            // 
            // sqlQueryToolStripMenuItem
            // 
            this.sqlQueryToolStripMenuItem.Name = "sqlQueryToolStripMenuItem";
            this.sqlQueryToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.sqlQueryToolStripMenuItem.Text = "Sql Query";
            this.sqlQueryToolStripMenuItem.Click += new System.EventHandler(this.sqlQueryToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeToolStripMenuItem,
            this.employerToolStripMenuItem,
            this.vacancyToolStripMenuItem,
            this.vacancyRequestToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.employeeToolStripMenuItem.Text = "Employee...";
            this.employeeToolStripMenuItem.Click += new System.EventHandler(this.employeeToolStripMenuItem_Click);
            // 
            // statisticsToolStripMenuItem
            // 
            this.statisticsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.freeVacancysToolStripMenuItem});
            this.statisticsToolStripMenuItem.Name = "statisticsToolStripMenuItem";
            this.statisticsToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.statisticsToolStripMenuItem.Text = "Statistics";
            // 
            // freeVacancysToolStripMenuItem
            // 
            this.freeVacancysToolStripMenuItem.Name = "freeVacancysToolStripMenuItem";
            this.freeVacancysToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.freeVacancysToolStripMenuItem.Text = "Vacancies";
            this.freeVacancysToolStripMenuItem.Click += new System.EventHandler(this.freeVacancysToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vacancyInterviewsToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // vacancyInterviewsToolStripMenuItem
            // 
            this.vacancyInterviewsToolStripMenuItem.Name = "vacancyInterviewsToolStripMenuItem";
            this.vacancyInterviewsToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.vacancyInterviewsToolStripMenuItem.Text = "Vacancy interviews";
            this.vacancyInterviewsToolStripMenuItem.Click += new System.EventHandler(this.vacancyInterviewsToolStripMenuItem_Click);
            // 
            // RefreshViewButton
            // 
            this.RefreshViewButton.Location = new System.Drawing.Point(349, 495);
            this.RefreshViewButton.Name = "RefreshViewButton";
            this.RefreshViewButton.Size = new System.Drawing.Size(75, 23);
            this.RefreshViewButton.TabIndex = 2;
            this.RefreshViewButton.Text = "Refresh";
            this.RefreshViewButton.UseVisualStyleBackColor = true;
            this.RefreshViewButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // AvgSlryDataGridView
            // 
            this.AvgSlryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AvgSlryDataGridView.Location = new System.Drawing.Point(12, 67);
            this.AvgSlryDataGridView.Name = "AvgSlryDataGridView";
            this.AvgSlryDataGridView.Size = new System.Drawing.Size(772, 422);
            this.AvgSlryDataGridView.TabIndex = 0;
            // 
            // avgSalarylabel
            // 
            this.avgSalarylabel.AutoSize = true;
            this.avgSalarylabel.Location = new System.Drawing.Point(295, 36);
            this.avgSalarylabel.Name = "avgSalarylabel";
            this.avgSalarylabel.Size = new System.Drawing.Size(209, 13);
            this.avgSalarylabel.TabIndex = 3;
            this.avgSalarylabel.Text = "Professions count form different companies";
            // 
            // employerToolStripMenuItem
            // 
            this.employerToolStripMenuItem.Name = "employerToolStripMenuItem";
            this.employerToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.employerToolStripMenuItem.Text = "Employer...";
            this.employerToolStripMenuItem.Click += new System.EventHandler(this.employerToolStripMenuItem_Click);
            // 
            // vacancyToolStripMenuItem
            // 
            this.vacancyToolStripMenuItem.Name = "vacancyToolStripMenuItem";
            this.vacancyToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.vacancyToolStripMenuItem.Text = "Vacancy...";
            this.vacancyToolStripMenuItem.Click += new System.EventHandler(this.vacancyToolStripMenuItem_Click);
            // 
            // vacancyRequestToolStripMenuItem
            // 
            this.vacancyRequestToolStripMenuItem.Name = "vacancyRequestToolStripMenuItem";
            this.vacancyRequestToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.vacancyRequestToolStripMenuItem.Text = "Vacancy request...";
            this.vacancyRequestToolStripMenuItem.Click += new System.EventHandler(this.vacancyRequestToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 529);
            this.Controls.Add(this.avgSalarylabel);
            this.Controls.Add(this.AvgSlryDataGridView);
            this.Controls.Add(this.RefreshViewButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AvgSlryDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dataBasesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataBasesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.DataGridView AvgSlryDataGridView;
        private System.Windows.Forms.Button RefreshViewButton;
        private System.Windows.Forms.ToolStripMenuItem sqlQueryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem freeVacancysToolStripMenuItem;
        private System.Windows.Forms.Label avgSalarylabel;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vacancyInterviewsToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog interviewsReportSaveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem employerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vacancyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vacancyRequestToolStripMenuItem;
    }
}

