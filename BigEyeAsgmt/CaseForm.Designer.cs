namespace BigEyeAsgmt
{
    partial class CaseForm
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
            this.lstCases = new System.Windows.Forms.ListBox();
            this.lblCaseNO = new System.Windows.Forms.Label();
            this.lblCaseID = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblCaseType = new System.Windows.Forms.Label();
            this.lblDateOpened = new System.Windows.Forms.Label();
            this.lblClient = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtCaseType = new System.Windows.Forms.TextBox();
            this.txtDateOpened = new System.Windows.Forms.TextBox();
            this.txtClient = new System.Windows.Forms.TextBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnAddCase = new System.Windows.Forms.Button();
            this.btnModifyCase = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnDeleteCase = new System.Windows.Forms.Button();
            this.lblClientNO = new System.Windows.Forms.Label();
            this.lblClientID = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.btnMarkClosed = new System.Windows.Forms.Button();
            this.pnlCase = new System.Windows.Forms.Panel();
            this.cmbPnlCaseType = new System.Windows.Forms.ComboBox();
            this.dtpDateOpened = new System.Windows.Forms.DateTimePicker();
            this.cmbPnlClient = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveCase = new System.Windows.Forms.Button();
            this.txtPnlDescription = new System.Windows.Forms.TextBox();
            this.lblPnlClient = new System.Windows.Forms.Label();
            this.lblPnlDateOpened = new System.Windows.Forms.Label();
            this.lblPnlCaseType = new System.Windows.Forms.Label();
            this.lblPnlDescription = new System.Windows.Forms.Label();
            this.lblPnlCaseID = new System.Windows.Forms.Label();
            this.lblPnlCaseNO = new System.Windows.Forms.Label();
            this.pnlCase.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstCases
            // 
            this.lstCases.FormattingEnabled = true;
            this.lstCases.ItemHeight = 20;
            this.lstCases.Location = new System.Drawing.Point(86, 36);
            this.lstCases.Name = "lstCases";
            this.lstCases.Size = new System.Drawing.Size(203, 264);
            this.lstCases.TabIndex = 0;
            // 
            // lblCaseNO
            // 
            this.lblCaseNO.AutoSize = true;
            this.lblCaseNO.Location = new System.Drawing.Point(373, 36);
            this.lblCaseNO.Name = "lblCaseNO";
            this.lblCaseNO.Size = new System.Drawing.Size(71, 20);
            this.lblCaseNO.TabIndex = 1;
            this.lblCaseNO.Text = "Case ID:";
            // 
            // lblCaseID
            // 
            this.lblCaseID.AutoSize = true;
            this.lblCaseID.Location = new System.Drawing.Point(444, 35);
            this.lblCaseID.Name = "lblCaseID";
            this.lblCaseID.Size = new System.Drawing.Size(43, 20);
            this.lblCaseID.TabIndex = 2;
            this.lblCaseID.Text = "case";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(351, 80);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(93, 20);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Description:";
            // 
            // lblCaseType
            // 
            this.lblCaseType.AutoSize = true;
            this.lblCaseType.Location = new System.Drawing.Point(356, 168);
            this.lblCaseType.Name = "lblCaseType";
            this.lblCaseType.Size = new System.Drawing.Size(88, 20);
            this.lblCaseType.TabIndex = 5;
            this.lblCaseType.Text = "Case Type:";
            // 
            // lblDateOpened
            // 
            this.lblDateOpened.AutoSize = true;
            this.lblDateOpened.Location = new System.Drawing.Point(335, 212);
            this.lblDateOpened.Name = "lblDateOpened";
            this.lblDateOpened.Size = new System.Drawing.Size(109, 20);
            this.lblDateOpened.TabIndex = 6;
            this.lblDateOpened.Text = "Date Opened:";
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Location = new System.Drawing.Point(466, 255);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(99, 20);
            this.lblClient.TabIndex = 7;
            this.lblClient.Text = "Client Name:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(448, 77);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(267, 26);
            this.txtDescription.TabIndex = 8;
            // 
            // txtCaseType
            // 
            this.txtCaseType.Location = new System.Drawing.Point(448, 165);
            this.txtCaseType.Name = "txtCaseType";
            this.txtCaseType.Size = new System.Drawing.Size(131, 26);
            this.txtCaseType.TabIndex = 10;
            // 
            // txtDateOpened
            // 
            this.txtDateOpened.Location = new System.Drawing.Point(448, 209);
            this.txtDateOpened.Name = "txtDateOpened";
            this.txtDateOpened.Size = new System.Drawing.Size(202, 26);
            this.txtDateOpened.TabIndex = 11;
            // 
            // txtClient
            // 
            this.txtClient.Location = new System.Drawing.Point(565, 253);
            this.txtClient.Name = "txtClient";
            this.txtClient.Size = new System.Drawing.Size(100, 26);
            this.txtClient.TabIndex = 12;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(86, 333);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(96, 38);
            this.btnPrevious.TabIndex = 13;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(193, 333);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(96, 38);
            this.btnNext.TabIndex = 14;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnAddCase
            // 
            this.btnAddCase.Location = new System.Drawing.Point(324, 333);
            this.btnAddCase.Name = "btnAddCase";
            this.btnAddCase.Size = new System.Drawing.Size(120, 38);
            this.btnAddCase.TabIndex = 15;
            this.btnAddCase.Text = "Add Case";
            this.btnAddCase.UseVisualStyleBackColor = true;
            this.btnAddCase.Click += new System.EventHandler(this.btnAddCase_Click);
            // 
            // btnModifyCase
            // 
            this.btnModifyCase.Location = new System.Drawing.Point(459, 333);
            this.btnModifyCase.Name = "btnModifyCase";
            this.btnModifyCase.Size = new System.Drawing.Size(120, 38);
            this.btnModifyCase.TabIndex = 16;
            this.btnModifyCase.Text = "Modify Case";
            this.btnModifyCase.UseVisualStyleBackColor = true;
            this.btnModifyCase.Click += new System.EventHandler(this.btnModifyCase_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(595, 377);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(120, 38);
            this.btnReturn.TabIndex = 17;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnDeleteCase
            // 
            this.btnDeleteCase.Location = new System.Drawing.Point(595, 333);
            this.btnDeleteCase.Name = "btnDeleteCase";
            this.btnDeleteCase.Size = new System.Drawing.Size(120, 38);
            this.btnDeleteCase.TabIndex = 18;
            this.btnDeleteCase.Text = "Delete Case";
            this.btnDeleteCase.UseVisualStyleBackColor = true;
            this.btnDeleteCase.Click += new System.EventHandler(this.btnDeleteCase_Click);
            // 
            // lblClientNO
            // 
            this.lblClientNO.AutoSize = true;
            this.lblClientNO.Location = new System.Drawing.Point(370, 255);
            this.lblClientNO.Name = "lblClientNO";
            this.lblClientNO.Size = new System.Drawing.Size(74, 20);
            this.lblClientNO.TabIndex = 18;
            this.lblClientNO.Text = "Client ID:";
            this.lblClientNO.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblClientID
            // 
            this.lblClientID.AutoSize = true;
            this.lblClientID.Location = new System.Drawing.Point(444, 255);
            this.lblClientID.Name = "lblClientID";
            this.lblClientID.Size = new System.Drawing.Size(0, 20);
            this.lblClientID.TabIndex = 18;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(384, 124);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(60, 20);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Status:";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(448, 121);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(100, 26);
            this.txtStatus.TabIndex = 9;
            // 
            // btnMarkClosed
            // 
            this.btnMarkClosed.Location = new System.Drawing.Point(377, 377);
            this.btnMarkClosed.Name = "btnMarkClosed";
            this.btnMarkClosed.Size = new System.Drawing.Size(175, 38);
            this.btnMarkClosed.TabIndex = 20;
            this.btnMarkClosed.Text = "Mark Case as Closed";
            this.btnMarkClosed.UseVisualStyleBackColor = true;
            this.btnMarkClosed.Click += new System.EventHandler(this.btnMarkClosed_Click);
            // 
            // pnlCase
            // 
            this.pnlCase.Controls.Add(this.cmbPnlCaseType);
            this.pnlCase.Controls.Add(this.dtpDateOpened);
            this.pnlCase.Controls.Add(this.cmbPnlClient);
            this.pnlCase.Controls.Add(this.btnCancel);
            this.pnlCase.Controls.Add(this.btnSaveCase);
            this.pnlCase.Controls.Add(this.txtPnlDescription);
            this.pnlCase.Controls.Add(this.lblPnlClient);
            this.pnlCase.Controls.Add(this.lblPnlDateOpened);
            this.pnlCase.Controls.Add(this.lblPnlCaseType);
            this.pnlCase.Controls.Add(this.lblPnlDescription);
            this.pnlCase.Controls.Add(this.lblPnlCaseID);
            this.pnlCase.Controls.Add(this.lblPnlCaseNO);
            this.pnlCase.Location = new System.Drawing.Point(167, 35);
            this.pnlCase.Name = "pnlCase";
            this.pnlCase.Size = new System.Drawing.Size(498, 292);
            this.pnlCase.TabIndex = 21;
            this.pnlCase.Visible = false;
            // 
            // cmbPnlCaseType
            // 
            this.cmbPnlCaseType.FormattingEnabled = true;
            this.cmbPnlCaseType.Location = new System.Drawing.Point(175, 102);
            this.cmbPnlCaseType.Name = "cmbPnlCaseType";
            this.cmbPnlCaseType.Size = new System.Drawing.Size(148, 28);
            this.cmbPnlCaseType.TabIndex = 41;
            // 
            // dtpDateOpened
            // 
            this.dtpDateOpened.CustomFormat = "dd MMM yyyy";
            this.dtpDateOpened.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateOpened.Location = new System.Drawing.Point(175, 147);
            this.dtpDateOpened.Name = "dtpDateOpened";
            this.dtpDateOpened.Size = new System.Drawing.Size(148, 26);
            this.dtpDateOpened.TabIndex = 40;
            // 
            // cmbPnlClient
            // 
            this.cmbPnlClient.FormattingEnabled = true;
            this.cmbPnlClient.Location = new System.Drawing.Point(175, 190);
            this.cmbPnlClient.Name = "cmbPnlClient";
            this.cmbPnlClient.Size = new System.Drawing.Size(121, 28);
            this.cmbPnlClient.TabIndex = 39;
            this.cmbPnlClient.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.cmbPnlClient_Format);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(235, 247);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 34);
            this.btnCancel.TabIndex = 38;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSaveCase
            // 
            this.btnSaveCase.Location = new System.Drawing.Point(96, 247);
            this.btnSaveCase.Name = "btnSaveCase";
            this.btnSaveCase.Size = new System.Drawing.Size(117, 34);
            this.btnSaveCase.TabIndex = 37;
            this.btnSaveCase.Text = "Save Case";
            this.btnSaveCase.UseVisualStyleBackColor = true;
            this.btnSaveCase.Click += new System.EventHandler(this.btnSaveCase_Click);
            // 
            // txtPnlDescription
            // 
            this.txtPnlDescription.Location = new System.Drawing.Point(175, 54);
            this.txtPnlDescription.Name = "txtPnlDescription";
            this.txtPnlDescription.Size = new System.Drawing.Size(267, 26);
            this.txtPnlDescription.TabIndex = 36;
            // 
            // lblPnlClient
            // 
            this.lblPnlClient.AutoSize = true;
            this.lblPnlClient.Location = new System.Drawing.Point(118, 193);
            this.lblPnlClient.Name = "lblPnlClient";
            this.lblPnlClient.Size = new System.Drawing.Size(53, 20);
            this.lblPnlClient.TabIndex = 35;
            this.lblPnlClient.Text = "Client:";
            // 
            // lblPnlDateOpened
            // 
            this.lblPnlDateOpened.AutoSize = true;
            this.lblPnlDateOpened.Location = new System.Drawing.Point(62, 149);
            this.lblPnlDateOpened.Name = "lblPnlDateOpened";
            this.lblPnlDateOpened.Size = new System.Drawing.Size(109, 20);
            this.lblPnlDateOpened.TabIndex = 34;
            this.lblPnlDateOpened.Text = "Date Opened:";
            // 
            // lblPnlCaseType
            // 
            this.lblPnlCaseType.AutoSize = true;
            this.lblPnlCaseType.Location = new System.Drawing.Point(83, 105);
            this.lblPnlCaseType.Name = "lblPnlCaseType";
            this.lblPnlCaseType.Size = new System.Drawing.Size(88, 20);
            this.lblPnlCaseType.TabIndex = 33;
            this.lblPnlCaseType.Text = "Case Type:";
            // 
            // lblPnlDescription
            // 
            this.lblPnlDescription.AutoSize = true;
            this.lblPnlDescription.Location = new System.Drawing.Point(78, 57);
            this.lblPnlDescription.Name = "lblPnlDescription";
            this.lblPnlDescription.Size = new System.Drawing.Size(93, 20);
            this.lblPnlDescription.TabIndex = 32;
            this.lblPnlDescription.Text = "Description:";
            // 
            // lblPnlCaseID
            // 
            this.lblPnlCaseID.AutoSize = true;
            this.lblPnlCaseID.Location = new System.Drawing.Point(171, 12);
            this.lblPnlCaseID.Name = "lblPnlCaseID";
            this.lblPnlCaseID.Size = new System.Drawing.Size(43, 20);
            this.lblPnlCaseID.TabIndex = 31;
            this.lblPnlCaseID.Text = "case";
            // 
            // lblPnlCaseNO
            // 
            this.lblPnlCaseNO.AutoSize = true;
            this.lblPnlCaseNO.Location = new System.Drawing.Point(100, 13);
            this.lblPnlCaseNO.Name = "lblPnlCaseNO";
            this.lblPnlCaseNO.Size = new System.Drawing.Size(71, 20);
            this.lblPnlCaseNO.TabIndex = 30;
            this.lblPnlCaseNO.Text = "Case ID:";
            // 
            // CaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 426);
            this.Controls.Add(this.pnlCase);
            this.Controls.Add(this.lblClientID);
            this.Controls.Add(this.lblClientNO);
            this.Controls.Add(this.btnMarkClosed);
            this.Controls.Add(this.btnDeleteCase);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnModifyCase);
            this.Controls.Add(this.btnAddCase);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.txtClient);
            this.Controls.Add(this.txtDateOpened);
            this.Controls.Add(this.txtCaseType);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblClient);
            this.Controls.Add(this.lblDateOpened);
            this.Controls.Add(this.lblCaseType);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblCaseID);
            this.Controls.Add(this.lblCaseNO);
            this.Controls.Add(this.lstCases);
            this.Name = "CaseForm";
            this.Text = "CaseForm";
            this.pnlCase.ResumeLayout(false);
            this.pnlCase.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCases;
        private System.Windows.Forms.Label lblCaseNO;
        private System.Windows.Forms.Label lblCaseID;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblCaseType;
        private System.Windows.Forms.Label lblDateOpened;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtCaseType;
        private System.Windows.Forms.TextBox txtDateOpened;
        private System.Windows.Forms.TextBox txtClient;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnAddCase;
        private System.Windows.Forms.Button btnModifyCase;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnDeleteCase;
        private System.Windows.Forms.Label lblClientID;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Button btnMarkClosed;
        private System.Windows.Forms.Label lblClientNO;
        private System.Windows.Forms.Panel pnlCase;
        private System.Windows.Forms.ComboBox cmbPnlCaseType;
        private System.Windows.Forms.DateTimePicker dtpDateOpened;
        private System.Windows.Forms.ComboBox cmbPnlClient;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSaveCase;
        private System.Windows.Forms.TextBox txtPnlDescription;
        private System.Windows.Forms.Label lblPnlClient;
        private System.Windows.Forms.Label lblPnlDateOpened;
        private System.Windows.Forms.Label lblPnlCaseType;
        private System.Windows.Forms.Label lblPnlDescription;
        private System.Windows.Forms.Label lblPnlCaseID;
        private System.Windows.Forms.Label lblPnlCaseNO;
    }
}