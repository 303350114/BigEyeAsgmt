namespace BigEyeAsgmt
{
    partial class InvestigatorForm
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
            this.lstInvestigators = new System.Windows.Forms.ListBox();
            this.lblInvestigatorNO = new System.Windows.Forms.Label();
            this.lblInvestigatorID = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblHourlyRate = new System.Windows.Forms.Label();
            this.lblCellPhone = new System.Windows.Forms.Label();
            this.lblLicensed = new System.Windows.Forms.Label();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnAddInvestigator = new System.Windows.Forms.Button();
            this.btnUpdateInvestigator = new System.Windows.Forms.Button();
            this.btnDeleteInvestigator = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtHourlyRate = new System.Windows.Forms.TextBox();
            this.txtCellPhone = new System.Windows.Forms.TextBox();
            this.txtLicensed = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstInvestigators
            // 
            this.lstInvestigators.FormattingEnabled = true;
            this.lstInvestigators.ItemHeight = 20;
            this.lstInvestigators.Location = new System.Drawing.Point(73, 39);
            this.lstInvestigators.Name = "lstInvestigators";
            this.lstInvestigators.Size = new System.Drawing.Size(220, 264);
            this.lstInvestigators.TabIndex = 0;
            // 
            // lblInvestigatorNO
            // 
            this.lblInvestigatorNO.AutoSize = true;
            this.lblInvestigatorNO.Location = new System.Drawing.Point(332, 39);
            this.lblInvestigatorNO.Name = "lblInvestigatorNO";
            this.lblInvestigatorNO.Size = new System.Drawing.Size(117, 20);
            this.lblInvestigatorNO.TabIndex = 1;
            this.lblInvestigatorNO.Text = "Investigator ID:";
            // 
            // lblInvestigatorID
            // 
            this.lblInvestigatorID.AutoSize = true;
            this.lblInvestigatorID.Location = new System.Drawing.Point(453, 38);
            this.lblInvestigatorID.Name = "lblInvestigatorID";
            this.lblInvestigatorID.Size = new System.Drawing.Size(90, 20);
            this.lblInvestigatorID.TabIndex = 2;
            this.lblInvestigatorID.Text = "investigator";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(359, 83);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(90, 20);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(359, 127);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(90, 20);
            this.lblFirstName.TabIndex = 4;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblHourlyRate
            // 
            this.lblHourlyRate.AutoSize = true;
            this.lblHourlyRate.Location = new System.Drawing.Point(352, 171);
            this.lblHourlyRate.Name = "lblHourlyRate";
            this.lblHourlyRate.Size = new System.Drawing.Size(97, 20);
            this.lblHourlyRate.TabIndex = 5;
            this.lblHourlyRate.Text = "Hourly Rate:";
            // 
            // lblCellPhone
            // 
            this.lblCellPhone.AutoSize = true;
            this.lblCellPhone.Location = new System.Drawing.Point(360, 215);
            this.lblCellPhone.Name = "lblCellPhone";
            this.lblCellPhone.Size = new System.Drawing.Size(89, 20);
            this.lblCellPhone.TabIndex = 6;
            this.lblCellPhone.Text = "Cell Phone:";
            // 
            // lblLicensed
            // 
            this.lblLicensed.AutoSize = true;
            this.lblLicensed.Location = new System.Drawing.Point(372, 259);
            this.lblLicensed.Name = "lblLicensed";
            this.lblLicensed.Size = new System.Drawing.Size(77, 20);
            this.lblLicensed.TabIndex = 7;
            this.lblLicensed.Text = "Licensed:";
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(64, 342);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(123, 45);
            this.btnPrevious.TabIndex = 8;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(203, 342);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(123, 45);
            this.btnNext.TabIndex = 9;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnAddInvestigator
            // 
            this.btnAddInvestigator.Location = new System.Drawing.Point(356, 342);
            this.btnAddInvestigator.Name = "btnAddInvestigator";
            this.btnAddInvestigator.Size = new System.Drawing.Size(143, 45);
            this.btnAddInvestigator.TabIndex = 10;
            this.btnAddInvestigator.Text = "Add Investigator";
            this.btnAddInvestigator.UseVisualStyleBackColor = true;
            // 
            // btnUpdateInvestigator
            // 
            this.btnUpdateInvestigator.Location = new System.Drawing.Point(515, 342);
            this.btnUpdateInvestigator.Name = "btnUpdateInvestigator";
            this.btnUpdateInvestigator.Size = new System.Drawing.Size(165, 45);
            this.btnUpdateInvestigator.TabIndex = 11;
            this.btnUpdateInvestigator.Text = "Update Investigator";
            this.btnUpdateInvestigator.UseVisualStyleBackColor = true;
            // 
            // btnDeleteInvestigator
            // 
            this.btnDeleteInvestigator.Location = new System.Drawing.Point(700, 342);
            this.btnDeleteInvestigator.Name = "btnDeleteInvestigator";
            this.btnDeleteInvestigator.Size = new System.Drawing.Size(168, 45);
            this.btnDeleteInvestigator.TabIndex = 12;
            this.btnDeleteInvestigator.Text = "Delete Investigator";
            this.btnDeleteInvestigator.UseVisualStyleBackColor = true;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(700, 416);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(168, 45);
            this.btnReturn.TabIndex = 13;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(455, 80);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 26);
            this.txtLastName.TabIndex = 14;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(455, 124);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 26);
            this.txtFirstName.TabIndex = 15;
            // 
            // txtHourlyRate
            // 
            this.txtHourlyRate.Location = new System.Drawing.Point(455, 168);
            this.txtHourlyRate.Name = "txtHourlyRate";
            this.txtHourlyRate.Size = new System.Drawing.Size(100, 26);
            this.txtHourlyRate.TabIndex = 16;
            // 
            // txtCellPhone
            // 
            this.txtCellPhone.Location = new System.Drawing.Point(455, 212);
            this.txtCellPhone.Name = "txtCellPhone";
            this.txtCellPhone.Size = new System.Drawing.Size(117, 26);
            this.txtCellPhone.TabIndex = 17;
            // 
            // txtLicensed
            // 
            this.txtLicensed.Location = new System.Drawing.Point(455, 256);
            this.txtLicensed.Name = "txtLicensed";
            this.txtLicensed.Size = new System.Drawing.Size(100, 26);
            this.txtLicensed.TabIndex = 18;
            // 
            // InvestigatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 483);
            this.Controls.Add(this.txtLicensed);
            this.Controls.Add(this.txtCellPhone);
            this.Controls.Add(this.txtHourlyRate);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDeleteInvestigator);
            this.Controls.Add(this.btnUpdateInvestigator);
            this.Controls.Add(this.btnAddInvestigator);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.lblLicensed);
            this.Controls.Add(this.lblCellPhone);
            this.Controls.Add(this.lblHourlyRate);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblInvestigatorID);
            this.Controls.Add(this.lblInvestigatorNO);
            this.Controls.Add(this.lstInvestigators);
            this.Name = "InvestigatorForm";
            this.Text = "InvestigatorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstInvestigators;
        private System.Windows.Forms.Label lblInvestigatorNO;
        private System.Windows.Forms.Label lblInvestigatorID;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblHourlyRate;
        private System.Windows.Forms.Label lblCellPhone;
        private System.Windows.Forms.Label lblLicensed;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnAddInvestigator;
        private System.Windows.Forms.Button btnUpdateInvestigator;
        private System.Windows.Forms.Button btnDeleteInvestigator;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtHourlyRate;
        private System.Windows.Forms.TextBox txtCellPhone;
        private System.Windows.Forms.TextBox txtLicensed;
    }
}