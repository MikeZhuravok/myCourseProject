namespace JobCentre.Views
{
    partial class ProfessionsStatisticsView
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
            this.statisticsDataGridView = new System.Windows.Forms.DataGridView();
            this.headerLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.statisticsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // statisticsDataGridView
            // 
            this.statisticsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.statisticsDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statisticsDataGridView.Location = new System.Drawing.Point(0, 66);
            this.statisticsDataGridView.Name = "statisticsDataGridView";
            this.statisticsDataGridView.Size = new System.Drawing.Size(597, 332);
            this.statisticsDataGridView.TabIndex = 0;
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.headerLabel.Location = new System.Drawing.Point(167, 23);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(246, 20);
            this.headerLabel.TabIndex = 1;
            this.headerLabel.Text = "Statistics for different professions";
            // 
            // ProfessionsStatisticsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 398);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.statisticsDataGridView);
            this.Name = "ProfessionsStatisticsView";
            this.Text = "AverageSalaryView";
            ((System.ComponentModel.ISupportInitialize)(this.statisticsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView statisticsDataGridView;
        private System.Windows.Forms.Label headerLabel;
    }
}