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
            this.lblCourtName = new System.Windows.Forms.Label();
            this.txtCourtName = new System.Windows.Forms.TextBox();
            this.txtBranchName = new System.Windows.Forms.TextBox();
            this.lblBranchName = new System.Windows.Forms.Label();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.dtmStartTime = new System.Windows.Forms.DateTimePicker();
            this.dtmEndTime = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pnlInformation.SuspendLayout();
            this.pnlUser.SuspendLayout();
            this.pnlFunction.SuspendLayout();
            this.pnlDisplayCourt.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
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
            this.btnAdmin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.pnlUser.Controls.Add(this.dtmEndTime);
            this.pnlUser.Controls.Add(this.dtmStartTime);
            this.pnlUser.Controls.Add(this.lblEndTime);
            this.pnlUser.Controls.Add(this.lblStartTime);
            this.pnlUser.Controls.Add(this.txtBranchName);
            this.pnlUser.Controls.Add(this.lblBranchName);
            this.pnlUser.Controls.Add(this.txtCourtName);
            this.pnlUser.Controls.Add(this.lblCourtName);
            this.pnlUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUser.Location = new System.Drawing.Point(0, 78);
            this.pnlUser.Name = "pnlUser";
            this.pnlUser.Size = new System.Drawing.Size(414, 211);
            this.pnlUser.TabIndex = 2;
            // 
            // btnUser
            // 
            this.btnUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.lblfunction.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfunction.Location = new System.Drawing.Point(155, 9);
            this.lblfunction.Name = "lblfunction";
            this.lblfunction.Size = new System.Drawing.Size(109, 28);
            this.lblfunction.TabIndex = 0;
            this.lblfunction.Text = "Chức Năng";
            // 
            // pnlDisplayCourt
            // 
            this.pnlDisplayCourt.Controls.Add(this.panel3);
            this.pnlDisplayCourt.Controls.Add(this.panel2);
            this.pnlDisplayCourt.Controls.Add(this.panel1);
            this.pnlDisplayCourt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDisplayCourt.Location = new System.Drawing.Point(414, 0);
            this.pnlDisplayCourt.Name = "pnlDisplayCourt";
            this.pnlDisplayCourt.Size = new System.Drawing.Size(850, 635);
            this.pnlDisplayCourt.TabIndex = 2;
            // 
            // lblCourtName
            // 
            this.lblCourtName.AutoSize = true;
            this.lblCourtName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourtName.Location = new System.Drawing.Point(12, 20);
            this.lblCourtName.Name = "lblCourtName";
            this.lblCourtName.Size = new System.Drawing.Size(78, 28);
            this.lblCourtName.TabIndex = 0;
            this.lblCourtName.Text = "Tên Sân";
            // 
            // txtCourtName
            // 
            this.txtCourtName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourtName.Location = new System.Drawing.Point(160, 14);
            this.txtCourtName.Name = "txtCourtName";
            this.txtCourtName.ReadOnly = true;
            this.txtCourtName.Size = new System.Drawing.Size(209, 34);
            this.txtCourtName.TabIndex = 1;
            // 
            // txtBranchName
            // 
            this.txtBranchName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBranchName.Location = new System.Drawing.Point(160, 64);
            this.txtBranchName.Name = "txtBranchName";
            this.txtBranchName.ReadOnly = true;
            this.txtBranchName.Size = new System.Drawing.Size(209, 34);
            this.txtBranchName.TabIndex = 3;
            // 
            // lblBranchName
            // 
            this.lblBranchName.AutoSize = true;
            this.lblBranchName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBranchName.Location = new System.Drawing.Point(12, 67);
            this.lblBranchName.Name = "lblBranchName";
            this.lblBranchName.Size = new System.Drawing.Size(84, 28);
            this.lblBranchName.TabIndex = 2;
            this.lblBranchName.Text = "Khu Vực";
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartTime.Location = new System.Drawing.Point(12, 123);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(168, 28);
            this.lblStartTime.TabIndex = 4;
            this.lblStartTime.Text = "Thời Gian Bắt Đầu";
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndTime.Location = new System.Drawing.Point(12, 168);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(175, 28);
            this.lblEndTime.TabIndex = 6;
            this.lblEndTime.Text = "Thời Gian Kết Thúc";
            // 
            // dtmStartTime
            // 
            this.dtmStartTime.Enabled = false;
            this.dtmStartTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtmStartTime.Location = new System.Drawing.Point(208, 117);
            this.dtmStartTime.Name = "dtmStartTime";
            this.dtmStartTime.Size = new System.Drawing.Size(109, 34);
            this.dtmStartTime.TabIndex = 7;
            // 
            // dtmEndTime
            // 
            this.dtmEndTime.Enabled = false;
            this.dtmEndTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtmEndTime.Location = new System.Drawing.Point(208, 162);
            this.dtmEndTime.Name = "dtmEndTime";
            this.dtmEndTime.Size = new System.Drawing.Size(109, 34);
            this.dtmEndTime.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 176);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BadmintonManagement.Properties.Resources.Used;
            this.pictureBox1.Location = new System.Drawing.Point(33, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(300, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(246, 176);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BadmintonManagement.Properties.Resources.Used;
            this.pictureBox2.Location = new System.Drawing.Point(33, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(182, 114);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Location = new System.Drawing.Point(601, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(246, 176);
            this.panel3.TabIndex = 2;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::BadmintonManagement.Properties.Resources.Used;
            this.pictureBox3.Location = new System.Drawing.Point(32, 25);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(182, 114);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
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
            this.pnlUser.ResumeLayout(false);
            this.pnlUser.PerformLayout();
            this.pnlFunction.ResumeLayout(false);
            this.pnlFunction.PerformLayout();
            this.pnlDisplayCourt.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
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
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.TextBox txtBranchName;
        private System.Windows.Forms.Label lblBranchName;
        private System.Windows.Forms.TextBox txtCourtName;
        private System.Windows.Forms.Label lblCourtName;
        private System.Windows.Forms.DateTimePicker dtmEndTime;
        private System.Windows.Forms.DateTimePicker dtmStartTime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}