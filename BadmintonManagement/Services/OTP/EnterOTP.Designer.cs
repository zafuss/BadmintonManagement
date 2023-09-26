namespace BadmintonManagement
{
    partial class EnterOTP
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtOTPCode = new System.Windows.Forms.TextBox();
            this.btnEnterOTP = new System.Windows.Forms.Button();
            this.btnSendAgain = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(53, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(0, 21);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtOTPCode
            // 
            this.txtOTPCode.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOTPCode.Location = new System.Drawing.Point(188, 107);
            this.txtOTPCode.Name = "txtOTPCode";
            this.txtOTPCode.Size = new System.Drawing.Size(139, 43);
            this.txtOTPCode.TabIndex = 1;
            this.txtOTPCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnEnterOTP
            // 
            this.btnEnterOTP.Location = new System.Drawing.Point(128, 198);
            this.btnEnterOTP.Name = "btnEnterOTP";
            this.btnEnterOTP.Size = new System.Drawing.Size(117, 36);
            this.btnEnterOTP.TabIndex = 2;
            this.btnEnterOTP.Text = "Xác nhận";
            this.btnEnterOTP.UseVisualStyleBackColor = true;
            this.btnEnterOTP.Click += new System.EventHandler(this.btnEnterOTP_Click);
            // 
            // btnSendAgain
            // 
            this.btnSendAgain.AutoSize = true;
            this.btnSendAgain.Location = new System.Drawing.Point(310, 206);
            this.btnSendAgain.Name = "btnSendAgain";
            this.btnSendAgain.Size = new System.Drawing.Size(54, 21);
            this.btnSendAgain.TabIndex = 3;
            this.btnSendAgain.Text = "Gửi lại";
            this.btnSendAgain.Click += new System.EventHandler(this.btnSendAgain_Click);
            // 
            // EnterOTP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 277);
            this.Controls.Add(this.btnSendAgain);
            this.Controls.Add(this.btnEnterOTP);
            this.Controls.Add(this.txtOTPCode);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EnterOTP";
            this.Text = "EnterOTP";
            this.Load += new System.EventHandler(this.EnterActiveOTP_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtOTPCode;
        private System.Windows.Forms.Button btnEnterOTP;
        private System.Windows.Forms.Label btnSendAgain;
    }
}