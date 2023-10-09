namespace BadmintonManagement.Forms.Report
{
    partial class IncomeForm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.incomeOfYear = new BadmintonManagement.IncomeOfYear();
            this.incomeOfYearBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.incomeOfYearTableAdapter = new BadmintonManagement.IncomeOfYearTableAdapters.IncomeOfYearTableAdapter();
            this.incomeOfYearBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dtpYear = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.incomeOfYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomeOfYearBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomeOfYearBindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "IncomeOfYear";
            reportDataSource1.Value = this.incomeOfYearBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BadmintonManagement.ReportIncome.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 53);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(964, 475);
            this.reportViewer1.TabIndex = 0;
            // 
            // incomeOfYear
            // 
            this.incomeOfYear.DataSetName = "IncomeOfYear";
            this.incomeOfYear.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // incomeOfYearBindingSource
            // 
            this.incomeOfYearBindingSource.DataMember = "IncomeOfYear";
            this.incomeOfYearBindingSource.DataSource = this.incomeOfYear;
            // 
            // incomeOfYearTableAdapter
            // 
            this.incomeOfYearTableAdapter.ClearBeforeFill = true;
            // 
            // incomeOfYearBindingSource1
            // 
            this.incomeOfYearBindingSource1.DataMember = "IncomeOfYear";
            this.incomeOfYearBindingSource1.DataSource = this.incomeOfYear;
            // 
            // dtpYear
            // 
            this.dtpYear.CustomFormat = "yyyy";
            this.dtpYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpYear.Location = new System.Drawing.Point(98, 12);
            this.dtpYear.Name = "dtpYear";
            this.dtpYear.Size = new System.Drawing.Size(145, 26);
            this.dtpYear.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtpYear);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(964, 53);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Năm ";
            // 
            // IncomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 528);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel1);
            this.Name = "IncomeForm";
            this.Text = "IncomeForm";
            this.Load += new System.EventHandler(this.IncomeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.incomeOfYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomeOfYearBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomeOfYearBindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource incomeOfYearBindingSource;
        private IncomeOfYear incomeOfYear;
        private IncomeOfYearTableAdapters.IncomeOfYearTableAdapter incomeOfYearTableAdapter;
        private System.Windows.Forms.BindingSource incomeOfYearBindingSource1;
        private System.Windows.Forms.DateTimePicker dtpYear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}