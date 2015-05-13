using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BigEyeAsgmt
{
    public partial class InvoicesForm : Form
    {
        private MainForm frmMenu;
        private DataModule DM;

        private int amountOfInvoicesPrinted, pagesAmountExpected;
        private DataRow[] invoicesForPrint;

        CurrencyManager cmClient;
        CurrencyManager cmCase;
        CurrencyManager cmInvestigator;
        CurrencyManager cmCaseAssignment;

        public InvoicesForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Overloading the constructor
        /// </summary>
        /// <param name="dm"></param>
        /// <param name="menu"></param>
        public InvoicesForm(DataModule dm, MainForm menu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = menu;

            cmClient = (CurrencyManager)this.BindingContext[DM.BigEyeDS, "T_CLIENT"];
            cmCase = (CurrencyManager)this.BindingContext[DM.BigEyeDS, "T_CASE"];
            cmInvestigator = (CurrencyManager)this.BindingContext[DM.BigEyeDS, "T_INVESTIGATOR"];
            cmCaseAssignment = (CurrencyManager)this.BindingContext[DM.BigEyeDS, "T_ASSIGNMENT"];
        }

        /// <summary>
        /// Print Invoices report.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrintInvoices_Click(object sender, EventArgs e)
        {
            amountOfInvoicesPrinted = 0;
            string strFilter = "Status = 'Open'";
            string strSort = "CaseID";

            invoicesForPrint = DM.BigEyeDS.Tables["T_Case"].Select(strFilter, strSort, DataViewRowState.CurrentRows);
            pagesAmountExpected = invoicesForPrint.Length;

            PreviewDlg.Document = printDoc;
            PreviewDlg.ShowDialog();
        }

        private void printDoc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            int linesSoFarHeading = 0;
            Font textFont = new Font("Arial", 10, FontStyle.Regular);
            Font textFontCenter = new Font("Arial", 10, FontStyle.Regular);
            Font totalSubtotal = new Font("Arial", 10, FontStyle.Bold);
            Font headingFont = new Font("Arial", 10, FontStyle.Bold);

            double caseTotal = 0;

            Brush brush = new SolidBrush(Color.Black);
            //margins
            int leftMargin = e.MarginBounds.Left;
            int topMargin = e.MarginBounds.Top;
            int headingLeftMargin = 20;

            int topMarginDetails = topMargin + 70;
            int rightMargin = e.MarginBounds.Right;
            DataRow drCase = invoicesForPrint[amountOfInvoicesPrinted];

            cmClient.Position = DM.caseView.Find(drCase["ClientID"].ToString());
            DataRow drClient = DM.dtClient.Rows[cmClient.Position];

            g.DrawString("Client ID: " + drClient["ClientID"], headingFont, brush, headingLeftMargin, topMargin);
            linesSoFarHeading++;

            g.DrawString(drClient["LastName"] + ", " + drClient["FirstName"], headingFont, brush, headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;

            g.DrawString(drClient["StreetAddress"].ToString(), headingFont, brush, headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;

            g.DrawString(drClient["Suburb"].ToString(), headingFont, brush, headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;

            g.DrawString(drClient["City"].ToString(), headingFont, brush, headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;
            linesSoFarHeading++;
            linesSoFarHeading++;

            g.DrawString("Case Description: " + drCase["Description"] + "  Date Opened: " + drCase["DateOpened"], headingFont, brush, headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;
            linesSoFarHeading++;
            linesSoFarHeading++;

            DataRow[] drCaseAssignment = drCase.GetChildRows(DM.dtCase.ChildRelations["CASE_ASSIGNMENT"]);
            if (drCaseAssignment.Length > 0)
            {
                foreach (DataRow drAssignment in drCaseAssignment)
                {
                    string asgmtText = "";
                    cmInvestigator.Position = DM.investigatorView.Find(drAssignment["InvestigatorID"].ToString());
                    DataRow drInvestigator = DM.dtInvestigator.Rows[cmInvestigator.Position];

                    Double investigatorCost = Convert.ToInt32(drAssignment["Hours"].ToString()) * Convert.ToDouble(drInvestigator["HourlyRate"].ToString());

                    caseTotal += investigatorCost;

                    asgmtText += "\tInvestigator Name: " + drInvestigator["LastName"].ToString()
                                                    + ", " + drInvestigator["FirstName"].ToString() + "  Hours: " + drAssignment["Hours"].ToString()
                                                    + Convert.ToString(String.Format("  Cost: {0:C}", investigatorCost)) + "\r\n";
                    linesSoFarHeading++;
                    g.DrawString(asgmtText, headingFont, brush, headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
                }
                linesSoFarHeading++;
                linesSoFarHeading++;
                linesSoFarHeading++;
                g.DrawString("\t" + Convert.ToString(String.Format("Gross due: {0:C}", caseTotal)), headingFont, brush, headingLeftMargin, topMargin + (linesSoFarHeading * textFont.Height));
                linesSoFarHeading++;
                linesSoFarHeading++;
                linesSoFarHeading++;
                linesSoFarHeading++;
            }
            caseTotal = 0;
            amountOfInvoicesPrinted++;
            if (!(amountOfInvoicesPrinted == pagesAmountExpected))
            {
                e.HasMorePages = true;
            }
            else
            {
                amountOfInvoicesPrinted = 0;
            }
        }

        /// <summary>
        /// Display Invoices report.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDisplayInvoices_Click(object sender, EventArgs e)
        {
            txtInvoicesContent.Text = "";
            string clientText = "";
            double caseTotal = 0;

            foreach (DataRow caseRow in DM.dtCase.Rows)
            {
                string status = caseRow["Status"].ToString();
                if (status.Equals("Open"))
                {
                    cmClient.Position = DM.caseView.Find(caseRow["ClientID"].ToString());
                    DataRow drClient = DM.dtClient.Rows[cmClient.Position];

                    clientText += "Client ID: " + drClient["ClientID"].ToString() + "\r\n";
                    clientText += "Client Name: " + drClient["LastName"].ToString() + ", " + drClient["FirstName"].ToString() + "\r\n";
                    clientText += drClient["StreetAddress"].ToString() + "\r\n";
                    clientText += drClient["Suburb"].ToString() + "\r\n";
                    clientText += drClient["City"].ToString() + "\r\n\r\n\r\n";

                    clientText += "Case Description: " + caseRow["Description"].ToString() + "  Date Opened: " + caseRow["DateOpened"].ToString() + "\r\n\r\n\r\n";

                    //DataRow[] drCaseAssignment = DM.dtAssignment.Select("CaseID = " + caseRow["CaseID"].ToString());
                    DataRow[] drCaseAssignment = caseRow.GetChildRows(DM.dtCase.ChildRelations["CASE_ASSIGNMENT"]);
                    
                    if (drCaseAssignment.Length > 0)
                    {
                        txtInvoicesContent.Text += clientText;

                        foreach (DataRow drAssignment in drCaseAssignment)
                        {
                            cmInvestigator.Position = DM.investigatorView.Find(drAssignment["InvestigatorID"].ToString());
                            DataRow drInvestigator = DM.dtInvestigator.Rows[cmInvestigator.Position];

                            Double investigatorCost = Convert.ToInt32(drAssignment["Hours"].ToString()) * Convert.ToDouble(drInvestigator["HourlyRate"].ToString());

                            caseTotal += investigatorCost;

                            txtInvoicesContent.Text += "\tInvestigator Name: " + drInvestigator["LastName"].ToString()
                                                            + ", " + drInvestigator["FirstName"].ToString() + "  Hours: " + drAssignment["Hours"].ToString()
                                                            + Convert.ToString(String.Format("  Cost: {0:C}", investigatorCost)) + "\r\n";
                        }
                        txtInvoicesContent.Text += "\r\n";
                        txtInvoicesContent.Text += "\t" + Convert.ToString(String.Format("Gross due: {0:C}", caseTotal));
                        txtInvoicesContent.Text += "\r\n\r\n\r\n\r\n";
                    }
                    caseTotal = 0;
                    clientText = "";
                }
            }

        }

        /// <summary>
        /// Close Invoices Form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
