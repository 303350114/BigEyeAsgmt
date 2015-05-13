namespace BigEyeAsgmt
{
    partial class AssignmentForm
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
            this.dgvCases = new System.Windows.Forms.DataGridView();
            this.dgvAssignments = new System.Windows.Forms.DataGridView();
            this.dgvInvestigators = new System.Windows.Forms.DataGridView();
            this.btnAssignInvestigator = new System.Windows.Forms.Button();
            this.btnModifyAssignment = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCases)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvestigators)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCases
            // 
            this.dgvCases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCases.Location = new System.Drawing.Point(67, 30);
            this.dgvCases.Name = "dgvCases";
            this.dgvCases.RowTemplate.Height = 28;
            this.dgvCases.Size = new System.Drawing.Size(941, 300);
            this.dgvCases.TabIndex = 0;
            // 
            // dgvAssignments
            // 
            this.dgvAssignments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssignments.Location = new System.Drawing.Point(67, 396);
            this.dgvAssignments.Name = "dgvAssignments";
            this.dgvAssignments.RowTemplate.Height = 28;
            this.dgvAssignments.Size = new System.Drawing.Size(360, 213);
            this.dgvAssignments.TabIndex = 1;
            // 
            // dgvInvestigators
            // 
            this.dgvInvestigators.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvestigators.Location = new System.Drawing.Point(717, 396);
            this.dgvInvestigators.Name = "dgvInvestigators";
            this.dgvInvestigators.RowTemplate.Height = 28;
            this.dgvInvestigators.Size = new System.Drawing.Size(366, 225);
            this.dgvInvestigators.TabIndex = 2;
            // 
            // btnAssignInvestigator
            // 
            this.btnAssignInvestigator.Location = new System.Drawing.Point(495, 396);
            this.btnAssignInvestigator.Name = "btnAssignInvestigator";
            this.btnAssignInvestigator.Size = new System.Drawing.Size(181, 36);
            this.btnAssignInvestigator.TabIndex = 3;
            this.btnAssignInvestigator.Text = "Assign Investigator";
            this.btnAssignInvestigator.UseVisualStyleBackColor = true;
            // 
            // btnModifyAssignment
            // 
            this.btnModifyAssignment.Location = new System.Drawing.Point(495, 456);
            this.btnModifyAssignment.Name = "btnModifyAssignment";
            this.btnModifyAssignment.Size = new System.Drawing.Size(181, 36);
            this.btnModifyAssignment.TabIndex = 4;
            this.btnModifyAssignment.Text = "Modify Assignment";
            this.btnModifyAssignment.UseVisualStyleBackColor = true;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(879, 685);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(129, 41);
            this.btnReturn.TabIndex = 5;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(495, 516);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 36);
            this.button1.TabIndex = 6;
            this.button1.Text = "Modify Assignment";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AssignmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 738);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnModifyAssignment);
            this.Controls.Add(this.btnAssignInvestigator);
            this.Controls.Add(this.dgvInvestigators);
            this.Controls.Add(this.dgvAssignments);
            this.Controls.Add(this.dgvCases);
            this.Name = "AssignmentForm";
            this.Text = "AssignmentForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCases)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvestigators)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCases;
        private System.Windows.Forms.DataGridView dgvAssignments;
        private System.Windows.Forms.DataGridView dgvInvestigators;
        private System.Windows.Forms.Button btnAssignInvestigator;
        private System.Windows.Forms.Button btnModifyAssignment;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button button1;
    }
}