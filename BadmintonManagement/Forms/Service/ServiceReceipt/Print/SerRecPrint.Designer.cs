﻿namespace BadmintonManagement.Forms.Service.ServiceReceipt.Print
{
    partial class SerRecPrint
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
            this.rpvPrint = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpvPrint
            // 
            this.rpvPrint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvPrint.LocalReport.ReportEmbeddedResource = "BadmintonManagement.SerRecPrintReport.rdlc";
            this.rpvPrint.Location = new System.Drawing.Point(0, 0);
            this.rpvPrint.Name = "rpvPrint";
            this.rpvPrint.ServerReport.BearerToken = null;
            this.rpvPrint.Size = new System.Drawing.Size(800, 450);
            this.rpvPrint.TabIndex = 0;
            this.rpvPrint.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // SerRecPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rpvPrint);
            this.Name = "SerRecPrint";
            this.Text = "SerRecPrint";
            this.Load += new System.EventHandler(this.SerRecPrint_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvPrint;
    }
}