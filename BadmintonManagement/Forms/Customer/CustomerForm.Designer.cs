﻿namespace BadmintonManagement.Forms.Customer
{
    partial class CustomerForm
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
            this.dgrv_Customer = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Add_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.panel_Menu = new System.Windows.Forms.Panel();
            this.panel_SubMenu = new System.Windows.Forms.Panel();
            this.btn_Menu = new System.Windows.Forms.Button();
            this.panel_Features = new System.Windows.Forms.Panel();
            this.btn_Search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgrv_Customer)).BeginInit();
            this.panel_Menu.SuspendLayout();
            this.panel_SubMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgrv_Customer
            // 
            this.dgrv_Customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrv_Customer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgrv_Customer.Location = new System.Drawing.Point(154, 0);
            this.dgrv_Customer.Margin = new System.Windows.Forms.Padding(2);
            this.dgrv_Customer.Name = "dgrv_Customer";
            this.dgrv_Customer.ReadOnly = true;
            this.dgrv_Customer.Size = new System.Drawing.Size(827, 512);
            this.dgrv_Customer.TabIndex = 0;
            this.dgrv_Customer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrv_Customer_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Số điện thoại khách hàng";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Họ tên khách hàng";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Email";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // btn_Add_Update
            // 
            this.btn_Add_Update.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Add_Update.Location = new System.Drawing.Point(0, 36);
            this.btn_Add_Update.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Add_Update.Name = "btn_Add_Update";
            this.btn_Add_Update.Size = new System.Drawing.Size(159, 36);
            this.btn_Add_Update.TabIndex = 1;
            this.btn_Add_Update.Text = "Thêm/Cập nhật";
            this.btn_Add_Update.UseVisualStyleBackColor = true;
            this.btn_Add_Update.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Delete.Location = new System.Drawing.Point(0, 0);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(159, 36);
            this.btn_Delete.TabIndex = 1;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(40, 226);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(71, 39);
            this.btn_Exit.TabIndex = 1;
            this.btn_Exit.Text = "Thoát";
            this.btn_Exit.UseVisualStyleBackColor = true;
            // 
            // panel_Menu
            // 
            this.panel_Menu.Controls.Add(this.panel_SubMenu);
            this.panel_Menu.Controls.Add(this.btn_Exit);
            this.panel_Menu.Controls.Add(this.btn_Menu);
            this.panel_Menu.Controls.Add(this.panel_Features);
            this.panel_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Menu.Location = new System.Drawing.Point(0, 0);
            this.panel_Menu.Name = "panel_Menu";
            this.panel_Menu.Size = new System.Drawing.Size(159, 523);
            this.panel_Menu.TabIndex = 2;
            // 
            // panel_SubMenu
            // 
            this.panel_SubMenu.Controls.Add(this.btn_Search);
            this.panel_SubMenu.Controls.Add(this.btn_Add_Update);
            this.panel_SubMenu.Controls.Add(this.btn_Delete);
            this.panel_SubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_SubMenu.Location = new System.Drawing.Point(0, 124);
            this.panel_SubMenu.Name = "panel_SubMenu";
            this.panel_SubMenu.Size = new System.Drawing.Size(159, 141);
            this.panel_SubMenu.TabIndex = 2;
            // 
            // btn_Menu
            // 
            this.btn_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Menu.Location = new System.Drawing.Point(0, 79);
            this.btn_Menu.Name = "btn_Menu";
            this.btn_Menu.Size = new System.Drawing.Size(159, 45);
            this.btn_Menu.TabIndex = 1;
            this.btn_Menu.Text = "Chức năng";
            this.btn_Menu.UseVisualStyleBackColor = true;
            this.btn_Menu.Click += new System.EventHandler(this.btn_Menu_Click);
            // 
            // panel_Features
            // 
            this.panel_Features.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Features.Location = new System.Drawing.Point(0, 0);
            this.panel_Features.Name = "panel_Features";
            this.panel_Features.Size = new System.Drawing.Size(159, 79);
            this.panel_Features.TabIndex = 0;
            // 
            // btn_Search
            // 
            this.btn_Search.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Search.Location = new System.Drawing.Point(0, 72);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(159, 39);
            this.btn_Search.TabIndex = 3;
            this.btn_Search.Text = "Tìm kiếm";
            this.btn_Search.UseVisualStyleBackColor = true;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 523);
            this.Controls.Add(this.panel_Menu);
            this.Controls.Add(this.dgrv_Customer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerForm";
            this.Text = "Khách Hàng";
            ((System.ComponentModel.ISupportInitialize)(this.dgrv_Customer)).EndInit();
            this.panel_Menu.ResumeLayout(false);
            this.panel_SubMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrv_Customer;
        private System.Windows.Forms.Button btn_Add_Update;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Panel panel_Menu;
        private System.Windows.Forms.Panel panel_Features;
        private System.Windows.Forms.Button btn_Menu;
        private System.Windows.Forms.Panel panel_SubMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button btn_Search;
    }
}