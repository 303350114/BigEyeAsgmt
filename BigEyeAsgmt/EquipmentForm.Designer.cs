namespace BigEyeAsgmt
{
    partial class EquipmentForm
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
            this.lblEquipmentNO = new System.Windows.Forms.Label();
            this.lstEquipments = new System.Windows.Forms.ListBox();
            this.lblEquipmentID = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnAddEquipment = new System.Windows.Forms.Button();
            this.btnModifyEquipment = new System.Windows.Forms.Button();
            this.btnDeleteEquipment = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblInvestigatorID = new System.Windows.Forms.Label();
            this.txtInvestigatorID = new System.Windows.Forms.TextBox();
            this.pnlEquipment = new System.Windows.Forms.Panel();
            this.txtPnlDescription = new System.Windows.Forms.TextBox();
            this.lblPnlDescription = new System.Windows.Forms.Label();
            this.lblPnlEquipmentID = new System.Windows.Forms.Label();
            this.lblPnlEquipmentNO = new System.Windows.Forms.Label();
            this.lblPnlInvestigatorID = new System.Windows.Forms.Label();
            this.btnSaveEquipment = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cmbInvestigatorID = new System.Windows.Forms.ComboBox();
            this.pnlEquipment.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEquipmentNO
            // 
            this.lblEquipmentNO.AutoSize = true;
            this.lblEquipmentNO.Location = new System.Drawing.Point(275, 50);
            this.lblEquipmentNO.Name = "lblEquipmentNO";
            this.lblEquipmentNO.Size = new System.Drawing.Size(111, 20);
            this.lblEquipmentNO.TabIndex = 0;
            this.lblEquipmentNO.Text = "Equipment ID:";
            // 
            // lstEquipments
            // 
            this.lstEquipments.FormattingEnabled = true;
            this.lstEquipments.ItemHeight = 20;
            this.lstEquipments.Location = new System.Drawing.Point(59, 50);
            this.lstEquipments.Name = "lstEquipments";
            this.lstEquipments.Size = new System.Drawing.Size(180, 184);
            this.lstEquipments.TabIndex = 1;
            // 
            // lblEquipmentID
            // 
            this.lblEquipmentID.AutoSize = true;
            this.lblEquipmentID.Location = new System.Drawing.Point(388, 50);
            this.lblEquipmentID.Name = "lblEquipmentID";
            this.lblEquipmentID.Size = new System.Drawing.Size(84, 20);
            this.lblEquipmentID.TabIndex = 2;
            this.lblEquipmentID.Text = "equipment";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(293, 96);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(93, 20);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Description:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(392, 93);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(257, 26);
            this.txtDescription.TabIndex = 4;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(59, 247);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(95, 42);
            this.btnPrevious.TabIndex = 5;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(160, 247);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(95, 42);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnAddEquipment
            // 
            this.btnAddEquipment.Location = new System.Drawing.Point(279, 246);
            this.btnAddEquipment.Name = "btnAddEquipment";
            this.btnAddEquipment.Size = new System.Drawing.Size(147, 42);
            this.btnAddEquipment.TabIndex = 7;
            this.btnAddEquipment.Text = "Add Equipment";
            this.btnAddEquipment.UseVisualStyleBackColor = true;
            this.btnAddEquipment.Click += new System.EventHandler(this.btnAddEquipment_Click);
            // 
            // btnModifyEquipment
            // 
            this.btnModifyEquipment.Location = new System.Drawing.Point(434, 246);
            this.btnModifyEquipment.Name = "btnModifyEquipment";
            this.btnModifyEquipment.Size = new System.Drawing.Size(164, 42);
            this.btnModifyEquipment.TabIndex = 8;
            this.btnModifyEquipment.Text = "Modify Equipment";
            this.btnModifyEquipment.UseVisualStyleBackColor = true;
            this.btnModifyEquipment.Click += new System.EventHandler(this.btnModifyEquipment_Click);
            // 
            // btnDeleteEquipment
            // 
            this.btnDeleteEquipment.Location = new System.Drawing.Point(606, 247);
            this.btnDeleteEquipment.Name = "btnDeleteEquipment";
            this.btnDeleteEquipment.Size = new System.Drawing.Size(164, 42);
            this.btnDeleteEquipment.TabIndex = 9;
            this.btnDeleteEquipment.Text = "Delete Equipment";
            this.btnDeleteEquipment.UseVisualStyleBackColor = true;
            this.btnDeleteEquipment.Click += new System.EventHandler(this.btnDeleteEquipment_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(606, 313);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(164, 42);
            this.btnReturn.TabIndex = 10;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblInvestigatorID
            // 
            this.lblInvestigatorID.AutoSize = true;
            this.lblInvestigatorID.Location = new System.Drawing.Point(269, 141);
            this.lblInvestigatorID.Name = "lblInvestigatorID";
            this.lblInvestigatorID.Size = new System.Drawing.Size(117, 20);
            this.lblInvestigatorID.TabIndex = 12;
            this.lblInvestigatorID.Text = "Investigator ID:";
            // 
            // txtInvestigatorID
            // 
            this.txtInvestigatorID.Location = new System.Drawing.Point(392, 138);
            this.txtInvestigatorID.Name = "txtInvestigatorID";
            this.txtInvestigatorID.Size = new System.Drawing.Size(100, 26);
            this.txtInvestigatorID.TabIndex = 13;
            // 
            // pnlEquipment
            // 
            this.pnlEquipment.Controls.Add(this.cmbInvestigatorID);
            this.pnlEquipment.Controls.Add(this.btnCancel);
            this.pnlEquipment.Controls.Add(this.btnSaveEquipment);
            this.pnlEquipment.Controls.Add(this.lblPnlInvestigatorID);
            this.pnlEquipment.Controls.Add(this.txtPnlDescription);
            this.pnlEquipment.Controls.Add(this.lblPnlDescription);
            this.pnlEquipment.Controls.Add(this.lblPnlEquipmentID);
            this.pnlEquipment.Controls.Add(this.lblPnlEquipmentNO);
            this.pnlEquipment.Location = new System.Drawing.Point(226, 50);
            this.pnlEquipment.Name = "pnlEquipment";
            this.pnlEquipment.Size = new System.Drawing.Size(383, 184);
            this.pnlEquipment.TabIndex = 14;
            this.pnlEquipment.Visible = false;
            // 
            // txtPnlDescription
            // 
            this.txtPnlDescription.Location = new System.Drawing.Point(186, 50);
            this.txtPnlDescription.Name = "txtPnlDescription";
            this.txtPnlDescription.Size = new System.Drawing.Size(177, 26);
            this.txtPnlDescription.TabIndex = 7;
            // 
            // lblPnlDescription
            // 
            this.lblPnlDescription.AutoSize = true;
            this.lblPnlDescription.Location = new System.Drawing.Point(93, 53);
            this.lblPnlDescription.Name = "lblPnlDescription";
            this.lblPnlDescription.Size = new System.Drawing.Size(93, 20);
            this.lblPnlDescription.TabIndex = 6;
            this.lblPnlDescription.Text = "Description:";
            // 
            // lblPnlEquipmentID
            // 
            this.lblPnlEquipmentID.AutoSize = true;
            this.lblPnlEquipmentID.Location = new System.Drawing.Point(182, 20);
            this.lblPnlEquipmentID.Name = "lblPnlEquipmentID";
            this.lblPnlEquipmentID.Size = new System.Drawing.Size(84, 20);
            this.lblPnlEquipmentID.TabIndex = 5;
            this.lblPnlEquipmentID.Text = "equipment";
            // 
            // lblPnlEquipmentNO
            // 
            this.lblPnlEquipmentNO.AutoSize = true;
            this.lblPnlEquipmentNO.Location = new System.Drawing.Point(75, 20);
            this.lblPnlEquipmentNO.Name = "lblPnlEquipmentNO";
            this.lblPnlEquipmentNO.Size = new System.Drawing.Size(111, 20);
            this.lblPnlEquipmentNO.TabIndex = 4;
            this.lblPnlEquipmentNO.Text = "Equipment ID:";
            // 
            // lblPnlInvestigatorID
            // 
            this.lblPnlInvestigatorID.AutoSize = true;
            this.lblPnlInvestigatorID.Location = new System.Drawing.Point(90, 92);
            this.lblPnlInvestigatorID.Name = "lblPnlInvestigatorID";
            this.lblPnlInvestigatorID.Size = new System.Drawing.Size(96, 20);
            this.lblPnlInvestigatorID.TabIndex = 8;
            this.lblPnlInvestigatorID.Text = "Investigator:";
            // 
            // btnSaveEquipment
            // 
            this.btnSaveEquipment.Location = new System.Drawing.Point(50, 130);
            this.btnSaveEquipment.Name = "btnSaveEquipment";
            this.btnSaveEquipment.Size = new System.Drawing.Size(157, 36);
            this.btnSaveEquipment.TabIndex = 10;
            this.btnSaveEquipment.Text = "Save Equipment";
            this.btnSaveEquipment.UseVisualStyleBackColor = true;
            this.btnSaveEquipment.Click += new System.EventHandler(this.btnSaveEquipment_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(222, 130);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(141, 36);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cmbInvestigatorID
            // 
            this.cmbInvestigatorID.FormattingEnabled = true;
            this.cmbInvestigatorID.Location = new System.Drawing.Point(186, 87);
            this.cmbInvestigatorID.Name = "cmbInvestigatorID";
            this.cmbInvestigatorID.Size = new System.Drawing.Size(121, 28);
            this.cmbInvestigatorID.TabIndex = 12;
            // 
            // EquipmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 388);
            this.Controls.Add(this.pnlEquipment);
            this.Controls.Add(this.txtInvestigatorID);
            this.Controls.Add(this.lblInvestigatorID);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDeleteEquipment);
            this.Controls.Add(this.btnModifyEquipment);
            this.Controls.Add(this.btnAddEquipment);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblEquipmentID);
            this.Controls.Add(this.lstEquipments);
            this.Controls.Add(this.lblEquipmentNO);
            this.Name = "EquipmentForm";
            this.Text = "EquipmentForm";
            this.pnlEquipment.ResumeLayout(false);
            this.pnlEquipment.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEquipmentNO;
        private System.Windows.Forms.ListBox lstEquipments;
        private System.Windows.Forms.Label lblEquipmentID;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnAddEquipment;
        private System.Windows.Forms.Button btnModifyEquipment;
        private System.Windows.Forms.Button btnDeleteEquipment;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblInvestigatorID;
        private System.Windows.Forms.TextBox txtInvestigatorID;
        private System.Windows.Forms.Panel pnlEquipment;
        private System.Windows.Forms.Label lblPnlInvestigatorID;
        private System.Windows.Forms.TextBox txtPnlDescription;
        private System.Windows.Forms.Label lblPnlDescription;
        private System.Windows.Forms.Label lblPnlEquipmentID;
        private System.Windows.Forms.Label lblPnlEquipmentNO;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSaveEquipment;
        private System.Windows.Forms.ComboBox cmbInvestigatorID;
    }
}