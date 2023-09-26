namespace BadmintonManagement.Forms.Report
{
    partial class InComeChart
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
            this.reportAction1 = new Microsoft.AnalysisServices.ReportAction();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.SuspendLayout();
          
            // 
            // InComeChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 464);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InComeChart";
            this.Text = "InComeChart";
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.AnalysisServices.ReportAction reportAction1;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
    }
}