﻿namespace JobCentre.Views
{
    partial class VacanciesView
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
            this.vacanciesDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.scopeComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.vacanciesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // vacanciesDataGridView
            // 
            this.vacanciesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.vacanciesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vacanciesDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.vacanciesDataGridView.Location = new System.Drawing.Point(0, 41);
            this.vacanciesDataGridView.Name = "vacanciesDataGridView";
            this.vacanciesDataGridView.Size = new System.Drawing.Size(594, 399);
            this.vacanciesDataGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Scope";
            // 
            // scopeComboBox
            // 
            this.scopeComboBox.FormattingEnabled = true;
            this.scopeComboBox.Location = new System.Drawing.Point(225, 12);
            this.scopeComboBox.Name = "scopeComboBox";
            this.scopeComboBox.Size = new System.Drawing.Size(121, 21);
            this.scopeComboBox.TabIndex = 2;
            this.scopeComboBox.SelectedIndexChanged += new System.EventHandler(this.scopeComboBox_SelectedIndexChanged);
            // 
            // VacanciesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 440);
            this.Controls.Add(this.scopeComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vacanciesDataGridView);
            this.Name = "VacanciesView";
            this.Text = "VacansiesView";
            ((System.ComponentModel.ISupportInitialize)(this.vacanciesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView vacanciesDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox scopeComboBox;
    }
}