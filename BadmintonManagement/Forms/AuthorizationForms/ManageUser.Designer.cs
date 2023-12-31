﻿namespace BadmintonManagement.Forms.AuthorizationForms
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
            this.txtRegUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRegPhoneNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRegEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelUser = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbxChangePassword = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.clnUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnStaus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(4, 382);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(371, 46);
            this.btnReg.TabIndex = 6;
            this.btnReg.Text = "Thêm user";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // txtRegUsername
            // 
            this.txtRegUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtRegUsername.Location = new System.Drawing.Point(139, 43);
            this.txtRegUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRegUsername.Name = "txtRegUsername";
            this.txtRegUsername.Size = new System.Drawing.Size(222, 34);
            this.txtRegUsername.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 185);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tên đăng nhập";
            // 
            // txtRegPhoneNumber
            // 
            this.txtRegPhoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtRegPhoneNumber.Location = new System.Drawing.Point(139, 192);
            this.txtRegPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRegPhoneNumber.Name = "txtRegPhoneNumber";
            this.txtRegPhoneNumber.Size = new System.Drawing.Size(222, 34);
            this.txtRegPhoneNumber.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 334);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 28);
            this.label3.TabIndex = 10;
            this.label3.Text = "Số điện thoại";
            // 
            // txtRegEmail
            // 
            this.txtRegEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtRegEmail.Location = new System.Drawing.Point(139, 143);
            this.txtRegEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRegEmail.Name = "txtRegEmail";
            this.txtRegEmail.Size = new System.Drawing.Size(222, 34);
            this.txtRegEmail.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 285);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 28);
            this.label4.TabIndex = 11;
            this.label4.Text = "Email";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BadmintonManagement.Properties.Resources.register_images;
            this.pictureBox1.Location = new System.Drawing.Point(117, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 121);
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
            this.clnName,
            this.clnEmail,
            this.clnPhoneNumber,
            this.clnRole,
            this.clnStaus});
            this.dgvUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsers.Location = new System.Drawing.Point(386, 151);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersWidth = 62;
            this.dgvUsers.RowTemplate.Height = 24;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(862, 395);
            this.dgvUsers.TabIndex = 9;
            this.dgvUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(4, 434);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(184, 46);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Sửa user";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelUser
            // 
            this.btnDelUser.Location = new System.Drawing.Point(194, 434);
            this.btnDelUser.Name = "btnDelUser";
            this.btnDelUser.Size = new System.Drawing.Size(184, 46);
            this.btnDelUser.TabIndex = 8;
            this.btnDelUser.Text = "...";
            this.btnDelUser.UseVisualStyleBackColor = true;
            this.btnDelUser.Click += new System.EventHandler(this.btnDelUser_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 234);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 28);
            this.label5.TabIndex = 6;
            this.label5.Text = "Họ tên";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtName.Location = new System.Drawing.Point(139, 92);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(222, 34);
            this.txtName.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbxChangePassword);
            this.panel1.Controls.Add(this.btnReg);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnDelUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 546);
            this.panel1.TabIndex = 12;
            // 
            // cbxChangePassword
            // 
            this.cbxChangePassword.AutoSize = true;
            this.cbxChangePassword.Location = new System.Drawing.Point(13, 486);
            this.cbxChangePassword.Name = "cbxChangePassword";
            this.cbxChangePassword.Size = new System.Drawing.Size(195, 32);
            this.cbxChangePassword.TabIndex = 0;
            this.cbxChangePassword.Text = "Thay đổi mật khẩu";
            this.cbxChangePassword.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRegUsername);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtRegPhoneNumber);
            this.groupBox1.Controls.Add(this.txtRegEmail);
            this.groupBox1.Location = new System.Drawing.Point(3, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 237);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tài khoản";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(489, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 28);
            this.label7.TabIndex = 14;
            this.label7.Text = "Tìm kiếm tài khoản";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(672, 114);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(178, 34);
            this.txtSearch.TabIndex = 13;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(386, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(862, 151);
            this.panel2.TabIndex = 16;
            this.panel2.SizeChanged += new System.EventHandler(this.panel2_SizeChanged);
            // 
            // clnUsername
            // 
            this.clnUsername.HeaderText = "Username";
            this.clnUsername.MinimumWidth = 8;
            this.clnUsername.Name = "clnUsername";
            this.clnUsername.ReadOnly = true;
            this.clnUsername.Width = 110;
            // 
            // clnName
            // 
            this.clnName.HeaderText = "Họ tên";
            this.clnName.MinimumWidth = 6;
            this.clnName.Name = "clnName";
            this.clnName.ReadOnly = true;
            this.clnName.Width = 180;
            // 
            // clnEmail
            // 
            this.clnEmail.HeaderText = "Email";
            this.clnEmail.MinimumWidth = 8;
            this.clnEmail.Name = "clnEmail";
            this.clnEmail.ReadOnly = true;
            this.clnEmail.Width = 230;
            // 
            // clnPhoneNumber
            // 
            this.clnPhoneNumber.HeaderText = "SĐT";
            this.clnPhoneNumber.MinimumWidth = 8;
            this.clnPhoneNumber.Name = "clnPhoneNumber";
            this.clnPhoneNumber.ReadOnly = true;
            this.clnPhoneNumber.Width = 110;
            // 
            // clnRole
            // 
            this.clnRole.HeaderText = "Quyền";
            this.clnRole.MinimumWidth = 8;
            this.clnRole.Name = "clnRole";
            this.clnRole.ReadOnly = true;
            this.clnRole.Width = 60;
            // 
            // clnStaus
            // 
            this.clnStaus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clnStaus.HeaderText = "Trạng thái";
            this.clnStaus.MinimumWidth = 6;
            this.clnStaus.Name = "clnStaus";
            this.clnStaus.ReadOnly = true;
            // 
            // ManageUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 546);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ManageUser";
            this.Text = "Quản Lý Tài Khoản";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.TextBox txtRegUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRegPhoneNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRegEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbxChangePassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnPhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnStaus;
    }
}