namespace BadmintonManagement.Forms.Court
{
    partial class AddCourtForm
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

        //#region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpInformation = new System.Windows.Forms.GroupBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblCourtName = new System.Windows.Forms.Label();
            this.lblBranchID = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblCourtID = new System.Windows.Forms.Label();
            this.dtmStartDate = new System.Windows.Forms.DateTimePicker();
            this.cboBranchID = new System.Windows.Forms.ComboBox();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.txtCourtName = new System.Windows.Forms.TextBox();
            this.txtCourtID = new System.Windows.Forms.TextBox();
            this.grpInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpInformation
            // 
            this.grpInformation.Controls.Add(this.btnChange);
            this.grpInformation.Controls.Add(this.btnDelete);
            this.grpInformation.Controls.Add(this.btnAdd);
            this.grpInformation.Controls.Add(this.lblStatus);
            this.grpInformation.Controls.Add(this.lblCourtName);
            this.grpInformation.Controls.Add(this.lblBranchID);
            this.grpInformation.Controls.Add(this.lblStartDate);
            this.grpInformation.Controls.Add(this.lblCourtID);
            this.grpInformation.Controls.Add(this.dtmStartDate);
            this.grpInformation.Controls.Add(this.cboBranchID);
            this.grpInformation.Controls.Add(this.cboStatus);
            this.grpInformation.Controls.Add(this.txtCourtName);
            this.grpInformation.Controls.Add(this.txtCourtID);
            this.grpInformation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInformation.Location = new System.Drawing.Point(3, 12);
            this.grpInformation.Name = "grpInformation";
            this.grpInformation.Size = new System.Drawing.Size(394, 448);
            this.grpInformation.TabIndex = 0;
            this.grpInformation.TabStop = false;
            this.grpInformation.Text = "Thông Tin Sân";
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(299, 405);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(87, 37);
            this.btnChange.TabIndex = 14;
            this.btnChange.Text = "Sửa";
            this.btnChange.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(164, 405);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 37);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(26, 405);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(87, 37);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(22, 186);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(101, 28);
            this.lblStatus.TabIndex = 11;
            this.lblStatus.Text = "Trạng Thái";
            // 
            // lblCourtName
            // 
            this.lblCourtName.AutoSize = true;
            this.lblCourtName.Location = new System.Drawing.Point(21, 112);
            this.lblCourtName.Name = "lblCourtName";
            this.lblCourtName.Size = new System.Drawing.Size(78, 28);
            this.lblCourtName.TabIndex = 10;
            this.lblCourtName.Text = "Tên Sân";
            // 
            // lblBranchID
            // 
            this.lblBranchID.AutoSize = true;
            this.lblBranchID.Location = new System.Drawing.Point(22, 333);
            this.lblBranchID.Name = "lblBranchID";
            this.lblBranchID.Size = new System.Drawing.Size(118, 28);
            this.lblBranchID.TabIndex = 9;
            this.lblBranchID.Text = "Tên Khu Vực";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(22, 259);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(161, 28);
            this.lblStartDate.TabIndex = 8;
            this.lblStartDate.Text = "Ngày Hoạt Động";
            // 
            // lblCourtID
            // 
            this.lblCourtID.AutoSize = true;
            this.lblCourtID.Location = new System.Drawing.Point(21, 44);
            this.lblCourtID.Name = "lblCourtID";
            this.lblCourtID.Size = new System.Drawing.Size(77, 28);
            this.lblCourtID.TabIndex = 1;
            this.lblCourtID.Text = "Mã Sân";
            // 
            // dtmStartDate
            // 
            this.dtmStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmStartDate.Location = new System.Drawing.Point(186, 253);
            this.dtmStartDate.Name = "dtmStartDate";
            this.dtmStartDate.Size = new System.Drawing.Size(200, 34);
            this.dtmStartDate.TabIndex = 4;
            // 
            // cboBranchID
            // 
            this.cboBranchID.FormattingEnabled = true;
            this.cboBranchID.Location = new System.Drawing.Point(186, 325);
            this.cboBranchID.Name = "cboBranchID";
            this.cboBranchID.Size = new System.Drawing.Size(200, 36);
            this.cboBranchID.TabIndex = 3;
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(186, 178);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(200, 36);
            this.cboStatus.TabIndex = 2;
            // 
            // txtCourtName
            // 
            this.txtCourtName.Location = new System.Drawing.Point(186, 106);
            this.txtCourtName.Name = "txtCourtName";
            this.txtCourtName.Size = new System.Drawing.Size(200, 34);
            this.txtCourtName.TabIndex = 1;
            // 
            // txtCourtID
            // 
            this.txtCourtID.Location = new System.Drawing.Point(186, 38);
            this.txtCourtID.Name = "txtCourtID";
            this.txtCourtID.Size = new System.Drawing.Size(200, 34);
            this.txtCourtID.TabIndex = 0;
            // 
            // AddCourtForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 459);
            this.Controls.Add(this.grpInformation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddCourtForm";
            this.Text = "CourtForm";
            this.grpInformation.ResumeLayout(false);
            this.grpInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        
        //#region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>

        private System.Windows.Forms.GroupBox grpInformation;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblCourtName;
        private System.Windows.Forms.Label lblBranchID;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblCourtID;
        private System.Windows.Forms.DateTimePicker dtmStartDate;
        private System.Windows.Forms.ComboBox cboBranchID;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.TextBox txtCourtName;
        private System.Windows.Forms.TextBox txtCourtID;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
    }
}