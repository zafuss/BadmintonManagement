namespace BadmintonManagement.Forms.AuthorizationForms
{
    partial class AccountChangePasswordCenterForm
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.picShowConfirmNewPassword = new System.Windows.Forms.PictureBox();
            this.picShowNewPassword = new System.Windows.Forms.PictureBox();
            this.txtConfirmNewPassword = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtCurrentPassword = new System.Windows.Forms.TextBox();
            this.picShowCurrentPassword = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picShowConfirmNewPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShowNewPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShowCurrentPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.picShowConfirmNewPassword);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.txtConfirmNewPassword);
            this.groupBox2.Controls.Add(this.picShowCurrentPassword);
            this.groupBox2.Controls.Add(this.picShowNewPassword);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtCurrentPassword);
            this.groupBox2.Controls.Add(this.txtNewPassword);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(311, 163);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(484, 257);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thay đổi mật khẩu";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(23, 192);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(416, 39);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 42);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 28);
            this.label7.TabIndex = 18;
            this.label7.Text = "Mật khẩu hiện tại";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 91);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 28);
            this.label6.TabIndex = 17;
            this.label6.Text = "Mật khẩu mới";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 141);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(216, 28);
            this.label8.TabIndex = 17;
            this.label8.Text = "Xác nhận mật khẩu mới";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(428, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(260, 50);
            this.label9.TabIndex = 25;
            this.label9.Text = "Đổi Mật Khẩu";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1158, 100);
            this.panel1.TabIndex = 28;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1158, 504);
            this.panel3.TabIndex = 29;
            // 
            // picShowConfirmNewPassword
            // 
            this.picShowConfirmNewPassword.Image = global::BadmintonManagement.Properties.Resources.hidden_password;
            this.picShowConfirmNewPassword.InitialImage = null;
            this.picShowConfirmNewPassword.Location = new System.Drawing.Point(446, 142);
            this.picShowConfirmNewPassword.Name = "picShowConfirmNewPassword";
            this.picShowConfirmNewPassword.Size = new System.Drawing.Size(23, 22);
            this.picShowConfirmNewPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picShowConfirmNewPassword.TabIndex = 22;
            this.picShowConfirmNewPassword.TabStop = false;
            this.picShowConfirmNewPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picShowConfirmNewPassword_MouseDown);
            this.picShowConfirmNewPassword.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picShowConfirmNewPassword_MouseUp);
            // 
            // picShowNewPassword
            // 
            this.picShowNewPassword.Image = global::BadmintonManagement.Properties.Resources.hidden_password;
            this.picShowNewPassword.InitialImage = null;
            this.picShowNewPassword.Location = new System.Drawing.Point(446, 92);
            this.picShowNewPassword.Name = "picShowNewPassword";
            this.picShowNewPassword.Size = new System.Drawing.Size(23, 22);
            this.picShowNewPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picShowNewPassword.TabIndex = 23;
            this.picShowNewPassword.TabStop = false;
            this.picShowNewPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picShowNewPassword_MouseDown);
            this.picShowNewPassword.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picShowNewPassword_MouseUp);
            // 
            // txtConfirmNewPassword
            // 
            this.txtConfirmNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirmNewPassword.ForeColor = System.Drawing.Color.DarkGray;
            this.txtConfirmNewPassword.Location = new System.Drawing.Point(206, 142);
            this.txtConfirmNewPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtConfirmNewPassword.Name = "txtConfirmNewPassword";
            this.txtConfirmNewPassword.Size = new System.Drawing.Size(233, 27);
            this.txtConfirmNewPassword.TabIndex = 2;
            this.txtConfirmNewPassword.Text = "Nhập lại mật khẩu mới";
            this.txtConfirmNewPassword.Enter += new System.EventHandler(this.txtConfirmPassword_Enter);
            this.txtConfirmNewPassword.Leave += new System.EventHandler(this.txtConfirmPassword_Leave);
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNewPassword.ForeColor = System.Drawing.Color.DarkGray;
            this.txtNewPassword.Location = new System.Drawing.Point(206, 92);
            this.txtNewPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(233, 27);
            this.txtNewPassword.TabIndex = 1;
            this.txtNewPassword.Text = "Mật khẩu mới";
            this.txtNewPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtNewPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // txtCurrentPassword
            // 
            this.txtCurrentPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCurrentPassword.ForeColor = System.Drawing.Color.DarkGray;
            this.txtCurrentPassword.Location = new System.Drawing.Point(206, 43);
            this.txtCurrentPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCurrentPassword.Name = "txtCurrentPassword";
            this.txtCurrentPassword.Size = new System.Drawing.Size(233, 27);
            this.txtCurrentPassword.TabIndex = 0;
            this.txtCurrentPassword.Text = "Mật khẩu hiện tại";
            this.txtCurrentPassword.Enter += new System.EventHandler(this.txtCurrentPassword_Enter);
            this.txtCurrentPassword.Leave += new System.EventHandler(this.txtCurrentPassword_Leave);
            // 
            // picShowCurrentPassword
            // 
            this.picShowCurrentPassword.Image = global::BadmintonManagement.Properties.Resources.hidden_password;
            this.picShowCurrentPassword.InitialImage = null;
            this.picShowCurrentPassword.Location = new System.Drawing.Point(446, 43);
            this.picShowCurrentPassword.Name = "picShowCurrentPassword";
            this.picShowCurrentPassword.Size = new System.Drawing.Size(23, 22);
            this.picShowCurrentPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picShowCurrentPassword.TabIndex = 23;
            this.picShowCurrentPassword.TabStop = false;
            this.picShowCurrentPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picShowCurrentPassword_MouseDown);
            this.picShowCurrentPassword.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picShowCurrentPassword_MouseUp);
            // 
            // AccountChangePasswordCenterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 504);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AccountChangePasswordCenterForm";
            this.Text = "AccountChangePasswordCenterForm";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picShowConfirmNewPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShowNewPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShowCurrentPassword)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox picShowConfirmNewPassword;
        private System.Windows.Forms.TextBox txtConfirmNewPassword;
        private System.Windows.Forms.PictureBox picShowCurrentPassword;
        private System.Windows.Forms.PictureBox picShowNewPassword;
        private System.Windows.Forms.TextBox txtCurrentPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
    }
}