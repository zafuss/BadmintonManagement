namespace BadmintonManagement.Forms.Price
{
    partial class PriceForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.btnUsedPrice = new System.Windows.Forms.Button();
            this.txtPriceID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddPrice = new System.Windows.Forms.Button();
            this.txtDateFactor = new System.Windows.Forms.TextBox();
            this.txtTimeFactor = new System.Windows.Forms.TextBox();
            this.txtPriceTag = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvPrices = new System.Windows.Forms.DataGridView();
            this.PriceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceTag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeFactor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateFactor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrices)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.cmbStatus);
            this.panel1.Controls.Add(this.btnUsedPrice);
            this.panel1.Controls.Add(this.txtPriceID);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnAddPrice);
            this.panel1.Controls.Add(this.txtDateFactor);
            this.panel1.Controls.Add(this.txtTimeFactor);
            this.panel1.Controls.Add(this.txtPriceTag);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 578);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BadmintonManagement.Properties.Resources.prices1;
            this.pictureBox1.Location = new System.Drawing.Point(92, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // cmbStatus
            // 
            this.cmbStatus.Enabled = false;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Không áp dụng",
            "Áp dụng"});
            this.cmbStatus.Location = new System.Drawing.Point(106, 365);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(140, 29);
            this.cmbStatus.TabIndex = 14;
            // 
            // btnUsedPrice
            // 
            this.btnUsedPrice.Location = new System.Drawing.Point(135, 441);
            this.btnUsedPrice.Name = "btnUsedPrice";
            this.btnUsedPrice.Size = new System.Drawing.Size(100, 36);
            this.btnUsedPrice.TabIndex = 13;
            this.btnUsedPrice.Text = "Áp Dụng";
            this.btnUsedPrice.UseVisualStyleBackColor = true;
            this.btnUsedPrice.Click += new System.EventHandler(this.btnUsedPrice_Click);
            // 
            // txtPriceID
            // 
            this.txtPriceID.Location = new System.Drawing.Point(106, 139);
            this.txtPriceID.Name = "txtPriceID";
            this.txtPriceID.Size = new System.Drawing.Size(140, 29);
            this.txtPriceID.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 373);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "Trạng Thái";
            // 
            // btnAddPrice
            // 
            this.btnAddPrice.Location = new System.Drawing.Point(10, 441);
            this.btnAddPrice.Name = "btnAddPrice";
            this.btnAddPrice.Size = new System.Drawing.Size(100, 36);
            this.btnAddPrice.TabIndex = 8;
            this.btnAddPrice.Text = "Thêm";
            this.btnAddPrice.UseVisualStyleBackColor = true;
            this.btnAddPrice.Click += new System.EventHandler(this.btnAddPrice_Click);
            // 
            // txtDateFactor
            // 
            this.txtDateFactor.Location = new System.Drawing.Point(106, 310);
            this.txtDateFactor.Name = "txtDateFactor";
            this.txtDateFactor.Size = new System.Drawing.Size(140, 29);
            this.txtDateFactor.TabIndex = 6;
            // 
            // txtTimeFactor
            // 
            this.txtTimeFactor.Location = new System.Drawing.Point(106, 250);
            this.txtTimeFactor.Name = "txtTimeFactor";
            this.txtTimeFactor.Size = new System.Drawing.Size(140, 29);
            this.txtTimeFactor.TabIndex = 5;
            // 
            // txtPriceTag
            // 
            this.txtPriceTag.Location = new System.Drawing.Point(106, 197);
            this.txtPriceTag.Name = "txtPriceTag";
            this.txtPriceTag.Size = new System.Drawing.Size(140, 29);
            this.txtPriceTag.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hệ Số Ngày";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hệ Số Giờ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Giá Thuê";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Giá ";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(8, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 317);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin giá";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvPrices);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(266, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(910, 575);
            this.panel2.TabIndex = 1;
            // 
            // dgvPrices
            // 
            this.dgvPrices.AllowUserToAddRows = false;
            this.dgvPrices.AllowUserToDeleteRows = false;
            this.dgvPrices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PriceID,
            this.PriceTag,
            this.TimeFactor,
            this.DateFactor,
            this.Status});
            this.dgvPrices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPrices.Location = new System.Drawing.Point(0, 111);
            this.dgvPrices.Name = "dgvPrices";
            this.dgvPrices.ReadOnly = true;
            this.dgvPrices.RowHeadersWidth = 62;
            this.dgvPrices.RowTemplate.Height = 28;
            this.dgvPrices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrices.Size = new System.Drawing.Size(910, 464);
            this.dgvPrices.TabIndex = 1;
            this.dgvPrices.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrices_CellClick);
            // 
            // PriceID
            // 
            this.PriceID.HeaderText = "Mã Giá";
            this.PriceID.MinimumWidth = 8;
            this.PriceID.Name = "PriceID";
            this.PriceID.ReadOnly = true;
            this.PriceID.Width = 150;
            // 
            // PriceTag
            // 
            this.PriceTag.HeaderText = "Giá ";
            this.PriceTag.MinimumWidth = 8;
            this.PriceTag.Name = "PriceTag";
            this.PriceTag.ReadOnly = true;
            this.PriceTag.Width = 200;
            // 
            // TimeFactor
            // 
            this.TimeFactor.HeaderText = "Hệ Số Giờ";
            this.TimeFactor.MinimumWidth = 8;
            this.TimeFactor.Name = "TimeFactor";
            this.TimeFactor.ReadOnly = true;
            this.TimeFactor.Width = 150;
            // 
            // DateFactor
            // 
            this.DateFactor.HeaderText = "Hệ Số Ngày";
            this.DateFactor.MinimumWidth = 8;
            this.DateFactor.Name = "DateFactor";
            this.DateFactor.ReadOnly = true;
            this.DateFactor.Width = 150;
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Status.HeaderText = "Trạng thái";
            this.Status.MinimumWidth = 8;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(910, 111);
            this.panel3.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(382, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 26);
            this.label6.TabIndex = 0;
            this.label6.Text = "Bảng Giá";
            // 
            // PriceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 578);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PriceForm";
            this.Text = "Bảng Giá";
            this.Load += new System.EventHandler(this.PriceForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrices)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAddPrice;
        private System.Windows.Forms.TextBox txtDateFactor;
        private System.Windows.Forms.TextBox txtTimeFactor;
        private System.Windows.Forms.TextBox txtPriceTag;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPriceID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUsedPrice;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvPrices;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceTag;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeFactor;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateFactor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}