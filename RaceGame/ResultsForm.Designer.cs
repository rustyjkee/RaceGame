namespace Race
{
    partial class ResultsForm
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
            resultsDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)resultsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // resultsDataGridView
            // 
            resultsDataGridView.AllowUserToAddRows = false;
            resultsDataGridView.AllowUserToDeleteRows = false;
            resultsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resultsDataGridView.Location = new Point(0, 0);
            resultsDataGridView.MaximumSize = new Size(455, 300);
            resultsDataGridView.MinimumSize = new Size(455, 300);
            resultsDataGridView.Name = "resultsDataGridView";
            resultsDataGridView.ReadOnly = true;
            resultsDataGridView.RowTemplate.Height = 25;
            resultsDataGridView.Size = new Size(455, 300);
            resultsDataGridView.TabIndex = 0;
            // 
            // ResultsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 305);
            Controls.Add(resultsDataGridView);
            MaximizeBox = false;
            MaximumSize = new Size(472, 344);
            MinimizeBox = false;
            MinimumSize = new Size(472, 344);
            Name = "ResultsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Результаты игр";
            Load += ResultsForm_Load;
            ((System.ComponentModel.ISupportInitialize)resultsDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView resultsDataGridView;
    }
}