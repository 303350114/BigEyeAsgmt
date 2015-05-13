namespace BigEyeAsgmt
{
    partial class MainForm
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnInvoices = new System.Windows.Forms.Button();
            this.grpMaintenance = new System.Windows.Forms.GroupBox();
            this.btnClient = new System.Windows.Forms.Button();
            this.btnCaseAssignment = new System.Windows.Forms.Button();
            this.btnInvestigator = new System.Windows.Forms.Button();
            this.btnCase = new System.Windows.Forms.Button();
            this.btnEquipment = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.grpMaintenance.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnExit);
            this.groupBox2.Controls.Add(this.btnInvoices);
            this.groupBox2.Location = new System.Drawing.Point(465, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 394);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reporting";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(28, 326);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(266, 39);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnInvoices
            // 
            this.btnInvoices.Location = new System.Drawing.Point(28, 42);
            this.btnInvoices.Name = "btnInvoices";
            this.btnInvoices.Size = new System.Drawing.Size(266, 39);
            this.btnInvoices.TabIndex = 0;
            this.btnInvoices.Text = "Invoices";
            this.btnInvoices.UseVisualStyleBackColor = true;
            this.btnInvoices.Click += new System.EventHandler(this.btnInvoices_Click_1);
            // 
            // grpMaintenance
            // 
            this.grpMaintenance.Controls.Add(this.btnClient);
            this.grpMaintenance.Controls.Add(this.btnCaseAssignment);
            this.grpMaintenance.Controls.Add(this.btnInvestigator);
            this.grpMaintenance.Controls.Add(this.btnCase);
            this.grpMaintenance.Controls.Add(this.btnEquipment);
            this.grpMaintenance.Location = new System.Drawing.Point(71, 50);
            this.grpMaintenance.Name = "grpMaintenance";
            this.grpMaintenance.Size = new System.Drawing.Size(319, 394);
            this.grpMaintenance.TabIndex = 7;
            this.grpMaintenance.TabStop = false;
            this.grpMaintenance.Text = "Maintenance";
            // 
            // btnClient
            // 
            this.btnClient.Location = new System.Drawing.Point(25, 42);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(266, 39);
            this.btnClient.TabIndex = 0;
            this.btnClient.Text = "Client Maintenance";
            this.btnClient.UseVisualStyleBackColor = true;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // btnCaseAssignment
            // 
            this.btnCaseAssignment.Location = new System.Drawing.Point(25, 326);
            this.btnCaseAssignment.Name = "btnCaseAssignment";
            this.btnCaseAssignment.Size = new System.Drawing.Size(266, 39);
            this.btnCaseAssignment.TabIndex = 4;
            this.btnCaseAssignment.Text = "Case Assignment Maintenance";
            this.btnCaseAssignment.UseVisualStyleBackColor = true;
            this.btnCaseAssignment.Click += new System.EventHandler(this.btnCaseAssignment_Click);
            // 
            // btnInvestigator
            // 
            this.btnInvestigator.Location = new System.Drawing.Point(25, 113);
            this.btnInvestigator.Name = "btnInvestigator";
            this.btnInvestigator.Size = new System.Drawing.Size(266, 39);
            this.btnInvestigator.TabIndex = 1;
            this.btnInvestigator.Text = "Investigator Maintenance";
            this.btnInvestigator.UseVisualStyleBackColor = true;
            this.btnInvestigator.Click += new System.EventHandler(this.btnInvestigator_Click);
            // 
            // btnCase
            // 
            this.btnCase.Location = new System.Drawing.Point(25, 255);
            this.btnCase.Name = "btnCase";
            this.btnCase.Size = new System.Drawing.Size(266, 39);
            this.btnCase.TabIndex = 3;
            this.btnCase.Text = "Case Maintenance";
            this.btnCase.UseVisualStyleBackColor = true;
            this.btnCase.Click += new System.EventHandler(this.btnCase_Click);
            // 
            // btnEquipment
            // 
            this.btnEquipment.Location = new System.Drawing.Point(25, 184);
            this.btnEquipment.Name = "btnEquipment";
            this.btnEquipment.Size = new System.Drawing.Size(266, 39);
            this.btnEquipment.TabIndex = 2;
            this.btnEquipment.Text = "Equipment Maintenance";
            this.btnEquipment.UseVisualStyleBackColor = true;
            this.btnEquipment.Click += new System.EventHandler(this.btnEquipment_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 479);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpMaintenance);
            this.Name = "MainForm";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.grpMaintenance.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnInvoices;
        private System.Windows.Forms.GroupBox grpMaintenance;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Button btnCaseAssignment;
        private System.Windows.Forms.Button btnInvestigator;
        private System.Windows.Forms.Button btnCase;
        private System.Windows.Forms.Button btnEquipment;
    }
}

