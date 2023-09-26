namespace BadmintonManagement.Forms.Court
{
    partial class CourtForm
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
            this.pnlInformation = new System.Windows.Forms.Panel();
            this.pnlAdmin = new System.Windows.Forms.Panel();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.pnlUser = new System.Windows.Forms.Panel();
            this.btnUser = new System.Windows.Forms.Button();
            this.pnlFunction = new System.Windows.Forms.Panel();
            this.lblfunction = new System.Windows.Forms.Label();
            this.pnlDisplayCourt = new System.Windows.Forms.Panel();
            this.pnlInformation.SuspendLayout();
            this.pnlFunction.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlInformation
            // 
            this.pnlInformation.Controls.Add(this.pnlAdmin);
            this.pnlInformation.Controls.Add(this.btnAdmin);
            this.pnlInformation.Controls.Add(this.pnlUser);
            this.pnlInformation.Controls.Add(this.btnUser);
            this.pnlInformation.Controls.Add(this.pnlFunction);
            this.pnlInformation.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlInformation.Location = new System.Drawing.Point(0, 0);
            this.pnlInformation.Name = "pnlInformation";
            this.pnlInformation.Size = new System.Drawing.Size(414, 635);
            this.pnlInformation.TabIndex = 1;
            // 
            // pnlAdmin
            // 
            this.pnlAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAdmin.Location = new System.Drawing.Point(0, 322);
            this.pnlAdmin.Name = "pnlAdmin";
            this.pnlAdmin.Size = new System.Drawing.Size(414, 313);
            this.pnlAdmin.TabIndex = 4;
            // 
            // btnAdmin
            // 
            this.btnAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdmin.Location = new System.Drawing.Point(0, 289);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(414, 33);
            this.btnAdmin.TabIndex = 3;
            this.btnAdmin.Text = "ADMIN";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // pnlUser
            // 
            this.pnlUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUser.Location = new System.Drawing.Point(0, 78);
            this.pnlUser.Name = "pnlUser";
            this.pnlUser.Size = new System.Drawing.Size(414, 211);
            this.pnlUser.TabIndex = 2;
            // 
            // btnUser
            // 
            this.btnUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUser.Location = new System.Drawing.Point(0, 45);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(414, 33);
            this.btnUser.TabIndex = 1;
            this.btnUser.Text = "USER";
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // pnlFunction
            // 
            this.pnlFunction.Controls.Add(this.lblfunction);
            this.pnlFunction.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFunction.Location = new System.Drawing.Point(0, 0);
            this.pnlFunction.Name = "pnlFunction";
            this.pnlFunction.Size = new System.Drawing.Size(414, 45);
            this.pnlFunction.TabIndex = 0;
            // 
            // lblfunction
            // 
            this.lblfunction.AutoSize = true;
            this.lblfunction.Location = new System.Drawing.Point(155, 9);
            this.lblfunction.Name = "lblfunction";
            this.lblfunction.Size = new System.Drawing.Size(73, 16);
            this.lblfunction.TabIndex = 0;
            this.lblfunction.Text = "Chức Năng";
            // 
            // pnlDisplayCourt
            // 
            this.pnlDisplayCourt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDisplayCourt.Location = new System.Drawing.Point(414, 0);
            this.pnlDisplayCourt.Name = "pnlDisplayCourt";
            this.pnlDisplayCourt.Size = new System.Drawing.Size(850, 635);
            this.pnlDisplayCourt.TabIndex = 2;
            // 
            // CourtForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 635);
            this.Controls.Add(this.pnlDisplayCourt);
            this.Controls.Add(this.pnlInformation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CourtForm";
            this.Text = "CourtForm";
            this.pnlInformation.ResumeLayout(false);
            this.pnlFunction.ResumeLayout(false);
            this.pnlFunction.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlInformation;
        private System.Windows.Forms.Panel pnlFunction;
        private System.Windows.Forms.Label lblfunction;
        private System.Windows.Forms.Panel pnlDisplayCourt;
        private System.Windows.Forms.Panel pnlAdmin;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Panel pnlUser;
        private System.Windows.Forms.Button btnUser;
    }
}