namespace BadmintonManagement.Forms.Report
{
    partial class IncomeReportForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlCustomerReport = new System.Windows.Forms.Panel();
            this.btnYearCostomer = new System.Windows.Forms.Button();
            this.btnMonthCustomer = new System.Windows.Forms.Button();
            this.btnDateCustomer = new System.Windows.Forms.Button();
            this.btnCustomerReport = new System.Windows.Forms.Button();
            this.pnlIncomeDate = new System.Windows.Forms.Panel();
            this.btnYearIncome = new System.Windows.Forms.Button();
            this.btnMonthIncome = new System.Windows.Forms.Button();
            this.btnDateIncome = new System.Windows.Forms.Button();
            this.btnIncomeReport = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.panel1.SuspendLayout();
            this.pnlCustomerReport.SuspendLayout();
            this.pnlIncomeDate.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlCustomerReport);
            this.panel1.Controls.Add(this.btnCustomerReport);
            this.panel1.Controls.Add(this.pnlIncomeDate);
            this.panel1.Controls.Add(this.btnIncomeReport);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 551);
            this.panel1.TabIndex = 0;
            // 
            // pnlCustomerReport
            // 
            this.pnlCustomerReport.Controls.Add(this.btnYearCostomer);
            this.pnlCustomerReport.Controls.Add(this.btnMonthCustomer);
            this.pnlCustomerReport.Controls.Add(this.btnDateCustomer);
            this.pnlCustomerReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCustomerReport.Location = new System.Drawing.Point(0, 224);
            this.pnlCustomerReport.Name = "pnlCustomerReport";
            this.pnlCustomerReport.Size = new System.Drawing.Size(235, 108);
            this.pnlCustomerReport.TabIndex = 5;
            // 
            // btnYearCostomer
            // 
            this.btnYearCostomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnYearCostomer.FlatAppearance.BorderSize = 0;
            this.btnYearCostomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYearCostomer.Location = new System.Drawing.Point(0, 70);
            this.btnYearCostomer.Name = "btnYearCostomer";
            this.btnYearCostomer.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnYearCostomer.Size = new System.Drawing.Size(235, 38);
            this.btnYearCostomer.TabIndex = 5;
            this.btnYearCostomer.Text = "Năm";
            this.btnYearCostomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYearCostomer.UseVisualStyleBackColor = true;
            // 
            // btnMonthCustomer
            // 
            this.btnMonthCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMonthCustomer.FlatAppearance.BorderSize = 0;
            this.btnMonthCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonthCustomer.Location = new System.Drawing.Point(0, 35);
            this.btnMonthCustomer.Name = "btnMonthCustomer";
            this.btnMonthCustomer.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnMonthCustomer.Size = new System.Drawing.Size(235, 35);
            this.btnMonthCustomer.TabIndex = 4;
            this.btnMonthCustomer.Text = "Tháng";
            this.btnMonthCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMonthCustomer.UseVisualStyleBackColor = true;
            // 
            // btnDateCustomer
            // 
            this.btnDateCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDateCustomer.FlatAppearance.BorderSize = 0;
            this.btnDateCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDateCustomer.Location = new System.Drawing.Point(0, 0);
            this.btnDateCustomer.Name = "btnDateCustomer";
            this.btnDateCustomer.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnDateCustomer.Size = new System.Drawing.Size(235, 35);
            this.btnDateCustomer.TabIndex = 3;
            this.btnDateCustomer.Text = "Ngày";
            this.btnDateCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDateCustomer.UseVisualStyleBackColor = true;
            // 
            // btnCustomerReport
            // 
            this.btnCustomerReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCustomerReport.FlatAppearance.BorderSize = 0;
            this.btnCustomerReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerReport.Location = new System.Drawing.Point(0, 184);
            this.btnCustomerReport.Name = "btnCustomerReport";
            this.btnCustomerReport.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCustomerReport.Size = new System.Drawing.Size(235, 40);
            this.btnCustomerReport.TabIndex = 4;
            this.btnCustomerReport.Text = "Thống kê khách hàng";
            this.btnCustomerReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomerReport.UseVisualStyleBackColor = true;
            this.btnCustomerReport.Click += new System.EventHandler(this.btnCustomerReport_Click);
            // 
            // pnlIncomeDate
            // 
            this.pnlIncomeDate.Controls.Add(this.btnYearIncome);
            this.pnlIncomeDate.Controls.Add(this.btnMonthIncome);
            this.pnlIncomeDate.Controls.Add(this.btnDateIncome);
            this.pnlIncomeDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlIncomeDate.Location = new System.Drawing.Point(0, 80);
            this.pnlIncomeDate.Name = "pnlIncomeDate";
            this.pnlIncomeDate.Size = new System.Drawing.Size(235, 104);
            this.pnlIncomeDate.TabIndex = 3;
            // 
            // btnYearIncome
            // 
            this.btnYearIncome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnYearIncome.FlatAppearance.BorderSize = 0;
            this.btnYearIncome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYearIncome.Location = new System.Drawing.Point(0, 70);
            this.btnYearIncome.Name = "btnYearIncome";
            this.btnYearIncome.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnYearIncome.Size = new System.Drawing.Size(235, 35);
            this.btnYearIncome.TabIndex = 2;
            this.btnYearIncome.Text = "Năm";
            this.btnYearIncome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYearIncome.UseVisualStyleBackColor = true;
            // 
            // btnMonthIncome
            // 
            this.btnMonthIncome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMonthIncome.FlatAppearance.BorderSize = 0;
            this.btnMonthIncome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonthIncome.Location = new System.Drawing.Point(0, 35);
            this.btnMonthIncome.Name = "btnMonthIncome";
            this.btnMonthIncome.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnMonthIncome.Size = new System.Drawing.Size(235, 35);
            this.btnMonthIncome.TabIndex = 1;
            this.btnMonthIncome.Text = "Tháng";
            this.btnMonthIncome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMonthIncome.UseVisualStyleBackColor = true;
            // 
            // btnDateIncome
            // 
            this.btnDateIncome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDateIncome.FlatAppearance.BorderSize = 0;
            this.btnDateIncome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDateIncome.Location = new System.Drawing.Point(0, 0);
            this.btnDateIncome.Name = "btnDateIncome";
            this.btnDateIncome.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnDateIncome.Size = new System.Drawing.Size(235, 35);
            this.btnDateIncome.TabIndex = 0;
            this.btnDateIncome.Text = "Ngày";
            this.btnDateIncome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDateIncome.UseVisualStyleBackColor = true;
            this.btnDateIncome.Click += new System.EventHandler(this.btnDateIncome_Click);
            // 
            // btnIncomeReport
            // 
            this.btnIncomeReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnIncomeReport.FlatAppearance.BorderSize = 0;
            this.btnIncomeReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncomeReport.Location = new System.Drawing.Point(0, 40);
            this.btnIncomeReport.Name = "btnIncomeReport";
            this.btnIncomeReport.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnIncomeReport.Size = new System.Drawing.Size(235, 40);
            this.btnIncomeReport.TabIndex = 2;
            this.btnIncomeReport.Text = "Thống kê doanh thu";
            this.btnIncomeReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIncomeReport.UseVisualStyleBackColor = true;
            this.btnIncomeReport.Click += new System.EventHandler(this.btnIncomeReport_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(235, 40);
            this.panel3.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Các loại thống kê";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(235, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(941, 551);
            this.panel2.TabIndex = 1;
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // IncomeReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 551);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "IncomeReportForm";
            this.Text = "Thống Kê";
            this.panel1.ResumeLayout(false);
            this.pnlCustomerReport.ResumeLayout(false);
            this.pnlIncomeDate.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.Panel pnlIncomeDate;
        private System.Windows.Forms.Button btnYearIncome;
        private System.Windows.Forms.Button btnMonthIncome;
        private System.Windows.Forms.Button btnDateIncome;
        private System.Windows.Forms.Button btnIncomeReport;
        private System.Windows.Forms.Panel pnlCustomerReport;
        private System.Windows.Forms.Button btnCustomerReport;
        private System.Windows.Forms.Button btnDateCustomer;
        private System.Windows.Forms.Button btnYearCostomer;
        private System.Windows.Forms.Button btnMonthCustomer;
    }
}