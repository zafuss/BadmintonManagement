namespace BadmintonManagement.Forms.Service
{
    partial class ManageServiceForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.nmrQuantity = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDelService = new System.Windows.Forms.Button();
            this.btnUpdateService = new System.Windows.Forms.Button();
            this.btnAddService = new System.Windows.Forms.Button();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtServiceID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtServiceName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvServices = new System.Windows.Forms.DataGridView();
            this.clnServiceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnServiceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.nmrQuantity);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtPrice);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnDelService);
            this.panel1.Controls.Add(this.btnUpdateService);
            this.panel1.Controls.Add(this.btnAddService);
            this.panel1.Controls.Add(this.txtUnit);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtServiceID);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtServiceName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 551);
            this.panel1.TabIndex = 13;
            // 
            // nmrQuantity
            // 
            this.nmrQuantity.Location = new System.Drawing.Point(110, 391);
            this.nmrQuantity.Name = "nmrQuantity";
            this.nmrQuantity.Size = new System.Drawing.Size(198, 34);
            this.nmrQuantity.TabIndex = 4;
            this.nmrQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 391);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 28);
            this.label3.TabIndex = 26;
            this.label3.Text = "Số lượng";
            // 
            // txtPrice
            // 
            this.txtPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtPrice.Location = new System.Drawing.Point(110, 339);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(198, 34);
            this.txtPrice.TabIndex = 3;
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 342);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 28);
            this.label4.TabIndex = 27;
            this.label4.Text = "Đơn giá";
            // 
            // btnDelService
            // 
            this.btnDelService.Location = new System.Drawing.Point(201, 458);
            this.btnDelService.Name = "btnDelService";
            this.btnDelService.Size = new System.Drawing.Size(107, 46);
            this.btnDelService.TabIndex = 7;
            this.btnDelService.Text = "...";
            this.btnDelService.UseVisualStyleBackColor = true;
            this.btnDelService.Click += new System.EventHandler(this.btnDelService_Click);
            // 
            // btnUpdateService
            // 
            this.btnUpdateService.Location = new System.Drawing.Point(110, 458);
            this.btnUpdateService.Name = "btnUpdateService";
            this.btnUpdateService.Size = new System.Drawing.Size(85, 46);
            this.btnUpdateService.TabIndex = 6;
            this.btnUpdateService.Text = "Sửa dịch vụ";
            this.btnUpdateService.UseVisualStyleBackColor = true;
            this.btnUpdateService.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAddService
            // 
            this.btnAddService.Location = new System.Drawing.Point(16, 458);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(88, 46);
            this.btnAddService.TabIndex = 5;
            this.btnAddService.Text = "Thêm dịch vụ";
            this.btnAddService.UseVisualStyleBackColor = true;
            this.btnAddService.Click += new System.EventHandler(this.btnAddService_Click);
            // 
            // txtUnit
            // 
            this.txtUnit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtUnit.Location = new System.Drawing.Point(110, 288);
            this.txtUnit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(198, 34);
            this.txtUnit.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 291);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 28);
            this.label5.TabIndex = 22;
            this.label5.Text = "Đơn vị tính";
            // 
            // txtServiceID
            // 
            this.txtServiceID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtServiceID.Location = new System.Drawing.Point(110, 189);
            this.txtServiceID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtServiceID.Name = "txtServiceID";
            this.txtServiceID.Size = new System.Drawing.Size(198, 34);
            this.txtServiceID.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 192);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 28);
            this.label2.TabIndex = 23;
            this.label2.Text = "Mã dịch vụ";
            // 
            // txtServiceName
            // 
            this.txtServiceName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtServiceName.Location = new System.Drawing.Point(110, 239);
            this.txtServiceName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtServiceName.Name = "txtServiceName";
            this.txtServiceName.Size = new System.Drawing.Size(198, 34);
            this.txtServiceName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 242);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 28);
            this.label1.TabIndex = 23;
            this.label1.Text = "Tên dịch vụ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BadmintonManagement.Properties.Resources.service_icon;
            this.pictureBox1.Location = new System.Drawing.Point(97, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(3, 152);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 300);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin dịch vụ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(337, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(839, 170);
            this.panel2.TabIndex = 17;
            this.panel2.SizeChanged += new System.EventHandler(this.panel2_SizeChanged);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(466, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 28);
            this.label7.TabIndex = 14;
            this.label7.Text = "Tìm kiếm dịch vụ";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(649, 133);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(178, 34);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dgvServices
            // 
            this.dgvServices.AllowUserToAddRows = false;
            this.dgvServices.AllowUserToDeleteRows = false;
            this.dgvServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnServiceID,
            this.clnServiceName,
            this.clnUnit,
            this.clnPrice,
            this.clnQuantity,
            this.clnStatus});
            this.dgvServices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvServices.Location = new System.Drawing.Point(337, 170);
            this.dgvServices.Name = "dgvServices";
            this.dgvServices.ReadOnly = true;
            this.dgvServices.RowHeadersWidth = 62;
            this.dgvServices.RowTemplate.Height = 24;
            this.dgvServices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvServices.Size = new System.Drawing.Size(839, 381);
            this.dgvServices.TabIndex = 18;
            this.dgvServices.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServices_CellClick);
            // 
            // clnServiceID
            // 
            this.clnServiceID.HeaderText = "Mã dịch vụ";
            this.clnServiceID.MinimumWidth = 8;
            this.clnServiceID.Name = "clnServiceID";
            this.clnServiceID.ReadOnly = true;
            this.clnServiceID.Width = 125;
            // 
            // clnServiceName
            // 
            this.clnServiceName.HeaderText = "Tên dịch vụ";
            this.clnServiceName.MinimumWidth = 6;
            this.clnServiceName.Name = "clnServiceName";
            this.clnServiceName.ReadOnly = true;
            this.clnServiceName.Width = 190;
            // 
            // clnUnit
            // 
            this.clnUnit.HeaderText = "Đơn vị tính";
            this.clnUnit.MinimumWidth = 8;
            this.clnUnit.Name = "clnUnit";
            this.clnUnit.ReadOnly = true;
            this.clnUnit.Width = 115;
            // 
            // clnPrice
            // 
            this.clnPrice.HeaderText = "Đơn giá";
            this.clnPrice.MinimumWidth = 8;
            this.clnPrice.Name = "clnPrice";
            this.clnPrice.ReadOnly = true;
            this.clnPrice.Width = 125;
            // 
            // clnQuantity
            // 
            this.clnQuantity.HeaderText = "Số lượng";
            this.clnQuantity.MinimumWidth = 8;
            this.clnQuantity.Name = "clnQuantity";
            this.clnQuantity.ReadOnly = true;
            this.clnQuantity.Width = 125;
            // 
            // clnStatus
            // 
            this.clnStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clnStatus.HeaderText = "Trạng thái";
            this.clnStatus.MinimumWidth = 6;
            this.clnStatus.Name = "clnStatus";
            this.clnStatus.ReadOnly = true;
            // 
            // ManageServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 551);
            this.Controls.Add(this.dgvServices);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ManageServiceForm";
            this.Text = "Dịch Vụ";
            this.Load += new System.EventHandler(this.ServiceForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDelService;
        private System.Windows.Forms.Button btnUpdateService;
        private System.Windows.Forms.Button btnAddService;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtServiceName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvServices;
        private System.Windows.Forms.TextBox txtServiceID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nmrQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnServiceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnServiceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnStatus;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}