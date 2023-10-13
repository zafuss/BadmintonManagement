namespace BadmintonManagement.Forms.AuthorizationForms
{
    partial class ResetPasswordForm
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
            this.btnEnterOTP = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picShowPassword = new System.Windows.Forms.PictureBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtConfirmNewPassword = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picShowPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEnterOTP
            // 
            this.btnEnterOTP.Location = new System.Drawing.Point(58, 157);
            this.btnEnterOTP.Name = "btnEnterOTP";
            this.btnEnterOTP.Size = new System.Drawing.Size(380, 43);
            this.btnEnterOTP.TabIndex = 2;
            this.btnEnterOTP.Text = "Xác nhận";
            this.btnEnterOTP.UseVisualStyleBackColor = true;
            this.btnEnterOTP.Click += new System.EventHandler(this.btnEnterOTP_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nhập mật khẩu mới:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Xác nhận mật khẩu:";
            // 
            // picShowPassword
            // 
            this.picShowPassword.Image = global::BadmintonManagement.Properties.Resources.hidden_password;
            this.picShowPassword.InitialImage = null;
            this.picShowPassword.Location = new System.Drawing.Point(445, 69);
            this.picShowPassword.Name = "picShowPassword";
            this.picShowPassword.Size = new System.Drawing.Size(23, 22);
            this.picShowPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picShowPassword.TabIndex = 2;
            this.picShowPassword.TabStop = false;
            this.picShowPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picShowNewPassword_MouseDown);
            this.picShowPassword.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picShowNewPassword_MouseUp);
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNewPassword.ForeColor = System.Drawing.Color.DarkGray;
            this.txtNewPassword.Location = new System.Drawing.Point(205, 69);
            this.txtNewPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(233, 22);
            this.txtNewPassword.TabIndex = 0;
            this.txtNewPassword.Text = "Mật khẩu mới";
            this.txtNewPassword.TextChanged += new System.EventHandler(this.txtNewPassword_TextChanged);
            this.txtNewPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtNewPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // txtConfirmNewPassword
            // 
            this.txtConfirmNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirmNewPassword.ForeColor = System.Drawing.Color.DarkGray;
            this.txtConfirmNewPassword.Location = new System.Drawing.Point(206, 106);
            this.txtConfirmNewPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtConfirmNewPassword.Name = "txtConfirmNewPassword";
            this.txtConfirmNewPassword.Size = new System.Drawing.Size(233, 22);
            this.txtConfirmNewPassword.TabIndex = 1;
            this.txtConfirmNewPassword.Text = "Nhập lại mật khẩu mới";
            this.txtConfirmNewPassword.Enter += new System.EventHandler(this.txtConfirmPassword_Enter);
            this.txtConfirmNewPassword.Leave += new System.EventHandler(this.txtConfirmPassword_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BadmintonManagement.Properties.Resources.hidden_password;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(446, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picShowConfirmNewPassword_MouseDown);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picShowConfirmNewPassword_MouseUp);
            // 
            // ResetPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 261);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picShowPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtConfirmNewPassword);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEnterOTP);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ResetPasswordForm";
            this.Text = "Đặt lại mật khẩu";
            ((System.ComponentModel.ISupportInitialize)(this.picShowPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnterOTP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picShowPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtConfirmNewPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}