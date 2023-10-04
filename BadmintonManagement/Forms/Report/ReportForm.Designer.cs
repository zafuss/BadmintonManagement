namespace BadmintonManagement.Forms.Report
{
    partial class ReportForm
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
            this.btnCustomerReport = new System.Windows.Forms.Button();
            this.pnlReceiptReport = new System.Windows.Forms.Panel();
            this.btnServiceReceipt = new System.Windows.Forms.Button();
            this.btnCourtReceipt = new System.Windows.Forms.Button();
            this.btnReceipt = new System.Windows.Forms.Button();
            this.btnIncome = new System.Windows.Forms.Button();
            this.pnlIncome = new System.Windows.Forms.Panel();
            this.pnlViewreport = new System.Windows.Forms.Panel();
            this.btnReservationReport = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnlReceiptReport.SuspendLayout();
            this.pnlIncome.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.btnReservationReport);
            this.panel1.Controls.Add(this.btnCustomerReport);
            this.panel1.Controls.Add(this.pnlReceiptReport);
            this.panel1.Controls.Add(this.btnReceipt);
            this.panel1.Controls.Add(this.btnIncome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(191, 620);
            this.panel1.TabIndex = 0;
            // 
            // btnCustomerReport
            // 
            this.btnCustomerReport.BackColor = System.Drawing.Color.LightGray;
            this.btnCustomerReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCustomerReport.FlatAppearance.BorderSize = 0;
            this.btnCustomerReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerReport.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnCustomerReport.Location = new System.Drawing.Point(0, 193);
            this.btnCustomerReport.Name = "btnCustomerReport";
            this.btnCustomerReport.Size = new System.Drawing.Size(191, 44);
            this.btnCustomerReport.TabIndex = 5;
            this.btnCustomerReport.Text = "Thống kê khách hàng";
            this.btnCustomerReport.UseVisualStyleBackColor = false;
            this.btnCustomerReport.Click += new System.EventHandler(this.btnCustomerReport_Click);
            // 
            // pnlReceiptReport
            // 
            this.pnlReceiptReport.Controls.Add(this.btnServiceReceipt);
            this.pnlReceiptReport.Controls.Add(this.btnCourtReceipt);
            this.pnlReceiptReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlReceiptReport.Location = new System.Drawing.Point(0, 96);
            this.pnlReceiptReport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlReceiptReport.Name = "pnlReceiptReport";
            this.pnlReceiptReport.Size = new System.Drawing.Size(191, 97);
            this.pnlReceiptReport.TabIndex = 4;
            // 
            // btnServiceReceipt
            // 
            this.btnServiceReceipt.BackColor = System.Drawing.Color.Gainsboro;
            this.btnServiceReceipt.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnServiceReceipt.FlatAppearance.BorderSize = 0;
            this.btnServiceReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServiceReceipt.Location = new System.Drawing.Point(0, 46);
            this.btnServiceReceipt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnServiceReceipt.Name = "btnServiceReceipt";
            this.btnServiceReceipt.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnServiceReceipt.Size = new System.Drawing.Size(191, 46);
            this.btnServiceReceipt.TabIndex = 1;
            this.btnServiceReceipt.Text = "Hóa đơn dịch vụ";
            this.btnServiceReceipt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnServiceReceipt.UseVisualStyleBackColor = false;
            this.btnServiceReceipt.Click += new System.EventHandler(this.btnServiceReceipt_Click);
            // 
            // btnCourtReceipt
            // 
            this.btnCourtReceipt.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCourtReceipt.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCourtReceipt.FlatAppearance.BorderSize = 0;
            this.btnCourtReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCourtReceipt.Location = new System.Drawing.Point(0, 0);
            this.btnCourtReceipt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCourtReceipt.Name = "btnCourtReceipt";
            this.btnCourtReceipt.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnCourtReceipt.Size = new System.Drawing.Size(191, 46);
            this.btnCourtReceipt.TabIndex = 0;
            this.btnCourtReceipt.Text = "Hóa đơn sân";
            this.btnCourtReceipt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCourtReceipt.UseVisualStyleBackColor = false;
            this.btnCourtReceipt.Click += new System.EventHandler(this.btnCourtReceipt_Click);
            // 
            // btnReceipt
            // 
            this.btnReceipt.BackColor = System.Drawing.Color.LightGray;
            this.btnReceipt.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReceipt.FlatAppearance.BorderSize = 0;
            this.btnReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceipt.Location = new System.Drawing.Point(0, 48);
            this.btnReceipt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReceipt.Name = "btnReceipt";
            this.btnReceipt.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnReceipt.Size = new System.Drawing.Size(191, 48);
            this.btnReceipt.TabIndex = 3;
            this.btnReceipt.Text = "Thống kê hóa đơn";
            this.btnReceipt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReceipt.UseVisualStyleBackColor = false;
            this.btnReceipt.Click += new System.EventHandler(this.btnReceipt_Click);
            // 
            // btnIncome
            // 
            this.btnIncome.BackColor = System.Drawing.Color.LightGray;
            this.btnIncome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnIncome.FlatAppearance.BorderSize = 0;
            this.btnIncome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncome.Location = new System.Drawing.Point(0, 0);
            this.btnIncome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnIncome.Name = "btnIncome";
            this.btnIncome.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnIncome.Size = new System.Drawing.Size(191, 48);
            this.btnIncome.TabIndex = 2;
            this.btnIncome.Text = "Thống kê doanh thu";
            this.btnIncome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIncome.UseVisualStyleBackColor = false;
            this.btnIncome.Click += new System.EventHandler(this.btnIncome_Click);
            // 
            // pnlIncome
            // 
            this.pnlIncome.Controls.Add(this.pnlViewreport);
            this.pnlIncome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlIncome.Location = new System.Drawing.Point(191, 0);
            this.pnlIncome.Name = "pnlIncome";
            this.pnlIncome.Size = new System.Drawing.Size(975, 620);
            this.pnlIncome.TabIndex = 1;
            // 
            // pnlViewreport
            // 
            this.pnlViewreport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlViewreport.Location = new System.Drawing.Point(0, 0);
            this.pnlViewreport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlViewreport.Name = "pnlViewreport";
            this.pnlViewreport.Size = new System.Drawing.Size(975, 620);
            this.pnlViewreport.TabIndex = 1;
            // 
            // btnReservationReport
            // 
            this.btnReservationReport.BackColor = System.Drawing.Color.LightGray;
            this.btnReservationReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReservationReport.FlatAppearance.BorderSize = 0;
            this.btnReservationReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservationReport.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnReservationReport.Location = new System.Drawing.Point(0, 237);
            this.btnReservationReport.Name = "btnReservationReport";
            this.btnReservationReport.Size = new System.Drawing.Size(191, 44);
            this.btnReservationReport.TabIndex = 6;
            this.btnReservationReport.Text = "Thống kê phiếu đặt sân";
            this.btnReservationReport.UseVisualStyleBackColor = false;
            this.btnReservationReport.Click += new System.EventHandler(this.button1_Click);
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 620);
            this.Controls.Add(this.pnlIncome);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ReportForm";
            this.Text = "Thống Kê";
            this.panel1.ResumeLayout(false);
            this.pnlReceiptReport.ResumeLayout(false);
            this.pnlIncome.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlIncome;
        private System.Windows.Forms.Button btnIncome;
        private System.Windows.Forms.Panel pnlViewreport;
        private System.Windows.Forms.Button btnReceipt;
        private System.Windows.Forms.Panel pnlReceiptReport;
        private System.Windows.Forms.Button btnServiceReceipt;
        private System.Windows.Forms.Button btnCourtReceipt;
        private System.Windows.Forms.Button btnCustomerReport;
        private System.Windows.Forms.Button btnReservationReport;
    }
}