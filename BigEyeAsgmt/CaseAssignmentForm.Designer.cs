namespace BigEyeAsgmt
{
    partial class CaseAssignmentForm
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
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnAssignInvestigator = new System.Windows.Forms.Button();
            this.btnModifyAssignment = new System.Windows.Forms.Button();
            this.btnRemoveInvestigator = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblInvestigatorName = new System.Windows.Forms.Label();
            this.lblClientID = new System.Windows.Forms.Label();
            this.lblClientNO = new System.Windows.Forms.Label();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.txtDateOpened = new System.Windows.Forms.TextBox();
            this.txtCaseType = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblClient = new System.Windows.Forms.Label();
            this.lblDateOpened = new System.Windows.Forms.Label();
            this.lblCaseType = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblCaseID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblInvestigatorNames = new System.Windows.Forms.Label();
            this.pnlCaseAssignment = new System.Windows.Forms.Panel();
            this.txtPnlHours = new System.Windows.Forms.TextBox();
            this.dtpAssignedDate = new System.Windows.Forms.DateTimePicker();
            this.lblPnlHours = new System.Windows.Forms.Label();
            this.lblPnlAssignedDate = new System.Windows.Forms.Label();
            this.cmbPnlInvestigators = new System.Windows.Forms.ComboBox();
            this.lblPnlInvestigator = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveAssignment = new System.Windows.Forms.Button();
            this.lblPnlHiddenHours = new System.Windows.Forms.Label();
            this.pnlCaseAssignment.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstCases
            // 
            this.lstCases.FormattingEnabled = true;
            this.lstCases.ItemHeight = 20;
            this.lstCases.Location = new System.Drawing.Point(66, 55);
            this.lstCases.Name = "lstCases";
            this.lstCases.Size = new System.Drawing.Size(210, 304);
            this.lstCases.TabIndex = 0;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(67, 425);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(103, 40);
            this.btnPrevious.TabIndex = 1;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(178, 425);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(103, 40);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnAssignInvestigator
            // 
            this.btnAssignInvestigator.Location = new System.Drawing.Point(286, 425);
            this.btnAssignInvestigator.Name = "btnAssignInvestigator";
            this.btnAssignInvestigator.Size = new System.Drawing.Size(178, 40);
            this.btnAssignInvestigator.TabIndex = 3;
            this.btnAssignInvestigator.Text = "Assign Investigator";
            this.btnAssignInvestigator.UseVisualStyleBackColor = true;
            this.btnAssignInvestigator.Click += new System.EventHandler(this.btnAssignInvestigator_Click);
            // 
            // btnModifyAssignment
            // 
            this.btnModifyAssignment.Location = new System.Drawing.Point(475, 425);
            this.btnModifyAssignment.Name = "btnModifyAssignment";
            this.btnModifyAssignment.Size = new System.Drawing.Size(178, 40);
            this.btnModifyAssignment.TabIndex = 4;
            this.btnModifyAssignment.Text = "Modify Assignment";
            this.btnModifyAssignment.UseVisualStyleBackColor = true;
            this.btnModifyAssignment.Click += new System.EventHandler(this.btnModifyAssignment_Click);
            // 
            // btnRemoveInvestigator
            // 
            this.btnRemoveInvestigator.Location = new System.Drawing.Point(659, 425);
            this.btnRemoveInvestigator.Name = "btnRemoveInvestigator";
            this.btnRemoveInvestigator.Size = new System.Drawing.Size(178, 40);
            this.btnRemoveInvestigator.TabIndex = 5;
            this.btnRemoveInvestigator.Text = "Remove Investigator";
            this.btnRemoveInvestigator.UseVisualStyleBackColor = true;
            this.btnRemoveInvestigator.Click += new System.EventHandler(this.btnRemoveInvestigator_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(659, 500);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(178, 40);
            this.btnReturn.TabIndex = 6;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblInvestigatorName
            // 
            this.lblInvestigatorName.AutoSize = true;
            this.lblInvestigatorName.Location = new System.Drawing.Point(315, 312);
            this.lblInvestigatorName.Name = "lblInvestigatorName";
            this.lblInvestigatorName.Size = new System.Drawing.Size(150, 20);
            this.lblInvestigatorName.TabIndex = 18;
            this.lblInvestigatorName.Text = "Investigator Names:";
            // 
            // lblClientID
            // 
            this.lblClientID.AutoSize = true;
            this.lblClientID.Location = new System.Drawing.Point(461, 274);
            this.lblClientID.Name = "lblClientID";
            this.lblClientID.Size = new System.Drawing.Size(0, 20);
            this.lblClientID.TabIndex = 31;
            // 
            // lblClientNO
            // 
            this.lblClientNO.AutoSize = true;
            this.lblClientNO.Location = new System.Drawing.Point(387, 274);
            this.lblClientNO.Name = "lblClientNO";
            this.lblClientNO.Size = new System.Drawing.Size(74, 20);
            this.lblClientNO.TabIndex = 32;
            this.lblClientNO.Text = "Client ID:";
            this.lblClientNO.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtClientName
            // 
            this.txtClientName.Location = new System.Drawing.Point(641, 271);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(124, 26);
            this.txtClientName.TabIndex = 30;
            // 
            // txtDateOpened
            // 
            this.txtDateOpened.Location = new System.Drawing.Point(465, 228);
            this.txtDateOpened.Name = "txtDateOpened";
            this.txtDateOpened.Size = new System.Drawing.Size(202, 26);
            this.txtDateOpened.TabIndex = 29;
            // 
            // txtCaseType
            // 
            this.txtCaseType.Location = new System.Drawing.Point(465, 184);
            this.txtCaseType.Name = "txtCaseType";
            this.txtCaseType.Size = new System.Drawing.Size(131, 26);
            this.txtCaseType.TabIndex = 28;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(465, 140);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(100, 26);
            this.txtStatus.TabIndex = 27;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(465, 96);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(267, 26);
            this.txtDescription.TabIndex = 26;
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Location = new System.Drawing.Point(536, 274);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(99, 20);
            this.lblClient.TabIndex = 25;
            this.lblClient.Text = "Client Name:";
            // 
            // lblDateOpened
            // 
            this.lblDateOpened.AutoSize = true;
            this.lblDateOpened.Location = new System.Drawing.Point(352, 231);
            this.lblDateOpened.Name = "lblDateOpened";
            this.lblDateOpened.Size = new System.Drawing.Size(109, 20);
            this.lblDateOpened.TabIndex = 24;
            this.lblDateOpened.Text = "Date Opened:";
            // 
            // lblCaseType
            // 
            this.lblCaseType.AutoSize = true;
            this.lblCaseType.Location = new System.Drawing.Point(373, 187);
            this.lblCaseType.Name = "lblCaseType";
            this.lblCaseType.Size = new System.Drawing.Size(88, 20);
            this.lblCaseType.TabIndex = 23;
            this.lblCaseType.Text = "Case Type:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(401, 143);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(60, 20);
            this.lblStatus.TabIndex = 22;
            this.lblStatus.Text = "Status:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(368, 99);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(93, 20);
            this.lblDescription.TabIndex = 21;
            this.lblDescription.Text = "Description:";
            // 
            // lblCaseID
            // 
            this.lblCaseID.AutoSize = true;
            this.lblCaseID.Location = new System.Drawing.Point(461, 54);
            this.lblCaseID.Name = "lblCaseID";
            this.lblCaseID.Size = new System.Drawing.Size(43, 20);
            this.lblCaseID.TabIndex = 20;
            this.lblCaseID.Text = "case";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(390, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Case ID:";
            // 
            // lblInvestigatorNames
            // 
            this.lblInvestigatorNames.Location = new System.Drawing.Point(461, 312);
            this.lblInvestigatorNames.Name = "lblInvestigatorNames";
            this.lblInvestigatorNames.Size = new System.Drawing.Size(301, 94);
            this.lblInvestigatorNames.TabIndex = 34;
            this.lblInvestigatorNames.Text = "label1";
            // 
            // pnlCaseAssignment
            // 
            this.pnlCaseAssignment.Controls.Add(this.lblPnlHiddenHours);
            this.pnlCaseAssignment.Controls.Add(this.txtPnlHours);
            this.pnlCaseAssignment.Controls.Add(this.dtpAssignedDate);
            this.pnlCaseAssignment.Controls.Add(this.lblPnlHours);
            this.pnlCaseAssignment.Controls.Add(this.lblPnlAssignedDate);
            this.pnlCaseAssignment.Controls.Add(this.cmbPnlInvestigators);
            this.pnlCaseAssignment.Controls.Add(this.lblPnlInvestigator);
            this.pnlCaseAssignment.Controls.Add(this.btnCancel);
            this.pnlCaseAssignment.Controls.Add(this.btnSaveAssignment);
            this.pnlCaseAssignment.Location = new System.Drawing.Point(214, 55);
            this.pnlCaseAssignment.Name = "pnlCaseAssignment";
            this.pnlCaseAssignment.Size = new System.Drawing.Size(551, 305);
            this.pnlCaseAssignment.TabIndex = 35;
            this.pnlCaseAssignment.Visible = false;
            // 
            // txtPnlHours
            // 
            this.txtPnlHours.Location = new System.Drawing.Point(225, 144);
            this.txtPnlHours.Name = "txtPnlHours";
            this.txtPnlHours.Size = new System.Drawing.Size(100, 26);
            this.txtPnlHours.TabIndex = 15;
            //this.txtPnlHours.TextChanged += new System.EventHandler(this.txtPnlHours_TextChanged);
            // 
            // dtpAssignedDate
            // 
            this.dtpAssignedDate.CustomFormat = "dd MMM yyyy";
            this.dtpAssignedDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAssignedDate.Location = new System.Drawing.Point(225, 82);
            this.dtpAssignedDate.Name = "dtpAssignedDate";
            this.dtpAssignedDate.Size = new System.Drawing.Size(135, 26);
            this.dtpAssignedDate.TabIndex = 14;
            // 
            // lblPnlHours
            // 
            this.lblPnlHours.AutoSize = true;
            this.lblPnlHours.Location = new System.Drawing.Point(167, 147);
            this.lblPnlHours.Name = "lblPnlHours";
            this.lblPnlHours.Size = new System.Drawing.Size(56, 20);
            this.lblPnlHours.TabIndex = 13;
            this.lblPnlHours.Text = "Hours:";
            // 
            // lblPnlAssignedDate
            // 
            this.lblPnlAssignedDate.AutoSize = true;
            this.lblPnlAssignedDate.Location = new System.Drawing.Point(105, 87);
            this.lblPnlAssignedDate.Name = "lblPnlAssignedDate";
            this.lblPnlAssignedDate.Size = new System.Drawing.Size(118, 20);
            this.lblPnlAssignedDate.TabIndex = 12;
            this.lblPnlAssignedDate.Text = "Assigned Date:";
            // 
            // cmbPnlInvestigators
            // 
            this.cmbPnlInvestigators.FormattingEnabled = true;
            this.cmbPnlInvestigators.Location = new System.Drawing.Point(225, 24);
            this.cmbPnlInvestigators.Name = "cmbPnlInvestigators";
            this.cmbPnlInvestigators.Size = new System.Drawing.Size(135, 28);
            this.cmbPnlInvestigators.TabIndex = 11;
            this.cmbPnlInvestigators.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.cmbPnlInvestigators_Format);
            // 
            // lblPnlInvestigator
            // 
            this.lblPnlInvestigator.AutoSize = true;
            this.lblPnlInvestigator.Location = new System.Drawing.Point(127, 27);
            this.lblPnlInvestigator.Name = "lblPnlInvestigator";
            this.lblPnlInvestigator.Size = new System.Drawing.Size(96, 20);
            this.lblPnlInvestigator.TabIndex = 10;
            this.lblPnlInvestigator.Text = "Investigator:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(270, 239);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(164, 41);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSaveAssignment
            // 
            this.btnSaveAssignment.Location = new System.Drawing.Point(87, 239);
            this.btnSaveAssignment.Name = "btnSaveAssignment";
            this.btnSaveAssignment.Size = new System.Drawing.Size(164, 41);
            this.btnSaveAssignment.TabIndex = 8;
            this.btnSaveAssignment.Text = "Save Assignment";
            this.btnSaveAssignment.UseVisualStyleBackColor = true;
            this.btnSaveAssignment.Click += new System.EventHandler(this.btnSaveAssignment_Click);
            // 
            // lblPnlHiddenHours
            // 
            this.lblPnlHiddenHours.AutoSize = true;
            this.lblPnlHiddenHours.Location = new System.Drawing.Point(191, 196);
            this.lblPnlHiddenHours.Name = "lblPnlHiddenHours";
            this.lblPnlHiddenHours.Size = new System.Drawing.Size(33, 20);
            this.lblPnlHiddenHours.TabIndex = 16;
            this.lblPnlHiddenHours.Text = "null";
            this.lblPnlHiddenHours.Visible = false;
            // 
            // CaseAssignmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 601);
            this.Controls.Add(this.pnlCaseAssignment);
            this.Controls.Add(this.lblInvestigatorNames);
            this.Controls.Add(this.lblClientID);
            this.Controls.Add(this.lblClientNO);
            this.Controls.Add(this.txtClientName);
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
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblInvestigatorName);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnRemoveInvestigator);
            this.Controls.Add(this.btnModifyAssignment);
            this.Controls.Add(this.btnAssignInvestigator);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.lstCases);
            this.Name = "CaseAssignmentForm";
            this.Text = "CaseAssignmentForm";
            this.pnlCaseAssignment.ResumeLayout(false);
            this.pnlCaseAssignment.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCases;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnAssignInvestigator;
        private System.Windows.Forms.Button btnModifyAssignment;
        private System.Windows.Forms.Button btnRemoveInvestigator;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblInvestigatorName;
        private System.Windows.Forms.Label lblClientID;
        private System.Windows.Forms.Label lblClientNO;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.TextBox txtDateOpened;
        private System.Windows.Forms.TextBox txtCaseType;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.Label lblDateOpened;
        private System.Windows.Forms.Label lblCaseType;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblCaseID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblInvestigatorNames;
        private System.Windows.Forms.Panel pnlCaseAssignment;
        private System.Windows.Forms.TextBox txtPnlHours;
        private System.Windows.Forms.DateTimePicker dtpAssignedDate;
        private System.Windows.Forms.Label lblPnlHours;
        private System.Windows.Forms.Label lblPnlAssignedDate;
        private System.Windows.Forms.ComboBox cmbPnlInvestigators;
        private System.Windows.Forms.Label lblPnlInvestigator;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSaveAssignment;
        private System.Windows.Forms.Label lblPnlHiddenHours;
    }
}