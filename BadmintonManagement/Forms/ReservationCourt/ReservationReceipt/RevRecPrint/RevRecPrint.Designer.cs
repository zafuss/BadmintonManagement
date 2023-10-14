namespace BadmintonManagement.Forms.ReservationCourt.ReservationReceipt.RevRecPrint
{
    partial class RevRecPrint
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
            this.rpvPrint.Location = new System.Drawing.Point(160, 77);
            this.rpvPrint.Name = "rpvPrint";
            this.rpvPrint.ServerReport.BearerToken = null;
            this.rpvPrint.Size = new System.Drawing.Size(396, 246);
            this.rpvPrint.TabIndex = 0;
            // 
            // RevRecPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rpvPrint);
            this.Name = "RevRecPrint";
            this.Text = "RevRecPrint";
            this.Load += new System.EventHandler(this.RevRecPrint_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvPrint;
    }
}