namespace BadmintonManagement.Forms.Report
{
    partial class CustomerReport
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnShowReport = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpMonth = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtbStart = new System.Windows.Forms.DateTimePicker();
            this.rdbDay = new System.Windows.Forms.RadioButton();
            this.rdbMonth = new System.Windows.Forms.RadioButton();
            this.rptIncome = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rptCustomer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnShowReport);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpMonth);
            this.groupBox1.Controls.Add(this.dtpEnd);
            this.groupBox1.Controls.Add(this.dtbStart);
            this.groupBox1.Controls.Add(this.rdbDay);
            this.groupBox1.Controls.Add(this.rdbMonth);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(710, 77);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thời gian";
            // 
            // btnShowReport
            // 
            this.btnShowReport.Location = new System.Drawing.Point(608, 40);
            this.btnShowReport.Name = "btnShowReport";
            this.btnShowReport.Size = new System.Drawing.Size(63, 20);
            this.btnShowReport.TabIndex = 7;
            this.btnShowReport.Text = "Thống kê";
            this.btnShowReport.UseVisualStyleBackColor = true;
            this.btnShowReport.Click += new System.EventHandler(this.btnShowReport_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(394, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Đến ngày";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Từ ngày";
            // 
            // dtpMonth
            // 
            this.dtpMonth.CustomFormat = "MM/yyyy";
            this.dtpMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMonth.Location = new System.Drawing.Point(243, 16);
            this.dtpMonth.Name = "dtpMonth";
            this.dtpMonth.Size = new System.Drawing.Size(137, 20);
            this.dtpMonth.TabIndex = 4;
            // 
            // dtpEnd
            // 
            this.dtpEnd.CustomFormat = "dd/MM/yyyy";
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(453, 40);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(137, 20);
            this.dtpEnd.TabIndex = 3;
            // 
            // dtbStart
            // 
            this.dtbStart.CustomFormat = "dd/MM/yyyy";
            this.dtbStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtbStart.Location = new System.Drawing.Point(243, 40);
            this.dtbStart.Name = "dtbStart";
            this.dtbStart.Size = new System.Drawing.Size(137, 20);
            this.dtbStart.TabIndex = 2;
            // 
            // rdbDay
            // 
            this.rdbDay.AutoSize = true;
            this.rdbDay.Location = new System.Drawing.Point(52, 43);
            this.rdbDay.Name = "rdbDay";
            this.rdbDay.Size = new System.Drawing.Size(121, 17);
            this.rdbDay.TabIndex = 1;
            this.rdbDay.TabStop = true;
            this.rdbDay.Text = "Thống kê theo ngày";
            this.rdbDay.UseVisualStyleBackColor = true;
            // 
            // rdbMonth
            // 
            this.rdbMonth.AutoSize = true;
            this.rdbMonth.Location = new System.Drawing.Point(52, 19);
            this.rdbMonth.Name = "rdbMonth";
            this.rdbMonth.Size = new System.Drawing.Size(125, 17);
            this.rdbMonth.TabIndex = 0;
            this.rdbMonth.TabStop = true;
            this.rdbMonth.Text = "Thống kê theo tháng";
            this.rdbMonth.UseVisualStyleBackColor = true;
            // 
            // rptIncome
            // 
            this.rptIncome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptIncome.Location = new System.Drawing.Point(0, 0);
            this.rptIncome.Name = "rptIncome";
            this.rptIncome.ServerReport.BearerToken = null;
            this.rptIncome.Size = new System.Drawing.Size(710, 411);
            this.rptIncome.TabIndex = 3;
            // 
            // rptCustomer
            // 
            this.rptCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptCustomer.Location = new System.Drawing.Point(0, 77);
            this.rptCustomer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rptCustomer.Name = "rptCustomer";
            this.rptCustomer.ServerReport.BearerToken = null;
            this.rptCustomer.Size = new System.Drawing.Size(710, 334);
            this.rptCustomer.TabIndex = 4;
            // 
            // CustomerReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 411);
            this.Controls.Add(this.rptCustomer);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rptIncome);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CustomerReport";
            this.Text = "CustomerReport";
            this.Load += new System.EventHandler(this.CustomerReport_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnShowReport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpMonth;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtbStart;
        private System.Windows.Forms.RadioButton rdbDay;
        private System.Windows.Forms.RadioButton rdbMonth;
        private Microsoft.Reporting.WinForms.ReportViewer rptIncome;
        private Microsoft.Reporting.WinForms.ReportViewer rptCustomer;
    }
}