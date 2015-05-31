namespace JobCentre.Views
{
    partial class Sql_query_editor
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
            this.sqlRichTextBox = new System.Windows.Forms.RichTextBox();
            this.doSQLButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.sqlQueryDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.sqlQueryDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // sqlRichTextBox
            // 
            this.sqlRichTextBox.Location = new System.Drawing.Point(14, 14);
            this.sqlRichTextBox.Name = "sqlRichTextBox";
            this.sqlRichTextBox.Size = new System.Drawing.Size(491, 99);
            this.sqlRichTextBox.TabIndex = 0;
            this.sqlRichTextBox.Text = "";
            // 
            // doSQLButton
            // 
            this.doSQLButton.Location = new System.Drawing.Point(526, 14);
            this.doSQLButton.Name = "doSQLButton";
            this.doSQLButton.Size = new System.Drawing.Size(106, 39);
            this.doSQLButton.TabIndex = 1;
            this.doSQLButton.Text = "Do sql";
            this.doSQLButton.UseVisualStyleBackColor = true;
            this.doSQLButton.Click += new System.EventHandler(this.doSQLButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(526, 74);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(106, 39);
            this.ClearButton.TabIndex = 2;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // sqlQueryDataGridView
            // 
            this.sqlQueryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sqlQueryDataGridView.Location = new System.Drawing.Point(14, 143);
            this.sqlQueryDataGridView.Name = "sqlQueryDataGridView";
            this.sqlQueryDataGridView.Size = new System.Drawing.Size(618, 300);
            this.sqlQueryDataGridView.TabIndex = 3;
            // 
            // Sql_query_editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 455);
            this.Controls.Add(this.sqlQueryDataGridView);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.doSQLButton);
            this.Controls.Add(this.sqlRichTextBox);
            this.Name = "Sql_query_editor";
            this.Text = "Sql_query_editor";
            ((System.ComponentModel.ISupportInitialize)(this.sqlQueryDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox sqlRichTextBox;
        private System.Windows.Forms.Button doSQLButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.DataGridView sqlQueryDataGridView;
    }
}