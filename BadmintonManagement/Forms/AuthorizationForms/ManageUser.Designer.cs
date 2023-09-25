namespace BadmintonManagement.Forms.AuthorizationForms
{
    partial class ManageUser
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
            this.btnReg = new System.Windows.Forms.Button();
            this.txtRegPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRegUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRegPhoneNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRegEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.clnUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnStaus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(62, 480);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(109, 46);
            this.btnReg.TabIndex = 4;
            this.btnReg.Text = "Thêm user";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // txtRegPassword
            // 
            this.txtRegPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtRegPassword.Location = new System.Drawing.Point(179, 296);
            this.txtRegPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRegPassword.Name = "txtRegPassword";
            this.txtRegPassword.Size = new System.Drawing.Size(220, 34);
            this.txtRegPassword.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 299);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // txtRegUsername
            // 
            this.txtRegUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtRegUsername.Location = new System.Drawing.Point(179, 234);
            this.txtRegUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRegUsername.Name = "txtRegUsername";
            this.txtRegUsername.Size = new System.Drawing.Size(220, 34);
            this.txtRegUsername.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 237);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "Username";
            // 
            // txtRegPhoneNumber
            // 
            this.txtRegPhoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtRegPhoneNumber.Location = new System.Drawing.Point(179, 420);
            this.txtRegPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRegPhoneNumber.Name = "txtRegPhoneNumber";
            this.txtRegPhoneNumber.Size = new System.Drawing.Size(220, 34);
            this.txtRegPhoneNumber.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 423);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 28);
            this.label3.TabIndex = 10;
            this.label3.Text = "Phone number";
            // 
            // txtRegEmail
            // 
            this.txtRegEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtRegEmail.Location = new System.Drawing.Point(179, 358);
            this.txtRegEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRegEmail.Name = "txtRegEmail";
            this.txtRegEmail.Size = new System.Drawing.Size(220, 34);
            this.txtRegEmail.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 361);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 28);
            this.label4.TabIndex = 11;
            this.label4.Text = "Email";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BadmintonManagement.Properties.Resources.register_images;
            this.pictureBox1.Location = new System.Drawing.Point(160, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 186);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnUsername,
            this.clnEmail,
            this.clnPhoneNumber,
            this.clnRole,
            this.clnStaus});
            this.dgvUsers.Location = new System.Drawing.Point(432, 12);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersWidth = 62;
            this.dgvUsers.RowTemplate.Height = 24;
            this.dgvUsers.Size = new System.Drawing.Size(720, 513);
            this.dgvUsers.TabIndex = 12;
            this.dgvUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellClick);
            // 
            // clnUsername
            // 
            this.clnUsername.HeaderText = "Username";
            this.clnUsername.MinimumWidth = 8;
            this.clnUsername.Name = "clnUsername";
            this.clnUsername.ReadOnly = true;
            this.clnUsername.Width = 200;
            // 
            // clnEmail
            // 
            this.clnEmail.HeaderText = "Email";
            this.clnEmail.MinimumWidth = 8;
            this.clnEmail.Name = "clnEmail";
            this.clnEmail.ReadOnly = true;
            this.clnEmail.Width = 250;
            // 
            // clnPhoneNumber
            // 
            this.clnPhoneNumber.HeaderText = "SĐT";
            this.clnPhoneNumber.MinimumWidth = 8;
            this.clnPhoneNumber.Name = "clnPhoneNumber";
            this.clnPhoneNumber.ReadOnly = true;
            this.clnPhoneNumber.Width = 125;
            // 
            // clnRole
            // 
            this.clnRole.HeaderText = "Quyền";
            this.clnRole.MinimumWidth = 8;
            this.clnRole.Name = "clnRole";
            this.clnRole.ReadOnly = true;
            this.clnRole.Width = 150;
            // 
            // clnStaus
            // 
            this.clnStaus.HeaderText = "Trạng thái";
            this.clnStaus.MinimumWidth = 6;
            this.clnStaus.Name = "clnStaus";
            this.clnStaus.ReadOnly = true;
            this.clnStaus.Width = 125;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(177, 480);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(108, 46);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Sửa user";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelUser
            // 
            this.btnDelUser.Location = new System.Drawing.Point(291, 480);
            this.btnDelUser.Name = "btnDelUser";
            this.btnDelUser.Size = new System.Drawing.Size(108, 46);
            this.btnDelUser.TabIndex = 4;
            this.btnDelUser.Text = "Vô hiệu hoá user";
            this.btnDelUser.UseVisualStyleBackColor = true;
            this.btnDelUser.Click += new System.EventHandler(this.btnDelUser_Click);
            // 
            // ManageUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 551);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.txtRegPhoneNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRegEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDelUser);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.txtRegPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRegUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ManageUser";
            this.Text = "Tài Khoản";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.TextBox txtRegPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRegUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRegPhoneNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRegEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnPhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnRole;
        private System.Windows.Forms.Button btnDelUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnStaus;
    }
}