namespace BigEyeAsgmt
{
    partial class InvoicesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoicesForm));
            this.txtInvoicesContent = new System.Windows.Forms.TextBox();
            this.btnPrintInvoices = new System.Windows.Forms.Button();
            this.btnDisplayInvoices = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.printDoc = new System.Drawing.Printing.PrintDocument();
            this.PreviewDlg = new System.Windows.Forms.PrintPreviewDialog();
            this.SuspendLayout();
            // 
            // txtInvoicesContent
            // 
            this.txtInvoicesContent.Location = new System.Drawing.Point(37, 25);
            this.txtInvoicesContent.Multiline = true;
            this.txtInvoicesContent.Name = "txtInvoicesContent";
            this.txtInvoicesContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInvoicesContent.Size = new System.Drawing.Size(776, 384);
            this.txtInvoicesContent.TabIndex = 0;
            // 
            // btnPrintInvoices
            // 
            this.btnPrintInvoices.Location = new System.Drawing.Point(509, 452);
            this.btnPrintInvoices.Name = "btnPrintInvoices";
            this.btnPrintInvoices.Size = new System.Drawing.Size(148, 39);
            this.btnPrintInvoices.TabIndex = 1;
            this.btnPrintInvoices.Text = "Print Invoices";
            this.btnPrintInvoices.UseVisualStyleBackColor = true;
            this.btnPrintInvoices.Click += new System.EventHandler(this.btnPrintInvoices_Click);
            // 
            // btnDisplayInvoices
            // 
            this.btnDisplayInvoices.Location = new System.Drawing.Point(665, 452);
            this.btnDisplayInvoices.Name = "btnDisplayInvoices";
            this.btnDisplayInvoices.Size = new System.Drawing.Size(148, 39);
            this.btnDisplayInvoices.TabIndex = 2;
            this.btnDisplayInvoices.Text = "Display Invoices";
            this.btnDisplayInvoices.UseVisualStyleBackColor = true;
            this.btnDisplayInvoices.Click += new System.EventHandler(this.btnDisplayInvoices_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(665, 522);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(148, 39);
            this.btnReturn.TabIndex = 3;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // printDoc
            // 
            this.printDoc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDoc_PrintPage);
            // 
            // PreviewDlg
            // 
            this.PreviewDlg.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.PreviewDlg.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.PreviewDlg.ClientSize = new System.Drawing.Size(400, 300);
            this.PreviewDlg.Document = this.printDoc;
            this.PreviewDlg.Enabled = true;
            this.PreviewDlg.Icon = ((System.Drawing.Icon)(resources.GetObject("PreviewDlg.Icon")));
            this.PreviewDlg.Name = "PreviewDlg";
            this.PreviewDlg.Visible = false;
            // 
            // InvoicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 573);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDisplayInvoices);
            this.Controls.Add(this.btnPrintInvoices);
            this.Controls.Add(this.txtInvoicesContent);
            this.Name = "InvoicesForm";
            this.Text = "InvoicesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInvoicesContent;
        private System.Windows.Forms.Button btnPrintInvoices;
        private System.Windows.Forms.Button btnDisplayInvoices;
        private System.Windows.Forms.Button btnReturn;
        private System.Drawing.Printing.PrintDocument printDoc;
        private System.Windows.Forms.PrintPreviewDialog PreviewDlg;
    }
}