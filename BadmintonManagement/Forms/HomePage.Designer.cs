namespace BadmintonManagement.Forms.AuthorizationForms
{
    partial class HomePage
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
            this.btnAdminManageUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdminManageUser
            // 
            this.btnAdminManageUser.Location = new System.Drawing.Point(1010, 52);
            this.btnAdminManageUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdminManageUser.Name = "btnAdminManageUser";
            this.btnAdminManageUser.Size = new System.Drawing.Size(125, 34);
            this.btnAdminManageUser.TabIndex = 0;
            this.btnAdminManageUser.Text = "Quản lý user";
            this.btnAdminManageUser.UseVisualStyleBackColor = true;
            this.btnAdminManageUser.Click += new System.EventHandler(this.btnAdminManageUser_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 727);
            this.Controls.Add(this.btnAdminManageUser);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HomePage_FormClosed);
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdminManageUser;
    }
}